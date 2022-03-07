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
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }
         string fname,  lname,   mobile,   email,   address, gender, dob, joindate, gymtime, membership;

        private void button2_Click(object sender, EventArgs e)
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            comboBoxGymtime.Items.Clear();
            comboBoxGymtime.ResetText();
            comboBoxMembership.Items.Clear();
            comboBoxMembership.ResetText();
            dateTimePickerDOB.ResetText();
            dateTimePickerJoinDate.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool isChecked = radioButton1.Checked;
            if (isChecked)
                gender = radioButton1.Text;
            else
                gender = radioButton2.Text;
            fname = txtFname.Text.ToString();
            lname = txtLname.Text.ToString();
            dob = dateTimePickerDOB.Text.ToString();
            mobile = txtMobile.Text.ToString();
            email = txtEmail.Text.ToString();
            joindate = dateTimePickerJoinDate.Text.ToString();
            gymtime = comboBoxGymtime.Text.ToString();
            address = txtAddress.Text.ToString();
            membership = comboBoxMembership.Text.ToString();


            if (fname == "" || lname == "" || dob == "" || mobile == "" || email == "" || joindate == "" || address==""|| membership=="" || gender == "")
            {
                MessageBox.Show("One of the field is empty please fill up every field!!");
            }
            else
            {
                Database.insertPerson("newmember", fname, lname, gender, dob, mobile, email, joindate, gymtime, address, membership, "");
            }
            
        }
    }
}
