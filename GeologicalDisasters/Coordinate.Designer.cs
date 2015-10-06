namespace GeologicalDisasters
{
    partial class Coordinate
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.Editing = new DevComponents.DotNetBar.ButtonX();
            this.startEdit = new DevComponents.DotNetBar.ButtonItem();
            this.saveEdit = new DevComponents.DotNetBar.ButtonItem();
            this.stopEdit = new DevComponents.DotNetBar.ButtonItem();
            this.Close = new DevComponents.DotNetBar.ButtonX();
            this.SaveCoor = new DevComponents.DotNetBar.ButtonX();
            this.DrawLayer = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(542, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(590, 293);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Editing
            // 
            this.Editing.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Editing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editing.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Editing.Location = new System.Drawing.Point(328, 306);
            this.Editing.Name = "Editing";
            this.Editing.Size = new System.Drawing.Size(101, 23);
            this.Editing.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Editing.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.startEdit,
            this.saveEdit,
            this.stopEdit});
            this.Editing.TabIndex = 5;
            this.Editing.Text = "编辑";
            this.Editing.Click += new System.EventHandler(this.Editing_Click);
            // 
            // startEdit
            // 
            this.startEdit.GlobalItem = false;
            this.startEdit.Name = "startEdit";
            this.startEdit.Text = "开始编辑";
            this.startEdit.Click += new System.EventHandler(this.startEdit_Click);
            // 
            // saveEdit
            // 
            this.saveEdit.GlobalItem = false;
            this.saveEdit.Name = "saveEdit";
            this.saveEdit.Text = "保存编辑";
            this.saveEdit.Click += new System.EventHandler(this.saveEdit_Click);
            // 
            // stopEdit
            // 
            this.stopEdit.GlobalItem = false;
            this.stopEdit.Name = "stopEdit";
            this.stopEdit.Text = "停止编辑";
            this.stopEdit.Click += new System.EventHandler(this.stopEdit_Click);
            // 
            // Close
            // 
            this.Close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Close.Location = new System.Drawing.Point(467, 306);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(99, 23);
            this.Close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Close.TabIndex = 6;
            this.Close.Text = "关闭";
            this.Close.Click += new System.EventHandler(this.ThisFormClose_Click);
            // 
            // SaveCoor
            // 
            this.SaveCoor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SaveCoor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCoor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.SaveCoor.Location = new System.Drawing.Point(177, 306);
            this.SaveCoor.Name = "SaveCoor";
            this.SaveCoor.Size = new System.Drawing.Size(118, 23);
            this.SaveCoor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SaveCoor.TabIndex = 7;
            this.SaveCoor.Text = "保存坐标点";
            this.SaveCoor.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawLayer
            // 
            this.DrawLayer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DrawLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawLayer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.DrawLayer.Location = new System.Drawing.Point(31, 306);
            this.DrawLayer.Name = "DrawLayer";
            this.DrawLayer.Size = new System.Drawing.Size(118, 23);
            this.DrawLayer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DrawLayer.TabIndex = 8;
            this.DrawLayer.Text = "添加图层";
            this.DrawLayer.Click += new System.EventHandler(this.DrawLayer_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(590, 342);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 9;
            // 
            // Coordinate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 342);
            this.Controls.Add(this.DrawLayer);
            this.Controls.Add(this.SaveCoor);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Editing);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupPanel1);
            this.Name = "Coordinate";
            this.Text = "读取坐标信息";
            this.Load += new System.EventHandler(this.Coordinate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevComponents.DotNetBar.ButtonX Editing;
        private DevComponents.DotNetBar.ButtonItem startEdit;
        private DevComponents.DotNetBar.ButtonItem saveEdit;
        private DevComponents.DotNetBar.ButtonItem stopEdit;
        private DevComponents.DotNetBar.ButtonX Close;
        private DevComponents.DotNetBar.ButtonX SaveCoor;
        private DevComponents.DotNetBar.ButtonX DrawLayer;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;


    }
}