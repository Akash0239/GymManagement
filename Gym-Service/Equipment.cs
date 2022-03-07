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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        string equipname, description, muscle, delivery, cost;

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxequipmentname.Text = "";
            richTextBoxdescription.Text = "";
            textBoxmuscle.Text = "";
            textBoxcost.Text = "";
            dateTimePickerdeliver.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            equipname = textBoxequipmentname.Text.ToString();
            description = richTextBoxdescription.Text.ToString();
            muscle = textBoxmuscle.Text.ToString();
            delivery = dateTimePickerdeliver.Text.ToString();
            cost = textBoxcost.Text.ToString();
            Database.insertEquipment(equipname, description, muscle, delivery, cost);
        }
    }
}
