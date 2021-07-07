
namespace QuanLySoTietKiem
{
    partial class FormBaoCaoThang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCaoThang));
            this.lbChenhLech = new Guna.UI.WinForms.GunaLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSoDong = new Guna.UI.WinForms.GunaLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSoMo = new Guna.UI.WinForms.GunaLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBaoCaoThang = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.btnTraCuu = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cbThang = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNam = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoaiTietKiem = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChenhLech
            // 
            this.lbChenhLech.AutoSize = true;
            this.lbChenhLech.BackColor = System.Drawing.Color.Silver;
            this.lbChenhLech.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChenhLech.Location = new System.Drawing.Point(475, 484);
            this.lbChenhLech.Name = "lbChenhLech";
            this.lbChenhLech.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lbChenhLech.Size = new System.Drawing.Size(27, 26);
            this.lbChenhLech.TabIndex = 113;
            this.lbChenhLech.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 112;
            this.label7.Text = "Chênh lệch:";
            // 
            // lbSoDong
            // 
            this.lbSoDong.AutoSize = true;
            this.lbSoDong.BackColor = System.Drawing.Color.Silver;
            this.lbSoDong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDong.Location = new System.Drawing.Point(216, 504);
            this.lbSoDong.Name = "lbSoDong";
            this.lbSoDong.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lbSoDong.Size = new System.Drawing.Size(27, 26);
            this.lbSoDong.TabIndex = 110;
            this.lbSoDong.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 109;
            this.label4.Text = "Tổng sổ đóng:";
            // 
            // lbSoMo
            // 
            this.lbSoMo.AutoSize = true;
            this.lbSoMo.BackColor = System.Drawing.Color.Silver;
            this.lbSoMo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoMo.Location = new System.Drawing.Point(216, 463);
            this.lbSoMo.Name = "lbSoMo";
            this.lbSoMo.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lbSoMo.Size = new System.Drawing.Size(27, 26);
            this.lbSoMo.TabIndex = 107;
            this.lbSoMo.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 106;
            this.label5.Text = "Tổng sổ mở:";
            // 
            // dgvBaoCaoThang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBaoCaoThang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCaoThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCaoThang.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCaoThang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaoCaoThang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBaoCaoThang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCaoThang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCaoThang.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCaoThang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaoCaoThang.EnableHeadersVisualStyles = false;
            this.dgvBaoCaoThang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBaoCaoThang.Location = new System.Drawing.Point(18, 259);
            this.dgvBaoCaoThang.Name = "dgvBaoCaoThang";
            this.dgvBaoCaoThang.RowHeadersVisible = false;
            this.dgvBaoCaoThang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCaoThang.Size = new System.Drawing.Size(638, 170);
            this.dgvBaoCaoThang.TabIndex = 105;
            this.dgvBaoCaoThang.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvBaoCaoThang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoCaoThang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBaoCaoThang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBaoCaoThang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBaoCaoThang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBaoCaoThang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoCaoThang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBaoCaoThang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBaoCaoThang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBaoCaoThang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBaoCaoThang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBaoCaoThang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBaoCaoThang.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvBaoCaoThang.ThemeStyle.ReadOnly = false;
            this.dgvBaoCaoThang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoCaoThang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBaoCaoThang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBaoCaoThang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBaoCaoThang.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBaoCaoThang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBaoCaoThang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(315, 208);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 15;
            this.gunaButton2.Size = new System.Drawing.Size(198, 35);
            this.gunaButton2.TabIndex = 104;
            this.gunaButton2.Text = "Xuất báo cáo";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.AnimationHoverSpeed = 0.07F;
            this.btnTraCuu.AnimationSpeed = 0.03F;
            this.btnTraCuu.BackColor = System.Drawing.Color.Transparent;
            this.btnTraCuu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTraCuu.BorderColor = System.Drawing.Color.Black;
            this.btnTraCuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTraCuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnTraCuu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.Image")));
            this.btnTraCuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTraCuu.Location = new System.Drawing.Point(150, 208);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTraCuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTraCuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTraCuu.OnHoverImage = null;
            this.btnTraCuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnTraCuu.Radius = 15;
            this.btnTraCuu.Size = new System.Drawing.Size(124, 35);
            this.btnTraCuu.TabIndex = 103;
            this.btnTraCuu.Text = "   Tra cứu";
            this.btnTraCuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(164, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 102;
            this.label8.Text = "Chọn tháng:";
            // 
            // cbThang
            // 
            this.cbThang.BackColor = System.Drawing.Color.Transparent;
            this.cbThang.BaseColor = System.Drawing.Color.White;
            this.cbThang.BorderColor = System.Drawing.Color.Teal;
            this.cbThang.BorderSize = 1;
            this.cbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FocusedColor = System.Drawing.Color.Empty;
            this.cbThang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.ForeColor = System.Drawing.Color.Black;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(299, 90);
            this.cbThang.Name = "cbThang";
            this.cbThang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbThang.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbThang.Radius = 10;
            this.cbThang.Size = new System.Drawing.Size(57, 30);
            this.cbThang.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(164, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 24);
            this.label2.TabIndex = 100;
            this.label2.Text = "BÁO CÁO ĐÓNG/MỞ SỔ THÁNG";
            // 
            // cbNam
            // 
            this.cbNam.BackColor = System.Drawing.Color.Transparent;
            this.cbNam.BaseColor = System.Drawing.Color.White;
            this.cbNam.BorderColor = System.Drawing.Color.Teal;
            this.cbNam.BorderSize = 1;
            this.cbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNam.FocusedColor = System.Drawing.Color.Empty;
            this.cbNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.ForeColor = System.Drawing.Color.Black;
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2021"});
            this.cbNam.Location = new System.Drawing.Point(364, 90);
            this.cbNam.Name = "cbNam";
            this.cbNam.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbNam.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbNam.Radius = 10;
            this.cbNam.Size = new System.Drawing.Size(93, 30);
            this.cbNam.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 117;
            this.label1.Text = "Loại tiết kiệm:";
            // 
            // cbLoaiTietKiem
            // 
            this.cbLoaiTietKiem.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiTietKiem.BaseColor = System.Drawing.Color.White;
            this.cbLoaiTietKiem.BorderColor = System.Drawing.Color.Teal;
            this.cbLoaiTietKiem.BorderSize = 1;
            this.cbLoaiTietKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiTietKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiTietKiem.FocusedColor = System.Drawing.Color.Empty;
            this.cbLoaiTietKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiTietKiem.ForeColor = System.Drawing.Color.Black;
            this.cbLoaiTietKiem.FormattingEnabled = true;
            this.cbLoaiTietKiem.Location = new System.Drawing.Point(298, 142);
            this.cbLoaiTietKiem.Name = "cbLoaiTietKiem";
            this.cbLoaiTietKiem.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbLoaiTietKiem.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbLoaiTietKiem.Radius = 10;
            this.cbLoaiTietKiem.Size = new System.Drawing.Size(159, 30);
            this.cbLoaiTietKiem.TabIndex = 116;
            // 
            // FormBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(675, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLoaiTietKiem);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.lbChenhLech);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbSoDong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSoMo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvBaoCaoThang);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.label2);
            this.Name = "FormBaoCaoThang";
            this.Text = "FormBaoCaoThang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lbChenhLech;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaLabel lbSoDong;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaLabel lbSoMo;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDataGridView dgvBaoCaoThang;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton btnTraCuu;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaComboBox cbThang;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cbNam;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cbLoaiTietKiem;
    }
}