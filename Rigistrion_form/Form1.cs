using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string birth_day;
        string color;
        string country;


        private void btn_submit_Click(object sender, EventArgs e)
        {
            user_name = lb_username.Text;
            password = lb_password.Text;
            email = lb_email.Text;
            id = lb_id.Text;
            study_level = lb_stu_level.Text;
            gender = ro_mule.Text;
            birth_day = dtp_birthdate.Value.ToShortDateString();
            color = lbl_selected_color.Text.Replace("Selected Color:","");
            country = cmb_country.SelectedItem?.ToString()??"not selected ";


            if (!Regex.IsMatch(user_name, "\\w+\\s?\\w+(\\d)?"))
            {
                MessageBox.Show("User name is unvalidion");
                return;
            }
            if (!Regex.IsMatch(password, "^\\d{6,}$"))
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
            if (cmb_country.SelectedItem == null)
            {
                MessageBox.Show("Pleas choose country!");
                return;
            }
            if (lbl_selected_color.Text == "No Color Selected")
            {
                MessageBox.Show("Pleas choose favorite color!");
            }

            show_data.Text = $"User Name: {user_name}\nEmail: {email}\nPassword: {lb_password}\nID: {id}\nGender: {gender}\nstudy level: {lb_stu_level}" +
                $"Birth day: {birth_day}\n Country: {country}\nFavorite Color: {color}";

        }

        private void btn_pick_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lbl_selected_color.Text = $"Selected color: {colorDialog.Color.Name}";
            }
        }

        private void btn__reset_Click(object sender, EventArgs e)
        {
            lb_username.Text = "";
            lb_password.Text = "";
            lb_email.Text = "";
            lb_id.Text = "";
            lb_stu_level.Text = "";
            ro_mule.Checked = false;
            ro_female.Checked = false;
            cmb_country.SelectedIndex = -1;
            dtp_birthdate.Value = DateTime.Now;
            lbl_selected_color.Text = "No Color Selected";
            show_data.Text = "";
            pic_student.Image = null;
            lb_username.Focus();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image.File|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_student.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string data = $"User Name: {user_name}\nEmail: {email}\nPassword: {lb_password}\nID: {id}\nGender: {gender}\nstudy level: {lb_stu_level}" +
                $"Birth day: {birth_day}\n Country: {country}\nFavorite Color: {color}"; ;

            File.WriteAllText("student_data.txt",data);
            if(pic_student.Image != null)
            {
                pic_student.Image.Save("student_picture.jpg");
            }
            MessageBox.Show("Data saved succssfully! ");
        }

        private DateTimePicker GetDtp_birthdate()
        {
            return dtp_birthdate;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (!File.Exists("student_data.txt"))
            {
                MessageBox.Show("No saved data Found");
                return;
            }
            string[] lines = File.ReadAllLines("student_data.txt");
           /* if(lines.Length < 9)
            {
                MessageBox.Show("saved data in complate!");
                return ;
            }*/

            lb_username.Text = lines[0];
            lb_email.Text = lines[1];
            lb_password.Text = lines[2];
            lb_id.Text = lines[3];
            if (lines[4]=="Mule") ro_mule.Checked = true;
            else ro_female.Checked = true;
           
            lb_stu_level.Text = lines[5];
            dtp_birthdate.Value = DateTime.Parse(lines[6]);
            cmb_country.SelectedItem = lines[7];
            lbl_selected_color.Text = "Selected Color: "+lines[8];
            if (File.Exists("student_picture.jpg") && lines[9] == "student_picture.jpg")
            {
                pic_student.Image = Image.FromFile("student_picture.jpg");
            }
            else
            {
                pic_student.Image = null;
            }
        }
    }
}
