namespace Final_project
{
    partial class Add_pation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_pation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_place = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_NO_number = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_father_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_mother_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txt_place);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txt_NO_number);
            this.panel1.Controls.Add(this.txt_father_name);
            this.panel1.Controls.Add(this.txt_mother_name);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(627, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "تاريخ الميلاد";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(553, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
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
            this.txt_place.Location = new System.Drawing.Point(6, 98);
            this.txt_place.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_place.Name = "txt_place";
            this.txt_place.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_place.Size = new System.Drawing.Size(220, 60);
            this.txt_place.TabIndex = 26;
            this.txt_place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btn_add.Location = new System.Drawing.Point(278, 300);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(211, 66);
            this.btn_add.TabIndex = 22;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_NO_number
            // 
            this.txt_NO_number.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_NO_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NO_number.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NO_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NO_number.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NO_number.HintText = "الرقم الوطني";
            this.txt_NO_number.isPassword = false;
            this.txt_NO_number.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_NO_number.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NO_number.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_NO_number.LineThickness = 4;
            this.txt_NO_number.Location = new System.Drawing.Point(279, 98);
            this.txt_NO_number.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_NO_number.Name = "txt_NO_number";
            this.txt_NO_number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NO_number.Size = new System.Drawing.Size(220, 60);
            this.txt_NO_number.TabIndex = 20;
            this.txt_NO_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NO_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NO_number_KeyPress);
            // 
            // txt_father_name
            // 
            this.txt_father_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_father_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_father_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_father_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_father_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_father_name.HintText = "اسم الأب";
            this.txt_father_name.isPassword = false;
            this.txt_father_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_father_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_father_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_father_name.LineThickness = 4;
            this.txt_father_name.Location = new System.Drawing.Point(278, 13);
            this.txt_father_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_father_name.Name = "txt_father_name";
            this.txt_father_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_father_name.Size = new System.Drawing.Size(220, 60);
            this.txt_father_name.TabIndex = 19;
            this.txt_father_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mother_name
            // 
            this.txt_mother_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mother_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mother_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mother_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mother_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_mother_name.HintText = "اسم الأم";
            this.txt_mother_name.isPassword = false;
            this.txt_mother_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_mother_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_mother_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_mother_name.LineThickness = 4;
            this.txt_mother_name.Location = new System.Drawing.Point(6, 13);
            this.txt_mother_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_mother_name.Name = "txt_mother_name";
            this.txt_mother_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_mother_name.Size = new System.Drawing.Size(220, 60);
            this.txt_mother_name.TabIndex = 18;
            this.txt_mother_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_name.HintText = "اسم المريض";
            this.txt_name.isPassword = false;
            this.txt_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_name.LineThickness = 4;
            this.txt_name.Location = new System.Drawing.Point(533, 13);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_name.Size = new System.Drawing.Size(220, 60);
            this.txt_name.TabIndex = 17;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Add_pation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_pation";
            this.Text = "Add_pation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NO_number;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_father_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_mother_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_name;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_place;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}