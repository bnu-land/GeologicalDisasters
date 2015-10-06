namespace GeologicalDisasters
{
    partial class StasticResult
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.Export1 = new DevComponents.DotNetBar.ButtonX();
            this.topClass = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Heigh = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.Export2 = new DevComponents.DotNetBar.ButtonX();
            this.middleClass = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.middle = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.Export3 = new DevComponents.DotNetBar.ButtonX();
            this.bottomClass = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.low = new DevComponents.DotNetBar.TabItem(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.middleClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 305);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.Heigh);
            this.tabControl1.Tabs.Add(this.middle);
            this.tabControl1.Tabs.Add(this.low);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.Export1);
            this.tabControlPanel1.Controls.Add(this.topClass);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(620, 279);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.Heigh;
            // 
            // Export1
            // 
            this.Export1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Export1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Export1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Export1.Location = new System.Drawing.Point(520, 5);
            this.Export1.Name = "Export1";
            this.Export1.Size = new System.Drawing.Size(88, 23);
            this.Export1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Export1.TabIndex = 1;
            this.Export1.Text = "统计信息导出";
            this.Export1.Click += new System.EventHandler(this.Export1_Click);
            // 
            // topClass
            // 
            this.topClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.topClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topClass.Location = new System.Drawing.Point(1, 1);
            this.topClass.MainView = this.gridView1;
            this.topClass.Name = "topClass";
            this.topClass.Size = new System.Drawing.Size(618, 277);
            this.topClass.TabIndex = 0;
            this.topClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.GridControl = this.topClass;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // Heigh
            // 
            this.Heigh.AttachedControl = this.tabControlPanel1;
            this.Heigh.Name = "Heigh";
            this.Heigh.Text = "高影响区";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.Export2);
            this.tabControlPanel2.Controls.Add(this.middleClass);
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(620, 279);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.middle;
            // 
            // Export2
            // 
            this.Export2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Export2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Export2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Export2.Location = new System.Drawing.Point(523, 4);
            this.Export2.Name = "Export2";
            this.Export2.Size = new System.Drawing.Size(85, 23);
            this.Export2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Export2.TabIndex = 5;
            this.Export2.Text = "统计信息导出";
            this.Export2.Click += new System.EventHandler(this.Export2_Click);
            // 
            // middleClass
            // 
            this.middleClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.middleClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleClass.Location = new System.Drawing.Point(1, 1);
            this.middleClass.MainView = this.gridView2;
            this.middleClass.Name = "middleClass";
            this.middleClass.Size = new System.Drawing.Size(618, 277);
            this.middleClass.TabIndex = 0;
            this.middleClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.GridControl = this.middleClass;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // middle
            // 
            this.middle.AttachedControl = this.tabControlPanel2;
            this.middle.Name = "middle";
            this.middle.Text = "中影响区";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.Export3);
            this.tabControlPanel3.Controls.Add(this.bottomClass);
            this.tabControlPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(620, 279);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.low;
            // 
            // Export3
            // 
            this.Export3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Export3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Export3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Export3.Location = new System.Drawing.Point(521, 4);
            this.Export3.Name = "Export3";
            this.Export3.Size = new System.Drawing.Size(87, 23);
            this.Export3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Export3.TabIndex = 5;
            this.Export3.Text = "统计信息导出";
            this.Export3.Click += new System.EventHandler(this.Export3_Click);
            // 
            // bottomClass
            // 
            this.bottomClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.bottomClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomClass.Location = new System.Drawing.Point(1, 1);
            this.bottomClass.MainView = this.gridView3;
            this.bottomClass.Name = "bottomClass";
            this.bottomClass.Size = new System.Drawing.Size(618, 277);
            this.bottomClass.TabIndex = 0;
            this.bottomClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Row.Options.UseTextOptions = true;
            this.gridView3.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView3.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView3.GridControl = this.bottomClass;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            // 
            // low
            // 
            this.low.AttachedControl = this.tabControlPanel3;
            this.low.Name = "low";
            this.low.Text = "低影响区";
            // 
            // StasticResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 305);
            this.Controls.Add(this.tabControl1);
            this.Name = "StasticResult";
            this.Text = "统计信息结果";
            this.Load += new System.EventHandler(this.StasticResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.middleClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem low;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem middle;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem Heigh;
        private DevExpress.XtraGrid.GridControl topClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl bottomClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl middleClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevComponents.DotNetBar.ButtonX Export1;
        private DevComponents.DotNetBar.ButtonX Export3;
        private DevComponents.DotNetBar.ButtonX Export2;
    }
}