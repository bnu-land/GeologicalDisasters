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
    public partial class StasticResult : Form
    {
        AxMapControl axmapcontrol = null;
        public StasticResult(AxMapControl am)
        {
            this.axmapcontrol = am;
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //加载统计信息
        private void StasticResult_Load(object sender, EventArgs e)
        {
            //gridView1.OptionsView.ShowGroupPanel = false;
            //gridView2.OptionsView.ShowGroupPanel = false;
            //gridView3.OptionsView.ShowGroupPanel = false;
           // DataTable dt = new DataTable();
            //dt.Columns.Add("影响区", typeof(string));
            //dt.Columns.Add("面积", typeof(double));
            //dt.Columns.Add("长度", typeof(double));
           // topClass.DataSource = dt;
           // middleClass.DataSource = dt;
           // bottomClass.DataSource = dt;
            
            //得到的是  一个FeatureLayer
           // axmapcontrol.ClearLayers();//清空图层
           // axmapcontrol.Map.AddLayer(featurelayer);//加载结果图层。
            for (int i = 1; i < 4; i++)
            {
                //ILayer ly = (ILayer)Stastic(axmapcontrol, i);
                switch (i)
                {
                    case 1:
                        ILayer ly1 = (ILayer)Stastic(axmapcontrol, i,Heigh.Text);
                        topClass.DataSource = creatDataTable(ly1, Heigh.Text);
                        break;
                    case 2:
                        ILayer ly2 = (ILayer)Stastic(axmapcontrol, i, middle.Text);
                        middleClass.DataSource = creatDataTable(ly2, middle.Text);
                        break;
                    case 3:
                        ILayer ly3 = (ILayer)Stastic(axmapcontrol, i, low.Text);
                        bottomClass.DataSource = creatDataTable(ly3, low.Text);
                        break;
                    default:
                        break;
                }
                if (axmapcontrol.LayerCount < i + 2)
                    continue;
            }

        }
        /// <summary>
        /// 叠置分析
        /// </summary>
        /// <param name="axmapcontrol"></param>
        /// <param name="i">图层索引</param>
        /// <param name="name">输出图层名字</param>
        /// <returns></returns>
        public static FeatureLayer Stastic(AxMapControl axmapcontrol,int i,string name)
        {
            ILayer pLayer;
            IFeatureClass pFeatureClass;
            IFeatureLayer pFeatureLayer;
            if (axmapcontrol == null || axmapcontrol.LayerCount < 2)
            { 
                return null;
            }
           // pLayer = axmapcontrol.Map.Layer(0);
            pLayer = axmapcontrol.ActiveView.FocusMap.get_Layer(i);
            pFeatureLayer = pLayer as IFeatureLayer;
            pFeatureClass = pFeatureLayer.FeatureClass;
            ITable table = pFeatureClass as ITable;
            
            
            pLayer = axmapcontrol.ActiveView.FocusMap.get_Layer(axmapcontrol.LayerCount - 1);
            IFeatureLayer ppFeatureLayer=(IFeatureLayer)pLayer;
            IFeatureClass ppFeatureClass=ppFeatureLayer.FeatureClass;
            ITable ptable = (ITable)ppFeatureClass;
           
            //Intersect intersect=new Intersect()
            Double tol=0.0;
            IWorkspaceFactory wspfctry = new ShapefileWorkspaceFactory();
            IWorkspace pWorkSpace = wspfctry.OpenFromFile(@"G:\数据库\实验数据", 0);

            IDataset pDataset = (IDataset)pWorkSpace;
            IName pName=pDataset.FullName;
            IDatasetName pDatasetName = new FeatureClassNameClass();
            pDatasetName.Name = name;
            pDatasetName.WorkspaceName = (IWorkspaceName)pName;
            IFeatureClassName fcn = (IFeatureClassName)pDatasetName;
            IBasicGeoprocessor pBG=new BasicGeoprocessor();
            IFeatureClass pOutFeatureClass = pBG.Intersect(table, false, ptable, false, tol, fcn);
            IFeatureLayer pOutFeatLayer = new FeatureLayerClass();
            FeatureLayer featurelayer = (FeatureLayer)pOutFeatLayer;
            featurelayer.FeatureClass = pOutFeatureClass;
            featurelayer.Name = pOutFeatureClass.AliasName;
            return featurelayer;
        }
        //建DataTable 表
        private static DataTable CreatDataTableByLayer(ILayer pLayer, string tableName)
        {
            DataTable pDataTable = new DataTable(tableName);
            ITable pTable = pLayer as ITable;
            IField pField = null;
            DataColumn pDataColumn;
            //根据字段建DataColumn
            for (int i = 0; i < pTable.Fields.FieldCount; i++)
            {
                pField = pTable.Fields.get_Field(i);
                pDataColumn = new DataColumn(pField.Name);
                if (pField.Name == pTable.OIDFieldName)
                {
                    pDataColumn.Unique = true;
                }
                pDataColumn.AllowDBNull = pField.IsNullable;//字段是否允许为空
                pDataColumn.Caption = pField.AliasName;//字段名
                pDataColumn.DataType = System.Type.GetType(ParseFieldType(pField.Type));
                pDataColumn.DefaultValue = pField.DefaultValue;
                if (pField.VarType == 8)
                    pDataColumn.MaxLength = pField.Length;
                //字段添加到表中
                pDataTable.Columns.Add(pDataColumn);
                pField = null;
                pDataColumn = null;
            }
            return pDataTable;
        }
        //装数据
        public static DataTable creatDataTable(ILayer pLayer, string tableName)
        {
            DataTable pDataTable = CreatDataTableByLayer(pLayer, tableName);
            //取得图层类型
           string shapeType = getShapeType(pLayer);
            //创建DataTable的行对象
           DataRow pDataRow = null;
             //从ILayer查询到ITable
           ITable pTable = pLayer as ITable;
           ICursor pCursor = pTable.Search(null, false);
           //取得ITable中的行信息
           IRow pRow = pCursor.NextRow();
           int n = 0;
           while (pRow != null)
           {
             //新建DataTable的行对象
             pDataRow = pDataTable.NewRow();
             for (int i = 0; i < pRow.Fields.FieldCount; i++)
              {
              //如果字段类型为esriFieldTypeGeometry，则根据图层类型设置字段值
              if (pRow.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeGeometry)
                {
                  pDataRow[i] = shapeType;
                }
                //当图层类型为Anotation时，要素类中会有esriFieldTypeBlob类型的数据，
                //其存储的是标注内容，如此情况需将对应的字段值设置为Element
               else if (pRow.Fields.get_Field(i).Type == esriFieldType.esriFieldTypeBlob)
                  {
                   pDataRow [i]= "Element";
                  }
                else
                    {
                      pDataRow[i] = pRow.get_Value(i);
                    } 
              }         
                  //添加DataRow到DataTable
                  pDataTable.Rows.Add(pDataRow);
                  pDataRow = null;
                    n++;
                 //为保证效率，一次只装载最多条记录
                if (n == 2000)
                   {
                    pRow = null;
                   }
                 else
                  {
                      pRow = pCursor.NextRow();
                  }   
            }      
               return pDataTable;


        }
        //获取数据类型
        public static string getShapeType(ILayer pLayer)
        {
            IFeatureLayer pFeatLyr = (IFeatureLayer)pLayer;
            switch (pFeatLyr.FeatureClass.ShapeType)
            {
                case esriGeometryType.esriGeometryPoint:
                    return "Point";
                case esriGeometryType.esriGeometryPolyline:
                    return "Polyline";
                case esriGeometryType.esriGeometryPolygon:
                    return "Polygon";
                default:
                    return "";
            }
        }

            //数据类型的转换
            public static string ParseFieldType(esriFieldType fieldType)
{
switch (fieldType)
{
case esriFieldType.esriFieldTypeBlob:
return "System.String";
case esriFieldType.esriFieldTypeDate:
return "System.DateTime";
case esriFieldType.esriFieldTypeDouble:
return "System.Double";
case esriFieldType.esriFieldTypeGeometry:
return "System.String";
case esriFieldType.esriFieldTypeGlobalID:
return "System.String";
case esriFieldType.esriFieldTypeGUID:
return "System.String";
case esriFieldType.esriFieldTypeInteger:
return "System.Int32";
case esriFieldType.esriFieldTypeOID:
return "System.String";
case esriFieldType.esriFieldTypeRaster:
return "System.String";
case esriFieldType.esriFieldTypeSingle:
return "System.Single";
case esriFieldType.esriFieldTypeSmallInteger:
return "System.Int32";
case esriFieldType.esriFieldTypeString:
return "System.String";
default:
return "System.String";
}
}

        //计算面积公式
        private double area(int i,AxMapControl axMapControl)
    {
        axMapControl.MapUnits = esriUnits.esriKilometers;
        ILayer layer1 = axMapControl.ActiveView.FocusMap.get_Layer(i);
        ILayer layer2 = axMapControl.ActiveView.FocusMap.get_Layer(i - 1);
        IFeatureLayer pfeatureLayer1 = (IFeatureLayer)layer1;
        IFeatureLayer pfeatureLayer2 = (IFeatureLayer)layer2;
        Polygon polygon1 = pfeatureLayer1 as Polygon;
        Polygon polygon2 = pfeatureLayer2 as Polygon;
        IArea area1 = (IArea)polygon1;
        IArea area2 = (IArea)polygon2;
        
        double s1 = area1.Area*10000;
        double s2 = area2.Area*10000;
        double s = s2 - s1;
        return s;//Convert.ToDouble(s).ToString("0.000");
    }
        private void Export1_Click(object sender, EventArgs e)
        {
            Export();
        }
        private void Export()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出Excel";
            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            saveFileDialog.FileName = Heigh.Text + "统计信息";
            DialogResult dialogResult = saveFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                topClass.ExportToXls(saveFileDialog.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Export2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出Excel";
            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            saveFileDialog.FileName = middle.Text + "统计信息";
            DialogResult dialogResult = saveFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                middleClass.ExportToXls(saveFileDialog.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Export3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出Excel";
            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            saveFileDialog.FileName = low.Text + "统计信息";
            DialogResult dialogResult = saveFileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                bottomClass.ExportToXls(saveFileDialog.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
