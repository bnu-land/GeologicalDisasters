using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

using GISHandler;


namespace GeologicalDisasters
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public Modules.ucFileNavPanel ucFileNavPanel = null;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        #region //GIS Map Tools

        private void btn_OpenMapFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;    //单选
            ofd.Title = "选择地图文件";
            ofd.Filter = "mxd文件|*.mxd";
            ofd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo fi = new FileInfo(ofd.FileName);
                if (fi.Exists)
                {
                    this.axMapControl1.LoadMxFile(fi.FullName);
                    this.axMapControl1.ActiveView.Refresh();
                }
            }
        }

        private void btn_MapPointValuel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btn_ExportMapPic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.ExportImage(this.axMapControl1.ActiveView);
        }

        private void btn_AddMapLayer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.AddData(this.axMapControl1);
        }

        private void btn_Pan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.Pan(this.axMapControl1);
        }

        private void btn_ZoomIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.ZoomIn(axMapControl1);
        }

        private void btn_ZoomOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.ZoomOut(axMapControl1);
        }

        private void btn_ScaleIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.ZoomInFix(axMapControl1);
        }

        private void btn_ScaleOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.ZoomOutFix(axMapControl1);
        }

        private void btn_MapMeasureLength_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.MeasureLength(this.axMapControl1);
        }

        private void btn_MapMeasureArea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_MapIdentifyInfo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.IdentifyTool(this.axMapControl1);
        }

        #endregion

        #region //设置与帮助
        private void btn_Settings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btn_HelpDocument_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_About_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion 

    }
}
