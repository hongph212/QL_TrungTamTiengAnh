namespace TTTA
{
    partial class UserControlDiem
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_LoadNV = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btn_SaveNV = new DevExpress.XtraBars.BarSubItem();
            this.btn_NewNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LoadHS = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SaveHS = new DevExpress.XtraBars.BarButtonItem();
            this.btn_New = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateHS = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteHS = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LoadGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SaveGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NewGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteGV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon_HocVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grid_HoSo = new System.Windows.Forms.DataGridView();
            this.MAHOSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBDIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XEPLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_Diem = new System.Windows.Forms.DataGridView();
            this.MAPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripDiem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_HoSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Diem)).BeginInit();
            this.contextMenuStripDiem.SuspendLayout();
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
            this.btn_LoadHS,
            this.btn_SaveHS,
            this.btn_New,
            this.btn_UpdateHS,
            this.btn_DeleteHS,
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
            // btn_LoadHS
            // 
            this.btn_LoadHS.Caption = "Load";
            this.btn_LoadHS.Glyph = global::TTTA.Properties.Resources.loadfrom_32x32;
            this.btn_LoadHS.Id = 10;
            this.btn_LoadHS.Name = "btn_LoadHS";
            this.btn_LoadHS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_LoadHS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LoadHV_ItemClick);
            // 
            // btn_SaveHS
            // 
            this.btn_SaveHS.Caption = "Save";
            this.btn_SaveHS.Glyph = global::TTTA.Properties.Resources.saveto_32x32;
            this.btn_SaveHS.Id = 11;
            this.btn_SaveHS.Name = "btn_SaveHS";
            this.btn_SaveHS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_SaveHS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_SaveHV_ItemClick);
            // 
            // btn_New
            // 
            this.btn_New.Caption = "New";
            this.btn_New.Glyph = global::TTTA.Properties.Resources.addgroupfooter_32x32;
            this.btn_New.Id = 12;
            this.btn_New.Name = "btn_New";
            this.btn_New.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_NewHV_ItemClick_1);
            // 
            // btn_UpdateHS
            // 
            this.btn_UpdateHS.Caption = "Update";
            this.btn_UpdateHS.Glyph = global::TTTA.Properties.Resources.pictureshapeoutlinecolor_32x32;
            this.btn_UpdateHS.Id = 13;
            this.btn_UpdateHS.Name = "btn_UpdateHS";
            this.btn_UpdateHS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_UpdateHS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_UpdateHV_ItemClick);
            // 
            // btn_DeleteHS
            // 
            this.btn_DeleteHS.Caption = "Delete";
            this.btn_DeleteHS.Glyph = global::TTTA.Properties.Resources.deletegroupfooter_32x32;
            this.btn_DeleteHS.Id = 14;
            this.btn_DeleteHS.Name = "btn_DeleteHS";
            this.btn_DeleteHS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DeleteHS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DeleteHV_ItemClick);
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
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_LoadHS);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_SaveHS);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Data";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_New);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_UpdateHS);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_DeleteHS);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Contact";
            // 
            // grid_HoSo
            // 
            this.grid_HoSo.AllowUserToAddRows = false;
            this.grid_HoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_HoSo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_HoSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_HoSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHOSO,
            this.HOTEN,
            this.LOP,
            this.TBDIEM,
            this.XEPLOAI});
            this.grid_HoSo.Location = new System.Drawing.Point(5, 180);
            this.grid_HoSo.Name = "grid_HoSo";
            this.grid_HoSo.RowTemplate.Height = 24;
            this.grid_HoSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_HoSo.Size = new System.Drawing.Size(908, 175);
            this.grid_HoSo.TabIndex = 16;
            this.grid_HoSo.SelectionChanged += new System.EventHandler(this.grid_HoSo_SelectionChanged);
            // 
            // MAHOSO
            // 
            this.MAHOSO.DataPropertyName = "MAHOSO";
            this.MAHOSO.HeaderText = "Mã HS";
            this.MAHOSO.Name = "MAHOSO";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.Name = "HOTEN";
            // 
            // LOP
            // 
            this.LOP.DataPropertyName = "TENLOP";
            this.LOP.HeaderText = "Lớp";
            this.LOP.Name = "LOP";
            // 
            // TBDIEM
            // 
            this.TBDIEM.DataPropertyName = "TBDIEM";
            this.TBDIEM.HeaderText = "Điểm TB";
            this.TBDIEM.Name = "TBDIEM";
            // 
            // XEPLOAI
            // 
            this.XEPLOAI.DataPropertyName = "XEPLOAI";
            this.XEPLOAI.HeaderText = "Xếp Loại";
            this.XEPLOAI.Name = "XEPLOAI";
            // 
            // grid_Diem
            // 
            this.grid_Diem.AllowUserToAddRows = false;
            this.grid_Diem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Diem.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid_Diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Diem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPC,
            this.LAN,
            this.DIEM});
            this.grid_Diem.ContextMenuStrip = this.contextMenuStripDiem;
            this.grid_Diem.Location = new System.Drawing.Point(5, 361);
            this.grid_Diem.Name = "grid_Diem";
            this.grid_Diem.RowTemplate.Height = 24;
            this.grid_Diem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Diem.Size = new System.Drawing.Size(908, 175);
            this.grid_Diem.TabIndex = 17;
            // 
            // MAPC
            // 
            this.MAPC.DataPropertyName = "MAPC";
            this.MAPC.HeaderText = "Mã PC";
            this.MAPC.Name = "MAPC";
            // 
            // LAN
            // 
            this.LAN.DataPropertyName = "LAN";
            this.LAN.HeaderText = "Lần";
            this.LAN.Name = "LAN";
            // 
            // DIEM
            // 
            this.DIEM.DataPropertyName = "DIEM";
            this.DIEM.HeaderText = "Điểm";
            this.DIEM.Name = "DIEM";
            // 
            // contextMenuStripDiem
            // 
            this.contextMenuStripDiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.xoáToolStripMenuItem});
            this.contextMenuStripDiem.Name = "contextMenuStripDiem";
            this.contextMenuStripDiem.Size = new System.Drawing.Size(128, 100);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.xoáToolStripMenuItem.Text = "Delete";
            this.xoáToolStripMenuItem.Click += new System.EventHandler(this.xoáToolStripMenuItem_Click);
            // 
            // UserControlDiem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid_Diem);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.grid_HoSo);
            this.Name = "UserControlDiem";
            this.Size = new System.Drawing.Size(926, 554);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_HoSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Diem)).EndInit();
            this.contextMenuStripDiem.ResumeLayout(false);
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
        private DevExpress.XtraBars.BarButtonItem btn_LoadHS;
        private DevExpress.XtraBars.BarButtonItem btn_SaveHS;
        private DevExpress.XtraBars.BarButtonItem btn_New;
        private DevExpress.XtraBars.BarButtonItem btn_UpdateHS;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteHS;
        private DevExpress.XtraBars.BarButtonItem btn_LoadGV;
        private DevExpress.XtraBars.BarButtonItem btn_SaveGV;
        private DevExpress.XtraBars.BarButtonItem btn_NewGV;
        private DevExpress.XtraBars.BarButtonItem btn_UpdateGV;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteGV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_HocVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private System.Windows.Forms.DataGridView grid_HoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHOSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBDIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn XEPLOAI;
        private System.Windows.Forms.DataGridView grid_Diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDiem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáToolStripMenuItem;
    }
}
