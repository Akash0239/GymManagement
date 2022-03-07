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
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
            DataTable dataTable = Database.show("newmember");
            dataGridView1.DataSource = dataTable;
        }
        string id, fname, lname;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                try
                {
                
                    id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                    fname = dataGridView1.SelectedRows[0].Cells["Fname"].Value.ToString();
                    lname = dataGridView1.SelectedRows[0].Cells["Lname"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete "+fname+" "+lname, "Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Database.deleteById("newmember", Int32.Parse(id));
                        this.Hide();
                        DeleteMember deleteMember = new DeleteMember();
                        deleteMember.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
