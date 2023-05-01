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
    public partial class RedactForm : Form
    {
        private Form1 _form1;
        ListViewItem _item = new ListViewItem();
        public RedactForm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            foreach (ListViewItem e in _form1.listView1.Items)
            {
                if (e.Text == _form1.listView1.SelectedItems[0].Text)
                {
                    _item = e;
                }
            }
            textBoxFIO.Text = _item.Text;
            textBoxMark.Text = _item.SubItems[1].Text;
            textBoxModel.Text = _item.SubItems[2].Text;
            textBoxSign.Text = _item.SubItems[3].Text;
            textBoxPlace.Text = _item.SubItems[4].Text;
            double parkingTime = (DateTime.Parse(_item.SubItems[7].Text) - DateTime.Parse(_item.SubItems[6].Text)).TotalHours;
            textBoxTime.Text = parkingTime.ToString();
        }

        private void buttonRedact_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Принять изменения?", "Редактирование", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _item.Text = textBoxFIO.Text;
                _item.SubItems[1].Text = textBoxMark.Text;
                _item.SubItems[2].Text = textBoxModel.Text;
                _item.SubItems[3].Text = textBoxSign.Text;
                _item.SubItems[4].Text = textBoxPlace.Text;
                Close();
            }
        }
    }
}
