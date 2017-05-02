using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwisstransporterGUI
{
    public partial class Form1 : Form
    {
        Fahrplan Fahrplan = new Fahrplan();
        StandortsFahrplan StandortsFahrplan = new StandortsFahrplan();
        public Form1()
        {
            InitializeComponent();
            PanelFahrplan.Controls.Add(Fahrplan);
        }

        private void FahrplanBtn_Click(object sender, EventArgs e)
        {
            PanelFahrplan.Controls.Clear();
            PanelFahrplan.Controls.Add(Fahrplan);
        }

        private void StandortsFahrplanBtn_Click(object sender, EventArgs e)
        {
            PanelFahrplan.Controls.Clear();
            PanelFahrplan.Controls.Add(StandortsFahrplan);
        }
    }
}
