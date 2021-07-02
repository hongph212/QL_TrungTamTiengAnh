namespace TTTA
{
    partial class frm_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckDN = new System.Windows.Forms.CheckBox();
            this.cbbCN = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_TRUNGTAMTADataSet = new TTTA.QL_TRUNGTAMTADataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_NhapLai = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TTTA.WaitForm1), true, true);
            this.v_DS_PHANMANHTableAdapter = new TTTA.QL_TRUNGTAMTADataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TRUNGTAMTADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Location = new System.Drawing.Point(3, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 273);
            this.panel1.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckDN);
            this.groupBox1.Controls.Add(this.cbbCN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Pass);
            this.groupBox1.Controls.Add(this.txt_User);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(488, 243);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // ckDN
            // 
            this.ckDN.AutoSize = true;
            this.ckDN.Location = new System.Drawing.Point(183, 205);
            this.ckDN.Name = "ckDN";
            this.ckDN.Size = new System.Drawing.Size(278, 31);
            this.ckDN.TabIndex = 6;
            this.ckDN.Text = "Đăng nhập bằng máy chủ";
            this.ckDN.UseVisualStyleBackColor = true;
            this.ckDN.CheckedChanged += new System.EventHandler(this.ckDN_CheckedChanged);
            // 
            // cbbCN
            // 
            this.cbbCN.DataSource = this.vDSPHANMANHBindingSource;
            this.cbbCN.DisplayMember = "TENCN";
            this.cbbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCN.FormattingEnabled = true;
            this.cbbCN.Location = new System.Drawing.Point(183, 37);
            this.cbbCN.Name = "cbbCN";
            this.cbbCN.Size = new System.Drawing.Size(291, 34);
            this.cbbCN.TabIndex = 5;
            this.cbbCN.ValueMember = "TENSERVER";
            this.cbbCN.SelectedValueChanged += new System.EventHandler(this.cbbCN_SelectedValueChanged);
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.qL_TRUNGTAMTADataSet;
            // 
            // qL_TRUNGTAMTADataSet
            // 
            this.qL_TRUNGTAMTADataSet.DataSetName = "QL_TRUNGTAMTADataSet";
            this.qL_TRUNGTAMTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cơ sở:";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(183, 167);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(291, 34);
            this.txt_Pass.TabIndex = 3;
            this.txt_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pass_KeyDown);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(183, 102);
            this.txt_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(291, 34);
            this.txt_User.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(512, 47);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(140, 153);
            this.pictureEdit1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(646, 32);
            this.label4.TabIndex = 55;
            this.label4.Text = "PHẦN MỀM QUẢN LÝ TRUNG TÂM TIẾNG ANH";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.btn_Thoat.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.btn_Thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thoat.Appearance.Options.UseBackColor = true;
            this.btn_Thoat.Appearance.Options.UseFont = true;
            this.btn_Thoat.Appearance.Options.UseForeColor = true;
            this.btn_Thoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Image = global::TTTA.Properties.Resources.cancel_32x32;
            this.btn_Thoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(510, 342);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(163, 49);
            this.btn_Thoat.TabIndex = 58;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.btn_NhapLai.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.btn_NhapLai.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapLai.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_NhapLai.Appearance.Options.UseBackColor = true;
            this.btn_NhapLai.Appearance.Options.UseFont = true;
            this.btn_NhapLai.Appearance.Options.UseForeColor = true;
            this.btn_NhapLai.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_NhapLai.Image = global::TTTA.Properties.Resources.convert_32x32;
            this.btn_NhapLai.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_NhapLai.Location = new System.Drawing.Point(265, 342);
            this.btn_NhapLai.Margin = new System.Windows.Forms.Padding(5);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(163, 49);
            this.btn_NhapLai.TabIndex = 57;
            this.btn_NhapLai.Text = "Nhập Lại";
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.btn_DangNhap.Appearance.BackColor2 = System.Drawing.Color.Maroon;
            this.btn_DangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_DangNhap.Appearance.Options.UseBackColor = true;
            this.btn_DangNhap.Appearance.Options.UseFont = true;
            this.btn_DangNhap.Appearance.Options.UseForeColor = true;
            this.btn_DangNhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_DangNhap.Image = global::TTTA.Properties.Resources.forward_32x32;
            this.btn_DangNhap.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_DangNhap.Location = new System.Drawing.Point(20, 342);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(163, 49);
            this.btn_DangNhap.TabIndex = 56;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_NhapLai);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TRUNGTAMTADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_Thoat;
        private DevExpress.XtraEditors.SimpleButton btn_NhapLai;
        private DevExpress.XtraEditors.SimpleButton btn_DangNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbCN;
        private System.Windows.Forms.Label label1;
        private QL_TRUNGTAMTADataSet qL_TRUNGTAMTADataSet;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private QL_TRUNGTAMTADataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.CheckBox ckDN;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}