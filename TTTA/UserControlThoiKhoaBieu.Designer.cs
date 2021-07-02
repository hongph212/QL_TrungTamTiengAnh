namespace TTTA
{
    partial class UserControlThoiKhoaBieu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_LoadNV = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btn_SaveNV = new DevExpress.XtraBars.BarSubItem();
            this.btn_NewNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LoadHV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SaveHV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NewHV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateHV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteHV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LoadGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SaveGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NewGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteGV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon_HocVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grid_GiaoVien = new System.Windows.Forms.DataGridView();
            this.MAPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHOAHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MADOTTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_GiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.Maroon;
            this.ribbon.ExpandCollapseItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_LoadNV,
            this.barSubItem1,
            this.btn_SaveNV,
            this.btn_NewNV,
            this.btn_DeleteNV,
            this.btn_UpdateNV,
            this.btn_LoadHV,
            this.btn_SaveHV,
            this.btn_NewHV,
            this.btn_UpdateHV,
            this.btn_DeleteHV,
            this.btn_LoadGV,
            this.btn_SaveGV,
            this.btn_NewGV,
            this.btn_UpdateGV,
            this.btn_DeleteGV});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbon_HocVien});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(926, 153);
            this.ribbon.Toolbar.ItemLinks.Add(this.barSubItem1);
            // 
            // btn_LoadNV
            // 
            this.btn_LoadNV.Caption = "Load";
            this.btn_LoadNV.Glyph = global::TTTA.Properties.Resources.loadfrom_32x32;
            this.btn_LoadNV.Id = 2;
            this.btn_LoadNV.ItemAppearance.Disabled.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadNV.ItemAppearance.Disabled.Options.UseFont = true;
            this.btn_LoadNV.Name = "btn_LoadNV";
            this.btn_LoadNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 3;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btn_SaveNV
            // 
            this.btn_SaveNV.Caption = "Save";
            this.btn_SaveNV.Glyph = global::TTTA.Properties.Resources.saveto_32x32;
            this.btn_SaveNV.Id = 4;
            this.btn_SaveNV.Name = "btn_SaveNV";
            this.btn_SaveNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_NewNV
            // 
            this.btn_NewNV.Caption = "New";
            this.btn_NewNV.Glyph = global::TTTA.Properties.Resources.addgroupfooter_32x32;
            this.btn_NewNV.Id = 7;
            this.btn_NewNV.Name = "btn_NewNV";
            this.btn_NewNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_DeleteNV
            // 
            this.btn_DeleteNV.Caption = "Delete";
            this.btn_DeleteNV.Glyph = global::TTTA.Properties.Resources.deletegroupfooter_32x32;
            this.btn_DeleteNV.Id = 8;
            this.btn_DeleteNV.Name = "btn_DeleteNV";
            this.btn_DeleteNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_UpdateNV
            // 
            this.btn_UpdateNV.Caption = "Update";
            this.btn_UpdateNV.Glyph = global::TTTA.Properties.Resources.pictureshapeoutlinecolor_32x32;
            this.btn_UpdateNV.Id = 9;
            this.btn_UpdateNV.Name = "btn_UpdateNV";
            this.btn_UpdateNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_LoadHV
            // 
            this.btn_LoadHV.Caption = "Load";
            this.btn_LoadHV.Glyph = global::TTTA.Properties.Resources.loadfrom_32x32;
            this.btn_LoadHV.Id = 10;
            this.btn_LoadHV.Name = "btn_LoadHV";
            this.btn_LoadHV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_LoadHV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LoadGV_ItemClick);
            // 
            // btn_SaveHV
            // 
            this.btn_SaveHV.Caption = "Save";
            this.btn_SaveHV.Glyph = global::TTTA.Properties.Resources.saveto_32x32;
            this.btn_SaveHV.Id = 11;
            this.btn_SaveHV.Name = "btn_SaveHV";
            this.btn_SaveHV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_SaveHV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_SaveGV_ItemClick);
            // 
            // btn_NewHV
            // 
            this.btn_NewHV.Caption = "New";
            this.btn_NewHV.Glyph = global::TTTA.Properties.Resources.addgroupfooter_32x32;
            this.btn_NewHV.Id = 12;
            this.btn_NewHV.Name = "btn_NewHV";
            this.btn_NewHV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_NewHV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NewGV_ItemClick);
            // 
            // btn_UpdateHV
            // 
            this.btn_UpdateHV.Caption = "Update";
            this.btn_UpdateHV.Glyph = global::TTTA.Properties.Resources.pictureshapeoutlinecolor_32x32;
            this.btn_UpdateHV.Id = 13;
            this.btn_UpdateHV.Name = "btn_UpdateHV";
            this.btn_UpdateHV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_UpdateHV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_UpdateGV_ItemClick);
            // 
            // btn_DeleteHV
            // 
            this.btn_DeleteHV.Caption = "Delete";
            this.btn_DeleteHV.Glyph = global::TTTA.Properties.Resources.deletegroupfooter_32x32;
            this.btn_DeleteHV.Id = 14;
            this.btn_DeleteHV.Name = "btn_DeleteHV";
            this.btn_DeleteHV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DeleteHV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DeleteGV_ItemClick);
            // 
            // btn_LoadGV
            // 
            this.btn_LoadGV.Caption = "Load";
            this.btn_LoadGV.Glyph = global::TTTA.Properties.Resources.loadfrom_32x32;
            this.btn_LoadGV.Id = 15;
            this.btn_LoadGV.Name = "btn_LoadGV";
            this.btn_LoadGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_SaveGV
            // 
            this.btn_SaveGV.Caption = "Save";
            this.btn_SaveGV.Glyph = global::TTTA.Properties.Resources.saveto_32x32;
            this.btn_SaveGV.Id = 16;
            this.btn_SaveGV.Name = "btn_SaveGV";
            this.btn_SaveGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_NewGV
            // 
            this.btn_NewGV.Caption = "New";
            this.btn_NewGV.Glyph = global::TTTA.Properties.Resources.addgroupfooter_32x32;
            this.btn_NewGV.Id = 17;
            this.btn_NewGV.Name = "btn_NewGV";
            this.btn_NewGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_UpdateGV
            // 
            this.btn_UpdateGV.Caption = "Update";
            this.btn_UpdateGV.Glyph = global::TTTA.Properties.Resources.pictureshapeoutlinecolor_32x32;
            this.btn_UpdateGV.Id = 18;
            this.btn_UpdateGV.Name = "btn_UpdateGV";
            this.btn_UpdateGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_DeleteGV
            // 
            this.btn_DeleteGV.Caption = "Delete";
            this.btn_DeleteGV.Glyph = global::TTTA.Properties.Resources.deletegroupfooter_32x32;
            this.btn_DeleteGV.Id = 19;
            this.btn_DeleteGV.Name = "btn_DeleteGV";
            this.btn_DeleteGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbon_HocVien
            // 
            this.ribbon_HocVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup5});
            this.ribbon_HocVien.Name = "ribbon_HocVien";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation1.Group = null;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery;
            this.ribbon_HocVien.ReduceOperations.Add(reduceOperation1);
            this.ribbon_HocVien.Text = "Home";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Glyph = global::TTTA.Properties.Resources.loadfrom_32x32;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_LoadHV);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_SaveHV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Data";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_NewHV);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_UpdateHV);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_DeleteHV);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Contact";
            // 
            // grid_GiaoVien
            // 
            this.grid_GiaoVien.AllowUserToAddRows = false;
            this.grid_GiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_GiaoVien.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_GiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_GiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPC,
            this.TENGV,
            this.LOP,
            this.KHOAHOC,
            this.MADOTTHI});
            this.grid_GiaoVien.Location = new System.Drawing.Point(6, 177);
            this.grid_GiaoVien.Name = "grid_GiaoVien";
            this.grid_GiaoVien.RowTemplate.Height = 24;
            this.grid_GiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_GiaoVien.Size = new System.Drawing.Size(908, 374);
            this.grid_GiaoVien.TabIndex = 15;
            // 
            // MAPC
            // 
            this.MAPC.DataPropertyName = "MAPC";
            this.MAPC.HeaderText = "Mã PC";
            this.MAPC.Name = "MAPC";
            // 
            // TENGV
            // 
            this.TENGV.DataPropertyName = "TENGV";
            this.TENGV.HeaderText = "Giáo Viên";
            this.TENGV.Name = "TENGV";
            // 
            // LOP
            // 
            this.LOP.DataPropertyName = "TENLOP";
            this.LOP.HeaderText = "Dạy Lớp";
            this.LOP.Name = "LOP";
            // 
            // KHOAHOC
            // 
            this.KHOAHOC.DataPropertyName = "KHOAHOC";
            this.KHOAHOC.HeaderText = "Khoá Học";
            this.KHOAHOC.Name = "KHOAHOC";
            // 
            // MADOTTHI
            // 
            this.MADOTTHI.DataPropertyName = "MADOTTHI";
            this.MADOTTHI.HeaderText = "Đợt Thi";
            this.MADOTTHI.Name = "MADOTTHI";
            // 
            // UserControlThoiKhoaBieu
            // 
            this.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid_GiaoVien);
            this.Controls.Add(this.ribbon);
            this.Name = "UserControlThoiKhoaBieu";
            this.Size = new System.Drawing.Size(926, 554);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_GiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btn_LoadNV;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem btn_SaveNV;
        private DevExpress.XtraBars.BarButtonItem btn_NewNV;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteNV;
        private DevExpress.XtraBars.BarButtonItem btn_UpdateNV;
        private DevExpress.XtraBars.BarButtonItem btn_LoadHV;
        private DevExpress.XtraBars.BarButtonItem btn_SaveHV;
        private DevExpress.XtraBars.BarButtonItem btn_NewHV;
        private DevExpress.XtraBars.BarButtonItem btn_UpdateHV;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteHV;
        private DevExpress.XtraBars.BarButtonItem btn_LoadGV;
        private DevExpress.XtraBars.BarButtonItem btn_SaveGV;
        private DevExpress.XtraBars.BarButtonItem btn_NewGV;
        private DevExpress.XtraBars.BarButtonItem btn_UpdateGV;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteGV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_HocVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private System.Windows.Forms.DataGridView grid_GiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHOAHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADOTTHI;
    }
}
