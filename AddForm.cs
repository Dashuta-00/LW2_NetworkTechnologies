using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР2
{
    public partial class AddForm : Form
    {
        private Client _client;
        private Form1 _form1;
        public AddForm(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            foreach (Client client in _form1.clients)
            {
                if (client.FIO == textBoxFIO.Text)
                {
                    textBoxMark.Enabled = false;
                    textBoxModel.Enabled = false;
                    textBoxSign.Enabled = false;
                    _client = client;
                    break;
                }
                else
                {
                    _client = new Client();
                    textBoxMark.Enabled = true;
                    textBoxModel.Enabled = true;
                    textBoxSign.Enabled = true;
                }
            }
        }

        private void Appeal(Client client)
        {
            Random rand = new Random();
            DateTime parkingTime = DateTime.Now.AddHours(-rand.Next(5, 100));
            int hours = Convert.ToInt32(textBoxTime.Text);
            DateTime departureTime = parkingTime.AddHours(hours);
            client.AddAppeal(new ParkingLotAppeal(parkingTime, departureTime, Convert.ToInt32(textBoxPlace.Text), hours * _form1.COST_PER_HOUR));
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Client c;
            if (_client == null || _client.FIO == null)
            {
                _form1.clients.Add(new Client(textBoxFIO.Text, textBoxMark.Text, textBoxModel.Text, textBoxSign.Text));
                Appeal(_form1.clients[_form1.clients.Count() - 1]);
                c = _form1.clients[_form1.clients.Count() - 1];
            }
            else
            {
                Appeal(_client);
                c = _client;
            }
            ListViewItem item = new ListViewItem(c.FIO);
            item.SubItems.Add(c.carMark);
            item.SubItems.Add(c.carModel);
            item.SubItems.Add(c.stateSign);
            item.SubItems.Add(c.appealHistory.Last().parkingPlace.ToString());
            item.SubItems.Add(c.appealHistory.Last().parkingCost.ToString());
            item.SubItems.Add(c.appealHistory.Last().parkingDate.ToString());
            item.SubItems.Add(c.appealHistory.Last().departureDate.ToString());
            DialogResult result = MessageBox.Show("Добавить?", "Добавление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _form1.listView1.Items.Add(item);
                Close();
            }
        }
    }
}
