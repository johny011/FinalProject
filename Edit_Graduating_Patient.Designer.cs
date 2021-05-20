namespace Final_project
{
    partial class Edit_Graduating_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Graduating_Patient));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_graduating = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_payment = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.combox_doctor = new System.Windows.Forms.ComboBox();
            this.combox_room = new System.Windows.Forms.ComboBox();
            this.txt_place = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_numberpatient = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.editRadio = new System.Windows.Forms.RadioButton();
            this.GraduatingRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
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
            this.btn_add.ButtonText = "تعديل";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.Black;
            this.btn_add.IdleLineColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(243, 361);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(220, 66);
            this.btn_add.TabIndex = 26;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_graduating
            // 
            this.btn_graduating.ActiveBorderThickness = 1;
            this.btn_graduating.ActiveCornerRadius = 20;
            this.btn_graduating.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_graduating.ActiveForecolor = System.Drawing.Color.White;
            this.btn_graduating.ActiveLineColor = System.Drawing.Color.White;
            this.btn_graduating.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_graduating.BackColor = System.Drawing.SystemColors.Control;
            this.btn_graduating.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_graduating.BackgroundImage")));
            this.btn_graduating.ButtonText = "تخريج";
            this.btn_graduating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_graduating.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_graduating.ForeColor = System.Drawing.Color.Black;
            this.btn_graduating.IdleBorderThickness = 1;
            this.btn_graduating.IdleCornerRadius = 20;
            this.btn_graduating.IdleFillColor = System.Drawing.Color.White;
            this.btn_graduating.IdleForecolor = System.Drawing.Color.Black;
            this.btn_graduating.IdleLineColor = System.Drawing.Color.Black;
            this.btn_graduating.Location = new System.Drawing.Point(13, 361);
            this.btn_graduating.Margin = new System.Windows.Forms.Padding(5);
            this.btn_graduating.Name = "btn_graduating";
            this.btn_graduating.Size = new System.Drawing.Size(220, 66);
            this.btn_graduating.TabIndex = 27;
            this.btn_graduating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_graduating.Click += new System.EventHandler(this.btn_graduating_Click);
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
            this.txt_payment.Location = new System.Drawing.Point(536, 198);
            this.txt_payment.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_payment.Size = new System.Drawing.Size(220, 60);
            this.txt_payment.TabIndex = 54;
            this.txt_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "الطبيب المشرف";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "الغرفة";
            // 
            // dateIn
            // 
            this.dateIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateIn.CustomFormat = "dd/MM/yyyy";
            this.dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateIn.Location = new System.Drawing.Point(44, 139);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(200, 20);
            this.dateIn.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "تاريخ الدخولية";
            // 
            // combox_doctor
            // 
            this.combox_doctor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_doctor.BackColor = System.Drawing.Color.White;
            this.combox_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_doctor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_doctor.FormattingEnabled = true;
            this.combox_doctor.Location = new System.Drawing.Point(289, 231);
            this.combox_doctor.Name = "combox_doctor";
            this.combox_doctor.Size = new System.Drawing.Size(220, 27);
            this.combox_doctor.Sorted = true;
            this.combox_doctor.TabIndex = 49;
            // 
            // combox_room
            // 
            this.combox_room.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_room.BackColor = System.Drawing.Color.White;
            this.combox_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_room.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_room.FormattingEnabled = true;
            this.combox_room.Location = new System.Drawing.Point(44, 231);
            this.combox_room.Name = "combox_room";
            this.combox_room.Size = new System.Drawing.Size(220, 27);
            this.combox_room.Sorted = true;
            this.combox_room.TabIndex = 48;
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
            this.txt_place.Location = new System.Drawing.Point(536, 99);
            this.txt_place.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_place.Name = "txt_place";
            this.txt_place.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_place.Size = new System.Drawing.Size(220, 60);
            this.txt_place.TabIndex = 47;
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
            this.txt_numberpatient.Location = new System.Drawing.Point(281, 99);
            this.txt_numberpatient.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_numberpatient.Name = "txt_numberpatient";
            this.txt_numberpatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_numberpatient.Size = new System.Drawing.Size(220, 60);
            this.txt_numberpatient.TabIndex = 46;
            this.txt_numberpatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateOut
            // 
            this.dateOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateOut.CustomFormat = "dd/MM/yyyy";
            this.dateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOut.Location = new System.Drawing.Point(554, 318);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(200, 20);
            this.dateOut.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(660, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "تاريخ الخروج";
            // 
            // editRadio
            // 
            this.editRadio.AutoSize = true;
            this.editRadio.Checked = true;
            this.editRadio.Location = new System.Drawing.Point(241, 336);
            this.editRadio.Name = "editRadio";
            this.editRadio.Size = new System.Drawing.Size(51, 17);
            this.editRadio.TabIndex = 57;
            this.editRadio.Text = "تعديل";
            this.editRadio.UseVisualStyleBackColor = true;
            // 
            // GraduatingRadio
            // 
            this.GraduatingRadio.AutoSize = true;
            this.GraduatingRadio.Location = new System.Drawing.Point(351, 336);
            this.GraduatingRadio.Name = "GraduatingRadio";
            this.GraduatingRadio.Size = new System.Drawing.Size(51, 17);
            this.GraduatingRadio.TabIndex = 58;
            this.GraduatingRadio.Text = "تخريج";
            this.GraduatingRadio.UseVisualStyleBackColor = true;
            this.GraduatingRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Edit_Graduating_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GraduatingRadio);
            this.Controls.Add(this.editRadio);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combox_doctor);
            this.Controls.Add(this.combox_room);
            this.Controls.Add(this.txt_place);
            this.Controls.Add(this.txt_numberpatient);
            this.Controls.Add(this.btn_graduating);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_Graduating_Patient";
            this.Text = "Edit_Graduating_Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_graduating;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_payment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combox_doctor;
        private System.Windows.Forms.ComboBox combox_room;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_place;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_numberpatient;
        private System.Windows.Forms.RadioButton editRadio;
        private System.Windows.Forms.RadioButton GraduatingRadio;
    }
}