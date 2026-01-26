using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using MaterialSkin;
using MaterialSkin.Controls;
using Dari.Clas;

namespace Dari
{
    public partial class UC_Apartments : UserControl
    {
        private Buildings buildings;
        private Apartments apartments;
        private bool isFieldsEditable = false;
        private bool isEditMode = false;

        public UC_Apartments()
        {
            InitializeComponent();
            
            // التحقق من أن Designer تم تحميله بشكل صحيح
            if (DesignMode)
                return;
            
            // تهيئة الكلاسات
            buildings = new Buildings();
            apartments = new Apartments();
            
            // ملء ComboBox الخاص برقم العقار
            LoadPropertiesComboBox();
            
            WireReadOnlyFocusGuards();
            
            // افتراضيًا: كل الحقول للقراءة فقط (وتتفعل عند الضغط على "إضافة")
            SetFieldsEditable(false);
            SetEditMode(false);
            
            // ربط أحداث الأزرار
            if (btnAdd != null)
                btnAdd.Click += BtnAdd_Click;
            if (btnClose != null)
                btnClose.Click += BtnClose_Click;
        }

        private void LoadPropertiesComboBox()
        {
            try
            {
                // الحصول على بيانات المباني
                DataTable dt = buildings.GET_ALL_Buildings();
                
                // ملء ComboBox
                cmbPropertyNo.DataSource = dt;
                cmbPropertyNo.DisplayMember = "PropertyName";  // يعرض اسم المبنى
                cmbPropertyNo.ValueMember = "PropertyNo";       // القيمة المرسلة هي رقم المبنى
                
                // جعل ComboBox فارغاً عند الدخول (بدون قيمة محددة)
                cmbPropertyNo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل بيانات المباني: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WireReadOnlyFocusGuards()
        {
            // منع الفوكس على الحقول عندما تكون ReadOnly (حتى عند الضغط بالماوس)
            if (txtApartmentNo != null) txtApartmentNo.Enter += PreventFocusWhenReadOnly;
            if (txtAreaSqm != null) txtAreaSqm.Enter += PreventFocusWhenReadOnly;
            if (txtRoomsCount != null) txtRoomsCount.Enter += PreventFocusWhenReadOnly;
            if (txtKitchensCount != null) txtKitchensCount.Enter += PreventFocusWhenReadOnly;
            if (txtBathroomsCount != null) txtBathroomsCount.Enter += PreventFocusWhenReadOnly;
            if (txtFloorNo != null) txtFloorNo.Enter += PreventFocusWhenReadOnly;
        }

        private void PreventFocusWhenReadOnly(object sender, EventArgs e)
        {
            if (isFieldsEditable)
                return;

            // إذا كانت الشاشة في وضع ReadOnly، انقل الفوكس لأقرب عنصر مناسب (مثل زر الإضافة)
            if (btnAdd != null && btnAdd.CanSelect)
            {
                btnAdd.Select();
                return;
            }

            if (sender is Control c)
                SelectNextControl(c, true, true, true, true);
        }

        private void SetEditMode(bool editMode)
        {
            isEditMode = editMode;
            if (btnSave != null)
                btnSave.Text = editMode ? "تحديث" : "حفظ";
        }

        private void SetFieldsEditable(bool isEditable)
        {
            isFieldsEditable = isEditable;

            // رقم الشقة: افتراضيًا للقراءة فقط (يتفعل فقط في حالة أول مرة)
            SetApartmentNoEditable(false);

            if (txtAreaSqm != null) { txtAreaSqm.ReadOnly = !isEditable; txtAreaSqm.TabStop = isEditable; }
            if (txtRoomsCount != null) { txtRoomsCount.ReadOnly = !isEditable; txtRoomsCount.TabStop = isEditable; }
            if (txtKitchensCount != null) { txtKitchensCount.ReadOnly = !isEditable; txtKitchensCount.TabStop = isEditable; }
            if (txtBathroomsCount != null) { txtBathroomsCount.ReadOnly = !isEditable; txtBathroomsCount.TabStop = isEditable; }
            if (txtFloorNo != null) { txtFloorNo.ReadOnly = !isEditable; txtFloorNo.TabStop = isEditable; }

            if (cmbPropertyNo != null) cmbPropertyNo.Enabled = isEditable;
            if (cmbApartmentType != null) cmbApartmentType.Enabled = isEditable;
            if (cmbApartmentStatus != null) cmbApartmentStatus.Enabled = isEditable;
            if (cmbRentStatus != null) cmbRentStatus.Enabled = isEditable;
        }

        private void SetApartmentNoEditable(bool isEditable)
        {
            if (txtApartmentNo == null)
                return;

            txtApartmentNo.ReadOnly = !isEditable;
            txtApartmentNo.TabStop = isEditable;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            ClearFields();
            SetFieldsEditable(true);

            try
            {
                string nextId = apartments.GET_NEXT_APARTMENT_CODE();

                // إذا لم يوجد رقم سابق (أول مرة/لا توجد بيانات رقمية) نخلي المستخدم يدخل الرقم يدوياً
                if (nextId == "1")
                {
                    SetApartmentNoEditable(true);
                    MessageBox.Show(
                        "لا يوجد رقم سابق للشقة.\nالرجاء إدخال رقم الشقة يدوياً لأول مرة، وسيتم توليد الرقم التالي تلقائياً لاحقاً.",
                        "تنبيه",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtApartmentNo?.Focus();
                    return;
                }

                if (txtApartmentNo != null)
                    txtApartmentNo.Text = nextId;
                SetApartmentNoEditable(false);

                cmbPropertyNo?.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء توليد الرقم: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            if (txtApartmentNo != null) txtApartmentNo.Text = string.Empty;
            if (cmbPropertyNo != null) cmbPropertyNo.SelectedIndex = -1;
            if (txtAreaSqm != null) txtAreaSqm.Text = string.Empty;
            if (cmbApartmentType != null) cmbApartmentType.SelectedIndex = -1;
            if (cmbApartmentStatus != null) cmbApartmentStatus.SelectedIndex = -1;
            if (cmbRentStatus != null) cmbRentStatus.SelectedIndex = -1;
            if (txtRoomsCount != null) txtRoomsCount.Text = string.Empty;
            if (txtKitchensCount != null) txtKitchensCount.Text = string.Empty;
            if (txtBathroomsCount != null) txtBathroomsCount.Text = string.Empty;
            if (txtFloorNo != null) txtFloorNo.Text = string.Empty;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            // رجوع للشاشة الرئيسية (Form1)
            if (FindForm() is Form1 mainForm)
            {
                mainForm.ShowHome();
                return;
            }

            // كحل احتياطي: إخفاء الشاشة الحالية
            this.Visible = false;
        }
    }
}
