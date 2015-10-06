using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.AnalysisTools;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geometry;
namespace GeologicalDisasters
{
    public partial class Tend : Form
    {
        private double distance;
        string meters = "Meters";
        string[] name = { "模拟矿区趋势_三月", "模拟矿区趋势_六月", "模拟矿区趋势_一年" };
        string[] name1 = { "2015年7月12日采集坐标点.txt_三月", "2015年7月12日采集坐标点.txt_六月", "2015年7月12日采集坐标点.txt_一年" };
        private IHookHelper m_hookHelper = null;
        AxMapControl axmapcontrol = null;
        public Tend(IHookHelper hookHelper,AxMapControl amap)
        {
            this.axmapcontrol = amap;

            this.m_hookHelper = hookHelper;
            InitializeComponent();
        }
        private void progress(int j)
        {
            progressBarControl1.Visible = true;
            progressBarControl1.Properties.Minimum = 0;
            progressBarControl1.Properties.Maximum = j;
            progressBarControl1.Properties.Step = 1;
            progressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            for (int i = 0; i < progressBarControl1.Properties.Maximum; i++)
            {
                Application.DoEvents();
                progressBarControl1.PerformStep();
            }
            DevExpress.XtraEditors.XtraMessageBox.Show("分析成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBarControl1.Visible = false;
        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            if (TimeSelect.SelectedItem == null)
            {
                MessageBox.Show("请选择时段", "提示！");
                return;
            }
            if (LayerSelect.SelectedItem == "模拟矿区坐标点.txt")
            {

                switch (TimeSelect.SelectedIndex)
                {
                    case 0:
                        //distance = 100;
                        progress(1000);
                        axmapcontrol.AddShapeFile(@"G:\数据库\演示数据库", name[TimeSelect.SelectedIndex]);
                        axmapcontrol.MoveLayerTo(LayerSelect.SelectedIndex, LayerSelect.SelectedIndex + 1);
                        ILayer ly3 = (ILayer)StasticResult.Stastic(axmapcontrol, TimeSelect.SelectedIndex + 1, name[TimeSelect.SelectedIndex]);
                        gridControl1.DataSource = StasticResult.creatDataTable(ly3, name[TimeSelect.SelectedIndex]);
                        groupPanel1.Text = name[TimeSelect.SelectedIndex] + "统计信息";
                        break;
                    case 1:
                        //distance = 250;
                        progress(2000);
                        axmapcontrol.AddShapeFile(@"G:\数据库\演示数据库", name[TimeSelect.SelectedIndex]);
                        axmapcontrol.MoveLayerTo(LayerSelect.SelectedIndex, LayerSelect.SelectedIndex + 2);
                        ILayer ly6 = (ILayer)StasticResult.Stastic(axmapcontrol, TimeSelect.SelectedIndex + 1, name[TimeSelect.SelectedIndex]);
                        gridControl1.DataSource = StasticResult.creatDataTable(ly6, name[TimeSelect.SelectedIndex]);
                        groupPanel1.Text = name[TimeSelect.SelectedIndex] + "统计信息";
                        break;
                    case 2:
                        //distance = 500;
                        progress(3000);
                        axmapcontrol.AddShapeFile(@"G:\数据库\演示数据库", name[TimeSelect.SelectedIndex]);
                        axmapcontrol.MoveLayerTo(LayerSelect.SelectedIndex, LayerSelect.SelectedIndex + 3);
                        ILayer ly12 = (ILayer)StasticResult.Stastic(axmapcontrol, TimeSelect.SelectedIndex + 1, name[TimeSelect.SelectedIndex]);
                        gridControl1.DataSource = StasticResult.creatDataTable(ly12, name[TimeSelect.SelectedIndex]);
                        groupPanel1.Text = name[TimeSelect.SelectedIndex] + "统计信息";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (TimeSelect.SelectedIndex)
                {
                    case 0:
                        //distance = 100;
                        progress(1000);
                        axmapcontrol.AddShapeFile(@"G:\数据库\演示数据库", name1[TimeSelect.SelectedIndex]);
                        axmapcontrol.MoveLayerTo(LayerSelect.SelectedIndex, LayerSelect.SelectedIndex + 1);
                        ILayer ly3 = (ILayer)StasticResult.Stastic(axmapcontrol, TimeSelect.SelectedIndex + 1, name[TimeSelect.SelectedIndex]);
                        gridControl1.DataSource = StasticResult.creatDataTable(ly3, name[TimeSelect.SelectedIndex]);
                        groupPanel1.Text = name[TimeSelect.SelectedIndex] + "统计信息";
                        break;
                    case 1:
                        //distance = 250;
                        progress(2000);
                        axmapcontrol.AddShapeFile(@"G:\数据库\演示数据库", name1[TimeSelect.SelectedIndex]);
                        axmapcontrol.MoveLayerTo(LayerSelect.SelectedIndex, LayerSelect.SelectedIndex + 2);
                        ILayer ly6 = (ILayer)StasticResult.Stastic(axmapcontrol, TimeSelect.SelectedIndex + 1, name[TimeSelect.SelectedIndex]);
                        gridControl1.DataSource = StasticResult.creatDataTable(ly6, name[TimeSelect.SelectedIndex]);
                        groupPanel1.Text = name[TimeSelect.SelectedIndex] + "统计信息";
                        break;
                    case 2:
                        //distance = 500;
                        progress(3000);
                        axmapcontrol.AddShapeFile(@"G:\数据库\演示数据库", name1[TimeSelect.SelectedIndex]);
                        axmapcontrol.MoveLayerTo(LayerSelect.SelectedIndex, LayerSelect.SelectedIndex + 3);
                        ILayer ly12 = (ILayer)StasticResult.Stastic(axmapcontrol, TimeSelect.SelectedIndex + 1, name[TimeSelect.SelectedIndex]);
                        gridControl1.DataSource = StasticResult.creatDataTable(ly12, name[TimeSelect.SelectedIndex]);
                        groupPanel1.Text = name[TimeSelect.SelectedIndex] + "统计信息";
                        break;
                    default:
                        break;
                }
            }
            
          
            
            /*
            IFeatureLayer layer = GetFeatureLayer((string)LayerSelect.SelectedItem);
            if (null == layer)
            {
                MessageBox.Show("选中图层无效！");
                return;
            }
            Geoprocessor gp = new Geoprocessor();
            gp.OverwriteOutput = true;
            this.Cursor = Cursors.WaitCursor;
            string path = System.IO.Path.Combine(@"I:\四平项目\实验数据", (string)LayerSelect.SelectedItem + "_Tency.shp");
            ESRI.ArcGIS.AnalysisTools.Buffer tence = new ESRI.ArcGIS.AnalysisTools.Buffer(layer, path, Convert.ToString(distance) + " " + meters);
            try
            {
                IGeoProcessorResult results = (IGeoProcessorResult)gp.Execute(tence, null);
                if (results.Status != esriJobStatus.esriJobSucceeded)
                {
                    MessageBox.Show("趋势分析失败: " + layer.Name, "提示！");
                }
                this.Cursor = Cursors.Default;
                MessageBox.Show(layer.Name + "趋势分析完成！", "提示!");
                progressBarControl1.Visible = false;*/
                    //将统计分析完成的图层添加到mapcontrol
              /*  IWorkspaceFactory pWorkspaceFactory = new ShapefileWorkspaceFactoryClass();//定义工作空间工厂接口
                IWorkspace pWorkSpace = pWorkspaceFactory.OpenFromFile(path.Substring(0, path.Length - ((string)LayerSelect.SelectedItem + "_Tency.shp").Length), 0);//实例化工作空间
                IFeatureWorkspace pFeatureWorkspace = pWorkSpace as IFeatureWorkspace;
                IFeatureClass pFeatureClass = pFeatureWorkspace.OpenFeatureClass((string)LayerSelect.SelectedItem + "_Tency.shp");//
                //以上得到的是featureclass。

                IDataset pDataset = pFeatureClass as IDataset;
                IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                pFeatureLayer.FeatureClass = pFeatureClass;
                pFeatureLayer.Name = pDataset.Name;//图层名称
                ILayer pLayer = pFeatureLayer as ILayer;

                m_hookHelper.FocusMap.AddLayer(pLayer);
                m_hookHelper.FocusMap.MoveLayer(pLayer, LayerSelect.SelectedIndex + 1);*/
              /*  axmapcontrol.AddShapeFile(@"I:\四平项目\实验数据", (string)LayerSelect.SelectedItem + "_Tency.shp");
                axmapcontrol.MoveLayerTo(LayerSelect.SelectedIndex, LayerSelect.SelectedIndex + 1);
            }
            catch
            {
                MessageBox.Show("错误");
            
            }*/
            //this.Close();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void Tend_Load(object sender, EventArgs e)
        {
            gridView1.OptionsView.ShowGroupPanel = false;
            AxMapControl axMapControl1 = new AxMapControl();
            //m_hookHelper.Hook = axMapControl1.Object;
            if (null == m_hookHelper || null == m_hookHelper.Hook || 0 == m_hookHelper.FocusMap.LayerCount)
                return;

            //load all the feature layers in the map to the layers combo
            IEnumLayer layers = GetLayers();
            layers.Reset();
            ILayer layer = null;
            while ((layer = layers.Next()) != null)
            {
                LayerSelect.Items.Add(layer.Name);
            }
            //select the first layer
            if (LayerSelect.Items.Count > 0)
                LayerSelect.SelectedIndex = 0;
            m_hookHelper.FocusMap.MapUnits = esriUnits.esriMeters;
           // int units = Convert.ToInt32(m_hookHelper.FocusMap.MapUnits);
            //cboUnits1.SelectedIndex = units;
            

        }
        // 获取图层 
        private IFeatureLayer GetFeatureLayer(string layerName)
        {
            //get the layers from the maps
            IEnumLayer layers = GetLayers();
            layers.Reset();

            ILayer layer = null;
            while ((layer = layers.Next()) != null)
            {
                if (layer.Name == layerName)
                    return layer as IFeatureLayer;
            }

            return null;
        }
        private IEnumLayer GetLayers()
        {

            UID uid = new UIDClass();
            uid.Value = "{40A9E885-5533-11d0-98BE-00805F7CED21}";// 代表只获取矢量图层
            //问题在这个地方 解决！
            IEnumLayer layers = m_hookHelper.FocusMap.get_Layers(uid, true);


            return layers;
        }
        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出Excel";
            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            saveFileDialog.FileName = name[TimeSelect.SelectedIndex];
            DialogResult dialogResult = saveFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                gridControl1.ExportToXls(saveFileDialog.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
