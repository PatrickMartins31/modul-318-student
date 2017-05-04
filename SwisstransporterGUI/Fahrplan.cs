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
    public partial class Fahrplan : UserControl
    {
        public Fahrplan()
        {
            InitializeComponent();
        }
        public ITransport _trans = new Transport();

        private void Fahrplan_Load(object sender, EventArgs e)
        {
            
        }

        private void CbAbfahrtsOrt_TextUpdate(object sender, EventArgs e)
        {
            SearchStations(CbAbfahrtsOrt);
        }
        /// <summary>
        /// Sucht Stationen in der ComboBox aber erst ab dem man 3 Buchstaben in die Combobox eingegeben hat.
        /// </summary>
        private void SearchStations(ComboBox cb)
        {
            string query = cb.Text;

            if (query.Length >= 3)
            {
                Stations Stations = new Stations();
                Stations = _trans.GetStations(query + ",");
                cb.Items.Clear();
                cb.SelectionStart = cb.Text.Length;
                cb.DroppedDown = true;
                foreach (Station Stat in Stations.StationList)
                {
                    cb.Items.Add(Stat);
                }
            }
        }

        private void CbAnkunftsort_TextUpdate(object sender, EventArgs e)
        {
            SearchStations(CbAnkunftsort);
        }
        /// <summary>
        /// Ist die Methode für den SearchBtn die dann die ListViewItems in die ListView einfügt.
        /// </summary>
        /// <param name="Fp"></param>
        public void FahrplanEingaben(ListView FahrplanListView)
        {
            Connections Connection = new Connections();
            string date ="&date=" + Datum.Value.Year + "-" + Datum.Value.Month + "-" + Datum.Value.Day;
            string time ="&time=" +Datum.Value.Hour + ":" + Datum.Value.Minute;
            Connection = _trans.GetConnections(CbAbfahrtsOrt.Text, CbAnkunftsort.Text, date, time);
            if (FahrplanListView.Columns.Count == 0)
            {
                FahrplanListView.Columns.Add("", 0);
                FahrplanListView.Columns.Add("From", 110);
                FahrplanListView.Columns.Add("To", 110);
                FahrplanListView.Columns.Add("Departure", 110);
                FahrplanListView.Columns.Add("Arrival", 110);
                FahrplanListView.Columns.Add("Duration", 110);
            }

            FahrplanListView.Items.Clear();
            foreach (Connection Connect in Connection.ConnectionList)
            {
                ListViewItem Item1 = new ListViewItem("");
                DateTime departure = Convert.ToDateTime(Connect.From.Departure);
                string departureTime = departure.ToShortTimeString();

                DateTime arrival = Convert.ToDateTime(Connect.To.Arrival);
                string arrivalTime = arrival.ToShortTimeString();

                string[] duration = Connect.Duration.Split('d')[1].Split(':');
                Item1.SubItems.Add(Connect.From.Station.Name);
                Item1.SubItems.Add(Connect.To.Station.Name);
                Item1.SubItems.Add(departureTime);
                Item1.SubItems.Add(arrivalTime);
                Item1.SubItems.Add(duration [0] + ":" + duration[1]);
                FahrplanListView.Items.Add(Item1);
                FahrplanListView.View = View.Details;
            }
        }

        private void SuchenBtn_Click(object sender, EventArgs e)
        {
            FahrplanEingaben(FahrplanListView);
        }
     
    }
}
