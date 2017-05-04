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
        public ITransport _transporter = new Transport();
        public StandortsFahrplan()
        {
            InitializeComponent();
        }
        
        private void CbStandort_TextUpdate(object sender, EventArgs e)
        {
            SearchStations(CbStandort);
        }
        /// <summary>
        /// Sucht die Station in der Combobox
        /// </summary>
        /// <param name="cb"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SFpE"></param>
        private void StandortsFahrplaEingaben(ListView StandortsFahrplanListView)
        {
            StationBoardRoot StationBoardRoot = new StationBoardRoot();
            StationBoardRoot = _transporter.GetStationBoard(CbStandort.Text, CbStandort.Text);
            if (StandortsFahrplanListView.Columns.Count == 0)
            {
                StandortsFahrplanListView.Columns.Add("", 0);
                StandortsFahrplanListView.Columns.Add("ÖV Bezeichnung", 110);
                StandortsFahrplanListView.Columns.Add("Nach", 110);
                StandortsFahrplanListView.Columns.Add("Abfahrtszeit", 110);
            }
            StandortsFahrplanListView.Items.Clear();
            foreach (StationBoard Station in StationBoardRoot.Entries)
            {
                DateTime departure = Convert.ToDateTime(Station.Stop.Departure);
                string departureTime = departure.ToShortTimeString();
                ListViewItem Item1 = new ListViewItem("");

                Item1.SubItems.Add(Station.Name);
                Item1.SubItems.Add(Station.To);
                Item1.SubItems.Add(departureTime);
                StandortsFahrplanListView.Items.Add(Item1);
                StandortsFahrplanListView.View = View.Details;
            }
        }

        private void StandortSucheBtn_Click(object sender, EventArgs e)
        {
            StandortsFahrplaEingaben(StandortsFahrplanListView);
            
        }
    }
}
