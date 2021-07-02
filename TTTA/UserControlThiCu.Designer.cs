namespace TTTA
{
    partial class UserControlThiCu
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
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation2 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            this.grid_ThiCu = new System.Windows.Forms.DataGridView();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_New = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateTC = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteTC = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_LoadTC = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SaveTC = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon_HocVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btn_DeleteGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NewGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SaveGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LoadGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NewNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SaveNV = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btn_LoadNV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.MADOTTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ThiCu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_ThiCu
            // 
            this.grid_ThiCu.AllowUserToAddRows = false;
            this.grid_ThiCu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_ThiCu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_ThiCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ThiCu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADOTTHI,
            this.LOP,
            this.NGAYTHI,
            this.GIOTHI});
            this.grid_ThiCu.Location = new System.Drawing.Point(5, 179);
            this.grid_ThiCu.Name = "grid_ThiCu";
            this.grid_ThiCu.RowTemplate.Height = 24;
            this.grid_ThiCu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ThiCu.Size = new System.Drawing.Size(908, 374);
            this.grid_ThiCu.TabIndex = 14;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_New);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_UpdateTC);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_DeleteTC);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Contact";
            // 
            // btn_New
            // 
            this.btn_New.Caption = "New";
            this.btn_New.Glyph = global::TTTA.Properties.Resources.addgroupfooter_32x32;
            this.btn_New.Id = 12;
            this.btn_New.Name = "btn_New";
            this.btn_New.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_New_ItemClick);
            // 
            // btn_UpdateTC
            // 
            this.btn_UpdateTC.Caption = "Update";
            this.btn_UpdateTC.Glyph = global::TTTA.Properties.Resources.pictureshapeoutlinecolor_32x32;
            this.btn_UpdateTC.Id = 13;
            this.btn_UpdateTC.Name = "btn_UpdateTC";
            this.btn_UpdateTC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_UpdateTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_UpdateTC_ItemClick);
            // 
            // btn_DeleteTC
            // 
            this.btn_DeleteTC.Caption = "Delete";
            this.btn_DeleteTC.Glyph = global::TTTA.Properties.Resources.deletegroupfooter_32x32;
            this.btn_DeleteTC.Id = 14;
            this.btn_DeleteTC.Name = "btn_DeleteTC";
            this.btn_DeleteTC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DeleteTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DeleteTC_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Glyph = global::TTTA.Properties.Resources.loadfrom_32x32;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_LoadTC);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_SaveTC);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Data";
            // 
            // btn_LoadTC
            // 
            this.btn_LoadTC.Caption = "Load";
            this.btn_LoadTC.Glyph = global::TTTA.Properties.Resources.loadfrom_32x32;
            this.btn_LoadTC.Id = 10;
            this.btn_LoadTC.Name = "btn_LoadTC";
            this.btn_LoadTC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_LoadTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LoadTC_ItemClick);
            // 
            // btn_SaveTC
            // 
            this.btn_SaveTC.Caption = "Save";
            this.btn_SaveTC.Glyph = global::TTTA.Properties.Resources.saveto_32x32;
            this.btn_SaveTC.Id = 11;
            this.btn_SaveTC.Name = "btn_SaveTC";
            this.btn_SaveTC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_SaveTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_SaveTC_ItemClick);
            // 
            // ribbon_HocVien
            // 
            this.ribbon_HocVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup5});
            this.ribbon_HocVien.Name = "ribbon_HocVien";
            reduceOperation2.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation2.Group = null;
            reduceOperation2.ItemLinkIndex = 0;
            reduceOperation2.ItemLinksCount = 0;
            reduceOperation2.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery;
            this.ribbon_HocVien.ReduceOperations.Add(reduceOperation2);
            this.ribbon_HocVien.Text = "Home";
            // 
            // btn_DeleteGV
            // 
            this.btn_DeleteGV.Caption = "Delete";
            this.btn_DeleteGV.Glyph = global::TTTA.Properties.Resources.deletegroupfooter_32x32;
            this.btn_DeleteGV.Id = 19;
            this.btn_DeleteGV.Name = "btn_DeleteGV";
            this.btn_DeleteGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_UpdateGV
            // 
            this.btn_UpdateGV.Caption = "Update";
            this.btn_UpdateGV.Glyph = global::TTTA.Properties.Resources.pictureshapeoutlinecolor_32x32;
            this.btn_UpdateGV.Id = 18;
            this.btn_UpdateGV.Name = "btn_UpdateGV";
            this.btn_UpdateGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_NewGV
            // 
            this.btn_NewGV.Caption = "New";
            this.btn_NewGV.Glyph = global::TTTA.Properties.Resources.addgroupfooter_32x32;
            this.btn_NewGV.Id = 17;
            this.btn_NewGV.Name = "btn_NewGV";
            this.btn_NewGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_SaveGV
            // 
            this.btn_SaveGV.Caption = "Save";
            this.btn_SaveGV.Glyph = global::TTTA.Properties.Resources.saveto_32x32;
            this.btn_SaveGV.Id = 16;
            this.btn_SaveGV.Name = "btn_SaveGV";
            this.btn_SaveGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_LoadGV
            // 
            this.btn_LoadGV.Caption = "Load";
            this.btn_LoadGV.Glyph = global::TTTA.Properties.Resources.loadfrom_32x32;
            this.btn_LoadGV.Id = 15;
            this.btn_LoadGV.Name = "btn_LoadGV";
            this.btn_LoadGV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_UpdateNV
            // 
            this.btn_UpdateNV.Caption = "Update";
            this.btn_UpdateNV.Glyph = global::TTTA.Properties.Resources.pictureshapeoutlinecolor_32x32;
            this.btn_UpdateNV.Id = 9;
            this.btn_UpdateNV.Name = "btn_UpdateNV";
            this.btn_UpdateNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_DeleteNV
            // 
            this.btn_DeleteNV.Caption = "Delete";
            this.btn_DeleteNV.Glyph = global::TTTA.Properties.Resources.deletegroupfooter_32x32;
            this.btn_DeleteNV.Id = 8;
            this.btn_DeleteNV.Name = "btn_DeleteNV";
            this.btn_DeleteNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_NewNV
            // 
            this.btn_NewNV.Caption = "New";
            this.btn_NewNV.Glyph = global::TTTA.Properties.Resources.addgroupfooter_32x32;
            this.btn_NewNV.Id = 7;
            this.btn_NewNV.Name = "btn_NewNV";
            this.btn_NewNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_SaveNV
            // 
            this.btn_SaveNV.Caption = "Save";
            this.btn_SaveNV.Glyph = global::TTTA.Properties.Resources.saveto_32x32;
            this.btn_SaveNV.Id = 4;
            this.btn_SaveNV.Name = "btn_SaveNV";
            this.btn_SaveNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 3;
            this.barSubItem1.Name = "barSubItem1";
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
            this.btn_LoadTC,
            this.btn_SaveTC,
            this.btn_New,
            this.btn_UpdateTC,
            this.btn_DeleteTC,
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
            // MADOTTHI
            // 
            this.MADOTTHI.DataPropertyName = "MADOTTHI";
            this.MADOTTHI.HeaderText = "Mã Đợt Thi";
            this.MADOTTHI.Name = "MADOTTHI";
            // 
            // LOP
            // 
            this.LOP.DataPropertyName = "TENLOP";
            this.LOP.HeaderText = "Lớp";
            this.LOP.Name = "LOP";
            // 
            // NGAYTHI
            // 
            this.NGAYTHI.DataPropertyName = "NGAYTHI";
            this.NGAYTHI.HeaderText = "Ngày Thi";
            this.NGAYTHI.Name = "NGAYTHI";
            // 
            // GIOTHI
            // 
            this.GIOTHI.DataPropertyName = "GIOTHI";
            this.GIOTHI.HeaderText = "Giờ Thi";
            this.GIOTHI.Name = "GIOTHI";
            // 
            // UserControlThiCu
            // 
            this.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid_ThiCu);
            this.Controls.Add(this.ribbon);
            this.Name = "UserControlThiCu";
            this.Size = new System.Drawing.Size(926, 554);
            this.Load += new System.EventHandler(this.UserControlThiCu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ThiCu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_ThiCu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_New;
        private DevExpress.XtraBars.BarButtonItem btn_UpdateTC;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteTC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_LoadTC;
        private DevExpress.XtraBars.BarButtonItem btn_SaveTC;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_HocVien;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteGV;
        private DevExpress.XtraBars.BarButtonItem btn_UpdateGV;
        private DevExpress.XtraBars.BarButtonItem btn_NewGV;
        private DevExpress.XtraBars.BarButtonItem btn_SaveGV;
        private DevExpress.XtraBars.BarButtonItem btn_LoadGV;
        private DevExpress.XtraBars.BarButtonItem btn_UpdateNV;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteNV;
        private DevExpress.XtraBars.BarButtonItem btn_NewNV;
        private DevExpress.XtraBars.BarSubItem btn_SaveNV;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btn_LoadNV;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADOTTHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOTHI;
    }
}
