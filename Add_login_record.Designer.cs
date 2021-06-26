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
            this.txt_payment = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.combox_doctor = new System.Windows.Forms.ComboBox();
            this.combox_room = new System.Windows.Forms.ComboBox();
            this.txt_place = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_numberpatient = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_payment);
            this.panel1.Controls.Add(this.txt_Notes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.combox_doctor);
            this.panel1.Controls.Add(this.combox_room);
            this.panel1.Controls.Add(this.txt_place);
            this.panel1.Controls.Add(this.txt_numberpatient);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // txt_payment
            // 
            this.txt_payment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_payment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_payment.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_payment.HintForeColor = System.Drawing.Color.Empty;
            this.txt_payment.HintText = "الدفعة الأولية";
            this.txt_payment.isPassword = false;
            this.txt_payment.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_payment.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_payment.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_payment.LineThickness = 4;
            this.txt_payment.Location = new System.Drawing.Point(525, 129);
            this.txt_payment.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_payment.Size = new System.Drawing.Size(220, 60);
            this.txt_payment.TabIndex = 45;
            this.txt_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_payment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_payment_KeyPress);
            // 
            // txt_Notes
            // 
            this.txt_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Notes.Location = new System.Drawing.Point(14, 264);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Notes.Size = new System.Drawing.Size(731, 74);
            this.txt_Notes.TabIndex = 44;
            this.txt_Notes.Text = "الملاحظات";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "الطبيب المشرف";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "الغرفة";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "تاريخ الدخولية";
            // 
            // combox_doctor
            // 
            this.combox_doctor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_doctor.BackColor = System.Drawing.Color.White;
            this.combox_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_doctor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_doctor.FormattingEnabled = true;
            this.combox_doctor.Location = new System.Drawing.Point(278, 162);
            this.combox_doctor.Name = "combox_doctor";
            this.combox_doctor.Size = new System.Drawing.Size(220, 27);
            this.combox_doctor.Sorted = true;
            this.combox_doctor.TabIndex = 38;
            // 
            // combox_room
            // 
            this.combox_room.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_room.BackColor = System.Drawing.Color.White;
            this.combox_room.DisplayMember = "roomid";
            this.combox_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_room.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_room.FormattingEnabled = true;
            this.combox_room.Location = new System.Drawing.Point(33, 162);
            this.combox_room.Name = "combox_room";
            this.combox_room.Size = new System.Drawing.Size(220, 27);
            this.combox_room.TabIndex = 37;
            this.combox_room.ValueMember = "roomid";
            // 
            // txt_place
            // 
            this.txt_place.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_place.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_place.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_place.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_place.HintForeColor = System.Drawing.Color.Empty;
            this.txt_place.HintText = "مكان الإقامة";
            this.txt_place.isPassword = false;
            this.txt_place.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_place.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_place.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_place.LineThickness = 4;
            this.txt_place.Location = new System.Drawing.Point(525, 30);
            this.txt_place.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_place.Name = "txt_place";
            this.txt_place.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_place.Size = new System.Drawing.Size(220, 60);
            this.txt_place.TabIndex = 26;
            this.txt_place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_numberpatient
            // 
            this.txt_numberpatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_numberpatient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_numberpatient.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numberpatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_numberpatient.HintForeColor = System.Drawing.Color.Empty;
            this.txt_numberpatient.HintText = "رقم المريض";
            this.txt_numberpatient.isPassword = false;
            this.txt_numberpatient.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_numberpatient.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_numberpatient.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_numberpatient.LineThickness = 4;
            this.txt_numberpatient.Location = new System.Drawing.Point(270, 30);
            this.txt_numberpatient.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_numberpatient.Name = "txt_numberpatient";
            this.txt_numberpatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_numberpatient.Size = new System.Drawing.Size(220, 60);
            this.txt_numberpatient.TabIndex = 24;
            this.txt_numberpatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_numberpatient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numberpatient_KeyPress);
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
            this.btn_add.Location = new System.Drawing.Point(279, 346);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(211, 66);
            this.btn_add.TabIndex = 22;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
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
            this.Load += new System.EventHandler(this.Add_login_record_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_place;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_numberpatient;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox combox_doctor;
        private System.Windows.Forms.ComboBox combox_room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Notes;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_payment;
    }
}