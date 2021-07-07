
namespace QuanLySoTietKiem
{
    partial class FormLapPhieuGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLapPhieuGui));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTienGui = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhieuGui = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKhachHang = new Guna.UI.WinForms.GunaTextBox();
            this.btnLuuPhieuGuiTien = new Guna.UI.WinForms.GunaButton();
            this.dgvDanhSachPhieuGuiTien = new Guna.UI.WinForms.GunaDataGridView();
            this.cbMaSoTietKiem = new System.Windows.Forms.ComboBox();
            this.dtpNgayGui = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.gunaTextBox5 = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuGuiTien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(221, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "LẬP PHIẾU GỬI TIỀN";
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.BackColor = System.Drawing.Color.Transparent;
            this.txtSoTienGui.BaseColor = System.Drawing.Color.White;
            this.txtSoTienGui.BorderColor = System.Drawing.Color.Teal;
            this.txtSoTienGui.BorderSize = 1;
            this.txtSoTienGui.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTienGui.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSoTienGui.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSoTienGui.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSoTienGui.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienGui.Location = new System.Drawing.Point(502, 118);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.PasswordChar = '\0';
            this.txtSoTienGui.Radius = 10;
            this.txtSoTienGui.SelectedText = "";
            this.txtSoTienGui.Size = new System.Drawing.Size(159, 33);
            this.txtSoTienGui.TabIndex = 30;
            this.txtSoTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienGui_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Số tiền gửi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ngày gửi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã sổ tiết kiệm:";
            // 
            // txtMaPhieuGui
            // 
            this.txtMaPhieuGui.BackColor = System.Drawing.Color.Transparent;
            this.txtMaPhieuGui.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaPhieuGui.BorderColor = System.Drawing.Color.Teal;
            this.txtMaPhieuGui.BorderSize = 1;
            this.txtMaPhieuGui.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieuGui.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaPhieuGui.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaPhieuGui.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaPhieuGui.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuGui.Location = new System.Drawing.Point(151, 72);
            this.txtMaPhieuGui.Name = "txtMaPhieuGui";
            this.txtMaPhieuGui.PasswordChar = '\0';
            this.txtMaPhieuGui.Radius = 10;
            this.txtMaPhieuGui.ReadOnly = true;
            this.txtMaPhieuGui.SelectedText = "";
            this.txtMaPhieuGui.Size = new System.Drawing.Size(159, 33);
            this.txtMaPhieuGui.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã phiếu gửi:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.txtKhachHang.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtKhachHang.BorderColor = System.Drawing.Color.Teal;
            this.txtKhachHang.BorderSize = 1;
            this.txtKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKhachHang.FocusedBaseColor = System.Drawing.Color.White;
            this.txtKhachHang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtKhachHang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKhachHang.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachHang.Location = new System.Drawing.Point(151, 168);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.PasswordChar = '\0';
            this.txtKhachHang.Radius = 10;
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.SelectedText = "";
            this.txtKhachHang.Size = new System.Drawing.Size(159, 33);
            this.txtKhachHang.TabIndex = 31;
            // 
            // btnLuuPhieuGuiTien
            // 
            this.btnLuuPhieuGuiTien.AnimationHoverSpeed = 0.07F;
            this.btnLuuPhieuGuiTien.AnimationSpeed = 0.03F;
            this.btnLuuPhieuGuiTien.BackColor = System.Drawing.Color.Transparent;
            this.btnLuuPhieuGuiTien.BaseColor = System.Drawing.Color.Teal;
            this.btnLuuPhieuGuiTien.BorderColor = System.Drawing.Color.Black;
            this.btnLuuPhieuGuiTien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuuPhieuGuiTien.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuuPhieuGuiTien.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPhieuGuiTien.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhieuGuiTien.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuPhieuGuiTien.Image")));
            this.btnLuuPhieuGuiTien.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuuPhieuGuiTien.Location = new System.Drawing.Point(387, 229);
            this.btnLuuPhieuGuiTien.Name = "btnLuuPhieuGuiTien";
            this.btnLuuPhieuGuiTien.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLuuPhieuGuiTien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuuPhieuGuiTien.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuuPhieuGuiTien.OnHoverImage = null;
            this.btnLuuPhieuGuiTien.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuuPhieuGuiTien.Radius = 15;
            this.btnLuuPhieuGuiTien.Size = new System.Drawing.Size(198, 35);
            this.btnLuuPhieuGuiTien.TabIndex = 33;
            this.btnLuuPhieuGuiTien.Text = "   Lưu và xuất phiếu";
            this.btnLuuPhieuGuiTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuuPhieuGuiTien.Click += new System.EventHandler(this.btnLuuPhieuGuiTien_Click);
            // 
            // dgvDanhSachPhieuGuiTien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachPhieuGuiTien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachPhieuGuiTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuGuiTien.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachPhieuGuiTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachPhieuGuiTien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachPhieuGuiTien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachPhieuGuiTien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachPhieuGuiTien.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachPhieuGuiTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachPhieuGuiTien.EnableHeadersVisualStyles = false;
            this.dgvDanhSachPhieuGuiTien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachPhieuGuiTien.Location = new System.Drawing.Point(10, 295);
            this.dgvDanhSachPhieuGuiTien.Name = "dgvDanhSachPhieuGuiTien";
            this.dgvDanhSachPhieuGuiTien.RowHeadersVisible = false;
            this.dgvDanhSachPhieuGuiTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPhieuGuiTien.Size = new System.Drawing.Size(651, 250);
            this.dgvDanhSachPhieuGuiTien.TabIndex = 35;
            this.dgvDanhSachPhieuGuiTien.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.ReadOnly = false;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachPhieuGuiTien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDanhSachPhieuGuiTien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPhieuGuiTien_CellClick);
            // 
            // cbMaSoTietKiem
            // 
            this.cbMaSoTietKiem.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSoTietKiem.FormattingEnabled = true;
            this.cbMaSoTietKiem.Location = new System.Drawing.Point(151, 123);
            this.cbMaSoTietKiem.Name = "cbMaSoTietKiem";
            this.cbMaSoTietKiem.Size = new System.Drawing.Size(159, 29);
            this.cbMaSoTietKiem.TabIndex = 105;
            this.cbMaSoTietKiem.SelectedValueChanged += new System.EventHandler(this.cbMaSoTietKiem_SelectedValueChanged);
            this.cbMaSoTietKiem.TextChanged += new System.EventHandler(this.cbMaSoTietKiem_TextChanged);
            // 
            // dtpNgayGui
            // 
            this.dtpNgayGui.CalendarFont = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayGui.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayGui.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGui.Location = new System.Drawing.Point(502, 73);
            this.dtpNgayGui.Name = "dtpNgayGui";
            this.dtpNgayGui.Size = new System.Drawing.Size(159, 29);
            this.dtpNgayGui.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 110;
            this.label8.Text = "Tìm Kiếm:";
            // 
            // gunaTextBox5
            // 
            this.gunaTextBox5.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox5.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox5.BorderColor = System.Drawing.Color.Teal;
            this.gunaTextBox5.BorderSize = 1;
            this.gunaTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox5.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox5.Location = new System.Drawing.Point(97, 233);
            this.gunaTextBox5.Name = "gunaTextBox5";
            this.gunaTextBox5.PasswordChar = '\0';
            this.gunaTextBox5.Radius = 10;
            this.gunaTextBox5.SelectedText = "";
            this.gunaTextBox5.Size = new System.Drawing.Size(194, 26);
            this.gunaTextBox5.TabIndex = 109;
            // 
            // FormLapPhieuGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(675, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gunaTextBox5);
            this.Controls.Add(this.dtpNgayGui);
            this.Controls.Add(this.cbMaSoTietKiem);
            this.Controls.Add(this.dgvDanhSachPhieuGuiTien);
            this.Controls.Add(this.btnLuuPhieuGuiTien);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.txtSoTienGui);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaPhieuGui);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLapPhieuGui";
            this.Text = "FormLapPhieuGui";
            this.Load += new System.EventHandler(this.FormLapPhieuGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuGuiTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtSoTienGui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtMaPhieuGui;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtKhachHang;
        private Guna.UI.WinForms.GunaButton btnLuuPhieuGuiTien;
        private Guna.UI.WinForms.GunaDataGridView dgvDanhSachPhieuGuiTien;
        private System.Windows.Forms.ComboBox cbMaSoTietKiem;
        private System.Windows.Forms.DateTimePicker dtpNgayGui;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox5;
    }
}