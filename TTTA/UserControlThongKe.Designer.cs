namespace TTTA
{
    partial class UserControlThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlThongKe));
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_HocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateHS = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteHS = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_Diem = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SoLuongHV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon_HocVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_LoadNV = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btn_SaveNV = new DevExpress.XtraBars.BarSubItem();
            this.btn_NewNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateNV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LoadGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_SaveGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_NewGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UpdateGV = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DeleteGV = new DevExpress.XtraBars.BarButtonItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_HocPhi);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Contact";
            // 
            // btn_HocPhi
            // 
            this.btn_HocPhi.Caption = "Học phí của từng cơ sở";
            this.btn_HocPhi.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_HocPhi.Glyph")));
            this.btn_HocPhi.Id = 12;
            this.btn_HocPhi.Name = "btn_HocPhi";
            this.btn_HocPhi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_HocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_HocPhi_ItemClick);
            // 
            // btn_UpdateHS
            // 
            this.btn_UpdateHS.Caption = "Update";
            this.btn_UpdateHS.Glyph = global::TTTA.Properties.Resources.pictureshapeoutlinecolor_32x32;
            this.btn_UpdateHS.Id = 13;
            this.btn_UpdateHS.Name = "btn_UpdateHS";
            this.btn_UpdateHS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_DeleteHS
            // 
            this.btn_DeleteHS.Caption = "Delete";
            this.btn_DeleteHS.Glyph = global::TTTA.Properties.Resources.deletegroupfooter_32x32;
            this.btn_DeleteHS.Id = 14;
            this.btn_DeleteHS.Name = "btn_DeleteHS";
            this.btn_DeleteHS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Glyph = global::TTTA.Properties.Resources.loadfrom_32x32;
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Diem);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_SoLuongHV);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Data";
            // 
            // btn_Diem
            // 
            this.btn_Diem.Caption = "Điểm";
            this.btn_Diem.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Diem.Glyph")));
            this.btn_Diem.Id = 10;
            this.btn_Diem.Name = "btn_Diem";
            this.btn_Diem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Diem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Diem_ItemClick);
            // 
            // btn_SoLuongHV
            // 
            this.btn_SoLuongHV.Caption = "Số lượng học viên của từng cơ sở";
            this.btn_SoLuongHV.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_SoLuongHV.Glyph")));
            this.btn_SoLuongHV.Id = 11;
            this.btn_SoLuongHV.Name = "btn_SoLuongHV";
            this.btn_SoLuongHV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_SoLuongHV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_SoLuongHV_ItemClick);
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
            this.btn_Diem,
            this.btn_SoLuongHV,
            this.btn_HocPhi,
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 178);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Maroon};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(905, 373);
            this.chart1.TabIndex = 2;
            // 
            // UserControlThongKe
            // 
            this.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ribbon);
            this.Name = "UserControlThongKe";
            this.Size = new System.Drawing.Size(926, 554);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_HocPhi;
        private DevExpress.XtraBars.BarButtonItem btn_UpdateHS;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteHS;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_Diem;
        private DevExpress.XtraBars.BarButtonItem btn_SoLuongHV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbon_HocVien;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem btn_LoadNV;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem btn_SaveNV;
        private DevExpress.XtraBars.BarButtonItem btn_NewNV;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteNV;
        private DevExpress.XtraBars.BarButtonItem btn_UpdateNV;
        private DevExpress.XtraBars.BarButtonItem btn_LoadGV;
        private DevExpress.XtraBars.BarButtonItem btn_SaveGV;
        private DevExpress.XtraBars.BarButtonItem btn_NewGV;
        private DevExpress.XtraBars.BarButtonItem btn_UpdateGV;
        private DevExpress.XtraBars.BarButtonItem btn_DeleteGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
