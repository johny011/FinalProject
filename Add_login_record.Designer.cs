namespace Final_project
{
    partial class Add_login_record
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_login_record));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_place = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pation_NO = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_date_logout = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_date_login = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_number_recording = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.combox_section = new System.Windows.Forms.ComboBox();
            this.combox_room = new System.Windows.Forms.ComboBox();
            this.combox_doctor = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.combox_doctor);
            this.panel1.Controls.Add(this.combox_room);
            this.panel1.Controls.Add(this.combox_section);
            this.panel1.Controls.Add(this.txt_number_recording);
            this.panel1.Controls.Add(this.txt_place);
            this.panel1.Controls.Add(this.pation_NO);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txt_date_logout);
            this.panel1.Controls.Add(this.txt_date_login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // txt_place
            // 
            this.txt_place.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_place.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_place.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_place.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_place.HintForeColor = System.Drawing.Color.Empty;
            this.txt_place.HintText = "";
            this.txt_place.isPassword = false;
            this.txt_place.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_place.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_place.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_place.LineThickness = 4;
            this.txt_place.Location = new System.Drawing.Point(298, 14);
            this.txt_place.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_place.Name = "txt_place";
            this.txt_place.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_place.Size = new System.Drawing.Size(220, 60);
            this.txt_place.TabIndex = 26;
            this.txt_place.Text = "مكان الإقامة";
            this.txt_place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pation_NO
            // 
            this.pation_NO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pation_NO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pation_NO.Enabled = false;
            this.pation_NO.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pation_NO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pation_NO.HintForeColor = System.Drawing.Color.Empty;
            this.pation_NO.HintText = "";
            this.pation_NO.isPassword = false;
            this.pation_NO.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pation_NO.LineIdleColor = System.Drawing.Color.Gray;
            this.pation_NO.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pation_NO.LineThickness = 4;
            this.pation_NO.Location = new System.Drawing.Point(15, 14);
            this.pation_NO.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pation_NO.Name = "pation_NO";
            this.pation_NO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pation_NO.Size = new System.Drawing.Size(220, 60);
            this.pation_NO.TabIndex = 24;
            this.pation_NO.Text = "رقم المريض";
            this.pation_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.White;
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "إضافة";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.Black;
            this.btn_add.IdleLineColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(287, 345);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(211, 66);
            this.btn_add.TabIndex = 22;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_date_logout
            // 
            this.txt_date_logout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_date_logout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_date_logout.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_date_logout.HintForeColor = System.Drawing.Color.Empty;
            this.txt_date_logout.HintText = "";
            this.txt_date_logout.isPassword = false;
            this.txt_date_logout.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_date_logout.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_date_logout.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_date_logout.LineThickness = 4;
            this.txt_date_logout.Location = new System.Drawing.Point(298, 84);
            this.txt_date_logout.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_date_logout.Name = "txt_date_logout";
            this.txt_date_logout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_date_logout.Size = new System.Drawing.Size(220, 60);
            this.txt_date_logout.TabIndex = 19;
            this.txt_date_logout.Text = "تاريخ الخروج";
            this.txt_date_logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_date_login
            // 
            this.txt_date_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_date_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_date_login.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_date_login.HintForeColor = System.Drawing.Color.Empty;
            this.txt_date_login.HintText = "";
            this.txt_date_login.isPassword = false;
            this.txt_date_login.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_date_login.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_date_login.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_date_login.LineThickness = 4;
            this.txt_date_login.Location = new System.Drawing.Point(565, 84);
            this.txt_date_login.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_date_login.Name = "txt_date_login";
            this.txt_date_login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_date_login.Size = new System.Drawing.Size(220, 60);
            this.txt_date_login.TabIndex = 17;
            this.txt_date_login.Text = "تاريخ الدخول";
            this.txt_date_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txt_number_recording
            // 
            this.txt_number_recording.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_number_recording.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_number_recording.Enabled = false;
            this.txt_number_recording.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number_recording.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_number_recording.HintForeColor = System.Drawing.Color.Empty;
            this.txt_number_recording.HintText = "";
            this.txt_number_recording.isPassword = false;
            this.txt_number_recording.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_number_recording.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_number_recording.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_number_recording.LineThickness = 4;
            this.txt_number_recording.Location = new System.Drawing.Point(565, 14);
            this.txt_number_recording.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_number_recording.Name = "txt_number_recording";
            this.txt_number_recording.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_number_recording.Size = new System.Drawing.Size(220, 60);
            this.txt_number_recording.TabIndex = 27;
            this.txt_number_recording.Text = "رقم سجل الدخولية";
            this.txt_number_recording.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // combox_section
            // 
            this.combox_section.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_section.BackColor = System.Drawing.Color.White;
            this.combox_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_section.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_section.FormattingEnabled = true;
            this.combox_section.Location = new System.Drawing.Point(15, 117);
            this.combox_section.Name = "combox_section";
            this.combox_section.Size = new System.Drawing.Size(220, 27);
            this.combox_section.Sorted = true;
            this.combox_section.TabIndex = 36;
            // 
            // combox_room
            // 
            this.combox_room.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_room.BackColor = System.Drawing.Color.White;
            this.combox_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_room.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_room.FormattingEnabled = true;
            this.combox_room.Location = new System.Drawing.Point(298, 183);
            this.combox_room.Name = "combox_room";
            this.combox_room.Size = new System.Drawing.Size(220, 27);
            this.combox_room.Sorted = true;
            this.combox_room.TabIndex = 37;
            // 
            // combox_doctor
            // 
            this.combox_doctor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_doctor.BackColor = System.Drawing.Color.White;
            this.combox_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_doctor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_doctor.FormattingEnabled = true;
            this.combox_doctor.Location = new System.Drawing.Point(565, 183);
            this.combox_doctor.Name = "combox_doctor";
            this.combox_doctor.Size = new System.Drawing.Size(220, 27);
            this.combox_doctor.Sorted = true;
            this.combox_doctor.TabIndex = 38;
            // 
            // Add_login_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_login_record";
            this.Text = "Add_login_record";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_place;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pation_NO;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_date_logout;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_date_login;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_number_recording;
        private System.Windows.Forms.ComboBox combox_doctor;
        private System.Windows.Forms.ComboBox combox_room;
        private System.Windows.Forms.ComboBox combox_section;
    }
}