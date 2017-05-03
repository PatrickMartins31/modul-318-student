using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Swisstransport
{
    public partial class StandortsFahrplan : UserControl
    {
        public StandortsFahrplan()
        {
            InitializeComponent();
        }
        public ITransport _transporter = new Transport();

        private void CbStandort_TextUpdate(object sender, EventArgs e)
        {
            SearchStations(CbStandort);
        }
        private void SearchStations(ComboBox cb)
        {
            string query = cb.Text;

            if (query.Length >= 3)
            {
                Stations Stations = new Stations();
                Stations = _transporter.GetStations(query + ",");
                cb.Items.Clear();
                cb.SelectionStart = cb.Text.Length;
                cb.DroppedDown = true;
                foreach (Station Stat in Stations.StationList)
                {
                    cb.Items.Add(Stat);
                }
            }
        }

        private void StandortSucheBtn_Click(object sender, EventArgs e)
        {
            StationBoardRoot StationBoardRoot = new StationBoardRoot();
            StationBoardRoot = _transporter.GetStationBoard(CbStandort.Text, CbStandort.Text);
            foreach(StationBoard Station in StationBoardRoot.Entries)
            {
                DateTime departure = Convert.ToDateTime(Station.Stop.Departure);
                string departuretime = departure.ToShortTimeString();
                StandortsFahrplanListbox.Items.Add(Station.Name + '\t' + Station.To + " | " + Station.Stop.Departure);
            }
        }
    }
}
