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
            this.panel_form = new System.Windows.Forms.Panel();
            this.btn_show_working_picture = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_radiograph = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_X_ray = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_show_picture = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_show_picture_results = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_X_ray_result = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panel_button.Controls.Add(this.btn_show_working_picture);
            this.panel_button.Controls.Add(this.btn_add_radiograph);
            this.panel_button.Controls.Add(this.btn_add_X_ray_result);
            this.panel_button.Controls.Add(this.btn_update_X_ray);
            this.panel_button.Controls.Add(this.btn_show_picture_results);
            this.panel_button.Controls.Add(this.btn_show_picture);
            this.panel_button.Location = new System.Drawing.Point(806, 66);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(181, 451);
            this.panel_button.TabIndex = 6;
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
            // btn_show_working_picture
            // 
            this.btn_show_working_picture.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_working_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_working_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_working_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_working_picture.BorderRadius = 0;
            this.btn_show_working_picture.ButtonText = "عرض الصور المطلوبة لمريض";
            this.btn_show_working_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_working_picture.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_working_picture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_working_picture.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show_working_picture.Iconimage = null;
            this.btn_show_working_picture.Iconimage_right = null;
            this.btn_show_working_picture.Iconimage_right_Selected = null;
            this.btn_show_working_picture.Iconimage_Selected = null;
            this.btn_show_working_picture.IconMarginLeft = 0;
            this.btn_show_working_picture.IconMarginRight = 0;
            this.btn_show_working_picture.IconRightVisible = true;
            this.btn_show_working_picture.IconRightZoom = 0D;
            this.btn_show_working_picture.IconVisible = true;
            this.btn_show_working_picture.IconZoom = 40D;
            this.btn_show_working_picture.IsTab = false;
            this.btn_show_working_picture.Location = new System.Drawing.Point(1, 200);
            this.btn_show_working_picture.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_working_picture.Name = "btn_show_working_picture";
            this.btn_show_working_picture.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_working_picture.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_working_picture.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_working_picture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_working_picture.selected = false;
            this.btn_show_working_picture.Size = new System.Drawing.Size(176, 40);
            this.btn_show_working_picture.TabIndex = 34;
            this.btn_show_working_picture.Text = "عرض الصور المطلوبة لمريض";
            this.btn_show_working_picture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_working_picture.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_working_picture.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_working_picture.Click += new System.EventHandler(this.btn_show_working_picture_Click);
            // 
            // btn_add_radiograph
            // 
            this.btn_add_radiograph.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_radiograph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_radiograph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_radiograph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_radiograph.BorderRadius = 0;
            this.btn_add_radiograph.ButtonText = "إضافة صورة";
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
            this.btn_add_radiograph.Text = "إضافة صورة";
            this.btn_add_radiograph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_radiograph.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_radiograph.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_radiograph.Click += new System.EventHandler(this.btn_add_radiograph_Click);
            // 
            // btn_update_X_ray
            // 
            this.btn_update_X_ray.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_X_ray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_X_ray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_X_ray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_X_ray.BorderRadius = 0;
            this.btn_update_X_ray.ButtonText = "تعديل صورة";
            this.btn_update_X_ray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_X_ray.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_X_ray.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_X_ray.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update_X_ray.Iconimage = null;
            this.btn_update_X_ray.Iconimage_right = null;
            this.btn_update_X_ray.Iconimage_right_Selected = null;
            this.btn_update_X_ray.Iconimage_Selected = null;
            this.btn_update_X_ray.IconMarginLeft = 0;
            this.btn_update_X_ray.IconMarginRight = 0;
            this.btn_update_X_ray.IconRightVisible = true;
            this.btn_update_X_ray.IconRightZoom = 0D;
            this.btn_update_X_ray.IconVisible = true;
            this.btn_update_X_ray.IconZoom = 40D;
            this.btn_update_X_ray.IsTab = false;
            this.btn_update_X_ray.Location = new System.Drawing.Point(1, 100);
            this.btn_update_X_ray.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_X_ray.Name = "btn_update_X_ray";
            this.btn_update_X_ray.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_X_ray.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_X_ray.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_X_ray.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_X_ray.selected = false;
            this.btn_update_X_ray.Size = new System.Drawing.Size(176, 40);
            this.btn_update_X_ray.TabIndex = 37;
            this.btn_update_X_ray.Text = "تعديل صورة";
            this.btn_update_X_ray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update_X_ray.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_X_ray.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_X_ray.Click += new System.EventHandler(this.btn_update_X_ray_Click);
            // 
            // btn_show_picture
            // 
            this.btn_show_picture.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_picture.BorderRadius = 0;
            this.btn_show_picture.ButtonText = "عرض الصور ";
            this.btn_show_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_picture.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_picture.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_picture.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show_picture.Iconimage = null;
            this.btn_show_picture.Iconimage_right = null;
            this.btn_show_picture.Iconimage_right_Selected = null;
            this.btn_show_picture.Iconimage_Selected = null;
            this.btn_show_picture.IconMarginLeft = 0;
            this.btn_show_picture.IconMarginRight = 0;
            this.btn_show_picture.IconRightVisible = true;
            this.btn_show_picture.IconRightZoom = 0D;
            this.btn_show_picture.IconVisible = true;
            this.btn_show_picture.IconZoom = 40D;
            this.btn_show_picture.IsTab = false;
            this.btn_show_picture.Location = new System.Drawing.Point(1, 150);
            this.btn_show_picture.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_picture.Name = "btn_show_picture";
            this.btn_show_picture.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_picture.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_picture.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_picture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_picture.selected = false;
            this.btn_show_picture.Size = new System.Drawing.Size(176, 40);
            this.btn_show_picture.TabIndex = 38;
            this.btn_show_picture.Text = "عرض الصور ";
            this.btn_show_picture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_picture.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_picture.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_picture.Click += new System.EventHandler(this.btn_show_picture_Click);
            // 
            // btn_show_picture_results
            // 
            this.btn_show_picture_results.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_picture_results.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_picture_results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_picture_results.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_picture_results.BorderRadius = 0;
            this.btn_show_picture_results.ButtonText = "عرض نتائج الصور لمريض";
            this.btn_show_picture_results.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_picture_results.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_picture_results.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_picture_results.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show_picture_results.Iconimage = null;
            this.btn_show_picture_results.Iconimage_right = null;
            this.btn_show_picture_results.Iconimage_right_Selected = null;
            this.btn_show_picture_results.Iconimage_Selected = null;
            this.btn_show_picture_results.IconMarginLeft = 0;
            this.btn_show_picture_results.IconMarginRight = 0;
            this.btn_show_picture_results.IconRightVisible = true;
            this.btn_show_picture_results.IconRightZoom = 0D;
            this.btn_show_picture_results.IconVisible = true;
            this.btn_show_picture_results.IconZoom = 40D;
            this.btn_show_picture_results.IsTab = false;
            this.btn_show_picture_results.Location = new System.Drawing.Point(1, 250);
            this.btn_show_picture_results.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_picture_results.Name = "btn_show_picture_results";
            this.btn_show_picture_results.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_picture_results.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_picture_results.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_picture_results.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_picture_results.selected = false;
            this.btn_show_picture_results.Size = new System.Drawing.Size(176, 40);
            this.btn_show_picture_results.TabIndex = 39;
            this.btn_show_picture_results.Text = "عرض نتائج الصور لمريض";
            this.btn_show_picture_results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_picture_results.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_picture_results.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_picture_results.Click += new System.EventHandler(this.btn_show_picture_results_Click);
            // 
            // btn_add_X_ray_result
            // 
            this.btn_add_X_ray_result.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_X_ray_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_X_ray_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_X_ray_result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_X_ray_result.BorderRadius = 0;
            this.btn_add_X_ray_result.ButtonText = "إضافة نتيجة صورة ";
            this.btn_add_X_ray_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_X_ray_result.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_X_ray_result.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_X_ray_result.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_X_ray_result.Iconimage = null;
            this.btn_add_X_ray_result.Iconimage_right = null;
            this.btn_add_X_ray_result.Iconimage_right_Selected = null;
            this.btn_add_X_ray_result.Iconimage_Selected = null;
            this.btn_add_X_ray_result.IconMarginLeft = 0;
            this.btn_add_X_ray_result.IconMarginRight = 0;
            this.btn_add_X_ray_result.IconRightVisible = true;
            this.btn_add_X_ray_result.IconRightZoom = 0D;
            this.btn_add_X_ray_result.IconVisible = true;
            this.btn_add_X_ray_result.IconZoom = 40D;
            this.btn_add_X_ray_result.IsTab = false;
            this.btn_add_X_ray_result.Location = new System.Drawing.Point(1, 50);
            this.btn_add_X_ray_result.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_X_ray_result.Name = "btn_add_X_ray_result";
            this.btn_add_X_ray_result.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_X_ray_result.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_X_ray_result.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_X_ray_result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_X_ray_result.selected = false;
            this.btn_add_X_ray_result.Size = new System.Drawing.Size(176, 40);
            this.btn_add_X_ray_result.TabIndex = 36;
            this.btn_add_X_ray_result.Text = "إضافة نتيجة صورة ";
            this.btn_add_X_ray_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_X_ray_result.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_X_ray_result.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_X_ray_result.Click += new System.EventHandler(this.btn_add_X_ray_result_Click);
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
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_working_picture;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_radiograph;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_X_ray_result;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update_X_ray;
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_picture_results;
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_picture;
    }
}