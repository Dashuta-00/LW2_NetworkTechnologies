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
    public partial class Form1 : Form
    {
        public float COST_PER_HOUR = 75.5f;
        public List<Client> clients = new List<Client>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new AddForm(this).Show();
        }

        private void buttonFix_Click(object sender, EventArgs e)
        {
            new RedactForm(this).Show();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedIndices.Count > 0)
            {
                DialogResult result = MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) listView1.Items[listView1.SelectedIndices[0]].Remove(); 
            }
            else
            {
                MessageBox.Show("Нужно выбрать элемент!", "Ошибка!");
            }
        }
    }
}
