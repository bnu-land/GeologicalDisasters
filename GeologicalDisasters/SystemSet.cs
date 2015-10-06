using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeologicalDisasters
{
    public partial class SystemSet : Form
    {
        public SystemSet()
        {
            InitializeComponent();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SystemSet_Load(object sender, EventArgs e)
        {
            textBoxX1.Text = System.IO.Path.Combine(@"G:\数据库\坐标数据");
            textBoxX2.Text = System.IO.Path.Combine(@"G:\数据库\图层数据");
            textBoxX3.Text = System.IO.Path.Combine(@"G:\数据库\地图数据");
            textBoxX4.Text = System.IO.Path.Combine(@"G:\数据库\统计数据");
        }
        private void save(string type,string name,string title,TextBox textBox)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.CheckPathExists = true;
            saveDlg.Filter = type;// "shp文件 (*.shp)|*.shp";
            saveDlg.OverwritePrompt = true;
            saveDlg.Title = title;
            saveDlg.RestoreDirectory = true;
            saveDlg.FileName = name;

            DialogResult dr = saveDlg.ShowDialog();
            if (dr == DialogResult.OK)
                textBox.Text = saveDlg.FileName;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            save("文本文件 (*.txt)|*.txt", DateTime.Now.ToLongDateString(), "坐标输出", textBoxX1);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            save("shp文件 (*.shp)|*.shp", DateTime.Now.ToLongDateString(), "图层输出", textBoxX2);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            save("地图文件 (*.mxd)|*.mxd", DateTime.Now.ToLongDateString(), "地图输出", textBoxX3);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            save("表文件 (*.exl)|*.exl", DateTime.Now.ToLongDateString(), "统计输出", textBoxX4);
        }
    }
}
