namespace Rigistrion_form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.show_data = new System.Windows.Forms.TextBox();
            this.ro_female = new System.Windows.Forms.RadioButton();
            this.ro_mule = new System.Windows.Forms.RadioButton();
            this.lb_stu_level = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_selected_color = new System.Windows.Forms.Label();
            this.btn_pick_color = new System.Windows.Forms.Button();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.lb_birth_day = new System.Windows.Forms.Label();
            this.cmb_country = new System.Windows.Forms.ComboBox();
            this.lb_country = new System.Windows.Forms.Label();
            this.pic_student = new System.Windows.Forms.PictureBox();
            this.btn__reset = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 29);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 432);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(556, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 432);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(34, 434);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 27);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MistyRose;
            this.panel5.Controls.Add(this.btn_load);
            this.panel5.Controls.Add(this.btn_save);
            this.panel5.Controls.Add(this.btn_upload);
            this.panel5.Controls.Add(this.btn__reset);
            this.panel5.Controls.Add(this.pic_student);
            this.panel5.Controls.Add(this.lb_country);
            this.panel5.Controls.Add(this.cmb_country);
            this.panel5.Controls.Add(this.lb_birth_day);
            this.panel5.Controls.Add(this.dtp_birthdate);
            this.panel5.Controls.Add(this.btn_pick_color);
            this.panel5.Controls.Add(this.lbl_selected_color);
            this.panel5.Controls.Add(this.btn_submit);
            this.panel5.Controls.Add(this.show_data);
            this.panel5.Controls.Add(this.ro_female);
            this.panel5.Controls.Add(this.ro_mule);
            this.panel5.Controls.Add(this.lb_stu_level);
            this.panel5.Controls.Add(this.lb_id);
            this.panel5.Controls.Add(this.lb_email);
            this.panel5.Controls.Add(this.lb_password);
            this.panel5.Controls.Add(this.lb_username);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(34, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 405);
            this.panel5.TabIndex = 4;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Peru;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Location = new System.Drawing.Point(13, 289);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // show_data
            // 
            this.show_data.Location = new System.Drawing.Point(10, 349);
            this.show_data.Multiline = true;
            this.show_data.Name = "show_data";
            this.show_data.Size = new System.Drawing.Size(500, 50);
            this.show_data.TabIndex = 13;
            this.show_data.Text = "empty, will be used to show results";
            // 
            // ro_female
            // 
            this.ro_female.AutoSize = true;
            this.ro_female.Location = new System.Drawing.Point(136, 172);
            this.ro_female.Name = "ro_female";
            this.ro_female.Size = new System.Drawing.Size(59, 17);
            this.ro_female.TabIndex = 12;
            this.ro_female.TabStop = true;
            this.ro_female.Text = "Female";
            this.ro_female.UseVisualStyleBackColor = true;
            // 
            // ro_mule
            // 
            this.ro_mule.AutoSize = true;
            this.ro_mule.Location = new System.Drawing.Point(69, 172);
            this.ro_mule.Name = "ro_mule";
            this.ro_mule.Size = new System.Drawing.Size(47, 17);
            this.ro_mule.TabIndex = 11;
            this.ro_mule.TabStop = true;
            this.ro_mule.Text = "Mule";
            this.ro_mule.UseVisualStyleBackColor = true;
            // 
            // lb_stu_level
            // 
            this.lb_stu_level.Location = new System.Drawing.Point(74, 137);
            this.lb_stu_level.Name = "lb_stu_level";
            this.lb_stu_level.Size = new System.Drawing.Size(121, 20);
            this.lb_stu_level.TabIndex = 10;
            // 
            // lb_id
            // 
            this.lb_id.Location = new System.Drawing.Point(74, 107);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(121, 20);
            this.lb_id.TabIndex = 9;
            // 
            // lb_email
            // 
            this.lb_email.Location = new System.Drawing.Point(74, 74);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(200, 20);
            this.lb_email.TabIndex = 8;
            // 
            // lb_password
            // 
            this.lb_password.Location = new System.Drawing.Point(74, 46);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(121, 20);
            this.lb_password.TabIndex = 7;
            // 
            // lb_username
            // 
            this.lb_username.AccessibleName = "user_name";
            this.lb_username.Location = new System.Drawing.Point(74, 19);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(200, 20);
            this.lb_username.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Study Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name ";
            // 
            // lbl_selected_color
            // 
            this.lbl_selected_color.AutoSize = true;
            this.lbl_selected_color.Location = new System.Drawing.Point(101, 211);
            this.lbl_selected_color.Name = "lbl_selected_color";
            this.lbl_selected_color.Size = new System.Drawing.Size(92, 13);
            this.lbl_selected_color.TabIndex = 15;
            this.lbl_selected_color.Text = "No Color Selected";
            // 
            // btn_pick_color
            // 
            this.btn_pick_color.Location = new System.Drawing.Point(11, 204);
            this.btn_pick_color.Name = "btn_pick_color";
            this.btn_pick_color.Size = new System.Drawing.Size(84, 23);
            this.btn_pick_color.TabIndex = 16;
            this.btn_pick_color.Text = "Choose Color";
            this.btn_pick_color.UseVisualStyleBackColor = true;
            this.btn_pick_color.Click += new System.EventHandler(this.btn_pick_color_Click);
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_birthdate.Location = new System.Drawing.Point(110, 232);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(105, 20);
            this.dtp_birthdate.TabIndex = 17;
            // 
            // lb_birth_day
            // 
            this.lb_birth_day.AutoSize = true;
            this.lb_birth_day.Location = new System.Drawing.Point(18, 239);
            this.lb_birth_day.Name = "lb_birth_day";
            this.lb_birth_day.Size = new System.Drawing.Size(55, 13);
            this.lb_birth_day.TabIndex = 18;
            this.lb_birth_day.Text = "Birth Date";
            // 
            // cmb_country
            // 
            this.cmb_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_country.FormattingEnabled = true;
            this.cmb_country.Items.AddRange(new object[] {
            "Yemen",
            "Egypt",
            "Oman",
            "Qatar",
            "Palestine",
            "Syria"});
            this.cmb_country.Location = new System.Drawing.Point(109, 261);
            this.cmb_country.Name = "cmb_country";
            this.cmb_country.Size = new System.Drawing.Size(121, 21);
            this.cmb_country.TabIndex = 19;
            // 
            // lb_country
            // 
            this.lb_country.AutoSize = true;
            this.lb_country.Location = new System.Drawing.Point(18, 264);
            this.lb_country.Name = "lb_country";
            this.lb_country.Size = new System.Drawing.Size(85, 13);
            this.lb_country.TabIndex = 20;
            this.lb_country.Text = "Choose Country";
            // 
            // pic_student
            // 
            this.pic_student.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_student.Location = new System.Drawing.Point(374, 7);
            this.pic_student.Name = "pic_student";
            this.pic_student.Size = new System.Drawing.Size(120, 120);
            this.pic_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_student.TabIndex = 21;
            this.pic_student.TabStop = false;
            // 
            // btn__reset
            // 
            this.btn__reset.BackColor = System.Drawing.Color.Khaki;
            this.btn__reset.Location = new System.Drawing.Point(104, 288);
            this.btn__reset.Name = "btn__reset";
            this.btn__reset.Size = new System.Drawing.Size(75, 24);
            this.btn__reset.TabIndex = 22;
            this.btn__reset.Text = "Reset";
            this.btn__reset.UseVisualStyleBackColor = false;
            this.btn__reset.Click += new System.EventHandler(this.btn__reset_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(374, 128);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(120, 30);
            this.btn_upload.TabIndex = 23;
            this.btn_upload.Text = "Upload Picture";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_save.Location = new System.Drawing.Point(13, 319);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 30);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "Save Data";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_load.Location = new System.Drawing.Point(119, 318);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(100, 30);
            this.btn_load.TabIndex = 25;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Registrion_form";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox show_data;
        private System.Windows.Forms.RadioButton ro_female;
        private System.Windows.Forms.RadioButton ro_mule;
        private System.Windows.Forms.TextBox lb_stu_level;
        private System.Windows.Forms.TextBox lb_id;
        private System.Windows.Forms.TextBox lb_email;
        private System.Windows.Forms.TextBox lb_password;
        private System.Windows.Forms.TextBox lb_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_country;
        private System.Windows.Forms.ComboBox cmb_country;
        private System.Windows.Forms.Label lb_birth_day;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.Button btn_pick_color;
        private System.Windows.Forms.Label lbl_selected_color;
        private System.Windows.Forms.PictureBox pic_student;
        private System.Windows.Forms.Button btn__reset;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
    }
}

