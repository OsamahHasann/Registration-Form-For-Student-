using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rigistrion_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string user_name;
        string password;
        string email;
        string id;
        string study_level;
        string gender;


        private void btn_submit_Click(object sender, EventArgs e)
        {
            user_name = lb_username.Text;
            password = lb_password.Text;
            email = lb_email.Text;
            id = lb_id.Text;
            study_level = lb_email.Text;
            gender = ro_mule.Text;

            if (!Regex.IsMatch(user_name, "\\w+\\s?\\w+(\\d)?"))
            {
                MessageBox.Show("User name is unvalidion");
                return;
            }
            if (!Regex.IsMatch(password, "^\\d{5,}$"))
            {
                MessageBox.Show("password is unvalidion");
                return;
            }

            if (!Regex.IsMatch(email, "\\w+\\d*?@\\w+.\\w"))
            {
                MessageBox.Show("email is unvalidion");
                return;
            }

            if (!Regex.IsMatch(id, "^\\d{8}"))
            {
                MessageBox.Show("id name is unvalidion");
                return;
            }

            if (!Regex.IsMatch(study_level, "\\w+"))
            {
                MessageBox.Show("study_level is unvalidion");
                return;
            }
            if (gender == null)
            {
                gender = "Female";
            }
            else
            {
                gender = "Mule";
            }
            
          
            show_data.Text = "User Name: "+user_name+"\n"
                             +"Email: " +email+"\n"
                             +"ID: "+id+"\n"
                             +"Gender: "+gender;

        }
    }
}
