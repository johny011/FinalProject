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
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_NO_number = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_father_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_mother_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pation_NO = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_date = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_place = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_place);
            this.panel1.Controls.Add(this.txt_date);
            this.panel1.Controls.Add(this.pation_NO);
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
            // txt_NO_number
            // 
            this.txt_NO_number.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_NO_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NO_number.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NO_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NO_number.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NO_number.HintText = "";
            this.txt_NO_number.isPassword = false;
            this.txt_NO_number.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_NO_number.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NO_number.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_NO_number.LineThickness = 4;
            this.txt_NO_number.Location = new System.Drawing.Point(288, 99);
            this.txt_NO_number.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_NO_number.Name = "txt_NO_number";
            this.txt_NO_number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_NO_number.Size = new System.Drawing.Size(220, 60);
            this.txt_NO_number.TabIndex = 20;
            this.txt_NO_number.Text = "الرقم الوطني";
            this.txt_NO_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_father_name
            // 
            this.txt_father_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_father_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_father_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_father_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_father_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_father_name.HintText = "";
            this.txt_father_name.isPassword = false;
            this.txt_father_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_father_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_father_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_father_name.LineThickness = 4;
            this.txt_father_name.Location = new System.Drawing.Point(15, 14);
            this.txt_father_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_father_name.Name = "txt_father_name";
            this.txt_father_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_father_name.Size = new System.Drawing.Size(220, 60);
            this.txt_father_name.TabIndex = 19;
            this.txt_father_name.Text = "اسم الأب";
            this.txt_father_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mother_name
            // 
            this.txt_mother_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mother_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mother_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mother_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mother_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_mother_name.HintText = "";
            this.txt_mother_name.isPassword = false;
            this.txt_mother_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_mother_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_mother_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_mother_name.LineThickness = 4;
            this.txt_mother_name.Location = new System.Drawing.Point(565, 99);
            this.txt_mother_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_mother_name.Name = "txt_mother_name";
            this.txt_mother_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_mother_name.Size = new System.Drawing.Size(220, 60);
            this.txt_mother_name.TabIndex = 18;
            this.txt_mother_name.Text = "اسم الأم";
            this.txt_mother_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_name.HintText = "";
            this.txt_name.isPassword = false;
            this.txt_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_name.LineThickness = 4;
            this.txt_name.Location = new System.Drawing.Point(288, 14);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_name.Size = new System.Drawing.Size(220, 60);
            this.txt_name.TabIndex = 17;
            this.txt_name.Text = "اسم المريض";
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
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
            this.pation_NO.Location = new System.Drawing.Point(565, 14);
            this.pation_NO.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pation_NO.Name = "pation_NO";
            this.pation_NO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pation_NO.Size = new System.Drawing.Size(220, 60);
            this.pation_NO.TabIndex = 24;
            this.pation_NO.Text = "رقم المريض";
            this.pation_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_date
            // 
            this.txt_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_date.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_date.HintForeColor = System.Drawing.Color.Empty;
            this.txt_date.HintText = "";
            this.txt_date.isPassword = false;
            this.txt_date.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_date.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_date.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_date.LineThickness = 4;
            this.txt_date.Location = new System.Drawing.Point(287, 210);
            this.txt_date.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_date.Name = "txt_date";
            this.txt_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_date.Size = new System.Drawing.Size(220, 60);
            this.txt_date.TabIndex = 25;
            this.txt_date.Text = "تاريخ الميلاد ";
            this.txt_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txt_place.Location = new System.Drawing.Point(15, 99);
            this.txt_place.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_place.Name = "txt_place";
            this.txt_place.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_place.Size = new System.Drawing.Size(220, 60);
            this.txt_place.TabIndex = 26;
            this.txt_place.Text = "مكان الإقامة";
            this.txt_place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_date;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pation_NO;
    }
}