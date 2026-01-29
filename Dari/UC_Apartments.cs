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
        
        // متغيرات لحفظ مسار الملف المرفق
        private string attachmentPath = null;
        private string attachmentPathCopied = null;
        private bool isAttachmentDeleted = false;

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
            WireNumericValidation();
            
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
            
            // ربط أحداث أزرار المرفق
            if (btnAttachmentUpload != null)
                btnAttachmentUpload.Click += BtnAttachmentUpload_Click;
            if (btnAttachmentOpen != null)
                btnAttachmentOpen.Click += BtnAttachmentOpen_Click;
            if (btnAttachmentDelete != null)
                btnAttachmentDelete.Click += BtnAttachmentDelete_Click;
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

        private void WireNumericValidation()
        {
            // ربط أحداث التحقق من الحقول الرقمية
            // المساحة (DECIMAL - يسمح بنقطة)
            if (txtAreaSqm != null)
            {
                txtAreaSqm.KeyPress += NumericKeyPress_Decimal;
                txtAreaSqm.KeyDown += NumericKeyDown_Decimal;
                txtAreaSqm.TextChanged += NumericTextChanged_Decimal;
                txtAreaSqm.Validating += NumericValidating;
            }

            // عدد الغرف (INT - أرقام فقط)
            if (txtRoomsCount != null)
            {
                txtRoomsCount.KeyPress += NumericKeyPress_Integer;
                txtRoomsCount.Validating += NumericValidating;
            }

            // عدد المطابخ (INT - أرقام فقط)
            if (txtKitchensCount != null)
            {
                txtKitchensCount.KeyPress += NumericKeyPress_Integer;
                txtKitchensCount.Validating += NumericValidating;
            }

            // عدد الحمامات (INT - أرقام فقط)
            if (txtBathroomsCount != null)
            {
                txtBathroomsCount.KeyPress += NumericKeyPress_Integer;
                txtBathroomsCount.Validating += NumericValidating;
            }

            // رقم الطابق (INT - أرقام فقط)
            if (txtFloorNo != null)
            {
                txtFloorNo.KeyPress += NumericKeyPress_Integer;
                txtFloorNo.Validating += NumericValidating;
            }
        }

        private void NumericKeyPress_Integer(object sender, KeyPressEventArgs e)
        {
            // السماح فقط بالأرقام (0-9) ومفاتيح التحكم (Backspace, Delete, Tab, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("هذا الحقل يقبل الأرقام فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NumericKeyPress_Decimal(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox2 textBox = sender as MaterialTextBox2;
            if (textBox == null) return;

            // السماح بالأرقام ومفاتيح التحكم
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            // السماح بنقطة واحدة فقط للأرقام العشرية
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // تحويل الفاصلة إلى نقطة
                if (e.KeyChar == ',')
                    e.KeyChar = '.';

                // التحقق من وجود نقطة مسبقاً
                if (textBox.Text.Contains("."))
                {
                    e.Handled = true;
                    MessageBox.Show("يمكن إدخال نقطة واحدة فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                e.Handled = false;
                return;
            }

            // السماح فقط بالأرقام
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("هذا الحقل يقبل الأرقام فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NumericKeyDown_Decimal(object sender, KeyEventArgs e)
        {
            MaterialTextBox2 textBox = sender as MaterialTextBox2;
            if (textBox == null) return;

            // السماح بمفاتيح التحكم (Backspace, Delete, Tab, Arrow keys, etc.)
            if (e.Control || e.Alt || 
                e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete ||
                e.KeyCode == Keys.Left || e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Home || e.KeyCode == Keys.End ||
                e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                return;
            }

            // السماح بالأرقام (0-9) والنقطة
            bool isNumeric = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                            (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);
            bool isDot = e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal;

            if (isDot)
            {
                // التحقق من وجود نقطة مسبقاً
                if (textBox.Text.Contains("."))
                {
                    e.SuppressKeyPress = true;
                    MessageBox.Show("يمكن إدخال نقطة واحدة فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                return;
            }

            // منع أي مفتاح آخر غير الأرقام
            if (!isNumeric)
            {
                e.SuppressKeyPress = true;
                MessageBox.Show("هذا الحقل يقبل الأرقام والنقطة فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NumericTextChanged_Decimal(object sender, EventArgs e)
        {
            MaterialTextBox2 textBox = sender as MaterialTextBox2;
            if (textBox == null || !isFieldsEditable) return;

            string text = textBox.Text;
            if (string.IsNullOrWhiteSpace(text)) return;

            // إزالة أي أحرف غير رقمية (عدا النقطة)
            string cleanedText = "";
            bool hasDot = false;
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    cleanedText += c;
                }
                else if ((c == '.' || c == ',') && !hasDot)
                {
                    cleanedText += ".";
                    hasDot = true;
                }
            }

            // إذا تغير النص، قم بتحديثه
            if (cleanedText != text)
            {
                int selectionStart = textBox.SelectionStart;
                int selectionLength = textBox.SelectionLength;
                
                // حساب الفرق في الطول
                int lengthDiff = cleanedText.Length - text.Length;
                
                textBox.Text = cleanedText;
                
                // الحفاظ على موضع المؤشر
                int newSelectionStart = selectionStart + lengthDiff;
                if (newSelectionStart < 0) newSelectionStart = 0;
                if (newSelectionStart > cleanedText.Length) newSelectionStart = cleanedText.Length;
                
                textBox.SelectionStart = newSelectionStart;
                textBox.SelectionLength = 0;
                
                MessageBox.Show("هذا الحقل يقبل الأرقام والنقطة فقط.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NumericValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaterialTextBox2 textBox = sender as MaterialTextBox2;
            if (textBox == null) return;

            string text = textBox.Text.Trim();

            // السماح بالحقل الفارغ (سيتم التحقق منه عند الحفظ)
            if (string.IsNullOrWhiteSpace(text))
                return;

            // التحقق من أن القيمة رقمية
            if (textBox == txtAreaSqm)
            {
                // للمساحة (DECIMAL)
                if (!decimal.TryParse(text, out decimal value))
                {
                    MessageBox.Show("الرجاء إدخال قيمة رقمية صحيحة للمساحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                    textBox.Focus();
                    return;
                }

                // التحقق من أن القيمة موجبة
                if (value <= 0)
                {
                    MessageBox.Show("المساحة يجب أن تكون قيمة موجبة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                    textBox.Focus();
                    return;
                }
            }
            else
            {
                // للحقول الأخرى (INT)
                if (!int.TryParse(text, out int value))
                {
                    MessageBox.Show("الرجاء إدخال قيمة رقمية صحيحة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                    textBox.Focus();
                    return;
                }

                // التحقق من أن القيمة موجبة
                if (value <= 0)
                {
                    MessageBox.Show("القيمة يجب أن تكون رقماً موجباً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                    textBox.Focus();
                    return;
                }
            }
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
            
            // أزرار المرفق
            if (btnAttachmentUpload != null) btnAttachmentUpload.Enabled = isEditable;
            if (btnAttachmentOpen != null) btnAttachmentOpen.Enabled = isEditable;
            if (btnAttachmentDelete != null) btnAttachmentDelete.Enabled = isEditable;
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

                // نسخ الملف إلى مجلد المرفقات قبل الحفظ
                string attachmentPathToSave = null;
                
                try
                {
                    if (!string.IsNullOrWhiteSpace(attachmentPath))
                    {
                        // إذا كان في وضع التعديل وكان هناك ملف قديم، احذفه أولاً
                        if (isEditMode && !string.IsNullOrWhiteSpace(attachmentPathCopied) && 
                            System.IO.File.Exists(attachmentPathCopied))
                        {
                            try
                            {
                                FileHelper.DeleteAttachmentFile(attachmentPathCopied);
                            }
                            catch { }
                        }
                        
                        attachmentPathToSave = CopyFileToAttachmentsFolder(attachmentPath, "Apartments");
                        attachmentPathCopied = attachmentPathToSave;
                        isAttachmentDeleted = false;
                    }
                    else if (isEditMode && !string.IsNullOrWhiteSpace(attachmentPathCopied) && !isAttachmentDeleted)
                    {
                        attachmentPathToSave = attachmentPathCopied;
                    }
                    else if (isEditMode && isAttachmentDeleted && !string.IsNullOrWhiteSpace(attachmentPathCopied))
                    {
                        try
                        {
                            FileHelper.DeleteAttachmentFile(attachmentPathCopied);
                            attachmentPathToSave = null;
                        }
                        catch { }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء نسخ الملف: {ex.Message}", "خطأ", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (isEditMode)
                {
                    apartments.UPDATE_Apartments(apartmentNo, propertyNo, areaSqm, apartmentType,
                        apartmentStatus, rentStatus, roomsCount, kitchensCount, bathroomsCount, floorNo, attachmentPathToSave);
                    MessageBox.Show("تم تحديث بيانات الشقة بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    apartments.ADD_Apartments(apartmentNo, propertyNo, areaSqm, apartmentType, 
                        apartmentStatus, rentStatus, roomsCount, kitchensCount, bathroomsCount, floorNo, attachmentPathToSave);
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
                // حذف الملف المرفق من القرص قبل حذف الشقة
                DataTable dt = apartments.GET_ALL_Apartments();
                DataRow apartmentRow = dt.AsEnumerable()
                    .FirstOrDefault(row => row["ApartmentNo"]?.ToString() == apartmentNo);
                
                if (apartmentRow != null)
                {
                    if (apartmentRow.Table.Columns.Contains("AttachmentPath") && 
                        apartmentRow["AttachmentPath"] != DBNull.Value && 
                        !string.IsNullOrWhiteSpace(apartmentRow["AttachmentPath"]?.ToString()))
                    {
                        try
                        {
                            FileHelper.DeleteAttachmentFile(apartmentRow["AttachmentPath"].ToString());
                        }
                        catch { }
                    }
                }
                
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
            
            // مسح المرفق
            attachmentPath = null;
            attachmentPathCopied = null;
            isAttachmentDeleted = false;
            if (lblAttachmentName != null) lblAttachmentName.Text = string.Empty;
        }

        // دوال ديناميكية للتعامل مع الملفات
        private void HandleFileUpload(ref string filePath, ref string filePathCopied, ref bool isDeleted, MaterialLabel labelName, string dialogTitle)
        {
            try
            {
                string selectedFile = FileHelper.BrowseFile(dialogTitle, "جميع الملفات|*.*|صور|*.jpg;*.jpeg;*.png;*.bmp|PDF|*.pdf");
                
                if (string.IsNullOrWhiteSpace(selectedFile))
                    return;

                filePath = selectedFile;
                isDeleted = false;
                
                string fileName = FileHelper.GetFileName(selectedFile);
                if (labelName != null)
                {
                    labelName.Text = fileName;
                }
                
                MessageBox.Show("تم اختيار الملف بنجاح. سيتم حفظه عند الضغط على زر الحفظ.", "تم", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء اختيار الملف: {ex.Message}", "خطأ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleFileOpen(string filePath)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filePath))
                {
                    MessageBox.Show("لا يوجد ملف مرفق.", "تنبيه", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FileHelper.OpenFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء فتح الملف: {ex.Message}", "خطأ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleFileDelete(ref string filePath, ref string filePathCopied, ref bool isDeleted, MaterialLabel labelName)
        {
            filePath = null;
            isDeleted = true;
            if (labelName != null)
            {
                labelName.Text = string.Empty;
            }
        }

        private string CopyFileToAttachmentsFolder(string sourceFilePath, string folderType)
        {
            if (string.IsNullOrWhiteSpace(sourceFilePath) || !System.IO.File.Exists(sourceFilePath))
                return null;
            
            try
            {
                return FileHelper.CopyFileToAttachments(sourceFilePath, folderType);
            }
            catch (Exception ex)
            {
                throw new Exception($"فشل في نسخ الملف إلى مجلد المرفقات: {ex.Message}");
            }
        }

        // دوال المرفق
        private void BtnAttachmentUpload_Click(object sender, EventArgs e)
        {
            HandleFileUpload(ref attachmentPath, ref attachmentPathCopied, ref isAttachmentDeleted, lblAttachmentName, "اختر المرفق");
        }

        private void BtnAttachmentOpen_Click(object sender, EventArgs e)
        {
            string filePathToOpen = attachmentPath;
            if (string.IsNullOrWhiteSpace(filePathToOpen))
            {
                filePathToOpen = attachmentPathCopied;
                if (string.IsNullOrWhiteSpace(filePathToOpen))
                {
                    string apartmentNo = (txtApartmentNo?.Text ?? string.Empty).Trim();
                    if (!string.IsNullOrWhiteSpace(apartmentNo))
                    {
                        try
                        {
                            DataTable dt = apartments.GET_ALL_Apartments();
                            DataRow apartmentRow = dt.AsEnumerable()
                                .FirstOrDefault(row => row["ApartmentNo"]?.ToString() == apartmentNo);
                            
                            if (apartmentRow != null && 
                                apartmentRow.Table.Columns.Contains("AttachmentPath") && 
                                apartmentRow["AttachmentPath"] != DBNull.Value)
                            {
                                filePathToOpen = apartmentRow["AttachmentPath"]?.ToString();
                            }
                        }
                        catch { }
                    }
                }
            }
            HandleFileOpen(filePathToOpen);
        }

        private void BtnAttachmentDelete_Click(object sender, EventArgs e)
        {
            HandleFileDelete(ref attachmentPath, ref attachmentPathCopied, ref isAttachmentDeleted, lblAttachmentName);
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
