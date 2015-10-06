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
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Output;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.EditorExt;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using System.Web.Http;
using _sdnMap;
using IdentifyTool;
using lesson3;
namespace GeologicalDisasters
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private bool isMeasure = false;
        private bool areaMeasure = false;
        public  bool attribute = false;
        private bool edit = false;
        private bool jian1 = false;
        private bool jian2 = false;
        private IdentifyDialog identifyDialog =new IdentifyDialog();
        //TOCControl控件变量
        private ITOCControl2 m_tocControl = null;
        //TOCControl中Map菜单
        private IToolbarMenu m_menuMap = null;
       //TOCControl中图层菜单
        private IToolbarMenu m_menuLayer = null;
        //pagelayout菜单
        private IToolbarMenu p_menuLayer = null;
     
        public Modules.ucFileNavPanel ucFileNavPanel = null;
        IHookHelper m_hookHelper = new HookHelperClass();
       
        //构造函数
        public MainForm()
        {
            InitializeComponent();
           
        }


        public  void Hook(IHookHelper m_hookHelper)
        {
            this.m_hookHelper = m_hookHelper;
            this.m_hookHelper.Hook = axMapControl1.Object;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            axMapControl1.LoadMxFile(@"G:\数据库\地图数据\演示数据.mxd", 0, Type.Missing);  
            //axMapControl1.AddShapeFile(@"I:\四平项目\实验数据", "东丰县行政区域");
            m_menuMap = new ToolbarMenuClass();
            m_menuLayer = new ToolbarMenuClass();
            p_menuLayer = new ToolbarMenuClass();

            p_menuLayer.AddItem(new AddName(this.axPageLayoutControl1), -1, 0, true, esriCommandStyles.esriCommandStyleTextOnly);

            p_menuLayer.AddItem(new AddLegend(), -1, 1, true, esriCommandStyles.esriCommandStyleTextOnly);

            p_menuLayer.AddItem(new AddNorthArrow(this.axPageLayoutControl1), -1, 2, true, esriCommandStyles.esriCommandStyleTextOnly);

            p_menuLayer.AddItem(new AddScal(this.axPageLayoutControl1), -1, 3, true, esriCommandStyles.esriCommandStyleTextOnly);
            //打开文档菜单
           // m_menuMap.AddItem(new GISTools(AddData), -1, 0, false, esriCommandStyles.esriCommandStyleIconAndText);
            //刷新
            m_menuMap.AddItem(new refresh(), -1, 0, false, esriCommandStyles.esriCommandStyleIconAndText);
            //

            //添加数据菜单
            //m_menuMap.AddItem(new ControlsAddDataCommandClass(), -1, 0, false, esriCommandStyles.esriCommandStyleIconAndText);
            m_menuMap.AddItem(new addData(), -1, 1, false, esriCommandStyles.esriCommandStyleIconAndText);
            //全局显示
            //m_menuMap.AddItem(new ControlsMapFullExtentCommandClass(), -1, 1, false, esriCommandStyles.esriCommandStyleIconAndText);
            m_menuMap.AddItem(new fullExtent(), -1, 2, false, esriCommandStyles.esriCommandStyleIconAndText);
            //移动
            //m_menuMap.AddItem(new ControlsMapPanToolClass(), 1, 2, false, esriCommandStyles.esriCommandStyleIconAndText);
            m_menuMap.AddItem(new pan(), 2, 3, false, esriCommandStyles.esriCommandStyleIconAndText);
            //移除图层菜单
            m_menuLayer.AddItem(new RemoveLayer(), -1, 0, false, esriCommandStyles.esriCommandStyleTextOnly);
            //放大到整个图层
            m_menuLayer.AddItem(new ZoomToLayer(), -1, 1, true, esriCommandStyles.esriCommandStyleTextOnly);
            m_menuLayer.SetHook((IMapControl3)this.axMapControl1.Object);
            m_menuMap.SetHook((IMapControl3)this.axMapControl1.Object);
            axTOCControl1.SetBuddyControl(axMapControl1);
        }

        #region GIS Map Tools
        #region GIS基本操作工具
        //
        //打开文件
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
        //图层输出
        private void btn_ExportMapPic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //输出当前活动窗口内容
            edit = true;
            if (edit)
            {
                GISHandler.GISTools.ExportImage(this.axPageLayoutControl1.ActiveView);
                edit = false;
            }

            else
                GISHandler.GISTools.ExportImage(this.axMapControl1.ActiveView);

           // 
        }
        //添加图层
        private void btn_AddMapLayer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;    //多选
            ofd.Title = "选择图层";
            ofd.Filter = "shp文件|*.shp";
            ofd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo fi = new FileInfo(ofd.FileName);
                if (fi.Exists)
                {
                    string path = ofd.FileName;
                    this.axMapControl1.AddShapeFile(path,ofd.FileName);
                    this.axMapControl1.ActiveView.Refresh();
                }
            }*/
          GISHandler.GISTools.AddData(this.axMapControl1);
            
        //  axMapControl1.AddLayerFromFile(@"I:\四平项目\东丰县2000数据库", 1);
        }
        //移动图层
        private void btn_Pan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.Pan(this.axMapControl1);
        }
        //放大
        private void btn_ZoomIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.ZoomIn(axMapControl1);
        }
        //缩小
        private void btn_ZoomOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.ZoomOut(axMapControl1);
        }
        //渐大
        private void btn_ScaleIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.ZoomInFix(axMapControl1);
        }
        //渐小
        private void btn_ScaleOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.ZoomOutFix(axMapControl1);
        }
        //选择
        private void btn_Select_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.SelectFeature(axMapControl1);
        }
        //全局
        private void btn_FullExtent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.FullExtent(axMapControl1);
        }
        //前一视图
       private void btn_FrontView_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.MapForwardView(axMapControl1);
        }
       //后一视图
        #endregion
       #region GIS 辅助工具
       private void btn_NextView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.MapNextView(axMapControl1);
        }
        //长度测量  完成
        private void btn_MapMeasureLength_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           //jian1 = true;
           //{
               //axMapControl1.OnMouseDown += axMapControl1_OnMouseDown;
               isMeasure = true;
           //    jian1 = false;
           //}
       }
        //面积测量  完成
        private void btn_MapMeasureArea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //axMapControl1.OnMouseDown+=axMapControl1_OnMouseDown;
            areaMeasure = true;
        }
        //属性查看  引用控件
        private void btn_MapIdentifyInfo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        //axMapControl1.OnMouseDown += axMapControl1_OnMouseDown;
        attribute = true;
        //GISHandler.GISTools.Edit(this.axMapControl1);
        ShowIdentifyDialog();
        }
        private void ShowIdentifyDialog()
        {
            //新建属性查询对象
            identifyDialog = IdentifyDialog.CreateInstance(axMapControl1);
            identifyDialog.Owner = this;
            identifyDialog.Show();
        }
        //导入坐标·  完善代码 未创建图层
        private void btn_Data_StatisticTables_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Coordinate am = new Coordinate( this.axMapControl1);
            am.Show();
            //am.TopMost = true;
            #region
            /*
            //定义点集环形
            Ring ring1 = new RingClass();
            object missing = Type.Missing;
            //新建一个datatable用于保存读入的数据
            DataTable dt = new DataTable();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;    //单选
            ofd.Title = "选择坐标文件";
            ofd.Filter = "txt文件|*.txt";
            ofd.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //IGeometryCollection pointPolygon = new PolygonClass();
                FileInfo fi = new FileInfo(ofd.FileName);
                try
                {
                    String paths = ofd.FileName;
                    int i = 0;
                    //给datatable添加5个列
                    dt.Columns.Add("编号", typeof(int));
                    dt.Columns.Add("坐标X", typeof(double));
                    dt.Columns.Add("坐标Y", typeof(double));
                    dt.Columns.Add("高程Z", typeof(double));
                    dt.Columns.Add("采集日期", typeof(string));
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
                        GISHandler.GISTools.CreatPoint(this.axMapControl1, (double)dr[1], (double)dr[2], i);
                    }
                }
                catch
                {
                    MessageBox.Show("坐标文件内容错误!请检查格式是否为：x,y或者x y");
                }
                */
                #region 源码
                /*
                     //画多边形；
                      IGeometryCollection pointPolygon = new PolygonClass();
                      pointPolygon.AddGeometry(ring1 as IGeometry, ref missing, ref missing);
                      IPolygon polyGonGeo = pointPolygon as IPolygon;
                      polyGonGeo.SimplifyPreserveFromTo();

                      //待封装
                      //ISimpleLineSymbol pLineSym = new SimpleLineSymbol();
                      ISimpleFillSymbol pSymbol = new SimpleFillSymbolClass();
                      IRgbColor pColor = new RgbColor();
                      pColor.Red = 255;
                      pColor.Green = 0;
                      pColor.Blue = 0;
                      pSymbol.Color = pColor;
                      //pSymbol.Style = esriSimpleFillStyle.;//esriSFSHorizontal网格斜线
                    
                      object Symbol = pSymbol as object;
                      
                    */
                #endregion

                //添加到图层
                //读取文件内容    进行标准化判断 
                //先读取每个点坐标，生成point(IPoint接口)
                //把所有Point加到pointcollection(IPointCollection接口)
                //首尾坐标要一致
                //画多边形；
            /*  IGeometryCollection pointPolygon = new PolygonClass();
              pointPolygon.AddGeometry(ring1 as IGeometry, ref missing, ref missing);
              IPolygon polyGonGeo = pointPolygon as IPolygon;
              polyGonGeo.SimplifyPreserveFromTo();

               
              Coordinate am = new Coordinate(polyGonGeo,this.axMapControl1);
             
              if (fi.Exists)
              {
                  am.AddSourse(dt);
                  am.Show();
                  //am.TopMost = true;

              }




              ISimpleFillSymbol pSymbol = new SimpleFillSymbolClass();
              IRgbColor pColor = new RgbColor();
              pColor.Red = 220;
              pColor.Green = 132;
              pColor.Blue = 145;
              pSymbol.Color = pColor;
              //pSymbol.Style = esriSimpleFillStyle.esriSFSHorizontal;//网格斜线（可更改）
                
              object Symbol = pSymbol as object;
              axMapControl1.DrawShape(polyGonGeo, ref Symbol);
             // if (MessageBox.Show("是否保存?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
              //{

              //GISHandler.GISTools.CreatePolygonFeatureClass(polyGonGeo, @"I:\四平项目\实验数据", DateTime.Now.ToLongDateString().ToString() + "采集坐标点.shp");
              //}
          }
      */
            #endregion
           
        }
        //范围分析···未添加  
        private void btn_PublishDisasterDoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_hookHelper.Hook = this.axMapControl1.Object;
            
            Buffer buffer = new Buffer(m_hookHelper,this.axMapControl1);
            
            buffer.StartPosition = FormStartPosition.CenterScreen;
            //buffer.TopMost = true;前置；
            buffer.ShowDialog();
            //GISHandler.GISTools.QueryByBuffer(axMapControl1);
            //buffer.Hook(axMapControl1);
        }
      
        //趋势分析···未添加
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_hookHelper.Hook = this.axMapControl1.Object;
            Tend td=new Tend(m_hookHelper,this.axMapControl1);
            
            td.StartPosition = FormStartPosition.CenterScreen;
            td.Show();
            
            //IPageLayout pageLayout = axPageLayoutControl1 as IPageLayout;
            //GISHandler.GISTools.CreatPoint(this.axMapControl1);
           // GISHandler.GISTools.addNorthArrow(axPageLayoutControl1, axPageLayoutControl1.ActiveView.FocusMap);
           // GISHandler.GISTools.AddScalebar(pageLayout, axMapControl1.Map);
            

        }
       #endregion
        //数据集管理（坐标数据）····未添加
        private void btn_ManageOfData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xtraTabPage_DataNav.Show();
            LoadFiles("G:\\数据库\\坐标数据");
            axMapControl1.ClearLayers();
            axMapControl1.LoadMxFile(@"G:\数据库\地图数据\演示数据.mxd", 0, Type.Missing);
            axMapControl1.OnMouseDown += axMapControl1_OnMouseDown;
            edit = true;

        }
        //获取目录下所有文件名==回去跟师兄要源码
        private void LoadFiles(string targetDirectory)
         {
               DataTable dt = new DataTable();
              // dt.Columns.Add(" ", typeof(int));

               dt.Columns.Add("矿区坐标文件", typeof(string));
               
              //取文件
              string[] fileEntries = Directory.GetFiles(targetDirectory);
            
              for (int i = 0; i < fileEntries.Length; i++)
              {
                  DataRow dr = dt.NewRow();
                 // dr[0] = i + 1;
                  string nm = fileEntries[i].Substring(fileEntries[i].Length - (fileEntries[i].Length - targetDirectory.Length - 1));
                  string[] nmm = nm.Split('.');
                  dr[0] = nmm[0];
                  dt.Rows.Add(dr);
              
              }
              //dataGridView1.DataSource = dt;
              //dataGridView1.ReadOnly = true;
             
              
             gridControl1.DataSource = dt;
             //gridControl1.ReadOnly = true;
             gridView1.OptionsBehavior.Editable = false;
             gridView1.OptionsView.ShowGroupPanel = false;
              //获取路径
              string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
               //遍历单个路径
                  foreach (string subdirectory in subdirectoryEntries)
                {
                 LoadFiles(subdirectory);
                   }

                } 
        //坐标信息的显示
        private void axMapControl1_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
       {
           //显示当前比例尺
       Coordinate.Text= "比例尺 1:" + ((long)this.axMapControl1.MapScale).ToString()+"  , 当前坐标X=" + e.mapX.ToString() + ",Y=" + e.mapY.ToString() + "," ;
       identifyDialog.OnMouseMove(e.mapX, e.mapY);
            //显示当前坐标信息
         
        }


        #endregion

        #region //设置与帮助

        private Uri url;
        private void btn_HelpDocument_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //url = new Uri("http://www.google.com"); //默认google
            //this.webBrowser1.Url = url;
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.baidu.com");
        }

        private void btn_About_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("北京穆图科技有限公司", "关于我们");
        }
        #endregion 
        //mapcontrol和pagelayerout挂链；
        private void axMapControl1_OnMapReplaced(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMapReplacedEvent e)
        {
            GISHandler.GISTools.copyToPageLayerOut(this.axMapControl1, axPageLayoutControl1);
        }
        //mapcontrol和pagelayerout挂链；
        private void axMapControl1_OnAfterScreenDraw(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnAfterScreenDrawEvent e)
        {
            GISHandler.GISTools.ScreenDraw(this.axMapControl1, axPageLayoutControl1);
            GISHandler.GISTools.copyToPageLayerOut(this.axMapControl1, axPageLayoutControl1);
        }
        //画线+测量
        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            //this.Cursor = Cursors.Default;
            if (e.button==1) //== MouseButtons.Left)
            {
                if (isMeasure)
                {
                    GISHandler.GISTools.CreatLine(this.axMapControl1);
                    isMeasure = false;
                }
                if (areaMeasure)
                {
                    GISHandler.GISTools.MeasureArea(this.axMapControl1);
                    areaMeasure = false;
                }
                if (attribute)
                {
                   // GISHandler.GISTools.IdentifyTool(this.axMapControl1);
                    if (identifyDialog.IsDisposed)
                    {
                        ShowIdentifyDialog();
                    }
                    identifyDialog.OnMouseDown(e.button, e.mapX, e.mapY);
                    
                    //attribute = false;
                }
                if (edit)
                {
                    Edit et = new Edit(this.axMapControl1);
                    et.Show();
                    et.TopMost = true;
                    edit = false;
                }
               
            }
            
            if (e.button == 2)
            {

                GISHandler.GISTools.setNull(this.axMapControl1);
                    //弹出右键菜单
                IMapControl3 m_mapControl = (IMapControl3)this.axMapControl1.Object;

                m_menuMap.PopupMenu(e.x, e.y, m_mapControl.hWnd);
              
            }
            
            
        }
        //保存
        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.Save(this.axMapControl1);

        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GISHandler.GISTools.refresh(this.axMapControl1);
           // GISHandler.GISTools.setNull(this.axMapControl1);
            attribute = false;
        }

        private void axTOCControl1_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {
            if (e.button != 2) return;
            esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
            IBasicMap map = null;
            ILayer layer = null;
            object other = null;
            object index = null;
            //判断所选菜单的类型
            axTOCControl1.HitTest(e.x, e.y, ref item, ref map, ref layer, ref other, ref index);
            //m_tocControl.HitTest(e.x, e.y, ref item, ref map, ref layer, ref other, ref index);
            //确定选定的菜单类型，Map或是图层菜单
            if (item == esriTOCControlItem.esriTOCControlItemMap)

                axTOCControl1.SelectItem(map, null);
            else if (item == esriTOCControlItem.esriTOCControlItemLayer)

                axTOCControl1.SelectItem(layer, null);
            else
                return;

            //设置CustomProperty为layer (用于自定义的Layer命令)  
            IMapControl3 m_mapControl = (IMapControl3)this.axMapControl1.Object;
            m_mapControl.CustomProperty = layer;
            //弹出右键菜单
            if (item == esriTOCControlItem.esriTOCControlItemMap)

                m_menuMap.PopupMenu(e.x, e.y, axTOCControl1.hWnd);

            if (item == esriTOCControlItem.esriTOCControlItemLayer)

                m_menuLayer.PopupMenu(e.x, e.y, axTOCControl1.hWnd);

        }

        private void axPageLayoutControl1_OnMouseDown(object sender, IPageLayoutControlEvents_OnMouseDownEvent e)
        {
            if (e.button == 1)
            {
             //   if()
             //GISHandler.GISTools.addNorthArrow(this.axPageLayoutControl1, axPageLayoutControl1.ActiveView.FocusMap);
            }
            if (e.button == 2)
            {
                IPageLayoutControl p_mapControl = (IPageLayoutControl)this.axPageLayoutControl1.Object;

                p_menuLayer.PopupMenu(e.x, e.y, p_mapControl.hWnd);
            }
        }

        private void axPageLayoutControl1_OnMouseMove(object sender, IPageLayoutControlEvents_OnMouseMoveEvent e)
        {
            labelControl1.Text = "当前坐标:X=" + e.pageX.ToString() + ",Y=" + e.pageY.ToString() + ",";
        }

        private void xtraTabControl_Center_Click(object sender, EventArgs e)
        {

            pagelayoutEdit pageTool = new pagelayoutEdit(this.axPageLayoutControl1, m_hookHelper);
            m_hookHelper.Hook = this.axMapControl1.Object;
            pageTool.Show();
            pageTool.TopMost=true;

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int intRowHandle = e.FocusedRowHandle;
            int FocusedRow_id;
   
           object rowIdObj = gridView1.GetRowCellValue(intRowHandle,"id");    
   
           if (DBNull.Value != rowIdObj)//做个判断否则获取不到id后报错    
           {    
               FocusedRow_id = Convert.ToInt32(rowIdObj); 
               MessageBox.Show(FocusedRow_id.ToString());
           }
           

        }

        private void axMapControl1_OnMouseUp(object sender, IMapControlEvents2_OnMouseUpEvent e)
        {
            identifyDialog.OnMouseUp(e.mapX, e.mapY);
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SystemSet set = new SystemSet();
            set.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form1 form = new Form1(this.axMapControl1);
            form.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UID uid = new UIDClass();
            uid.Value = "{40A9E885-5533-11d0-98BE-00805F7CED21}";
            FeatureLayer flayer=(FeatureLayer)axMapControl1.Map.get_Layer(0);
            IGeoFeatureLayer player=(IGeoFeatureLayer)flayer;
            GISHandler.GISTools.Annotation(player, axMapControl1.Map, "NAME", this.axMapControl1);
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            switch (select())
            {
                case "2015年7月25日采集坐标点":
                    axMapControl1.ClearLayers();
                    axMapControl1.AddShapeFile(@"G:\数据库\实验数据", "2015年7月25日采集坐标点");
                    break;
                case "2015年7月26日采集坐标点":
                    axMapControl1.ClearLayers();
                    axMapControl1.AddShapeFile(@"G:\数据库\实验数据", "2015年7月26日采集坐标点");
                    break;
                case "2015年7月27日采集坐标点":
                    axMapControl1.ClearLayers();
                    axMapControl1.AddShapeFile(@"G:\数据库\实验数据", "2015年7月27日采集坐标点");
                    break;
                case "矿区1":
                    axMapControl1.ClearLayers();
                    axMapControl1.AddShapeFile(@"G:\数据库\实验数据", "矿区1");
                    break;
                case "矿区2":
                    axMapControl1.ClearLayers();
                    axMapControl1.AddShapeFile(@"G:\数据库\实验数据", "矿区2");
                    break;
                case "矿区3":
                    axMapControl1.ClearLayers();
                    axMapControl1.AddShapeFile(@"G:\数据库\实验数据", "矿区3");
                    break;
                case "矿区4":
                    axMapControl1.ClearLayers();
                    axMapControl1.AddShapeFile(@"G:\数据库\实验数据", "矿区4");
                    break;
                case "模拟矿区坐标点":
                    axMapControl1.ClearLayers();
                    axMapControl1.AddShapeFile(@"G:\数据库\实验数据", "模拟矿区坐标点");
                    break;
                case "坐标点":
                    axMapControl1.ClearLayers();
                    axMapControl1.AddShapeFile(@"G:\数据库\实验数据", "坐标点");
                    break;
                default:
                    break;

            }
        }
        private string select()
        {
            int selectedHandle;
            selectedHandle = this.gridView1.GetSelectedRows()[0];
            return this.gridView1.GetRowCellValue(selectedHandle, "矿区坐标文件").ToString();
        }

        private void axMapControl1_OnDoubleClick(object sender, IMapControlEvents2_OnDoubleClickEvent e)
        {
            if (attribute)
            {
                attribute = false;
            }
        }

        private void axPageLayoutControl1_OnDoubleClick(object sender, IPageLayoutControlEvents_OnDoubleClickEvent e)
        {
            pagelayoutEdit pageTool = new pagelayoutEdit(this.axPageLayoutControl1, m_hookHelper);
            m_hookHelper.Hook = this.axMapControl1.Object;
            pageTool.Show();
            pageTool.TopMost = true;
        }

        private void ribbonControl1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void expandablePanel1_Click(object sender, EventArgs e)
        {

        }

        private void expandablePanel1_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (splitContainerControl1.SplitterPosition == 241)
                splitContainerControl1.SplitterPosition = 40;
            else
                splitContainerControl1.SplitterPosition = 241;
        }

      

        private void DataManage_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (splitContainerControl1.SplitterPosition == 241)
                splitContainerControl1.SplitterPosition = 40;
            else
                splitContainerControl1.SplitterPosition = 241;
        }
 
       
    }
}
