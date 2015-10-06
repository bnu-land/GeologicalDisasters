using System;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Configuration; 
using System.Runtime.InteropServices;
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

using System.Collections.Generic;


using System.IO;



using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.GeoAnalyst;

using ESRI.ArcGIS.DataSourcesRaster;

namespace GeologicalDisasters
{
    public partial class Buffer : Form
    {
        [DllImport("user32.dll")]
        private static extern int PostMessage(IntPtr wnd,
                                              uint Msg,
                                              IntPtr wParam,
                                              IntPtr lParam);
        private const uint WM_VSCROLL = 0x0115;
        private const uint SB_BOTTOM = 7;
        private IHookHelper m_hookHelper = null;
        string DW;
        AxMapControl mapContol;
        //IHookHelper map_hookHelper =new HookHelperClass();AxMapControl axMapControl
        public Buffer(IHookHelper hookHelper,AxMapControl am)
        {
            this.m_hookHelper = hookHelper;
            this.mapContol = am;
            InitializeComponent();
        }
      

        /*变量：
         * 1、图层
         * 2、距离
         * 3、单位
         * 4、保存路径
         */
        private void button1_Click(object sender, EventArgs e)
        {

            double bufferDistance, bufferDistance2, bufferDistance3;
            double.TryParse(txtBufferDistance.Text, out bufferDistance);
            double.TryParse(txtBufferDistance2.Text, out bufferDistance2);
            double.TryParse(txtBufferDistance3.Text, out bufferDistance3);
            if (CNunit.SelectedIndex == 0)
                DW= "Meters";
            else if (CNunit.SelectedIndex == 1)
                DW= "Kilometers";
            if (0.0 == bufferDistance)
            {
                MessageBox.Show("输入范围距离无效！");
                return;
            }
            if (CNunit.SelectedItem == null)
            {
                MessageBox.Show("请选择单位", "提示");
                return;
            }
             //判断输出路径是否合法
           if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(txtOutputPath.Text)) ||".shp" != System.IO.Path.GetExtension(txtOutputPath.Text))
             {
               MessageBox.Show("输出路径无效！");
                return;
            }
            IFeatureLayer layer = GetFeatureLayer((string)cboLayers.SelectedItem);
          if (null == layer)
          {
               MessageBox.Show("选中图层无效！");
              return;
          }
            Geoprocessor gp = new Geoprocessor();
            gp.OverwriteOutput = true;
            double[] dis = { 0,bufferDistance, bufferDistance2 ,bufferDistance3 };
            string[] level={"","高级","中级","低级"};
            int i=1;
            while (i < 4)
            {
                //修改当前指针样式  
                this.Cursor = Cursors.WaitCursor; 
                //调用缓冲去区处理工具buffer
                txtOutputPath.Text = System.IO.Path.Combine(@"G:\数据库\实验数据", (level[i] + "_" + (string)cboLayers.SelectedItem + "_buffer.shp"));
                ESRI.ArcGIS.AnalysisTools.Buffer buffer = new ESRI.ArcGIS.AnalysisTools.Buffer(layer, txtOutputPath.Text, Convert.ToString(dis[i]) + " " +DW);//单级缓冲
                try
                {
                    IGeoProcessorResult results = (IGeoProcessorResult)gp.Execute(buffer, null);
                    if (results.Status != esriJobStatus.esriJobSucceeded)
                    {
                        MessageBox.Show("缓冲区失败的图层: " + layer.Name, "提示！");
                    }
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(level[i]+"_" +layer.Name + "分析统计完成！", "提示!");
                    //将统计分析完成的图层添加到mapcontrol
                    IWorkspaceFactory pWorkspaceFactory = new ShapefileWorkspaceFactoryClass();//定义工作空间工厂接口
                    IWorkspace pWorkSpace = pWorkspaceFactory.OpenFromFile(txtOutputPath.Text.Substring(0, txtOutputPath.Text.Length - (level[i]+"_" + (string)cboLayers.SelectedItem + "_buffer.shp").Length), 0);//实例化工作空间
                    IFeatureWorkspace pFeatureWorkspace = pWorkSpace as IFeatureWorkspace;
                    IFeatureClass pFeatureClass = pFeatureWorkspace.OpenFeatureClass(level[i]+"_" +(string)cboLayers.SelectedItem +  "_buffer.shp");//
                    //以上得到的是featureclass。

                    IDataset pDataset = pFeatureClass as IDataset;
                    IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                    pFeatureLayer.FeatureClass = pFeatureClass;
                    pFeatureLayer.Name = pDataset.Name;//图层名称
                    ILayer pLayer = pFeatureLayer as ILayer;

                    m_hookHelper.FocusMap.AddLayer(pLayer);
                    m_hookHelper.FocusMap.MoveLayer(pLayer, cboLayers.SelectedIndex + i);
                    i++;
                    
                }
                catch
                {
                    MessageBox.Show("处理失败");
                    this.Cursor = Cursors.Default;
                    this.Close();
                    return;
                }
            }
            
            //GISHandler.GISTools.QueryByBuffer(m_hookHelper);
            this.Close();
            StasticResult SR = new StasticResult(this.mapContol);
            SR.Show();
            SR.StartPosition = FormStartPosition.CenterScreen;
            SR.TopMost = true;
            
            //1、将结果图层添加到axmapcontrol中
            //2、多级缓冲 -->方法递归调用。/for循环三次  distance+=distance(图层叠加在一起  不好进行统计。)
            //3、将各级缓冲区中所叠置基图中的属性信息 自定义提取 装入 gridcontrol中。完成！

            
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
        // 获取图层  
        private IEnumLayer GetLayers()
        {
          
            UID uid = new UIDClass();
            uid.Value = "{40A9E885-5533-11d0-98BE-00805F7CED21}";// 代表只获取矢量图层
            //问题在这个地方 解决！
            IEnumLayer layers = m_hookHelper.FocusMap.get_Layers(uid, true);


            return layers;
        }
        //保存输出图层路径
        private void btnOutputLayer_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.CheckPathExists = true;
            saveDlg.Filter = "shp文件 (*.shp)|*.shp";
            saveDlg.OverwritePrompt = true;
            saveDlg.Title = "图层输出";
            saveDlg.RestoreDirectory = true;
            saveDlg.FileName = (string)cboLayers.SelectedItem + "_buffer.shp";

            DialogResult dr = saveDlg.ShowDialog();
            if (dr == DialogResult.OK)
                txtOutputPath.Text = saveDlg.FileName;
        }
        //窗口启动程序
        private void Buffer_Load(object sender, EventArgs e)
        {
            AxMapControl axMapControl1=new AxMapControl();
            //m_hookHelper.Hook = axMapControl1.Object;
            if (null == m_hookHelper || null == m_hookHelper.Hook || 0 == m_hookHelper.FocusMap.LayerCount)
                return;

            //load all the feature layers in the map to the layers combo
            IEnumLayer layers = GetLayers();
            layers.Reset();
            ILayer layer = null;
            while ((layer = layers.Next()) != null)
            {
                cboLayers.Items.Add(layer.Name);
            }
            //select the first layer
            if (cboLayers.Items.Count > 0)
                cboLayers.SelectedIndex = 0;

           // string tempDir = System.IO.Path.GetTempPath();
            string tempDir = @"G:\数据库\实验数据";
            txtOutputPath.Text = System.IO.Path.Combine(tempDir, ((string)cboLayers.SelectedItem + "_buffer.shp"));

            
            
            //set the default units of the buffer
            m_hookHelper.FocusMap.MapUnits = esriUnits.esriMeters;
            CNunit.SelectedIndex = 0;
          /*   int units = Convert.ToInt32(m_hookHelper.FocusMap.MapUnits);
            cboUnits1.SelectedIndex = units;
           */
        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
