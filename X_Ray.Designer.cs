namespace Final_project
{
    partial class X_Ray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(X_Ray));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_hospital_name = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.maxBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.minBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_button = new System.Windows.Forms.Panel();
            this.btn_add_radiograph = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Requsetpicture = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_form = new System.Windows.Forms.Panel();
            this.btn_add_picture = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_edit_picture = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_title.SuspendLayout();
            this.panel_hospital_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
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
            this.panel_title.Location = new System.Drawing.Point(-1, -1);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(988, 67);
            this.panel_title.TabIndex = 5;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseMove);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseUp);
            // 
            // panel_hospital_name
            // 
            this.panel_hospital_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_hospital_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel_hospital_name.Controls.Add(this.Title);
            this.panel_hospital_name.Location = new System.Drawing.Point(807, 1);
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
            // panel_button
            // 
            this.panel_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.panel_button.Controls.Add(this.btn_edit_picture);
            this.panel_button.Controls.Add(this.btn_add_picture);
            this.panel_button.Controls.Add(this.btn_add_radiograph);
            this.panel_button.Controls.Add(this.btn_Requsetpicture);
            this.panel_button.Location = new System.Drawing.Point(806, 66);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(181, 451);
            this.panel_button.TabIndex = 6;
            // 
            // btn_add_radiograph
            // 
            this.btn_add_radiograph.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_radiograph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_radiograph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_radiograph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_radiograph.BorderRadius = 0;
            this.btn_add_radiograph.ButtonText = "إرسال نتيجة صورة ";
            this.btn_add_radiograph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_radiograph.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_radiograph.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_radiograph.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_radiograph.Iconimage = null;
            this.btn_add_radiograph.Iconimage_right = null;
            this.btn_add_radiograph.Iconimage_right_Selected = null;
            this.btn_add_radiograph.Iconimage_Selected = null;
            this.btn_add_radiograph.IconMarginLeft = 0;
            this.btn_add_radiograph.IconMarginRight = 0;
            this.btn_add_radiograph.IconRightVisible = true;
            this.btn_add_radiograph.IconRightZoom = 0D;
            this.btn_add_radiograph.IconVisible = true;
            this.btn_add_radiograph.IconZoom = 40D;
            this.btn_add_radiograph.IsTab = false;
            this.btn_add_radiograph.Location = new System.Drawing.Point(1, 0);
            this.btn_add_radiograph.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_radiograph.Name = "btn_add_radiograph";
            this.btn_add_radiograph.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_radiograph.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_radiograph.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_radiograph.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_radiograph.selected = false;
            this.btn_add_radiograph.Size = new System.Drawing.Size(176, 40);
            this.btn_add_radiograph.TabIndex = 35;
            this.btn_add_radiograph.Text = "إرسال نتيجة صورة ";
            this.btn_add_radiograph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_radiograph.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_radiograph.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_radiograph.Click += new System.EventHandler(this.btn_add_radiograph_Click);
            // 
            // btn_Requsetpicture
            // 
            this.btn_Requsetpicture.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_Requsetpicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Requsetpicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_Requsetpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Requsetpicture.BorderRadius = 0;
            this.btn_Requsetpicture.ButtonText = "الصور المطلوبة";
            this.btn_Requsetpicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Requsetpicture.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Requsetpicture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Requsetpicture.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Requsetpicture.Iconimage = null;
            this.btn_Requsetpicture.Iconimage_right = null;
            this.btn_Requsetpicture.Iconimage_right_Selected = null;
            this.btn_Requsetpicture.Iconimage_Selected = null;
            this.btn_Requsetpicture.IconMarginLeft = 0;
            this.btn_Requsetpicture.IconMarginRight = 0;
            this.btn_Requsetpicture.IconRightVisible = true;
            this.btn_Requsetpicture.IconRightZoom = 0D;
            this.btn_Requsetpicture.IconVisible = true;
            this.btn_Requsetpicture.IconZoom = 40D;
            this.btn_Requsetpicture.IsTab = false;
            this.btn_Requsetpicture.Location = new System.Drawing.Point(1, 50);
            this.btn_Requsetpicture.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Requsetpicture.Name = "btn_Requsetpicture";
            this.btn_Requsetpicture.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_Requsetpicture.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_Requsetpicture.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Requsetpicture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Requsetpicture.selected = false;
            this.btn_Requsetpicture.Size = new System.Drawing.Size(176, 40);
            this.btn_Requsetpicture.TabIndex = 36;
            this.btn_Requsetpicture.Text = "الصور المطلوبة";
            this.btn_Requsetpicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Requsetpicture.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_Requsetpicture.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Requsetpicture.Click += new System.EventHandler(this.btn_add_X_ray_result_Click);
            // 
            // panel_form
            // 
            this.panel_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form.Location = new System.Drawing.Point(0, 65);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(806, 451);
            this.panel_form.TabIndex = 7;
            // 
            // btn_add_picture
            // 
            this.btn_add_picture.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_picture.BorderRadius = 0;
            this.btn_add_picture.ButtonText = "اضافة انواع صور";
            this.btn_add_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_picture.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_picture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_picture.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_picture.Iconimage = null;
            this.btn_add_picture.Iconimage_right = null;
            this.btn_add_picture.Iconimage_right_Selected = null;
            this.btn_add_picture.Iconimage_Selected = null;
            this.btn_add_picture.IconMarginLeft = 0;
            this.btn_add_picture.IconMarginRight = 0;
            this.btn_add_picture.IconRightVisible = true;
            this.btn_add_picture.IconRightZoom = 0D;
            this.btn_add_picture.IconVisible = true;
            this.btn_add_picture.IconZoom = 40D;
            this.btn_add_picture.IsTab = false;
            this.btn_add_picture.Location = new System.Drawing.Point(0, 100);
            this.btn_add_picture.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_picture.Name = "btn_add_picture";
            this.btn_add_picture.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_picture.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_picture.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_picture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_picture.selected = false;
            this.btn_add_picture.Size = new System.Drawing.Size(176, 40);
            this.btn_add_picture.TabIndex = 37;
            this.btn_add_picture.Text = "اضافة انواع صور";
            this.btn_add_picture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_picture.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_picture.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_picture.Click += new System.EventHandler(this.btn_add_picture_Click);
            // 
            // btn_edit_picture
            // 
            this.btn_edit_picture.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_edit_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_edit_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit_picture.BorderRadius = 0;
            this.btn_edit_picture.ButtonText = "تعديل انواع صور";
            this.btn_edit_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_picture.DisabledColor = System.Drawing.Color.Gray;
            this.btn_edit_picture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_edit_picture.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_edit_picture.Iconimage = null;
            this.btn_edit_picture.Iconimage_right = null;
            this.btn_edit_picture.Iconimage_right_Selected = null;
            this.btn_edit_picture.Iconimage_Selected = null;
            this.btn_edit_picture.IconMarginLeft = 0;
            this.btn_edit_picture.IconMarginRight = 0;
            this.btn_edit_picture.IconRightVisible = true;
            this.btn_edit_picture.IconRightZoom = 0D;
            this.btn_edit_picture.IconVisible = true;
            this.btn_edit_picture.IconZoom = 40D;
            this.btn_edit_picture.IsTab = false;
            this.btn_edit_picture.Location = new System.Drawing.Point(0, 150);
            this.btn_edit_picture.Margin = new System.Windows.Forms.Padding(5);
            this.btn_edit_picture.Name = "btn_edit_picture";
            this.btn_edit_picture.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_edit_picture.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_edit_picture.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_edit_picture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_edit_picture.selected = false;
            this.btn_edit_picture.Size = new System.Drawing.Size(176, 40);
            this.btn_edit_picture.TabIndex = 38;
            this.btn_edit_picture.Text = "تعديل انواع صور";
            this.btn_edit_picture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit_picture.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_edit_picture.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_edit_picture.Click += new System.EventHandler(this.btn_edit_picture_Click);
            // 
            // X_Ray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 518);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "X_Ray";
            this.Text = "X_Ray";
            this.panel_title.ResumeLayout(false);
            this.panel_hospital_name.ResumeLayout(false);
            this.panel_hospital_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panel_button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_hospital_name;
        protected System.Windows.Forms.Label Title;
        private Bunifu.Framework.UI.BunifuImageButton maxBtn;
        private Bunifu.Framework.UI.BunifuImageButton exitBtn;
        private Bunifu.Framework.UI.BunifuImageButton minBtn;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Panel panel_form;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_radiograph;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Requsetpicture;
        private Bunifu.Framework.UI.BunifuFlatButton btn_edit_picture;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_picture;
    }
}