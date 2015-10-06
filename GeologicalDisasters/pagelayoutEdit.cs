using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
namespace GeologicalDisasters
{
    public partial class pagelayoutEdit : Form
    {
        AxPageLayoutControl pagelayout = null;
        IHookHelper m_hookHelper = null;
        public pagelayoutEdit(AxPageLayoutControl  page,IHookHelper helper)
        {
            this.pagelayout = page;
            this.m_hookHelper = helper;
            InitializeComponent();
        }

        private void pagelayoutEdit_Load(object sender, EventArgs e)
        {
            axToolbarControl1.SetBuddyControl(pagelayout);
            if (pagelayout == null)
                return;
            IEnumLayer layers = GetLayers();
            layers.Reset();
            ILayer layer=layers.Next();
            textEdit1.Text = layer.Name;
        }

        private void addTitle_Click(object sender, EventArgs e)
        {
            textEdit1.Enabled = true;
            simpleButton1.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
             GISHandler.GISTools.AddTextElement(pagelayout,10,25,textEdit1.Text);
             textEdit1.Enabled = false;
             this.simpleButton1.Enabled = false;
        }
        // 获取图层  
        private IEnumLayer GetLayers()
        {

            UID uid = new UIDClass();
            uid.Value = "{40A9E885-5533-11d0-98BE-00805F7CED21}";// 代表只获取矢量图层
            //问题在这个地方 解决！
            IEnumLayer layers = m_hookHelper.FocusMap.get_Layers(uid, true);


            return layers;
        }

        private void addNorthArrow_Click(object sender, EventArgs e)
        {
            GISHandler.GISTools.AddNorthArrow(pagelayout, pagelayout.ActiveView.FocusMap);
        }

        private void addScalBar_Click(object sender, EventArgs e)
        {
            GISHandler.GISTools.AddScalebar(pagelayout, pagelayout.ActiveView.FocusMap);
        }

        private void oneKey_Click(object sender, EventArgs e)
        {
            GISHandler.GISTools.AddNorthArrow(pagelayout, pagelayout.ActiveView.FocusMap);
            GISHandler.GISTools.AddScalebar(pagelayout, pagelayout.ActiveView.FocusMap);
            GISHandler.GISTools.AddTextElement(pagelayout, 10, 25, textEdit1.Text);
            GISHandler.GISTools.Addlegend(pagelayout, pagelayout.ActiveView.FocusMap, 2.0, 2.0, 5.0);
        }

        private void addLegend_Click(object sender, EventArgs e)
        {
            GISHandler.GISTools.Addlegend(pagelayout, pagelayout.ActiveView.FocusMap, 2.0, 2.0, 5.0);//可行  英文图例
            //GISHandler.GISTools.AddLegend(pagelayout);
            //IEnvelope pEnvelope = new EnvelopeClass();
            //pEnvelope.PutCoords(2, 2, 10, 10);
            //GISHandler.GISTools.AddLegendToPageLayout(pagelayout, pEnvelope);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            pagelayout.ActiveView.GraphicsContainer.DeleteAllElements();
            //IGraphicsContainer pDeletElement = pagelayout.ActiveView.FocusMap as IGraphicsContainer;
           // pDeletElement.DeleteAllElements();
            pagelayout.ActiveView.Refresh();
        }
    }
}
