
namespace QuanLySoTietKiem
{
    partial class FormBaoCao
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
            this.containerBaoCao = new Guna.UI.WinForms.GunaPanel();
            this.pnControlTabCon = new System.Windows.Forms.Panel();
            this.btnBaoCaoThang = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBaoCaoNgay = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnControlTabCon.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerBaoCao
            // 
            this.containerBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerBaoCao.Location = new System.Drawing.Point(0, 37);
            this.containerBaoCao.Name = "containerBaoCao";
            this.containerBaoCao.Size = new System.Drawing.Size(691, 524);
            this.containerBaoCao.TabIndex = 73;
            this.containerBaoCao.Paint += new System.Windows.Forms.PaintEventHandler(this.containerBaoCao_Paint);
            // 
            // pnControlTabCon
            // 
            this.pnControlTabCon.BackColor = System.Drawing.Color.Linen;
            this.pnControlTabCon.Controls.Add(this.btnBaoCaoThang);
            this.pnControlTabCon.Controls.Add(this.btnBaoCaoNgay);
            this.pnControlTabCon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControlTabCon.Location = new System.Drawing.Point(0, 0);
            this.pnControlTabCon.Name = "pnControlTabCon";
            this.pnControlTabCon.Size = new System.Drawing.Size(691, 37);
            this.pnControlTabCon.TabIndex = 72;
            // 
            // btnBaoCaoThang
            // 
            this.btnBaoCaoThang.Animated = true;
            this.btnBaoCaoThang.AnimationHoverSpeed = 0.07F;
            this.btnBaoCaoThang.AnimationSpeed = 0.03F;
            this.btnBaoCaoThang.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoCaoThang.BaseColor = System.Drawing.Color.Transparent;
            this.btnBaoCaoThang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnBaoCaoThang.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnBaoCaoThang.CheckedBaseColor = System.Drawing.Color.White;
            this.btnBaoCaoThang.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBaoCaoThang.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnBaoCaoThang.CheckedImage = null;
            this.btnBaoCaoThang.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnBaoCaoThang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBaoCaoThang.FocusedColor = System.Drawing.Color.Empty;
            this.btnBaoCaoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoThang.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBaoCaoThang.Image = null;
            this.btnBaoCaoThang.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBaoCaoThang.LineBottom = 3;
            this.btnBaoCaoThang.LineColor = System.Drawing.Color.White;
            this.btnBaoCaoThang.Location = new System.Drawing.Point(182, 5);
            this.btnBaoCaoThang.Name = "btnBaoCaoThang";
            this.btnBaoCaoThang.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnBaoCaoThang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBaoCaoThang.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnBaoCaoThang.OnHoverImage = null;
            this.btnBaoCaoThang.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(87)))), ((int)(((byte)(124)))));
            this.btnBaoCaoThang.OnPressedColor = System.Drawing.Color.Black;
            this.btnBaoCaoThang.OnPressedDepth = 0;
            this.btnBaoCaoThang.Size = new System.Drawing.Size(174, 28);
            this.btnBaoCaoThang.TabIndex = 1;
            this.btnBaoCaoThang.Text = "Báo Cáo Tháng";
            this.btnBaoCaoThang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBaoCaoThang.Click += new System.EventHandler(this.btnBaoCaoThang_Click);
            // 
            // btnBaoCaoNgay
            // 
            this.btnBaoCaoNgay.Animated = true;
            this.btnBaoCaoNgay.AnimationHoverSpeed = 0.07F;
            this.btnBaoCaoNgay.AnimationSpeed = 0.03F;
            this.btnBaoCaoNgay.BackColor = System.Drawing.Color.Transparent;
            this.btnBaoCaoNgay.BaseColor = System.Drawing.Color.Transparent;
            this.btnBaoCaoNgay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnBaoCaoNgay.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnBaoCaoNgay.Checked = true;
            this.btnBaoCaoNgay.CheckedBaseColor = System.Drawing.Color.White;
            this.btnBaoCaoNgay.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBaoCaoNgay.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnBaoCaoNgay.CheckedImage = null;
            this.btnBaoCaoNgay.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnBaoCaoNgay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBaoCaoNgay.FocusedColor = System.Drawing.Color.Empty;
            this.btnBaoCaoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoNgay.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBaoCaoNgay.Image = null;
            this.btnBaoCaoNgay.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBaoCaoNgay.LineBottom = 3;
            this.btnBaoCaoNgay.LineColor = System.Drawing.Color.White;
            this.btnBaoCaoNgay.Location = new System.Drawing.Point(7, 5);
            this.btnBaoCaoNgay.Name = "btnBaoCaoNgay";
            this.btnBaoCaoNgay.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnBaoCaoNgay.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBaoCaoNgay.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.btnBaoCaoNgay.OnHoverImage = null;
            this.btnBaoCaoNgay.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(87)))), ((int)(((byte)(124)))));
            this.btnBaoCaoNgay.OnPressedColor = System.Drawing.Color.Black;
            this.btnBaoCaoNgay.OnPressedDepth = 0;
            this.btnBaoCaoNgay.Size = new System.Drawing.Size(174, 28);
            this.btnBaoCaoNgay.TabIndex = 0;
            this.btnBaoCaoNgay.Text = "Báo Cáo Ngày";
            this.btnBaoCaoNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBaoCaoNgay.Click += new System.EventHandler(this.btnBaoCaoNgay_Click);
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 561);
            this.Controls.Add(this.containerBaoCao);
            this.Controls.Add(this.pnControlTabCon);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.pnControlTabCon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel containerBaoCao;
        private System.Windows.Forms.Panel pnControlTabCon;
        private Guna.UI.WinForms.GunaAdvenceButton btnBaoCaoThang;
        private Guna.UI.WinForms.GunaAdvenceButton btnBaoCaoNgay;
    }
}