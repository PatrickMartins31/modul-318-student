﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swisstransport
{
    public partial class Form1 : Form
    {
        Fahrplan _Fahrplan = new Fahrplan();
        StandortsFahrplan _StandortsFahrplan = new StandortsFahrplan();
        public Form1()
        {
            InitializeComponent();
            PanelFahrplan.Controls.Add(_Fahrplan);
        }

        private void FahrplanBtn_Click(object sender, EventArgs e)
        {
            PanelFahrplan.Controls.Clear();
            PanelFahrplan.Controls.Add(_Fahrplan);
            
        }

        private void StandortsFahrplanBtn_Click(object sender, EventArgs e)
        {
            PanelFahrplan.Controls.Clear();
            PanelFahrplan.Controls.Add(_StandortsFahrplan);
            
        }

        private void PanelFahrplan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
