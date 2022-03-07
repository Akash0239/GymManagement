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
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }
        string fname, lname, mobile, email, address, gender, dob, joindate, position;

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxfname.Text = "";
            textBoxlname.Text = "";
            textBoxmobile.Text = "";
            //textBoxemail.Text = "";
            textBoxposition.Text = "";
            //textBoxaddress.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dateTimePickerdob.ResetText();
            dateTimePickerjoin.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                gender = radioButton1.Text;
            else
                gender = radioButton2.Text;
            fname = textBoxfname.Text.ToString();
            lname = textBoxlname.Text.ToString();
            dob = dateTimePickerdob.Text.ToString();
            mobile = textBoxmobile.Text.ToString();
            //email = textBoxemail.Text.ToString();
            joindate = dateTimePickerjoin.Text.ToString();
            position = textBoxposition.Text.ToString();
            //address = textBoxaddress.Text.ToString();
            Database.insertPerson("newstaff", fname, lname, gender, dob, mobile, "", joindate,"", "", "", position);
        }
    }
}
