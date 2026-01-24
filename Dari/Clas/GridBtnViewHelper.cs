using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Dari.Clas
{
    public class GridBtnViewHelper
    {
        public DataRow Show(DataTable dt, string title = "عرض البيانات")
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات للعرض", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            DataRow selectedRow = null;

            // إنشاء Form بتصميم Material Design
            MaterialForm viewForm = new MaterialForm();
            viewForm.Text = title;
            viewForm.RightToLeft = RightToLeft.Yes;
            viewForm.RightToLeftLayout = true;
            viewForm.Size = new Size(1200, 600);
            viewForm.StartPosition = FormStartPosition.CenterScreen;
            viewForm.MaximizeBox = false;
            viewForm.MinimizeBox = false;

            // إعداد MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(viewForm);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue700, Primary.Blue800,
                Primary.Blue500, Accent.Blue200,
                TextShade.WHITE
            );

            // ================== Header Panel ==================
            Panel pnlHeader = new Panel();
            pnlHeader.BackColor = Color.FromArgb(33, 150, 243);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 60;
            pnlHeader.RightToLeft = RightToLeft.Yes;

            MaterialLabel lblTitle = new MaterialLabel();
            lblTitle.AutoSize = true;
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Roboto Medium", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 18);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Text = title;
            lblTitle.RightToLeft = RightToLeft.Yes;

            pnlHeader.Controls.Add(lblTitle);

            // ================== شريط البحث ==================
            Panel searchPanel = new Panel();
            searchPanel.Dock = DockStyle.Top;
            searchPanel.Height = 60;
            searchPanel.Padding = new Padding(20, 10, 20, 10);
            searchPanel.BackColor = Color.White;
            searchPanel.RightToLeft = RightToLeft.Yes;

            MaterialLabel lblSearch = new MaterialLabel();
            lblSearch.Text = "بحث:";
            lblSearch.AutoSize = true;
            lblSearch.Depth = 0;
            lblSearch.Font = new Font("Roboto", 12F);
            lblSearch.ForeColor = Color.FromArgb(180, 0, 0, 0);
            lblSearch.Location = new Point(20, 20);
            lblSearch.MouseState = MaterialSkin.MouseState.HOVER;
            lblSearch.RightToLeft = RightToLeft.Yes;

            MaterialTextBox2 txtSearch = new MaterialTextBox2();
            txtSearch.Width = 300;
            txtSearch.Hint = "ابحث في جميع الأعمدة...";
            txtSearch.RightToLeft = RightToLeft.Yes;
            txtSearch.TextAlign = HorizontalAlignment.Right;
            txtSearch.Location = new Point(80, 15);
            txtSearch.UseTallSize = false;

            searchPanel.Controls.Add(lblSearch);
            searchPanel.Controls.Add(txtSearch);
            // =================================================

            DataView dv = new DataView(dt);

            // ================== DataGridView ==================
            Panel pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Padding = new Padding(20);
            pnlContent.BackColor = Color.White;
            pnlContent.RightToLeft = RightToLeft.Yes;

            DataGridView dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.DataSource = dv;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RightToLeft = RightToLeft.Yes;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(240, 240, 240);
            dgv.RowHeadersWidth = 51;

            pnlContent.Controls.Add(dgv);
            // =================================================

            // ================== أزرار ==================
            Panel pnlButtons = new Panel();
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Height = 80;
            pnlButtons.Padding = new Padding(20);
            pnlButtons.BackColor = Color.White;
            pnlButtons.RightToLeft = RightToLeft.Yes;

            MaterialButton btnCancel = new MaterialButton();
            btnCancel.AutoSize = false;
            btnCancel.Size = new Size(150, 50);
            btnCancel.Text = "إلغاء";
            btnCancel.Type = MaterialButton.MaterialButtonType.Contained;
            btnCancel.HighEmphasis = false;
            btnCancel.Location = new Point(20, 15);
            btnCancel.Click += (s, e) => { viewForm.Close(); };

            MaterialButton btnSelect = new MaterialButton();
            btnSelect.AutoSize = false;
            btnSelect.Size = new Size(150, 50);
            btnSelect.Text = "اختيار";
            btnSelect.Type = MaterialButton.MaterialButtonType.Contained;
            btnSelect.HighEmphasis = true;
            btnSelect.Location = new Point(180, 15);
            btnSelect.Click += (s, e) =>
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    var selectedRowView = dgv.SelectedRows[0];
                    if (selectedRowView.DataBoundItem != null)
                    {
                        var rowView = selectedRowView.DataBoundItem as DataRowView;
                        if (rowView != null)
                        {
                            selectedRow = rowView.Row;
                            viewForm.DialogResult = DialogResult.OK;
                            viewForm.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("يرجى اختيار سطر من القائمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnSelect);
            // =================================================

            // البحث
            txtSearch.TextChanged += (s, e) =>
            {
                try
                {
                    string text = txtSearch.Text.Trim();
                    if (string.IsNullOrEmpty(text))
                    {
                        dv.RowFilter = "";
                        return;
                    }

                    List<string> filters = new List<string>();
                    string esc = text.Replace("'", "''");

                    foreach (DataColumn col in dt.Columns)
                    {
                        filters.Add($"CONVERT([{col.ColumnName}], System.String) LIKE '%{esc}%'");
                    }

                    dv.RowFilter = string.Join(" OR ", filters);
                }
                catch
                {
                    dv.RowFilter = "";
                }
            };

            // اختيار الصف - Double Click
            dgv.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var rowView = dgv.Rows[e.RowIndex].DataBoundItem as DataRowView;
                    if (rowView != null)
                    {
                        selectedRow = rowView.Row;
                        viewForm.DialogResult = DialogResult.OK;
                        viewForm.Close();
                    }
                }
            };

            // اختيار الصف - Enter Key
            dgv.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter && dgv.CurrentRow != null)
                {
                    var rowView = dgv.CurrentRow.DataBoundItem as DataRowView;
                    if (rowView != null)
                    {
                        selectedRow = rowView.Row;
                        viewForm.DialogResult = DialogResult.OK;
                        viewForm.Close();
                    }
                }
            };

            // إضافة Controls إلى Form
            viewForm.Controls.Add(pnlContent);
            viewForm.Controls.Add(pnlButtons);
            viewForm.Controls.Add(searchPanel);
            viewForm.Controls.Add(pnlHeader);

            viewForm.ShowDialog();

            return selectedRow;
        }
    }
}
