namespace Final_project
{
    partial class Private_reception
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Private_reception));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_hospital_name = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.panel_form = new System.Windows.Forms.Panel();
            this.maxBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.minBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_title = new System.Windows.Forms.Panel();
            this.search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.view_info_patient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.update_entrance_patient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.view_entrance_patient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_hospital_name.SuspendLayout();
            this.panel_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_hospital_name
            // 
            this.panel_hospital_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_hospital_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel_hospital_name.Controls.Add(this.Title);
            this.panel_hospital_name.Location = new System.Drawing.Point(741, 1);
            this.panel_hospital_name.Name = "panel_hospital_name";
            this.panel_hospital_name.Size = new System.Drawing.Size(179, 67);
            this.panel_hospital_name.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Gainsboro;
            this.Title.Location = new System.Drawing.Point(25, 22);
            this.Title.Name = "Title";
            this.Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Title.Size = new System.Drawing.Size(131, 23);
            this.Title.TabIndex = 2;
            this.Title.Text = "Our Hospital";
            // 
            // panel_button
            // 
            this.panel_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.panel_button.Controls.Add(this.search);
            this.panel_button.Controls.Add(this.view_info_patient);
            this.panel_button.Controls.Add(this.update_entrance_patient);
            this.panel_button.Controls.Add(this.view_entrance_patient);
            this.panel_button.Location = new System.Drawing.Point(741, 65);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(181, 575);
            this.panel_button.TabIndex = 5;
            // 
            // panel_form
            // 
            this.panel_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form.Location = new System.Drawing.Point(0, 67);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(741, 567);
            this.panel_form.TabIndex = 2;
            // 
            // maxBtn
            // 
            this.maxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.maxBtn.Image = ((System.Drawing.Image)(resources.GetObject("maxBtn.Image")));
            this.maxBtn.ImageActive = null;
            this.maxBtn.Location = new System.Drawing.Point(59, 14);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(40, 40);
            this.maxBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxBtn.TabIndex = 6;
            this.maxBtn.TabStop = false;
            this.maxBtn.Zoom = 10;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageActive = null;
            this.exitBtn.Location = new System.Drawing.Point(13, 14);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(40, 40);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 4;
            this.exitBtn.TabStop = false;
            this.exitBtn.Zoom = 10;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.minBtn.Image = ((System.Drawing.Image)(resources.GetObject("minBtn.Image")));
            this.minBtn.ImageActive = null;
            this.minBtn.Location = new System.Drawing.Point(105, 14);
            this.minBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(40, 40);
            this.minBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minBtn.TabIndex = 5;
            this.minBtn.TabStop = false;
            this.minBtn.Zoom = 10;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // panel_title
            // 
            this.panel_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.panel_title.Controls.Add(this.panel_hospital_name);
            this.panel_title.Controls.Add(this.maxBtn);
            this.panel_title.Controls.Add(this.exitBtn);
            this.panel_title.Controls.Add(this.minBtn);
            this.panel_title.Location = new System.Drawing.Point(0, -1);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(922, 68);
            this.panel_title.TabIndex = 4;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseMove);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseUp);
            // 
            // search
            // 
            this.search.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search.BorderRadius = 0;
            this.search.ButtonText = "بحث";
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.DisabledColor = System.Drawing.Color.Gray;
            this.search.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.search.Iconcolor = System.Drawing.Color.Transparent;
            this.search.Iconimage = null;
            this.search.Iconimage_right = null;
            this.search.Iconimage_right_Selected = null;
            this.search.Iconimage_Selected = null;
            this.search.IconMarginLeft = 0;
            this.search.IconMarginRight = 0;
            this.search.IconRightVisible = true;
            this.search.IconRightZoom = 0D;
            this.search.IconVisible = true;
            this.search.IconZoom = 40D;
            this.search.IsTab = false;
            this.search.Location = new System.Drawing.Point(1, 151);
            this.search.Margin = new System.Windows.Forms.Padding(5);
            this.search.Name = "search";
            this.search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.search.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.search.OnHoverTextColor = System.Drawing.Color.White;
            this.search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search.selected = false;
            this.search.Size = new System.Drawing.Size(178, 40);
            this.search.TabIndex = 33;
            this.search.Text = "بحث";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.search.Textcolor = System.Drawing.Color.Gainsboro;
            this.search.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // view_info_patient
            // 
            this.view_info_patient.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.view_info_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.view_info_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.view_info_patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_info_patient.BorderRadius = 0;
            this.view_info_patient.ButtonText = "عرض معلومات مريض";
            this.view_info_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_info_patient.DisabledColor = System.Drawing.Color.Gray;
            this.view_info_patient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.view_info_patient.Iconcolor = System.Drawing.Color.Transparent;
            this.view_info_patient.Iconimage = null;
            this.view_info_patient.Iconimage_right = null;
            this.view_info_patient.Iconimage_right_Selected = null;
            this.view_info_patient.Iconimage_Selected = null;
            this.view_info_patient.IconMarginLeft = 0;
            this.view_info_patient.IconMarginRight = 0;
            this.view_info_patient.IconRightVisible = true;
            this.view_info_patient.IconRightZoom = 0D;
            this.view_info_patient.IconVisible = true;
            this.view_info_patient.IconZoom = 40D;
            this.view_info_patient.IsTab = false;
            this.view_info_patient.Location = new System.Drawing.Point(1, 51);
            this.view_info_patient.Margin = new System.Windows.Forms.Padding(5);
            this.view_info_patient.Name = "view_info_patient";
            this.view_info_patient.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.view_info_patient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.view_info_patient.OnHoverTextColor = System.Drawing.Color.White;
            this.view_info_patient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.view_info_patient.selected = false;
            this.view_info_patient.Size = new System.Drawing.Size(178, 40);
            this.view_info_patient.TabIndex = 32;
            this.view_info_patient.Text = "عرض معلومات مريض";
            this.view_info_patient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view_info_patient.Textcolor = System.Drawing.Color.Gainsboro;
            this.view_info_patient.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.view_info_patient.Click += new System.EventHandler(this.view_info_patient_Click);
            // 
            // update_entrance_patient
            // 
            this.update_entrance_patient.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.update_entrance_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_entrance_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.update_entrance_patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_entrance_patient.BorderRadius = 0;
            this.update_entrance_patient.ButtonText = "تعديل أو تخريج مريض";
            this.update_entrance_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_entrance_patient.DisabledColor = System.Drawing.Color.Gray;
            this.update_entrance_patient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.update_entrance_patient.Iconcolor = System.Drawing.Color.Transparent;
            this.update_entrance_patient.Iconimage = null;
            this.update_entrance_patient.Iconimage_right = null;
            this.update_entrance_patient.Iconimage_right_Selected = null;
            this.update_entrance_patient.Iconimage_Selected = null;
            this.update_entrance_patient.IconMarginLeft = 0;
            this.update_entrance_patient.IconMarginRight = 0;
            this.update_entrance_patient.IconRightVisible = true;
            this.update_entrance_patient.IconRightZoom = 0D;
            this.update_entrance_patient.IconVisible = true;
            this.update_entrance_patient.IconZoom = 40D;
            this.update_entrance_patient.IsTab = false;
            this.update_entrance_patient.Location = new System.Drawing.Point(1, 1);
            this.update_entrance_patient.Margin = new System.Windows.Forms.Padding(5);
            this.update_entrance_patient.Name = "update_entrance_patient";
            this.update_entrance_patient.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.update_entrance_patient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.update_entrance_patient.OnHoverTextColor = System.Drawing.Color.White;
            this.update_entrance_patient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.update_entrance_patient.selected = false;
            this.update_entrance_patient.Size = new System.Drawing.Size(178, 40);
            this.update_entrance_patient.TabIndex = 30;
            this.update_entrance_patient.Text = "تعديل أو تخريج مريض";
            this.update_entrance_patient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update_entrance_patient.Textcolor = System.Drawing.Color.Gainsboro;
            this.update_entrance_patient.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.update_entrance_patient.Click += new System.EventHandler(this.update_entrance_patient_Click_1);
            // 
            // view_entrance_patient
            // 
            this.view_entrance_patient.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.view_entrance_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.view_entrance_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.view_entrance_patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_entrance_patient.BorderRadius = 0;
            this.view_entrance_patient.ButtonText = "عرض سجلات الدخولية";
            this.view_entrance_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_entrance_patient.DisabledColor = System.Drawing.Color.Gray;
            this.view_entrance_patient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.view_entrance_patient.Iconcolor = System.Drawing.Color.Transparent;
            this.view_entrance_patient.Iconimage = null;
            this.view_entrance_patient.Iconimage_right = null;
            this.view_entrance_patient.Iconimage_right_Selected = null;
            this.view_entrance_patient.Iconimage_Selected = null;
            this.view_entrance_patient.IconMarginLeft = 0;
            this.view_entrance_patient.IconMarginRight = 0;
            this.view_entrance_patient.IconRightVisible = true;
            this.view_entrance_patient.IconRightZoom = 0D;
            this.view_entrance_patient.IconVisible = true;
            this.view_entrance_patient.IconZoom = 40D;
            this.view_entrance_patient.IsTab = false;
            this.view_entrance_patient.Location = new System.Drawing.Point(1, 101);
            this.view_entrance_patient.Margin = new System.Windows.Forms.Padding(5);
            this.view_entrance_patient.Name = "view_entrance_patient";
            this.view_entrance_patient.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.view_entrance_patient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.view_entrance_patient.OnHoverTextColor = System.Drawing.Color.White;
            this.view_entrance_patient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.view_entrance_patient.selected = false;
            this.view_entrance_patient.Size = new System.Drawing.Size(178, 40);
            this.view_entrance_patient.TabIndex = 31;
            this.view_entrance_patient.Text = "عرض سجلات الدخولية";
            this.view_entrance_patient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view_entrance_patient.Textcolor = System.Drawing.Color.Gainsboro;
            this.view_entrance_patient.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.view_entrance_patient.Click += new System.EventHandler(this.view_entrance_patient_Click);
            // 
            // Private_reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 635);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Private_reception";
            this.Text = "Private_reception";
            this.panel_hospital_name.ResumeLayout(false);
            this.panel_hospital_name.PerformLayout();
            this.panel_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Panel panel_hospital_name;
        protected System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_form;
        private Bunifu.Framework.UI.BunifuImageButton maxBtn;
        private Bunifu.Framework.UI.BunifuImageButton exitBtn;
        private Bunifu.Framework.UI.BunifuImageButton minBtn;
        private Bunifu.Framework.UI.BunifuFlatButton search;
        private Bunifu.Framework.UI.BunifuFlatButton view_info_patient;
        private Bunifu.Framework.UI.BunifuFlatButton update_entrance_patient;
        private Bunifu.Framework.UI.BunifuFlatButton view_entrance_patient;
    }
}