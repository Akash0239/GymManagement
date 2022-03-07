using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Service
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
            DataTable dataTable = Database.show("newmember");
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBox1.Text);

            DataTable dataTable = Database.searchById("newmember",id);
            dataGridView1.DataSource = dataTable;

        }
    }
}
