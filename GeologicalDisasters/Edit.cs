using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
namespace GeologicalDisasters
{
    public partial class Edit : Form
    {
        AxMapControl axMapcontrol = null;
        public Edit(AxMapControl  am)
        {
            this.axMapcontrol = am;
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            axToolbarControl1.SetBuddyControl(axMapcontrol);
        }
    }
}
