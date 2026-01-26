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
        private GridBtnViewHelper gridBtnViewHelper;
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
            gridBtnViewHelper = new GridBtnViewHelper();
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
            if (btnSave != null)
                btnSave.Click += BtnSave_Click;
            if (btnSearch != null)
                btnSearch.Click += BtnSearch_Click;
            if (btnEdit != null)
                btnEdit.Click += BtnEdit_Click;
            if (btnDelete != null)
                btnDelete.Click += BtnDelete_Click;
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string apartmentNo = (txtApartmentNo?.Text ?? string.Empty).Trim();
                string propertyNo = cmbPropertyNo?.SelectedValue?.ToString() ?? string.Empty;
                string areaSqmText = (txtAreaSqm?.Text ?? string.Empty).Trim();
                string apartmentType = (cmbApartmentType?.SelectedItem?.ToString() ?? cmbApartmentType?.Text ?? string.Empty).Trim();
                string apartmentStatus = (cmbApartmentStatus?.SelectedItem?.ToString() ?? cmbApartmentStatus?.Text ?? string.Empty).Trim();
                string rentStatus = (cmbRentStatus?.SelectedItem?.ToString() ?? cmbRentStatus?.Text ?? string.Empty).Trim();
                string roomsCountText = (txtRoomsCount?.Text ?? string.Empty).Trim();
                string kitchensCountText = (txtKitchensCount?.Text ?? string.Empty).Trim();
                string bathroomsCountText = (txtBathroomsCount?.Text ?? string.Empty).Trim();
                string floorNoText = (txtFloorNo?.Text ?? string.Empty).Trim();

                // التحقق من الحقول الإلزامية
                if (string.IsNullOrWhiteSpace(apartmentNo) ||
                    string.IsNullOrWhiteSpace(propertyNo) ||
                    string.IsNullOrWhiteSpace(areaSqmText) ||
                    string.IsNullOrWhiteSpace(apartmentType) ||
                    string.IsNullOrWhiteSpace(apartmentStatus) ||
                    string.IsNullOrWhiteSpace(rentStatus) ||
                    string.IsNullOrWhiteSpace(roomsCountText) ||
                    string.IsNullOrWhiteSpace(kitchensCountText) ||
                    string.IsNullOrWhiteSpace(bathroomsCountText) ||
                    string.IsNullOrWhiteSpace(floorNoText))
                {
                    MessageBox.Show(
                        "الرجاء تعبئة جميع الحقول الإلزامية.",
                        "تنبيه",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // تحويل القيم الرقمية
                if (!decimal.TryParse(areaSqmText, out decimal areaSqm))
                {
                    MessageBox.Show("الرجاء إدخال قيمة صحيحة للمساحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(roomsCountText, out int roomsCount))
                {
                    MessageBox.Show("الرجاء إدخال قيمة صحيحة لعدد الغرف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(kitchensCountText, out int kitchensCount))
                {
                    MessageBox.Show("الرجاء إدخال قيمة صحيحة لعدد المطابخ.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(bathroomsCountText, out int bathroomsCount))
                {
                    MessageBox.Show("الرجاء إدخال قيمة صحيحة لعدد الحمامات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(floorNoText, out int floorNo))
                {
                    MessageBox.Show("الرجاء إدخال قيمة صحيحة لرقم الطابق.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (isEditMode)
                {
                    apartments.UPDATE_Apartments(apartmentNo, propertyNo, areaSqm, apartmentType,
                        apartmentStatus, rentStatus, roomsCount, kitchensCount, bathroomsCount, floorNo);
                    MessageBox.Show("تم تحديث بيانات الشقة بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    apartments.ADD_Apartments(apartmentNo, propertyNo, areaSqm, apartmentType, 
                        apartmentStatus, rentStatus, roomsCount, kitchensCount, bathroomsCount, floorNo);
                    MessageBox.Show("تم حفظ بيانات الشقة بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClearFields();
                SetFieldsEditable(false);
                SetEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
            // استدعاء البيانات من قاعدة البيانات
            DataTable dt = apartments.GET_ALL_Apartments();
            
            // عرض البيانات في نافذة البحث الديناميكية
            DataRow row = gridBtnViewHelper.Show(dt, "البحث عن الشقق");
            
            if (row != null)
            {
                // تعبئة البيانات في الحقول
                FillFieldsFromRow(row);
            }
        }

        private void FillFieldsFromRow(DataRow row)
        {
            try
            {
                SetEditMode(false);
                SetFieldsEditable(false);

                // تعبئة الحقول من البيانات المختارة
                if (row.Table.Columns.Contains("ApartmentNo"))
                    txtApartmentNo.Text = row["ApartmentNo"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("PropertyNo"))
                {
                    string propertyNo = row["PropertyNo"]?.ToString() ?? "";
                    // البحث عن رقم العقار في ComboBox
                    if (cmbPropertyNo != null)
                    {
                        for (int i = 0; i < cmbPropertyNo.Items.Count; i++)
                        {
                            DataRowView drv = cmbPropertyNo.Items[i] as DataRowView;
                            if (drv != null && drv["PropertyNo"]?.ToString() == propertyNo)
                            {
                                cmbPropertyNo.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }

                if (row.Table.Columns.Contains("AreaSqm"))
                    txtAreaSqm.Text = row["AreaSqm"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("ApartmentType"))
                {
                    string apartmentType = row["ApartmentType"]?.ToString() ?? "";
                    // البحث عن النوع في ComboBox
                    if (cmbApartmentType != null)
                    {
                        for (int i = 0; i < cmbApartmentType.Items.Count; i++)
                        {
                            if (cmbApartmentType.Items[i].ToString() == apartmentType)
                            {
                                cmbApartmentType.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }

                if (row.Table.Columns.Contains("ApartmentStatus"))
                {
                    string apartmentStatus = row["ApartmentStatus"]?.ToString() ?? "";
                    // البحث عن الحالة في ComboBox
                    if (cmbApartmentStatus != null)
                    {
                        for (int i = 0; i < cmbApartmentStatus.Items.Count; i++)
                        {
                            if (cmbApartmentStatus.Items[i].ToString() == apartmentStatus)
                            {
                                cmbApartmentStatus.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }

                if (row.Table.Columns.Contains("RentStatus"))
                {
                    string rentStatus = row["RentStatus"]?.ToString() ?? "";
                    // البحث عن حالة الإيجار في ComboBox
                    if (cmbRentStatus != null)
                    {
                        for (int i = 0; i < cmbRentStatus.Items.Count; i++)
                        {
                            if (cmbRentStatus.Items[i].ToString() == rentStatus)
                            {
                                cmbRentStatus.SelectedIndex = i;
                                break;
                            }
                        }
                    }
                }

                if (row.Table.Columns.Contains("RoomsCount"))
                    txtRoomsCount.Text = row["RoomsCount"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("KitchensCount"))
                    txtKitchensCount.Text = row["KitchensCount"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("BathroomsCount"))
                    txtBathroomsCount.Text = row["BathroomsCount"]?.ToString() ?? "";

                if (row.Table.Columns.Contains("FloorNo"))
                    txtFloorNo.Text = row["FloorNo"]?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تعبئة البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // لا يمكن التعديل بدون اختيار سجل (رقم شقة)
            string apartmentNo = (txtApartmentNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(apartmentNo))
            {
                MessageBox.Show("الرجاء اختيار شقة أولاً عن طريق زر البحث.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetEditMode(true);
            SetFieldsEditable(true);

            // رقم الشقة لا يتعدل
            SetApartmentNoEditable(false);

            cmbPropertyNo?.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string apartmentNo = (txtApartmentNo?.Text ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(apartmentNo))
            {
                MessageBox.Show("الرجاء اختيار شقة أولاً عن طريق زر البحث.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"هل أنت متأكد من حذف الشقة رقم ({apartmentNo})؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                apartments.DELETE_Apartments(apartmentNo);
                MessageBox.Show("تم حذف الشقة بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                SetFieldsEditable(false);
                SetEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
