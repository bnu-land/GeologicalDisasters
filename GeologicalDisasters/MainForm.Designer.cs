namespace GeologicalDisasters
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Pan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.btn_ScaleIn = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ScaleOut = new DevExpress.XtraBars.BarButtonItem();
            this.buttongroup = new DevExpress.XtraBars.BarButtonGroup();
            this.btn_ZoomIn = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ZoomOut = new DevExpress.XtraBars.BarButtonItem();
            this.btn_HelpDocument = new DevExpress.XtraBars.BarButtonItem();
            this.btn_About = new DevExpress.XtraBars.BarButtonItem();
            this.btn_OpenMapFile = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AddMapLayer = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ExportMapPic = new DevExpress.XtraBars.BarButtonItem();
            this.btn_MapMeasureLength = new DevExpress.XtraBars.BarButtonItem();
            this.btn_MapMeasureArea = new DevExpress.XtraBars.BarButtonItem();
            this.btn_MapIdentifyInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Data_StatisticTables = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PublishDisasterDoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl_Left = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage_MapLayers = new DevExpress.XtraTab.XtraTabPage();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.xtraTabPage_DataNav = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl_Center = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.axPageLayoutControl1 = new ESRI.ArcGIS.Controls.AxPageLayoutControl();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_Left)).BeginInit();
            this.xtraTabControl_Left.SuspendLayout();
            this.xtraTabPage_MapLayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_Center)).BeginInit();
            this.xtraTabControl_Center.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_Pan,
            this.barButtonGroup2,
            this.btn_ScaleIn,
            this.btn_ScaleOut,
            this.buttongroup,
            this.btn_ZoomIn,
            this.btn_ZoomOut,
            this.btn_HelpDocument,
            this.btn_About,
            this.btn_OpenMapFile,
            this.btn_AddMapLayer,
            this.btn_ExportMapPic,
            this.btn_MapMeasureLength,
            this.btn_MapMeasureArea,
            this.btn_MapIdentifyInfo,
            this.btn_Data_StatisticTables,
            this.btn_PublishDisasterDoc,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 31;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(990, 147);
            // 
            // btn_Pan
            // 
            this.btn_Pan.Caption = "平移";
            this.btn_Pan.Glyph = global::GeologicalDisasters.Properties.Resources.icon_pan_32;
            this.btn_Pan.Id = 1;
            this.btn_Pan.Name = "btn_Pan";
            this.btn_Pan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Pan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Pan_ItemClick);
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Caption = "逐级缩放";
            this.barButtonGroup2.Id = 8;
            this.barButtonGroup2.ItemLinks.Add(this.btn_ScaleIn);
            this.barButtonGroup2.ItemLinks.Add(this.btn_ScaleOut);
            this.barButtonGroup2.Name = "barButtonGroup2";
            // 
            // btn_ScaleIn
            // 
            this.btn_ScaleIn.Caption = "渐大";
            this.btn_ScaleIn.Glyph = global::GeologicalDisasters.Properties.Resources.scaleIn_32;
            this.btn_ScaleIn.Id = 9;
            this.btn_ScaleIn.Name = "btn_ScaleIn";
            this.btn_ScaleIn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_ScaleIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ScaleIn_ItemClick);
            // 
            // btn_ScaleOut
            // 
            this.btn_ScaleOut.Caption = "渐小";
            this.btn_ScaleOut.Glyph = global::GeologicalDisasters.Properties.Resources.scaleOut_32;
            this.btn_ScaleOut.Id = 10;
            this.btn_ScaleOut.Name = "btn_ScaleOut";
            this.btn_ScaleOut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_ScaleOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ScaleOut_ItemClick);
            // 
            // buttongroup
            // 
            this.buttongroup.Caption = "缩放";
            this.buttongroup.Id = 13;
            this.buttongroup.ItemLinks.Add(this.btn_ZoomIn);
            this.buttongroup.ItemLinks.Add(this.btn_ZoomOut);
            this.buttongroup.Name = "buttongroup";
            // 
            // btn_ZoomIn
            // 
            this.btn_ZoomIn.Caption = "放大";
            this.btn_ZoomIn.Glyph = global::GeologicalDisasters.Properties.Resources.zoomIn_32;
            this.btn_ZoomIn.Id = 14;
            this.btn_ZoomIn.Name = "btn_ZoomIn";
            this.btn_ZoomIn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_ZoomIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ZoomIn_ItemClick);
            // 
            // btn_ZoomOut
            // 
            this.btn_ZoomOut.Caption = "缩小";
            this.btn_ZoomOut.Glyph = global::GeologicalDisasters.Properties.Resources.zoomOut_32;
            this.btn_ZoomOut.Id = 15;
            this.btn_ZoomOut.Name = "btn_ZoomOut";
            this.btn_ZoomOut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_ZoomOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ZoomOut_ItemClick);
            // 
            // btn_HelpDocument
            // 
            this.btn_HelpDocument.Caption = "帮助文档";
            this.btn_HelpDocument.Glyph = global::GeologicalDisasters.Properties.Resources.Help_64;
            this.btn_HelpDocument.Id = 17;
            this.btn_HelpDocument.Name = "btn_HelpDocument";
            this.btn_HelpDocument.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_HelpDocument.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_HelpDocument_ItemClick);
            // 
            // btn_About
            // 
            this.btn_About.Caption = "关于";
            this.btn_About.Glyph = global::GeologicalDisasters.Properties.Resources.aboutUs_64;
            this.btn_About.Id = 18;
            this.btn_About.Name = "btn_About";
            this.btn_About.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_About.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_About_ItemClick);
            // 
            // btn_OpenMapFile
            // 
            this.btn_OpenMapFile.Caption = "打开地图";
            this.btn_OpenMapFile.Glyph = global::GeologicalDisasters.Properties.Resources.openMap_64;
            this.btn_OpenMapFile.Id = 21;
            this.btn_OpenMapFile.Name = "btn_OpenMapFile";
            this.btn_OpenMapFile.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_OpenMapFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_OpenMapFile_ItemClick);
            // 
            // btn_AddMapLayer
            // 
            this.btn_AddMapLayer.Caption = "添加图层";
            this.btn_AddMapLayer.Glyph = global::GeologicalDisasters.Properties.Resources.Add_Layer;
            this.btn_AddMapLayer.Id = 22;
            this.btn_AddMapLayer.Name = "btn_AddMapLayer";
            this.btn_AddMapLayer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_AddMapLayer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddMapLayer_ItemClick);
            // 
            // btn_ExportMapPic
            // 
            this.btn_ExportMapPic.Caption = "输出地图";
            this.btn_ExportMapPic.Glyph = global::GeologicalDisasters.Properties.Resources.exportMap_64;
            this.btn_ExportMapPic.Id = 23;
            this.btn_ExportMapPic.Name = "btn_ExportMapPic";
            this.btn_ExportMapPic.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_ExportMapPic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ExportMapPic_ItemClick);
            // 
            // btn_MapMeasureLength
            // 
            this.btn_MapMeasureLength.Caption = "长度测量";
            this.btn_MapMeasureLength.Glyph = global::GeologicalDisasters.Properties.Resources.Satellite;
            this.btn_MapMeasureLength.Id = 25;
            this.btn_MapMeasureLength.Name = "btn_MapMeasureLength";
            this.btn_MapMeasureLength.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_MapMeasureLength.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MapMeasureLength_ItemClick);
            // 
            // btn_MapMeasureArea
            // 
            this.btn_MapMeasureArea.Caption = "面积测量";
            this.btn_MapMeasureArea.Glyph = global::GeologicalDisasters.Properties.Resources.today_64;
            this.btn_MapMeasureArea.Id = 26;
            this.btn_MapMeasureArea.Name = "btn_MapMeasureArea";
            this.btn_MapMeasureArea.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_MapMeasureArea.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MapMeasureArea_ItemClick);
            // 
            // btn_MapIdentifyInfo
            // 
            this.btn_MapIdentifyInfo.Caption = "属性查看";
            this.btn_MapIdentifyInfo.Glyph = global::GeologicalDisasters.Properties.Resources.Layers;
            this.btn_MapIdentifyInfo.Id = 27;
            this.btn_MapIdentifyInfo.Name = "btn_MapIdentifyInfo";
            this.btn_MapIdentifyInfo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_MapIdentifyInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_MapIdentifyInfo_ItemClick_1);
            // 
            // btn_Data_StatisticTables
            // 
            this.btn_Data_StatisticTables.Caption = "导入坐标";
            this.btn_Data_StatisticTables.Glyph = global::GeologicalDisasters.Properties.Resources.statistic;
            this.btn_Data_StatisticTables.Id = 28;
            this.btn_Data_StatisticTables.Name = "btn_Data_StatisticTables";
            this.btn_Data_StatisticTables.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_PublishDisasterDoc
            // 
            this.btn_PublishDisasterDoc.Caption = "范围分析";
            this.btn_PublishDisasterDoc.Glyph = global::GeologicalDisasters.Properties.Resources.document;
            this.btn_PublishDisasterDoc.Id = 29;
            this.btn_PublishDisasterDoc.Name = "btn_PublishDisasterDoc";
            this.btn_PublishDisasterDoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "趋势分析";
            this.barButtonItem1.Id = 30;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "地图与数据";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Pan);
            this.ribbonPageGroup1.ItemLinks.Add(this.buttongroup, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonGroup2);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_OpenMapFile, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_AddMapLayer);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_ExportMapPic);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "地图工具";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_MapMeasureLength);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_MapMeasureArea);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_MapIdentifyInfo);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "辅助工具";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_Data_StatisticTables);
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_PublishDisasterDoc);
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "分析工具";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "设置与帮助";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_HelpDocument);
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_About);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 147);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl_Left);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl_Center);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(990, 648);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl_Left
            // 
            this.xtraTabControl_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_Left.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabControl_Left.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl_Left.Name = "xtraTabControl_Left";
            this.xtraTabControl_Left.SelectedTabPage = this.xtraTabPage_MapLayers;
            this.xtraTabControl_Left.Size = new System.Drawing.Size(229, 648);
            this.xtraTabControl_Left.TabIndex = 0;
            this.xtraTabControl_Left.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage_MapLayers,
            this.xtraTabPage_DataNav});
            // 
            // xtraTabPage_MapLayers
            // 
            this.xtraTabPage_MapLayers.Controls.Add(this.axTOCControl1);
            this.xtraTabPage_MapLayers.Name = "xtraTabPage_MapLayers";
            this.xtraTabPage_MapLayers.Size = new System.Drawing.Size(223, 619);
            this.xtraTabPage_MapLayers.Text = "图层";
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(223, 619);
            this.axTOCControl1.TabIndex = 0;
            // 
            // xtraTabPage_DataNav
            // 
            this.xtraTabPage_DataNav.Name = "xtraTabPage_DataNav";
            this.xtraTabPage_DataNav.Size = new System.Drawing.Size(223, 619);
            this.xtraTabPage_DataNav.Text = "数据";
            // 
            // xtraTabControl_Center
            // 
            this.xtraTabControl_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl_Center.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabControl_Center.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl_Center.Name = "xtraTabControl_Center";
            this.xtraTabControl_Center.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl_Center.Size = new System.Drawing.Size(756, 648);
            this.xtraTabControl_Center.TabIndex = 2;
            this.xtraTabControl_Center.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.axLicenseControl1);
            this.xtraTabPage3.Controls.Add(this.axMapControl1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(750, 619);
            this.xtraTabPage3.Text = "地图";
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(231, 142);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 1;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(750, 619);
            this.axMapControl1.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.axPageLayoutControl1);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(750, 619);
            this.xtraTabPage4.Text = "制图输出";
            // 
            // axPageLayoutControl1
            // 
            this.axPageLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPageLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.axPageLayoutControl1.Name = "axPageLayoutControl1";
            this.axPageLayoutControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPageLayoutControl1.OcxState")));
            this.axPageLayoutControl1.Size = new System.Drawing.Size(750, 619);
            this.axPageLayoutControl1.TabIndex = 0;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_HelpDocument);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_About);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "帮助中心";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 795);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "减灾中心 - 积雪覆盖分析";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_Left)).EndInit();
            this.xtraTabControl_Left.ResumeLayout(false);
            this.xtraTabPage_MapLayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl_Center)).EndInit();
            this.xtraTabControl_Center.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.BarButtonItem btn_Pan;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_ScaleIn;
        private DevExpress.XtraBars.BarButtonItem btn_ScaleOut;
        private DevExpress.XtraBars.BarButtonGroup buttongroup;
        private DevExpress.XtraBars.BarButtonItem btn_ZoomIn;
        private DevExpress.XtraBars.BarButtonItem btn_ZoomOut;
        private DevExpress.XtraBars.BarButtonItem btn_HelpDocument;
        private DevExpress.XtraBars.BarButtonItem btn_About;
        private DevExpress.XtraBars.BarButtonItem btn_OpenMapFile;
        private DevExpress.XtraBars.BarButtonItem btn_AddMapLayer;
        private DevExpress.XtraBars.BarButtonItem btn_ExportMapPic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_MapMeasureLength;
        private DevExpress.XtraBars.BarButtonItem btn_MapMeasureArea;
        private DevExpress.XtraBars.BarButtonItem btn_MapIdentifyInfo;
        private DevExpress.XtraBars.BarButtonItem btn_Data_StatisticTables;
        private DevExpress.XtraBars.BarButtonItem btn_PublishDisasterDoc;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl_Left;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_MapLayers;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage_DataNav;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl_Center;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxPageLayoutControl axPageLayoutControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

