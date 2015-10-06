using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using GISHandler;
using GeologicalDisasters;
namespace GeologicalDisasters
{
    public partial class Coordinate : Form
    {
        IPolygon ply = null;

        AxMapControl mapControl = null;
        string paths1;
        int lengh;
        public Coordinate(AxMapControl axMapControl)
        {
            //  this.ply = plo;

            this.mapControl = axMapControl;
            InitializeComponent();
        }
        public void AddSourse(DataTable coorData)
        {
            gridControl1.DataSource = coorData;

            dataGridView1.DataSource = coorData;
        }
        //数据存储
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog pSaveFileDialog = new SaveFileDialog();
            pSaveFileDialog.CheckPathExists = true;
            pSaveFileDialog.Filter = "txt文件|*.txt";
            pSaveFileDialog.OverwritePrompt = true;
            pSaveFileDialog.Title = "保存坐标点";
            pSaveFileDialog.RestoreDirectory = true;

            // pSaveFileDialog.FilterIndex = 1;
            //string pathSave = pSaveFileDialog.FileName;
            //string date = DateTime.Now.Date.ToString();//xxxx-xx-xx 00:00:00
            string date = DateTime.Now.ToLongDateString().ToString();//xxxx年xx月xx日
            pSaveFileDialog.FileName = date + "采集坐标点.txt";
            DialogResult dr = pSaveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MessageBox.Show(pSaveFileDialog.FileName, "保存路径提示");
                System.IO.FileStream fileStream = new System.IO.FileStream(@pSaveFileDialog.FileName, FileMode.OpenOrCreate);//"D:\\" + date + "采集坐标点.txt"
                StreamWriter streamWriter = new StreamWriter(fileStream, System.Text.Encoding.Unicode);
                StringBuilder strBuilder = new StringBuilder();
                try
                {
                    //逐行写入 strBuilder
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        strBuilder = new StringBuilder();
                        for (int j = 1; j < dataGridView1.Columns.Count - 2; j++)
                        {
                            strBuilder.Append(dataGridView1.Rows[i].Cells[j].Value.ToString() + ",");
                        }
                        strBuilder.Remove(strBuilder.Length - 1, 1);
                        streamWriter.WriteLine(strBuilder.ToString());
                    }
                }
                catch (Exception ex)
                {
                    string strErrorMessage = ex.Message;
                }
                finally
                {
                    streamWriter.Close();
                    fileStream.Close();
                }
            }


        }

        private void ThisFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool drawPolygon = false;

        private void DrawLayer_Click(object sender, EventArgs e)
        {
            /* SaveFileDialog pSaveFileDialog = new SaveFileDialog();
             pSaveFileDialog.CheckPathExists = true;
             pSaveFileDialog.Filter = "shap文件|*.shp";
             pSaveFileDialog.OverwritePrompt = true;
             pSaveFileDialog.Title = "保存图层";
             pSaveFileDialog.RestoreDirectory = true;
             pSaveFileDialog.CreatePrompt = true;
             string date = DateTime.Now.ToLongDateString().ToString();

            pSaveFileDialog.FileName=date + "采集坐标点.shp";
   
    
   
            // pSaveFileDialog.FileName = date + "采集坐标点.shp";
             DialogResult dr = pSaveFileDialog.ShowDialog();
             if (dr == DialogResult.OK)
             {
                // System.IO.FileStream fileStream = new System.IO.FileStream(@pSaveFileDialog.FileName, FileMode.OpenOrCreate);
               GISHandler.GISTools.cp(ply, pSaveFileDialog.FileName.Substring(0, pSaveFileDialog.FileName.Length - (date + "采集坐标点.shp").Length), pSaveFileDialog.FileName);
               // GISHandler.GISTools.CreatePolygonFeatureClass(ply, pSaveFileDialog.FileName.Substring(0, pSaveFileDialog.FileName.Length - (date + "采集坐标点.shp").Length), pSaveFileDialog.FileName);
             }
             //坐标图层 的保存出现问题。
             //ILayer pfeature= hookhelp.FocusMap.get_Layer(0);
    
            //IFeatureClass featureclass=  pfeature as IFeatureClass;
             //AddFeatureToFeatureClass(ply, featureclass);
            */
            //GISHandler.GISTools.cp(ply);
            if (MessageBox.Show("是否保存?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //DateTime.Now.ToLongDateString().ToString()
                //System.DateTime currentTime = new System.DateTime();
                try
                {
                    GISHandler.GISTools.CreatePolygonFeatureclass(ply, @"G:\数据库\图层数据", paths1.Substring(paths1.Length - lengh + 1));
                    MessageBox.Show("已成功保存！", "提示");
                    this.mapControl.AddShapeFile(@"G:\数据库\图层数据", paths1.Substring(paths1.Length - lengh + 1));
                }
                catch
                {
                    //MessageBox.Show("错误");
                }//DateTime.Now.ToLongDateString().ToString() + "采集坐标点.shp"
            }





        }
        //向shp中添加要素  pPolygon多边形   pFeatureClass多边形shp
        public static void AddFeatureToFeatureClass(IPolygon pPolygon, IFeatureClass pFeatureClass)
        {

            IFeature pFeature = pFeatureClass.CreateFeature();
            pFeature.Shape = pPolygon;
            pFeature.Store();
        }

        private void startEdit_Click(object sender, EventArgs e)
        {
            GISHandler.GISTools.startEdit(this.mapControl);
            GISHandler.GISTools.EditTool(this.mapControl);
        }

        private void saveEdit_Click(object sender, EventArgs e)
        {
            GISHandler.GISTools.saveEdit(this.mapControl);
        }

        private void stopEdit_Click(object sender, EventArgs e)
        {
            GISHandler.GISTools.stopEdit(this.mapControl);
        }

        private void Coordinate_Load(object sender, EventArgs e)
        {
            //定义点集环形
            Ring ring1 = new RingClass();
            object missing = Type.Missing;
            //新建一个datatable用于保存读入的数据
            DataTable dt = new DataTable();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;    //单选
            ofd.Title = "选择坐标文件";
            ofd.Filter = "txt文件|*.txt";
            // ofd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            ofd.InitialDirectory = @"G:\数据库\坐标数据";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //IGeometryCollection pointPolygon = new PolygonClass();
                FileInfo fi = new FileInfo(ofd.FileName);
                try
                {
                    paths1 = ofd.FileName;
                    lengh = paths1.Length - ofd.InitialDirectory.Length;
                    String paths = ofd.FileName;

                    int i = 0;
                    //给datatable添加5个列
                    dt.Columns.Add("编号", typeof(int));
                    dt.Columns.Add("坐标X", typeof(double));
                    dt.Columns.Add("坐标Y", typeof(double));
                    dt.Columns.Add("高程Z", typeof(double));
                    dt.Columns.Add("日期", typeof(string));
                    //读入文件
                    StreamReader sr = new StreamReader(paths, Encoding.Default);

                    //循环读取所有行
                    while (!sr.EndOfStream)//(line = sr.ReadLine()) != null)
                    {
                        i++;
                        //将每行数据，用-分割成2段 
                        //sr.ReadLine().TrimStart();//消除前面空格
                        //sr.ReadLine().TrimEnd();//消除尾部空格
                        string[] data = sr.ReadLine().Split(',', ' ');
                        //新建一行，并将读出的数据分段，分别存入5个对应的列中
                        DataRow dr = dt.NewRow();
                        dr[0] = i;
                        dr[1] = data[0];
                        dr[2] = data[1];
                        dr[3] = 0;
                        dr[4] = DateTime.Now.ToLongDateString().ToString();
                        //将这行数据加入到datatable中
                        dt.Rows.Add(dr);
                        //点上生成面
                        IPoint ppp = new PointClass();
                        ppp.PutCoords((double)dr[1], (double)dr[2]);
                        ring1.AddPoint(ppp, ref missing, ref missing);
                        //调用画点工具
                        GISHandler.GISTools.CreatPoint(this.mapControl, (double)dr[1], (double)dr[2], i);
                    }
                }
                catch
                {
                    MessageBox.Show("坐标文件内容错误!请检查格式是否为：x,y或者x y");
                    return;
                }
                IGeometryCollection pointPolygon = new PolygonClass();
                pointPolygon.AddGeometry(ring1 as IGeometry, ref missing, ref missing);
                IPolygon polyGonGeo = pointPolygon as IPolygon;
                ply = polyGonGeo;
                polyGonGeo.SimplifyPreserveFromTo();
                //object miss = Type.Missing;
                //this.mapControl.DrawShape(polyGonGeo, ref miss);

            }
            else
                this.Close();
            gridControl1.DataSource = dt;
            dataGridView1.DataSource = dt;
            gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void Editing_Click(object sender, EventArgs e)
        {
            Edit editing = new Edit(this.mapControl);
            editing.Show();
            editing.StartPosition = FormStartPosition.CenterScreen;
            editing.TopMost = true;
        }

    }

}
    
