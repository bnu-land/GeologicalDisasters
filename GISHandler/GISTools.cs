using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.ComponentModel;
using System.Data;
using System.Drawing;

using stdole;

using System.IO;

using System.Windows.Forms;
using DevExpress.XtraGrid;
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
using ESRI.ArcGIS.ConversionTools;
using ESRI.ArcGIS.Geoprocessor;     
namespace GISHandler
{

    public class GISTools
    {
        /// <summary>
        /// 设置当前工具为空
        /// </summary>
        /// <param name="axMapControl"></param>
        public static void setNull(ESRI.ArcGIS.Controls.AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            IMapControl2 mapControl = (IMapControl2)axMapControl.Object;
            mapControl.CurrentTool = null;
        }
        
        public static void Menu()
        {

          /* esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
            IBasicMap map = null;
            ILayer layer = null;
            object other = null;
            object index = null;
            //判断所选菜单的类型
          //m_tocControl.HitTest(e.x, e.y, ref item, ref map, ref layer, ref other, ref index);

            */
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        public static void AddData(ESRI.ArcGIS.Controls.AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsAddDataCommandClass();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
        }
        /// <summary>
        /// 放大
        /// </summary>
        public static void ZoomIn(ESRI.ArcGIS.Controls.AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsMapZoomInToolClass();
            pCommand.OnCreate(axMapControl.Object);
            axMapControl.CurrentTool = (ITool)pCommand;
        }
        /// <summary>
        /// 缩小
        /// </summary>
        public static void ZoomOut(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsMapZoomOutToolClass();
            pCommand.OnCreate(axMapControl.Object);
            axMapControl.CurrentTool = (ITool)pCommand;
        }
        /// <summary>
        /// 选择
        /// </summary>
        public static void Select(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsSelectToolClass();
            pCommand.OnCreate(axMapControl.Object);
            axMapControl.CurrentTool = (ITool)pCommand;
           
        }
        /// <summary>
        /// 全局
        /// </summary>
        public static void FullExtent(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsMapFullExtentCommandClass();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
        }
        //保存
        public static void Save(AxMapControl axMapControl)
        {
            DialogResult res = MessageBox.Show("是否保存当前地图?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                ICommand pCommand = new ControlsSaveAsDocCommandClass();
                if(axMapControl!=null)
                pCommand.OnCreate(axMapControl.Object);
               
                IMap map = new MapClass();
                map.Name = "Map";
                axMapControl.DocumentFilename = string.Empty;
                 pCommand.OnClick();

            }
            if (axMapControl == null)
            {
                return;
            }
        }

        /// <summary>
        /// 查询要素信息
        /// </summary>
        public static void IdentifyTool(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsMapIdentifyToolClass();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
            axMapControl.CurrentTool = (ITool)pCommand;
            

        }
        /// <summary>
        /// 编辑
        /// </summary>
        public static void startEdit(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand startEdit = new ControlsEditingStartCommandClass();
            ICommand pCommand= new ControlsEditingEditToolClass();
         
            startEdit.OnCreate(axMapControl.Object);
            startEdit.OnClick();
            pCommand.OnCreate(axMapControl.Object);
            axMapControl.CurrentTool = (ITool)pCommand;
        }
        /// <summary>
        /// 编辑工具
        /// </summary>
        public static void EditTool(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
           
            ICommand pCommand = new ControlsEditingEditToolClass();
            pCommand.OnCreate(axMapControl.Object);
            axMapControl.CurrentTool = (ITool)pCommand;
            
        }
        /// <summary>
        /// 保存编辑
        /// </summary>
        public static void saveEdit(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand saveEdit = new ControlsEditingSaveCommand();
            saveEdit.OnCreate(axMapControl.Object);
            saveEdit.OnClick();
        }
        /// <summary>
        /// 保存编辑
        /// </summary>
        public static void stopEdit(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand stopEdit = new ControlsEditingStopCommand();
            stopEdit.OnCreate(axMapControl.Object);
            stopEdit.OnClick();
        }
        /// <summary>
        /// 移动
        /// </summary>
        public static void Pan(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsMapPanToolClass();
            pCommand.OnCreate(axMapControl.Object);
            axMapControl.CurrentTool = (ITool)pCommand;
        }
        /// <summary>
        /// 比例放大
        /// </summary>
        public static void ZoomInFix(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsMapZoomInFixedCommand();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
        }
        /// <summary>
        /// 比例缩小
        /// </summary>
        public static void ZoomOutFix(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsMapZoomOutFixedCommand();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
        }
       
        /// <summary>
        /// 上一视图
        /// </summary>
        public static void MapForwardView(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
           ICommand pCommand;
            pCommand = new ControlsMapZoomToLastExtentBackCommandClass();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
        }
        /// <summary>
        /// 下一视图
        /// </summary>
        public static void MapNextView(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsMapZoomToLastExtentForwardCommand();

            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
           // pCommand=new ControlsEditingEditToolClass
        }
        /// <summary>
        /// 全屏显示
        /// </summary>
        public static void FullExtend(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ESRI.ArcGIS.Controls.ControlsMapFullExtentCommand();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
        }
        public static void refresh(AxMapControl axMapControl)
        {
            IGraphicsContainer pDeleteElements = axMapControl.ActiveView.FocusMap as IGraphicsContainer;
            pDeleteElements.DeleteAllElements();
            axMapControl.ActiveView.Refresh();
            GISHandler.GISTools.setNull(axMapControl);
            axMapControl.ActiveView.FocusMap.ClearSelection();
        }
        /// <summary>
        /// 选择
        /// </summary>
        
        public static void SelectFeature(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsSelectFeaturesToolClass();
            pCommand.OnCreate(axMapControl.Object);
            axMapControl.CurrentTool = (ITool)pCommand;
        }
        
        /// <summary>
        /// 关联mapcontril+pagelayerout
        /// </summary>
        #region 挂链控件
        public static void copyToPageLayerOut(AxMapControl axMapControl, AxPageLayoutControl axpageLayerOut)
        {
            IObjectCopy objectCopy = new ObjectCopyClass();
            object copyFromMap = axMapControl.Map;
            object copyMap = objectCopy.Copy(copyFromMap);
            object copyToMap = axpageLayerOut.ActiveView.FocusMap;
            objectCopy.Overwrite(copyMap, ref copyToMap);
        }
        public static void ScreenDraw(AxMapControl axMapControl, AxPageLayoutControl axpageLayerOut)
        {
            IActiveView activeView = (IActiveView)axpageLayerOut.ActiveView.FocusMap;
            IDisplayTransformation displayTransformation = activeView.ScreenDisplay.DisplayTransformation;
            displayTransformation.VisibleBounds = axMapControl.Extent;
            axpageLayerOut.ActiveView.Refresh();
         }
        #endregion
        /// <summary>
        /// 放大到选择对象
        /// </summary>
        public static void ZoomToFeatures(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsZoomToSelectedCommand();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
        }
        /// <summary>
        /// 清除选择
        /// </summary>
        public static void ClearSelect(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsClearSelectionCommand();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
        }
        //保存文档
        public static void SaveMxdFile(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsSaveAsDocCommandClass();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
        }

      
        //坐标画点
        public static void CreatPoint(AxMapControl axMapControl,double x,double y,int m)
        {
       
            //首先要实现容器接口
            IGraphicsContainer pGraphicsContainer = axMapControl.ActiveView as IGraphicsContainer;
            //pGraphicsContainer.DeleteAllElements();//清空容器里面所有的元素

            //设置点的坐标
            IPoint pPoint = new PointClass();
            pPoint.PutCoords(x, y);

            //IMarkerElement用来获得symbol属性
            IMarkerElement pMarkerElement = new MarkerElementClass();
            
            
            //用ISimpleMarkerSymbol来设置点的属性
            ISimpleMarkerSymbol pSymbol = new SimpleMarkerSymbolClass();
            IRgbColor pRGBcolor = new RgbColorClass();
            pRGBcolor.Red = 0;
            pRGBcolor.Green =220;
            pRGBcolor.Blue = 0;
           // pSymbol.Style = esriSimpleMarkerStyle.esriSMSCircle;
            pSymbol.Size = 5;
            pSymbol.Color = pRGBcolor;//绿色
            pSymbol.Style = esriSimpleMarkerStyle.esriSMSCross;
            pSymbol.Outline = false;
            
            pMarkerElement.Symbol = pSymbol;

            //IEnvelope envelop=new EnvelopeClass();
            pPoint.Envelope.SetEmpty();
            //IElement用来获得Geometry属性
            IElement pElement = pMarkerElement as IElement;
            //把IPoint转换为为IGeoMetry也能实现
            //IGeometry pGeometry = pPoint as IGeometry;
            //pElement.Geometry = pGeometry;
            //设置点的标签；
            ITextSymbol pTextSymbol = new TextSymbolClass();
            pTextSymbol.Size = 10;
            pTextSymbol.HorizontalAlignment = esriTextHorizontalAlignment.esriTHALeft;
            ITextElement texElement = new TextElementClass();
            texElement.Symbol = pTextSymbol;
            texElement.Text = m.ToString();
            IElement tElement = texElement as IElement;
            texElement.ScaleText = true;
            

            pElement.Geometry = pPoint;
            tElement.Geometry = pPoint;
            
            //在容器里添加元素
            pGraphicsContainer.AddElement(pElement, 0);
            pGraphicsContainer.AddElement(tElement, 0);
            pElement.Activate(axMapControl.ActiveView.ScreenDisplay);
          //tElement.Activate(axMapControl.ActiveView.ScreenDisplay);
            axMapControl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, pElement, null);
           // axMapControl.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, tElement, null);

        }
        //点成面
        public static void PointToPolygon(AxMapControl axMapControl, double x, double y,int m)
        {
            IPointCollection pCol = new PolygonClass(); 
            object missing = Type.Missing;
            for(int i=0;i<m;i++)
            {
              IPoint ppp=new PointClass();
              
              pCol.AddPoint(ppp, ref missing, ref missing);
            }


        }
        //将多边形添加
        public static IPolygon MergePolygons(IPolygon plygon1, IPolygon plygon2)
        {
            try
            {
                IGeometryCollection pGCollection1 = new PolygonClass();
                IGeometryCollection pGCollection2 = plygon1 as IGeometryCollection;
                IGeometryCollection pGCollection3 = plygon2 as IGeometryCollection;
                //添加多边形
                pGCollection1.AddGeometryCollection(pGCollection2);
                pGCollection1.AddGeometryCollection(pGCollection3);
                ITopologicalOperator pTopological = pGCollection1 as ITopologicalOperator;
                pTopological.Simplify();
                IPolygon pPolygon = pGCollection1 as IPolygon;
                return pPolygon;
            }
            catch(Exception Err)
            {
                return null;
            }
        }
       //查询
        public static void QueryByBuffer(AxMapControl axMapControl)
        {
           
           // IDataset data = null;
            ILayer layer = axMapControl.get_Layer(0);
            IFeatureLayer featureLayer = layer as IFeatureLayer;
            //获取featurelayer的featureClass
            IFeatureClass featureClass = featureLayer.FeatureClass;
            IFeature feature = null;
            IQueryFilter queryFilter = new QueryFilterClass();
            IFeatureCursor featureCursor;
            queryFilter.WhereClause = "NAME";
            featureCursor = featureClass.Search(queryFilter, true);
            feature = featureCursor.NextFeature();
            if (feature != null)
            {
                axMapControl.Map.SelectFeature(axMapControl.get_Layer(axMapControl.Map.LayerCount), feature);
                axMapControl.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null);
            }
            axMapControl.MousePointer = ESRI.ArcGIS.Controls.esriControlsMousePointer.esriPointerCrosshair; 
            IGeometry geometry = null;
            geometry = axMapControl.TrackPolygon();

            //geometry = axMapControl.get_Layer(axMapControl.Map.LayerCount - 1) as IGeometry;
            axMapControl.Map.SelectByShape(geometry, null, false);
            axMapControl.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null);

        }
        //coordinate 点坐标创建shp图层。
        public static void CreatePolygonFeatureclass(IPolygon pPolygon, string shpfolder, string shpname)
        {
            
            IWorkspaceFactory pWorkSpaceFac = new ShapefileWorkspaceFactoryClass();
            IFeatureWorkspace pFeatureWorkSpace = pWorkSpaceFac.OpenFromFile(shpfolder, 0) as IFeatureWorkspace;
            if (File.Exists(shpfolder+shpname))//如果shp存在则替换它。
            {
                if (MessageBox.Show("发现同名文件，是否覆盖源文件?", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    IFeatureClass featureclass = pFeatureWorkSpace.OpenFeatureClass(shpname);
                    IDataset pDataset = featureclass as IDataset;
                    pDataset.Delete();
                }
                else
                    return;
            }
            //创建字段集2
            IFeatureClassDescription fcDescription = new FeatureClassDescriptionClass();
            IObjectClassDescription ocDescription = (IObjectClassDescription)fcDescription;//创建必要字段
            IFields fields = ocDescription.RequiredFields;
            int shapeFieldIndex = fields.FindField(fcDescription.ShapeFieldName);
            IField field = fields.get_Field(shapeFieldIndex);
            IGeometryDef geometryDef = field.GeometryDef;
            IGeometryDefEdit geometryDefEdit = (IGeometryDefEdit)geometryDef;
            //geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPoint;
            //geometryDefEdit.SpatialReference_2 = spatialReference;

            geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolygon;
            ISpatialReferenceFactory pSpatialRefFac = new SpatialReferenceEnvironmentClass();
           // IProjectedCoordinateSystem pcsSys = pSpatialRefFac.CreateProjectedCoordinateSystem((int)esriSRProjCS4Type.esriSRProjCS_Xian1980_3_Degree_GK_Zone_39);
            IGeographicCoordinateSystem pcsSys = pSpatialRefFac.CreateGeographicCoordinateSystem(4490);
            geometryDefEdit.SpatialReference_2 = pcsSys;

            IFieldChecker fieldChecker = new FieldCheckerClass();
            IEnumFieldError enumFieldError = null;
            IFields validatedFields = null; //将传入字段 转成 validatedFields
            fieldChecker.ValidateWorkspace = (IWorkspace)pFeatureWorkSpace;
            fieldChecker.Validate(fields, out enumFieldError, out validatedFields);

            field = new FieldClass();
            IFieldsEdit pFieldsEdit = (IFieldsEdit)fields;
            IFieldEdit pFieldEdit = (IFieldEdit)field;
            pFieldEdit = (IFieldEdit)field;
            pFieldEdit.Name_2 = "面积";
            pFieldEdit.Type_2 = esriFieldType.esriFieldTypeDouble;
            pFieldsEdit.AddField(field);
            IArea s = pPolygon as IArea;
            double area = s.Area*100;
            double length=pPolygon.Length*100;
            MessageBox.Show("该区域面积为：" + Convert.ToDouble(area).ToString("0.000") + "平方公里（km2）" +"\r\n" + "边长为：" + Convert.ToDouble(length).ToString("0.000") + "千米（KM）");
            try
            {
                IFeatureClass pFeatureClass;
                //pFeatureClass = pFeatureWorkSpace.OpenFeatureClass(shpname);
                pFeatureClass = pFeatureWorkSpace.CreateFeatureClass(shpname, validatedFields, ocDescription.InstanceCLSID, ocDescription.ClassExtensionCLSID, esriFeatureType.esriFTSimple, fcDescription.ShapeFieldName, "");
                IFeature pFeature = pFeatureClass.CreateFeature();
                pFeature.Shape = pPolygon;
               // pFeature.set_Value(pFeature.Fields.FindField("面积"), area);
                pFeature.Store();
            }
            catch
            {
               // MessageBox.Show("存储失败！请检查目录下是否有同名文件···", "提示");
                //return;
            }
        
        }
        /// <summary>
        /// 创建多边形shp
        /// </summary>
        /// <param name="pPolygon"></param>
        /// <param name="shpPath"></param>
       
       public static void CreatePolygonFeatureClass(IPolygon pPolygon, string shpfolder, string shpname)
        {
            IWorkspaceFactory pWorkSpaceFac = new ShapefileWorkspaceFactoryClass();
            IWorkspaceEdit pWorkspaceEdit = (IWorkspaceEdit)pWorkSpaceFac;
            IFeatureWorkspace pFeatureWorkSpace = pWorkSpaceFac.OpenFromFile(shpfolder, 0) as IFeatureWorkspace;

            //创建字段集2
            IFeatureClassDescription fcDescription = new FeatureClassDescriptionClass();
            IObjectClassDescription ocDescription = (IObjectClassDescription)fcDescription;//创建必要字段
            IFields fields = ocDescription.RequiredFields;
            int shapeFieldIndex = fields.FindField(fcDescription.ShapeFieldName);
            IField field = fields.get_Field(shapeFieldIndex);
            IGeometryDef geometryDef = field.GeometryDef;
            IGeometryDefEdit geometryDefEdit = (IGeometryDefEdit)geometryDef;
            //geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPoint;
            //geometryDefEdit.SpatialReference_2 = spatialReference;
            geometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolygon;

         
            ISpatialReferenceFactory pSpatialRefFac = new SpatialReferenceEnvironmentClass();
            IProjectedCoordinateSystem pcsSys = pSpatialRefFac.CreateProjectedCoordinateSystem((int)esriSRProjCS4Type.esriSRProjCS_Xian1980_3_Degree_GK_Zone_39);
            geometryDefEdit.SpatialReference_2 = pcsSys;

            IFieldChecker fieldChecker = new FieldCheckerClass();
            IEnumFieldError enumFieldError = null;
            IFields validatedFields = null; //将传入字段 转成 validatedFields
            fieldChecker.ValidateWorkspace = (IWorkspace)pFeatureWorkSpace;
            fieldChecker.Validate(fields, out enumFieldError, out validatedFields);

            field = new FieldClass();
            IFieldsEdit pFieldsEdit = (IFieldsEdit)fields;
            IFieldEdit pFieldEdit = (IFieldEdit)field;
            pFieldEdit = (IFieldEdit)field;
            pFieldEdit.Name_2 = "面积";
            pFieldEdit.Type_2 = esriFieldType.esriFieldTypeDouble;
            pFieldsEdit.AddField(field);

            pWorkspaceEdit.StartEditOperation();
            IFeatureClass pFeatureClass = pFeatureWorkSpace.CreateFeatureClass(shpname, validatedFields, ocDescription.InstanceCLSID, ocDescription.ClassExtensionCLSID, esriFeatureType.esriFTSimple, fcDescription.ShapeFieldName, "");
            pPolygon = new PolygonClass();
            IArea s = pPolygon as IArea;
             double area = s.Area;
            IFeature pfeature = pFeatureClass.CreateFeature();
            pfeature.Shape = pPolygon;
            try
            {
                pfeature.set_Value(pfeature.Fields.FindField("面积"), area.ToString());
                pfeature.Store();
            }
            catch
            {
                MessageBox.Show(area.ToString());
            }
            pWorkspaceEdit.StopEditOperation();

        }
          
      
        
       /// <summary>
       /// 测量线
       /// </summary>
       /// <param name="axMapControl"></param>
        public static void CreatLine(AxMapControl axMapControl)
        {
            
            try
            {
                IActiveView pActiveView = axMapControl.ActiveView;
                IScreenDisplay screenDisplay = pActiveView.ScreenDisplay;
                ISimpleLineSymbol lineSymbol = new SimpleLineSymbolClass();
                IRgbColor rgbClolor = new RgbColorClass();
                lineSymbol.Width = 2;
                rgbClolor.Red = 255;
                lineSymbol.Color = rgbClolor;
                IPolyline pLine = axMapControl.TrackLine() as IPolyline;
                screenDisplay.StartDrawing(screenDisplay.hDC, (short)esriScreenCache.esriNoScreenCache);
                screenDisplay.SetSymbol((ISymbol)lineSymbol);
                screenDisplay.DrawPolyline(pLine);
                screenDisplay.FinishDrawing();
                double l = pLine.Length*100;
                //axMapControl.Map.MapUnits = esriUnits.esriKilometers;
                //DialogResult r =MessageBox.Show("长度为：" + l.ToString() + "公里（km）","长度测量结果");
                MessageBox.Show("长度为：" + Convert.ToDouble(l).ToString("0.000") + "千米（km）", "长度测量结果");
                IGraphicsContainer pDeletElement = axMapControl.ActiveView.FocusMap as IGraphicsContainer;
                pDeletElement.DeleteAllElements();
                axMapControl.ActiveView.Refresh();
                //screenDisplay.RemoveAllCaches();
                // typeof(AxMapControl).GetEvent("OnMouseDown").RemoveEventHandler(axMapControl,);            
            }
            catch
            {  }       
        }
        
        /// <summary>
        /// 面积测量
        /// </summary>
        /// <param name="axMapControl"></param>
        public static void MeasureArea(AxMapControl axMapControl)
        {
            IActiveView pActiveView = axMapControl.ActiveView;
            IScreenDisplay screenDisplay = pActiveView.ScreenDisplay;
            ISimpleLineSymbol lineSymbol = new SimpleLineSymbolClass();
            //ISimpleFillSymbol fillSymbol = new SimpleFillSymbolClass();
            //fillSymbol.Outline = lineSymbol;
            //fillSymbol.Style = esriSimpleFillStyle.esriSFSHollow;

            IRgbColor rgbClolor = new RgbColorClass();
            lineSymbol.Width = 2;
            rgbClolor.Red = 255;
            lineSymbol.Color = rgbClolor;
            axMapControl.Map.MapUnits = esriUnits.esriKilometers;
            IPolygon pGon = axMapControl.TrackPolygon() as IPolygon;
            screenDisplay.StartDrawing(screenDisplay.hDC, (short)esriScreenCache.esriNoScreenCache);
            screenDisplay.SetSymbol((ISymbol)lineSymbol);
            screenDisplay.DrawPolyline(pGon);
            screenDisplay.FinishDrawing();
            try
            {
                IArea pArea = pGon as IArea;
                double s = pArea.Area*10000;//
                MessageBox.Show("测量面积为：" + Convert.ToDouble(s).ToString("0.000") + "平方公里（km2）", "面积测量结果");
                IGraphicsContainer pDeletElement = axMapControl.ActiveView.FocusMap as IGraphicsContainer;
                pDeletElement.DeleteAllElements();
                axMapControl.ActiveView.Refresh();
            }
            catch
            {
                MessageBox.Show("无法测量面积！请正确画出测量区域···","提示");
            }
        }
        public static void AddLegend(AxPageLayoutControl pageLayoutControl)
        {

            try
            {
                IEnvelope pEnvelope = new EnvelopeClass();
                pEnvelope.PutCoords(0.2,0.2,5,5);
                IActiveView pActiveView = pageLayoutControl as IActiveView;
                IMap pMap = pActiveView.FocusMap;
                IGraphicsContainer pGraphicsContainer = pActiveView as IGraphicsContainer;
                IMapFrame pMapFram = pGraphicsContainer.FindFrame(pMap) as IMapFrame;
                IElement mapElement = pMapFram as IElement;
                IEnvelope mapEnv = mapElement.Geometry.Envelope;
                pEnvelope.PutCoords(mapEnv.XMin, mapEnv.YMin, mapEnv.XMin + 6.5, mapEnv.YMin + 0.8);
                UID pUID = new UID();
                pUID.Value = "{7A3F91E4-B9E3-11d1-8756-0000F8751720}";
                ISymbolBackground pSymbolBackground = new SymbolBackgroundClass();
                IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
                ILineSymbol pLineSymbol = new SimpleLineSymbolClass();
                pFillSymbol.Color = GetRgbColor(255, 255, 255);
                pLineSymbol.Color = GetRgbColor(255, 255, 255);
                pFillSymbol.Outline = pLineSymbol;
                pSymbolBackground.FillSymbol = pFillSymbol;
                IMapSurroundFrame pMapSurroundFrame = pMapFram.CreateSurroundFrame(pUID, null);
                pMapSurroundFrame.Background = pSymbolBackground;
                IElement pElement = pMapSurroundFrame as IElement;
                pElement.Geometry = pEnvelope;
                IMapSurround pMapSurround = pMapSurroundFrame.MapSurround;
                ILegend pLegend = pMapSurround as ILegend;
                pLegend.ClearItems();
                pLegend.Title = "图例";
                ITextSymbol pTextSymbol = new TextSymbolClass();
                pTextSymbol.Size = 10;
                pTextSymbol.HorizontalAlignment = esriTextHorizontalAlignment.esriTHALeft;
                ILegendItem pLegendItem = null;
                for (int i = 0; i < pActiveView.FocusMap.LayerCount; i++)
                {
                    ILayer pLayer = pActiveView.FocusMap.get_Layer(i);
                    if (pLayer is IFeatureLayer)
                    {
                        IFeatureLayer pFLayer = pLayer as IFeatureLayer;
                        IFeatureClass pFeatureClass = pFLayer.FeatureClass;
                        if (pFeatureClass.FeatureType == esriFeatureType.esriFTAnnotation)
                        {
                            continue;
                        }
                        else
                        {
                            pLegendItem = new HorizontalLegendItemClass();
                            pLegendItem.Layer = pLayer;
                            pLegendItem.Columns = 1;
                            pLegendItem.ShowDescriptions = false;
                            pLegendItem.ShowHeading = false;
                            pLegendItem.ShowLabels = true;
                            pLegendItem.LayerNameSymbol = pTextSymbol;
                            pLegend.AddItem(pLegendItem);
                        }
                    }
                }

            }
            catch(Exception Err)
            { }

        }

        private static IColor GetRgbColor(int p1, int p2, int p3)
        {
            IRgbColor pRGBcolor = new RgbColorClass();
            pRGBcolor.Red = p1;
            pRGBcolor.Green = p2;
            pRGBcolor.Blue = p3;
            return pRGBcolor;
        }

        
        /// <summary>
        /// 根据项目地图的不同，自定义全图工具
        /// </summary>
        /// <param name="axMapControl"></param>
        public static void FullExtentBySelfDefine(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            IEnvelope evp = new EnvelopeClass();
            evp.XMax = 138.197944;
            evp.XMin = 70.335832;
            evp.YMax = 14.680281;
            evp.YMin = 57.216853;
            axMapControl.ActiveView.Extent = evp;
            axMapControl.ActiveView.Refresh();
        }
        /// <summary>
        /// //输出当前地图为图片
        /// </summary>
        /// <param name="pActiveView"></param>
        /// <returns></returns>
        public static string ExportImage(IActiveView pActiveView)
        {
            if (pActiveView == null)
            {
                return null;
            }
            try
            {
                SaveFileDialog pSaveFileDialog = new SaveFileDialog();
                pSaveFileDialog.Filter = "JPEG(*.jpg)|*.jpg|AI(*.ai)|*.ai|BMP(*.BMP)|*.bmp|EMF(*.emf)|*.emf|GIF(*.gif)|*.gif|PDF(*.pdf)|*.pdf|PNG(*.png)|*.png|EPS(*.eps)|*.eps|SVG(*.svg)|*.svg|TIFF(*.tif)|*.tif";
                pSaveFileDialog.Title = "输出地图";
                pSaveFileDialog.RestoreDirectory = true;
                pSaveFileDialog.FilterIndex = 1;
                if (pSaveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return null;
                }
                string FileName = pSaveFileDialog.FileName;
                IExport pExporter = null;
                switch (pSaveFileDialog.FilterIndex)
                {
                    case 1:
                        pExporter = new ExportJPEGClass();
                        break;
                    case 2:
                        pExporter = new ExportBMPClass();
                        break;
                    case 3:
                        pExporter = new ExportEMFClass();
                        break;
                    case 4:
                        pExporter = new ExportGIFClass();
                        break;
                    case 5:
                        pExporter = new ExportAIClass();
                        break;
                    case 6:
                        pExporter = new ExportPDFClass();
                        break;
                    case 7:
                        pExporter = new ExportPNGClass();
                        break;
                    case 8:
                        pExporter = new ExportPSClass();
                        break;
                    case 9:
                        pExporter = new ExportSVGClass();
                        break;
                    case 10:
                        pExporter = new ExportTIFFClass();
                        break;
                    default:
                        MessageBox.Show("输出格式错误");
                        return null;
                }
                IEnvelope pEnvelope = new EnvelopeClass();
                ITrackCancel pTrackCancel = new CancelTrackerClass();
                tagRECT ptagRECT;
                ptagRECT = pActiveView.ScreenDisplay.DisplayTransformation.get_DeviceFrame();

                int pResolution = (int)(pActiveView.ScreenDisplay.DisplayTransformation.Resolution);

                pEnvelope.PutCoords(ptagRECT.left, ptagRECT.bottom, ptagRECT.right, ptagRECT.top);
                pExporter.Resolution = pResolution;
                pExporter.ExportFileName = FileName;
                pExporter.PixelBounds = pEnvelope;
                pActiveView.Output(pExporter.StartExporting(), pResolution, ref ptagRECT, pActiveView.Extent, pTrackCancel);
                pExporter.FinishExporting();
                //释放资源
                pSaveFileDialog.Dispose();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(pExporter);
                return FileName;
            }
            catch
            {
                return null;

            }
        }
       //public IFeatureLayer pFeaturelayer = new FeatureLayerClass();
        public static void cp(IPolygon pPolygon)
        {
            
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Shape文件（*.shp）|*.shp";
            saveFileDialog.Title = "新建面形shp文件";
            saveFileDialog.CheckFileExists = true;
            saveFileDialog.RestoreDirectory = true;
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            string shpPath;
            string shpName;
            IWorkspaceFactory pWorkSpaceFactory = new ShapefileWorkspaceFactory();
            if (dialogResult == DialogResult.OK)
            {
                IFeatureClass pFeatureClass;
                string date = DateTime.Now.ToLongDateString().ToString();
                //saveFileDialog.FileName = date + "采集的坐标点";
                string fileFullName = saveFileDialog.FileName;
                int index = fileFullName.LastIndexOf("\\");
                shpName = fileFullName.Substring(index + 1);
                shpPath = fileFullName.Substring(0, index);
                IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkSpaceFactory.OpenFromFile(shpPath, 0);
                IWorkspaceEdit pWorkspaceEdit = (IWorkspaceEdit)pFeatureWorkspace;
                IGeometryDef pGeometryDef = new GeometryDef();
                IGeometryDefEdit pGeometryDefEdit = pGeometryDef as IGeometryDefEdit;
                pGeometryDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPolygon;//点、线、面什么的
                



                ISpatialReferenceFactory2 ipSpaRefFa = new SpatialReferenceEnvironmentClass();
                IGeographicCoordinateSystem ipGeoCorSys = new GeographicCoordinateSystemClass();

                ipGeoCorSys = ipSpaRefFa.CreateGeographicCoordinateSystem((int)esriSRGeoCSType.esriSRGeoCS_WGS1984);
                ISpatialReference ipSpaRef = ipGeoCorSys;
                pGeometryDefEdit.SpatialReference_2 = ipSpaRef;


               

                /*if (System.IO.File.Exists(saveFileDialog.FileName))
                {
                    if (MessageBox.Show("是否替换原文件？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {

                        pFeatureClass = pFeatureWorkspace.OpenFeatureClass(shpName);
                        IDataset pDataset = (IDataset)pFeatureClass;
                        pDataset.Delete();
                    }
                    else
                        return;
                }
                else
                {
                    fileFullName = null;
                    return;
                }*/

                //设置字段

                double area;
                IFields pFields = new FieldsClass();
                IFieldsEdit pFieldsEdit = (IFieldsEdit)pFields;
                

                IField pField = new FieldClass();
                IFieldEdit pFieldEdit = (IFieldEdit)pField;
                pFieldEdit.Name_2 = "SHAPE";
                pFieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;
                pFieldEdit.GeometryDef_2 = pGeometryDef;
                pFieldsEdit.AddField(pField);

                pField = new FieldClass();
                pFieldEdit = (IFieldEdit)pField;
                pFieldEdit.Name_2 = "面积";
                pFieldEdit.Type_2 = esriFieldType.esriFieldTypeDouble;
                pFieldsEdit.AddField(pField);
                //创建shp
                pWorkspaceEdit.StartEditOperation();//启动编辑

                pFeatureClass = pFeatureWorkspace.CreateFeatureClass(shpName, pFields, null, null, esriFeatureType.esriFTSimple, "SHAPE", "");

                pPolygon = new PolygonClass();
                IArea s = pPolygon as IArea;
                area = s.Area;
                IFeature pfeature = pFeatureClass.CreateFeature();
                pfeature.Shape = pPolygon;
                pfeature.set_Value(pfeature.Fields.FindField("面积"), area.ToString());
                pfeature.Store();
                pWorkspaceEdit.StopEditOperation();
                IFeatureLayer pFeaturelayer = new FeatureLayerClass();
                pFeaturelayer.FeatureClass = pFeatureClass;
                pFeaturelayer.Name = "采集坐标图层";

            }
            
        }
        
        public static void AddScalebar(AxPageLayoutControl axpagelayoutcontrol, ESRI.ArcGIS.Carto.IMap map)
        {
            IPageLayout pageLayout;
            pageLayout = axpagelayoutcontrol.PageLayout;

            if (pageLayout == null || map == null)
            {
                return;
            }

            ESRI.ArcGIS.Geometry.IEnvelope envelope = new ESRI.ArcGIS.Geometry.EnvelopeClass();
            envelope.PutCoords(8, 3, 15, 3.8); // Specify the location and size of the scalebar
            ESRI.ArcGIS.esriSystem.IUID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = "esriCarto.AlternatingScaleBar";

            // Create a Surround. Set the geometry of the MapSurroundFrame to give it a location
            // Activate it and add it to the PageLayout's graphics container
            ESRI.ArcGIS.Carto.IGraphicsContainer graphicsContainer = pageLayout as ESRI.ArcGIS.Carto.IGraphicsContainer; // Dynamic Cast
            ESRI.ArcGIS.Carto.IActiveView activeView = pageLayout as ESRI.ArcGIS.Carto.IActiveView; // Dynamic Cast
            ESRI.ArcGIS.Carto.IFrameElement frameElement = graphicsContainer.FindFrame(map);
            ESRI.ArcGIS.Carto.IMapFrame mapFrame = frameElement as ESRI.ArcGIS.Carto.IMapFrame; // Dynamic Cast
            ESRI.ArcGIS.Carto.IMapSurroundFrame mapSurroundFrame = mapFrame.CreateSurroundFrame(uid as ESRI.ArcGIS.esriSystem.UID, null); // Dynamic Cast
            ESRI.ArcGIS.Carto.IElement element = mapSurroundFrame as ESRI.ArcGIS.Carto.IElement; // Dynamic Cast
            element.Geometry = envelope;
            element.Activate(activeView.ScreenDisplay);
            graphicsContainer.AddElement(element, 0);
            ESRI.ArcGIS.Carto.IMapSurround mapSurround = mapSurroundFrame.MapSurround;


            ESRI.ArcGIS.Carto.IScaleBar markerScaleBar = ((ESRI.ArcGIS.Carto.IScaleBar)(mapSurround));
            ITextSymbol scalbarsm = markerScaleBar.LabelSymbol;
            markerScaleBar.Units = esriUnits.esriKilometers;
            markerScaleBar.Name = "比例尺";
            markerScaleBar.Map = axpagelayoutcontrol.ActiveView.FocusMap;

            markerScaleBar.LabelPosition = ESRI.ArcGIS.Carto.esriVertPosEnum.esriTop;
            //markerScaleBar.UseMapSettings();
        }
        public static void AddNorthArrow(AxPageLayoutControl axpagelayoutcontrol, ESRI.ArcGIS.Carto.IMap map)
        {
           IPageLayout pageLayout;
           pageLayout = axpagelayoutcontrol.PageLayout;

            if (pageLayout == null || map == null)
            {
                return;
            }
            ESRI.ArcGIS.Geometry.IEnvelope envelope = new ESRI.ArcGIS.Geometry.EnvelopeClass();
            envelope.PutCoords(16, 24, 21, 29); //  Specify the location and size of the north arrow

            ESRI.ArcGIS.esriSystem.IUID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = "esriCarto.MarkerNorthArrow";

            // Create a Surround. Set the geometry of the MapSurroundFrame to give it a location
            // Activate it and add it to the PageLayout's graphics container
            ESRI.ArcGIS.Carto.IGraphicsContainer graphicsContainer = pageLayout as ESRI.ArcGIS.Carto.IGraphicsContainer; // Dynamic Cast
            ESRI.ArcGIS.Carto.IActiveView activeView = pageLayout as ESRI.ArcGIS.Carto.IActiveView; // Dynamic Cast
            ESRI.ArcGIS.Carto.IFrameElement frameElement = graphicsContainer.FindFrame(map);
            ESRI.ArcGIS.Carto.IMapFrame mapFrame = frameElement as ESRI.ArcGIS.Carto.IMapFrame; // Dynamic Cast
            ESRI.ArcGIS.Carto.IMapSurroundFrame mapSurroundFrame = mapFrame.CreateSurroundFrame(uid as ESRI.ArcGIS.esriSystem.UID, null); // Dynamic Cast
            ESRI.ArcGIS.Carto.IElement element = mapSurroundFrame as ESRI.ArcGIS.Carto.IElement; // Dynamic Cast
            element.Geometry = envelope;
            element.Activate(activeView.ScreenDisplay);
            graphicsContainer.AddElement(element, 0);
            ESRI.ArcGIS.Carto.IMapSurround mapSurround = mapSurroundFrame.MapSurround;

            // Change out the default north arrow
            ESRI.ArcGIS.Carto.IMarkerNorthArrow markerNorthArrow = mapSurround as ESRI.ArcGIS.Carto.IMarkerNorthArrow; // Dynamic Cast
            ESRI.ArcGIS.Display.IMarkerSymbol markerSymbol = markerNorthArrow.MarkerSymbol;
            ESRI.ArcGIS.Display.ICharacterMarkerSymbol characterMarkerSymbol = markerSymbol as ESRI.ArcGIS.Display.ICharacterMarkerSymbol; // Dynamic Cast
            characterMarkerSymbol.CharacterIndex = 202; // change the symbol for the North Arrow
            markerNorthArrow.MarkerSymbol = characterMarkerSymbol;
        }
        public static void AddTextElement(AxPageLayoutControl PageLayoutControl, double x, double y, string textName)
        {
            IPageLayout pPageLayout;
            IActiveView pAV;
            IGraphicsContainer pGraphicsContainer;
            IPoint pPoint;
            ITextElement pTextElement;
            IElement pElement;
            ITextSymbol pTextSymbol;
            IRgbColor pColor;
            pPageLayout = PageLayoutControl.PageLayout;
            pAV = (IActiveView)pPageLayout;
            pGraphicsContainer = (IGraphicsContainer)pPageLayout;
            pTextElement = new TextElementClass();

            IFontDisp pFont = new StdFontClass() as IFontDisp;
            pFont.Bold = true;
            pFont.Name = "宋体";
            pFont.Size = 26;

            pColor = new RgbColorClass();
            pColor.Red = 255;

            pTextSymbol = new TextSymbolClass();
            pTextSymbol.Color = (IColor)pColor;
            pTextSymbol.Font = pFont;

            pTextElement.Text = textName;
            pTextElement.Symbol = pTextSymbol;

            pPoint = new PointClass();
            pPoint.X = x;
            pPoint.Y = y;

            pElement = (IElement)pTextElement;
            pElement.Geometry = (IGeometry)pPoint;
            pGraphicsContainer.AddElement(pElement, 0);

            pAV.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }
        /// <summary>
        /// 为PageLayout对象添加图例对象
        /// </summary>
        /// <param name="pPageLayout">PageLayout对象</param>
        /// <param name="pEnvelope">图例添加的位置</param>
        public static void AddLegendToPageLayout(AxPageLayoutControl axpagelayoutcontrol, IEnvelope pEnvelope)
        {
            IPageLayout pageLayout;
            pageLayout = axpagelayoutcontrol.PageLayout;
            try
            {
                IActiveView pActiveView = pageLayout as IActiveView;
                IMap pMap = pActiveView.FocusMap;
                IGraphicsContainer pGraphicsContainer = pActiveView as IGraphicsContainer;
                IMapFrame pMapFrame = pGraphicsContainer.FindFrame(pMap) as IMapFrame;
                UID pUID = new UID();
                pUID.Value = "{7A3F91E4-B9E3-11d1-8756-0000F8751720}";
                ISymbolBackground pSymbolBackground = new SymbolBackgroundClass();
                IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
                ILineSymbol pLineSymbol = new SimpleLineSymbolClass();
                pFillSymbol.Color = GetRgbColor(255, 255, 255);
                pLineSymbol.Color = GetRgbColor(255, 255, 255);
                pFillSymbol.Outline = pLineSymbol;
                pSymbolBackground.FillSymbol = pFillSymbol;
                IMapSurroundFrame pMapSurroundFrame = pMapFrame.CreateSurroundFrame(pUID, null);
                pMapSurroundFrame.Background = pSymbolBackground;
                IElement pElement = pMapSurroundFrame as IElement;
                pElement.Geometry = pEnvelope;
                IMapSurround pMapSurround = pMapSurroundFrame.MapSurround;
                ILegend pLegend = pMapSurround as ILegend;
                pLegend.ClearItems();
                pLegend.Title = "图例";
                ITextSymbol pTextSymbol = new TextSymbolClass();
                pTextSymbol.Size = 10;
                pTextSymbol.HorizontalAlignment = esriTextHorizontalAlignment.esriTHALeft;
                ILegendItem pLegendItem = null;

                for (int i = 0; i < pActiveView.FocusMap.LayerCount; i++)
                {
                    ILayer pLayer = pActiveView.FocusMap.get_Layer(i);
                    if (pLayer is IFeatureLayer)
                    {
                        IFeatureLayer pFLayer = pLayer as IFeatureLayer;
                        IFeatureClass pFeatureClass = pFLayer.FeatureClass;
                        if (pFeatureClass.FeatureType == esriFeatureType.esriFTAnnotation)
                        {
                            continue;
                        }
                        else
                        {
                            pLegendItem = new HorizontalBarLegendItemClass();
                            pLegendItem.Layer = pLayer;
                            pLegendItem.Columns = 1;
                            pLegendItem.ShowDescriptions = false;
                            pLegendItem.ShowHeading = false;
                            pLegendItem.ShowLabels = true;
                            pLegendItem.LayerNameSymbol = pTextSymbol;
                            pLegend.AddItem(pLegendItem);
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("失败");
            }
        }
        ///<summary>Add a Legend to the Page Layout from the Map.</summary>
        ///
        ///<param name="pageLayout">An IPageLayout interface.</param>
        ///<param name="map">An IMap interface.</param>
        ///<param name="posX">A System.Double that is X coordinate value in page units for the start of the Legend. Example: 2.0</param>
        ///<param name="posY">A System.Double that is Y coordinate value in page units for the start of the Legend. Example: 2.0</param>
        ///<param name="legW">A System.Double that is length in page units of the Legend in both the X and Y direction. Example: 5.0</param>
        /// 
        ///<remarks></remarks>
        public static void Addlegend(AxPageLayoutControl axpageLayoutControl, ESRI.ArcGIS.Carto.IMap map, System.Double posX, System.Double posY, System.Double legW)
        {
            IPageLayout pageLayout;
            pageLayout = axpageLayoutControl.PageLayout;
            if (pageLayout == null || map == null)
            {
                return;
            }
            ESRI.ArcGIS.Carto.IGraphicsContainer graphicsContainer = pageLayout as ESRI.ArcGIS.Carto.IGraphicsContainer; // Dynamic Cast
            ESRI.ArcGIS.Carto.IMapFrame mapFrame = graphicsContainer.FindFrame(map) as ESRI.ArcGIS.Carto.IMapFrame; // Dynamic Cast
            ESRI.ArcGIS.esriSystem.IUID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = "esriCarto.Legend";
            ESRI.ArcGIS.Carto.IMapSurroundFrame mapSurroundFrame = mapFrame.CreateSurroundFrame((ESRI.ArcGIS.esriSystem.UID)uid, null); // Explicit Cast

            //Get aspect ratio
            ESRI.ArcGIS.Carto.IQuerySize querySize = mapSurroundFrame.MapSurround as ESRI.ArcGIS.Carto.IQuerySize; // Dynamic Cast
            System.Double w = 0;
            System.Double h = 0;
            querySize.QuerySize(ref w, ref h);
            System.Double aspectRatio = w / h;

            ESRI.ArcGIS.Geometry.IEnvelope envelope = new ESRI.ArcGIS.Geometry.EnvelopeClass();
            envelope.PutCoords(posX, posY, (posX * legW), (posY * legW / aspectRatio));
            ESRI.ArcGIS.Carto.IElement element = mapSurroundFrame as ESRI.ArcGIS.Carto.IElement; // Dynamic Cast
            element.Geometry = envelope;
            graphicsContainer.AddElement(element, 0);
        }
        //删除gridcontrol中 的记录
        public static void datagridviewdel_Dev(DevExpress.XtraGrid.Views.Grid.GridView Mydgv)
        {
            if (MessageBox.Show("你确定要删除选中的记录吗", "删除提示",MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2, 0, false) == DialogResult.Yes)
            {
                int iSelectRowCount = Mydgv.SelectedRowsCount;
                if (iSelectRowCount > 0)
                {
                    Mydgv.DeleteSelectedRows();
                }
            }
        }
        
        /// <summary>
        /// //标注
        /// </summary>
        /// <param name="pGeoFeatLyr"></param>
        /// <param name="pMap"></param>
        /// <param name="annoField">字段名称</param>
         public static  void Annotation(IGeoFeatureLayer pGeoFeatLyr, IMap pMap, string annoField,AxMapControl axMapControl1)
          {
              IAnnotateMap pAnnoMap=new AnnotateMapClass();
             //pAnnoMap = new MaplexAnnotateMapClass();
             pMap.AnnotationEngine = pAnnoMap;
             IGeoFeatureLayer pGeoFeatLayer;
             pGeoFeatLayer = pGeoFeatLyr;
             IAnnotateLayerPropertiesCollection pAnnoProps;
             pAnnoProps = pGeoFeatLyr.AnnotationProperties;
             pAnnoProps.Clear();
             ILabelEngineLayerProperties2 pLabelEngine2 = new MaplexLabelEngineLayerPropertiesClass();
             pLabelEngine2.Expression = "[" + annoField + "]";
            
             IMaplexOverposterLayerProperties pMaplexPro = new MaplexOverposterLayerPropertiesClass();
             pMaplexPro.FeatureType = esriBasicOverposterFeatureType.esriOverposterPolygon;
             pMaplexPro.PolygonPlacementMethod = esriMaplexPolygonPlacementMethod.esriMaplexHorizontalInPolygon;
             pMaplexPro.CanPlaceLabelOutsidePolygon = false;
             pMaplexPro.CanRemoveOverlappingLabel = false;
             pMaplexPro.RepeatLabel = false;
             pLabelEngine2.OverposterLayerProperties = pMaplexPro as IOverposterLayerProperties;
             IMapOverposter pMapPos = axMapControl1.Map as IMapOverposter;
             IOverposterProperties pOP = pMapPos.OverposterProperties;
             IMaplexOverposterProperties pMaplexOP = pOP as IMaplexOverposterProperties;
             pMaplexOP.LabelLargestPolygon = false;
             pAnnoProps.Add(pLabelEngine2 as IAnnotateLayerProperties);
             pGeoFeatLyr.DisplayAnnotation = true;
    
         }
         public static void ConverTool(IFeatureClass feature,string fold)
         {
             Geoprocessor gp = new Geoprocessor();
             gp.OverwriteOutput = true;
             ESRI.ArcGIS.ConversionTools.FeatureClassToShapefile Conver = new FeatureClassToShapefile();
             Conver.Input_Features=feature;
             Conver.Output_Folder = fold;
             gp.Execute(Conver, null);
         }
        #region 代码冗余
        /// <summary>
        /// 左移
        /// </summary>
        /* public static void PanLeft(AxMapControl axMapControl)
         {
             if (axMapControl == null)
             {
                 return;
             }
             ICommand pCommand;
             pCommand = new ControlsMapLeftCommand();
             pCommand.OnCreate(axMapControl.Object);
             pCommand.OnClick();
         }
         /// <summary>
         /// 右移
         /// </summary>
         public static void PanRight(AxMapControl axMapControl)
         {
             if (axMapControl == null)
             {
                 return;
             }
             ICommand pCommand;
             pCommand = new ControlsMapRightCommand();
             pCommand.OnCreate(axMapControl.Object);
             pCommand.OnClick();
         }
         /// <summary>
         /// 上移
         /// </summary>
         public static void PanUp(AxMapControl axMapControl)
         {
             if (axMapControl == null)
             {
                 return;
             }
             ICommand pCommand;
             pCommand = new ControlsMapUpCommand();
             pCommand.OnCreate(axMapControl.Object);
             pCommand.OnClick();
         }
         /// <summary>
         /// 下移
         /// </summary>
         public static void PanDown(AxMapControl axMapControl)
         {
             if (axMapControl == null)
             {
                 return;
             }
             ICommand pCommand;
             pCommand = new ControlsMapDownCommand();
             pCommand.OnCreate(axMapControl.Object);
             pCommand.OnClick();
         }
         /// <summary>
        /// 反选
        /// </summary>
        public static void SwitchSelection(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsSwitchSelectionCommand();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
        }
         /// <summary>
        /// 选择要素
        /// </summary>
        public static void SelectByGraphic(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsSelectToolClass();
            pCommand.OnCreate(axMapControl.Object);
            axMapControl.CurrentTool = (ITool)pCommand;
        }
        /// <summary>
        /// 全选
        /// </summary>
        public static void SelectAll(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsSelectAllCommandClass();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
            
        }
         //测量
           public static void MeasureLength(AxMapControl axMapControl)
        {
            if (axMapControl == null)
            {
                return;
            }
            ICommand pCommand;
            pCommand = new ControlsMapMeasureToolClass();
            pCommand.OnCreate(axMapControl.Object);
            pCommand.OnClick();
        }
         //缓冲分析
        public static void bufferAnalysis(AxMapControl axMapControl)
        {
            //ICommand pcmd=new 
        }
         * /
         /*
        /// <summary>
        /// 属性查询
        /// </summary>
        public void Identify(AxMapControl axMapControl, frmMain form)
        {
            IdentityService service = new IdentityService();
            service.FeatureIdentity(form, axMapControl);
        }
        /// <summary>
        /// 量测
        /// </summary>
        public void Measure(AxMapControl axMapControl, frmMain form)
        {
            IdentityService service = new IdentityService();
            service.Measure(form, axMapControl);
        }
         */
        /* /// <summary>
         /// 刷新
         /// </summary>
         public static void barRefresh(AxMapControl axMapControl)
         {
             IGraphicsContainer pDeleteElements = axMapControl.ActiveView.FocusMap as IGraphicsContainer;
             pDeleteElements.DeleteAllElements();
             axMapControl.ActiveView.Refresh();
         }

         /// <summary>
         /// 查询定位
         /// </summary>
         //public void FindAndLocate()
         //{
         //    Tools.frmFindAndLocate sf = new Tools.frmFindAndLocate();
         //    sf.ShowDialog();
         //}
 */
        #endregion
    }
}
