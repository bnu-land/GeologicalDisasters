namespace GeologicalDisasters
{
    partial class Buffer
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOutputLayer = new System.Windows.Forms.Button();
            this.txtBufferDistance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.units = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBufferDistance2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBufferDistance3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboLayers = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLayers = new System.Windows.Forms.Label();
            this.CNunit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.unit2 = new DevComponents.Editors.ComboItem();
            this.unit1 = new DevComponents.Editors.ComboItem();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.CNunit);
            this.panelEx1.Controls.Add(this.lblLayers);
            this.panelEx1.Controls.Add(this.label5);
            this.panelEx1.Controls.Add(this.cboLayers);
            this.panelEx1.Controls.Add(this.txtBufferDistance3);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.txtBufferDistance2);
            this.panelEx1.Controls.Add(this.button1);
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.units);
            this.panelEx1.Controls.Add(this.txtOutputPath);
            this.panelEx1.Controls.Add(this.txtBufferDistance);
            this.panelEx1.Controls.Add(this.btnOutputLayer);
            this.panelEx1.Controls.Add(this.button2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(300, 268);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOutputLayer
            // 
            this.btnOutputLayer.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOutputLayer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOutputLayer.Location = new System.Drawing.Point(241, 131);
            this.btnOutputLayer.Name = "btnOutputLayer";
            this.btnOutputLayer.Size = new System.Drawing.Size(50, 22);
            this.btnOutputLayer.TabIndex = 10;
            this.btnOutputLayer.Text = "选择";
            this.btnOutputLayer.UseVisualStyleBackColor = true;
            this.btnOutputLayer.Click += new System.EventHandler(this.btnOutputLayer_Click);
            // 
            // txtBufferDistance
            // 
            // 
            // 
            // 
            this.txtBufferDistance.Border.Class = "TextBoxBorder";
            this.txtBufferDistance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBufferDistance.ButtonCustom.Tooltip = "";
            this.txtBufferDistance.ButtonCustom2.Tooltip = "";
            this.txtBufferDistance.Location = new System.Drawing.Point(79, 59);
            this.txtBufferDistance.Name = "txtBufferDistance";
            this.txtBufferDistance.PreventEnterBeep = true;
            this.txtBufferDistance.Size = new System.Drawing.Size(35, 21);
            this.txtBufferDistance.TabIndex = 15;
            this.txtBufferDistance.Text = "100";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(79, 132);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new System.Drawing.Size(153, 21);
            this.txtOutputPath.TabIndex = 9;
            // 
            // units
            // 
            this.units.AutoSize = true;
            this.units.Location = new System.Drawing.Point(31, 99);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(41, 12);
            this.units.TabIndex = 16;
            this.units.Text = "单位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "输出图层：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "高级";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始统计 ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBufferDistance2
            // 
            // 
            // 
            // 
            this.txtBufferDistance2.Border.Class = "TextBoxBorder";
            this.txtBufferDistance2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBufferDistance2.ButtonCustom.Tooltip = "";
            this.txtBufferDistance2.ButtonCustom2.Tooltip = "";
            this.txtBufferDistance2.Location = new System.Drawing.Point(138, 59);
            this.txtBufferDistance2.Name = "txtBufferDistance2";
            this.txtBufferDistance2.PreventEnterBeep = true;
            this.txtBufferDistance2.Size = new System.Drawing.Size(35, 21);
            this.txtBufferDistance2.TabIndex = 18;
            this.txtBufferDistance2.Text = "200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "中级";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "范围距离：";
            // 
            // txtBufferDistance3
            // 
            // 
            // 
            // 
            this.txtBufferDistance3.Border.Class = "TextBoxBorder";
            this.txtBufferDistance3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBufferDistance3.ButtonCustom.Tooltip = "";
            this.txtBufferDistance3.ButtonCustom2.Tooltip = "";
            this.txtBufferDistance3.Location = new System.Drawing.Point(201, 59);
            this.txtBufferDistance3.Name = "txtBufferDistance3";
            this.txtBufferDistance3.PreventEnterBeep = true;
            this.txtBufferDistance3.Size = new System.Drawing.Size(35, 21);
            this.txtBufferDistance3.TabIndex = 20;
            this.txtBufferDistance3.Text = "300";
            // 
            // cboLayers
            // 
            this.cboLayers.DisplayMember = "Text";
            this.cboLayers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLayers.FormattingEnabled = true;
            this.cboLayers.ItemHeight = 15;
            this.cboLayers.Location = new System.Drawing.Point(84, 15);
            this.cboLayers.Name = "cboLayers";
            this.cboLayers.Size = new System.Drawing.Size(157, 21);
            this.cboLayers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboLayers.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "低级";
            // 
            // lblLayers
            // 
            this.lblLayers.AutoSize = true;
            this.lblLayers.Location = new System.Drawing.Point(15, 24);
            this.lblLayers.Name = "lblLayers";
            this.lblLayers.Size = new System.Drawing.Size(65, 12);
            this.lblLayers.TabIndex = 3;
            this.lblLayers.Text = "选择图层：";
            // 
            // CNunit
            // 
            this.CNunit.DisplayMember = "Text";
            this.CNunit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CNunit.FormattingEnabled = true;
            this.CNunit.ItemHeight = 15;
            this.CNunit.Items.AddRange(new object[] {
            this.unit1,
            this.unit2});
            this.CNunit.Location = new System.Drawing.Point(78, 95);
            this.CNunit.Name = "CNunit";
            this.CNunit.Size = new System.Drawing.Size(157, 21);
            this.CNunit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CNunit.TabIndex = 22;
            // 
            // unit2
            // 
            this.unit2.Text = "千米";
            // 
            // unit1
            // 
            this.unit1.Text = "米";
            // 
            // Buffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 268);
            this.Controls.Add(this.panelEx1);
            this.Name = "Buffer";
            this.Text = "范围分析";
            this.Load += new System.EventHandler(this.Buffer_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CNunit;
        private DevComponents.Editors.ComboItem unit1;
        private DevComponents.Editors.ComboItem unit2;
        private System.Windows.Forms.Label lblLayers;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLayers;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBufferDistance3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBufferDistance2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label units;
        private System.Windows.Forms.TextBox txtOutputPath;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBufferDistance;
        private System.Windows.Forms.Button btnOutputLayer;
        private System.Windows.Forms.Button button2;

    }
}