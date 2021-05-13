namespace Final_project
{
    partial class Main_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_admin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_hospital_name = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.maxBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.minBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_button = new System.Windows.Forms.Panel();
            this.btn_show_working_period = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_acount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_show_department = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_emp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_show_emp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_interval = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_show_room = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_working_period = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_show_acount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_emp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_room = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_acount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_working_period = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_interval = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_room = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_form = new System.Windows.Forms.Panel();
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
            this.panel_title.Size = new System.Drawing.Size(1105, 67);
            this.panel_title.TabIndex = 5;
            this.panel_title.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_title_Paint);
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseMove);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseUp);
            // 
            // panel_hospital_name
            // 
            this.panel_hospital_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_hospital_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel_hospital_name.Controls.Add(this.Title);
            this.panel_hospital_name.Location = new System.Drawing.Point(924, 1);
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
            this.panel_button.Controls.Add(this.btn_show_working_period);
            this.panel_button.Controls.Add(this.btn_update_acount);
            this.panel_button.Controls.Add(this.btn_show_department);
            this.panel_button.Controls.Add(this.btn_add_emp);
            this.panel_button.Controls.Add(this.btn_show_emp);
            this.panel_button.Controls.Add(this.btn_update_interval);
            this.panel_button.Controls.Add(this.btn_show_room);
            this.panel_button.Controls.Add(this.btn_add_working_period);
            this.panel_button.Controls.Add(this.btn_show_acount);
            this.panel_button.Controls.Add(this.btn_update_emp);
            this.panel_button.Controls.Add(this.btn_update_room);
            this.panel_button.Controls.Add(this.btn_add_acount);
            this.panel_button.Controls.Add(this.btn_update_working_period);
            this.panel_button.Controls.Add(this.btn_add_interval);
            this.panel_button.Controls.Add(this.btn_add_room);
            this.panel_button.Location = new System.Drawing.Point(923, 65);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(181, 710);
            this.panel_button.TabIndex = 6;
            // 
            // btn_show_working_period
            // 
            this.btn_show_working_period.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_working_period.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_working_period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_working_period.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_working_period.BorderRadius = 0;
            this.btn_show_working_period.ButtonText = "عرض فترات العمل";
            this.btn_show_working_period.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_working_period.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_working_period.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_working_period.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show_working_period.Iconimage = null;
            this.btn_show_working_period.Iconimage_right = null;
            this.btn_show_working_period.Iconimage_right_Selected = null;
            this.btn_show_working_period.Iconimage_Selected = null;
            this.btn_show_working_period.IconMarginLeft = 0;
            this.btn_show_working_period.IconMarginRight = 0;
            this.btn_show_working_period.IconRightVisible = true;
            this.btn_show_working_period.IconRightZoom = 0D;
            this.btn_show_working_period.IconVisible = true;
            this.btn_show_working_period.IconZoom = 40D;
            this.btn_show_working_period.IsTab = false;
            this.btn_show_working_period.Location = new System.Drawing.Point(1, 489);
            this.btn_show_working_period.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_working_period.Name = "btn_show_working_period";
            this.btn_show_working_period.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_working_period.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_working_period.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_working_period.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_working_period.selected = false;
            this.btn_show_working_period.Size = new System.Drawing.Size(178, 25);
            this.btn_show_working_period.TabIndex = 56;
            this.btn_show_working_period.Text = "عرض فترات العمل";
            this.btn_show_working_period.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_working_period.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_working_period.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_working_period.Click += new System.EventHandler(this.btn_show_working_period_Click);
            // 
            // btn_update_acount
            // 
            this.btn_update_acount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_acount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_acount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_acount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_acount.BorderRadius = 0;
            this.btn_update_acount.ButtonText = "تعديل حساب";
            this.btn_update_acount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_acount.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_acount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_acount.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update_acount.Iconimage = null;
            this.btn_update_acount.Iconimage_right = null;
            this.btn_update_acount.Iconimage_right_Selected = null;
            this.btn_update_acount.Iconimage_Selected = null;
            this.btn_update_acount.IconMarginLeft = 0;
            this.btn_update_acount.IconMarginRight = 0;
            this.btn_update_acount.IconRightVisible = true;
            this.btn_update_acount.IconRightZoom = 0D;
            this.btn_update_acount.IconVisible = true;
            this.btn_update_acount.IconZoom = 40D;
            this.btn_update_acount.IsTab = false;
            this.btn_update_acount.Location = new System.Drawing.Point(-4, 210);
            this.btn_update_acount.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_acount.Name = "btn_update_acount";
            this.btn_update_acount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_acount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_acount.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_acount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_acount.selected = false;
            this.btn_update_acount.Size = new System.Drawing.Size(178, 25);
            this.btn_update_acount.TabIndex = 66;
            this.btn_update_acount.Text = "تعديل حساب";
            this.btn_update_acount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update_acount.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_acount.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_acount.Click += new System.EventHandler(this.btn_update_acount_Click);
            // 
            // btn_show_department
            // 
            this.btn_show_department.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_department.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_department.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_department.BorderRadius = 0;
            this.btn_show_department.ButtonText = "عرض الأقسام";
            this.btn_show_department.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_department.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_department.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_department.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show_department.Iconimage = null;
            this.btn_show_department.Iconimage_right = null;
            this.btn_show_department.Iconimage_right_Selected = null;
            this.btn_show_department.Iconimage_Selected = null;
            this.btn_show_department.IconMarginLeft = 0;
            this.btn_show_department.IconMarginRight = 0;
            this.btn_show_department.IconRightVisible = true;
            this.btn_show_department.IconRightZoom = 0D;
            this.btn_show_department.IconVisible = true;
            this.btn_show_department.IconZoom = 40D;
            this.btn_show_department.IsTab = false;
            this.btn_show_department.Location = new System.Drawing.Point(1, 454);
            this.btn_show_department.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_department.Name = "btn_show_department";
            this.btn_show_department.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_department.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_department.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_department.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_department.selected = false;
            this.btn_show_department.Size = new System.Drawing.Size(178, 25);
            this.btn_show_department.TabIndex = 55;
            this.btn_show_department.Text = "عرض الأقسام";
            this.btn_show_department.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_department.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_department.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_department.Click += new System.EventHandler(this.btn_show_department_Click);
            // 
            // btn_add_emp
            // 
            this.btn_add_emp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_emp.BorderRadius = 0;
            this.btn_add_emp.ButtonText = "إضافة عاملين";
            this.btn_add_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_emp.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_emp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_emp.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_emp.Iconimage = null;
            this.btn_add_emp.Iconimage_right = null;
            this.btn_add_emp.Iconimage_right_Selected = null;
            this.btn_add_emp.Iconimage_Selected = null;
            this.btn_add_emp.IconMarginLeft = 0;
            this.btn_add_emp.IconMarginRight = 0;
            this.btn_add_emp.IconRightVisible = true;
            this.btn_add_emp.IconRightZoom = 0D;
            this.btn_add_emp.IconVisible = true;
            this.btn_add_emp.IconZoom = 40D;
            this.btn_add_emp.IsTab = false;
            this.btn_add_emp.Location = new System.Drawing.Point(1, 3);
            this.btn_add_emp.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_emp.Name = "btn_add_emp";
            this.btn_add_emp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_emp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_emp.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_emp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_emp.selected = false;
            this.btn_add_emp.Size = new System.Drawing.Size(178, 25);
            this.btn_add_emp.TabIndex = 58;
            this.btn_add_emp.Text = "إضافة عاملين";
            this.btn_add_emp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_emp.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_emp.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_emp.Click += new System.EventHandler(this.btn_add_emp_Click);
            // 
            // btn_show_emp
            // 
            this.btn_show_emp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_emp.BorderRadius = 0;
            this.btn_show_emp.ButtonText = "عرض العاملين";
            this.btn_show_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_emp.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_emp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_emp.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show_emp.Iconimage = null;
            this.btn_show_emp.Iconimage_right = null;
            this.btn_show_emp.Iconimage_right_Selected = null;
            this.btn_show_emp.Iconimage_Selected = null;
            this.btn_show_emp.IconMarginLeft = 0;
            this.btn_show_emp.IconMarginRight = 0;
            this.btn_show_emp.IconRightVisible = true;
            this.btn_show_emp.IconRightZoom = 0D;
            this.btn_show_emp.IconVisible = true;
            this.btn_show_emp.IconZoom = 40D;
            this.btn_show_emp.IsTab = false;
            this.btn_show_emp.Location = new System.Drawing.Point(1, 349);
            this.btn_show_emp.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_emp.Name = "btn_show_emp";
            this.btn_show_emp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_emp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_emp.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_emp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_emp.selected = false;
            this.btn_show_emp.Size = new System.Drawing.Size(178, 25);
            this.btn_show_emp.TabIndex = 52;
            this.btn_show_emp.Text = "عرض العاملين";
            this.btn_show_emp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_emp.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_emp.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_emp.Click += new System.EventHandler(this.btn_show_emp_Click);
            // 
            // btn_update_interval
            // 
            this.btn_update_interval.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_interval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_interval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_interval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_interval.BorderRadius = 0;
            this.btn_update_interval.ButtonText = "تعديل فترة";
            this.btn_update_interval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_interval.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_interval.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_interval.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update_interval.Iconimage = null;
            this.btn_update_interval.Iconimage_right = null;
            this.btn_update_interval.Iconimage_right_Selected = null;
            this.btn_update_interval.Iconimage_Selected = null;
            this.btn_update_interval.IconMarginLeft = 0;
            this.btn_update_interval.IconMarginRight = 0;
            this.btn_update_interval.IconRightVisible = true;
            this.btn_update_interval.IconRightZoom = 0D;
            this.btn_update_interval.IconVisible = true;
            this.btn_update_interval.IconZoom = 40D;
            this.btn_update_interval.IsTab = false;
            this.btn_update_interval.Location = new System.Drawing.Point(-4, 245);
            this.btn_update_interval.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_interval.Name = "btn_update_interval";
            this.btn_update_interval.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_interval.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_interval.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_interval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_interval.selected = false;
            this.btn_update_interval.Size = new System.Drawing.Size(178, 25);
            this.btn_update_interval.TabIndex = 65;
            this.btn_update_interval.Text = "تعديل فترة";
            this.btn_update_interval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update_interval.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_interval.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_interval.Click += new System.EventHandler(this.btn_update_interval_Click);
            // 
            // btn_show_room
            // 
            this.btn_show_room.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_room.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_room.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_room.BorderRadius = 0;
            this.btn_show_room.ButtonText = "عرض الغرف";
            this.btn_show_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_room.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_room.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_room.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show_room.Iconimage = null;
            this.btn_show_room.Iconimage_right = null;
            this.btn_show_room.Iconimage_right_Selected = null;
            this.btn_show_room.Iconimage_Selected = null;
            this.btn_show_room.IconMarginLeft = 0;
            this.btn_show_room.IconMarginRight = 0;
            this.btn_show_room.IconRightVisible = true;
            this.btn_show_room.IconRightZoom = 0D;
            this.btn_show_room.IconVisible = true;
            this.btn_show_room.IconZoom = 40D;
            this.btn_show_room.IsTab = false;
            this.btn_show_room.Location = new System.Drawing.Point(1, 419);
            this.btn_show_room.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_room.Name = "btn_show_room";
            this.btn_show_room.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_room.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_room.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_room.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_room.selected = false;
            this.btn_show_room.Size = new System.Drawing.Size(178, 25);
            this.btn_show_room.TabIndex = 54;
            this.btn_show_room.Text = "عرض الغرف";
            this.btn_show_room.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_room.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_room.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_room.Click += new System.EventHandler(this.btn_show_room_Click);
            // 
            // btn_add_working_period
            // 
            this.btn_add_working_period.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_working_period.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_working_period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_working_period.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_working_period.BorderRadius = 0;
            this.btn_add_working_period.ButtonText = "إضافة فترة عمل";
            this.btn_add_working_period.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_working_period.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_working_period.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_working_period.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_working_period.Iconimage = null;
            this.btn_add_working_period.Iconimage_right = null;
            this.btn_add_working_period.Iconimage_right_Selected = null;
            this.btn_add_working_period.Iconimage_Selected = null;
            this.btn_add_working_period.IconMarginLeft = 0;
            this.btn_add_working_period.IconMarginRight = 0;
            this.btn_add_working_period.IconRightVisible = true;
            this.btn_add_working_period.IconRightZoom = 0D;
            this.btn_add_working_period.IconVisible = true;
            this.btn_add_working_period.IconZoom = 40D;
            this.btn_add_working_period.IsTab = false;
            this.btn_add_working_period.Location = new System.Drawing.Point(-4, 140);
            this.btn_add_working_period.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_working_period.Name = "btn_add_working_period";
            this.btn_add_working_period.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_working_period.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_working_period.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_working_period.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_working_period.selected = false;
            this.btn_add_working_period.Size = new System.Drawing.Size(178, 25);
            this.btn_add_working_period.TabIndex = 63;
            this.btn_add_working_period.Text = "إضافة فترة عمل";
            this.btn_add_working_period.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_working_period.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_working_period.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_working_period.Click += new System.EventHandler(this.btn_add_working_period_Click);
            // 
            // btn_show_acount
            // 
            this.btn_show_acount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_acount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_acount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_acount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_acount.BorderRadius = 0;
            this.btn_show_acount.ButtonText = "عرض الحسابات";
            this.btn_show_acount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_acount.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_acount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_acount.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show_acount.Iconimage = null;
            this.btn_show_acount.Iconimage_right = null;
            this.btn_show_acount.Iconimage_right_Selected = null;
            this.btn_show_acount.Iconimage_Selected = null;
            this.btn_show_acount.IconMarginLeft = 0;
            this.btn_show_acount.IconMarginRight = 0;
            this.btn_show_acount.IconRightVisible = true;
            this.btn_show_acount.IconRightZoom = 0D;
            this.btn_show_acount.IconVisible = true;
            this.btn_show_acount.IconZoom = 40D;
            this.btn_show_acount.IsTab = false;
            this.btn_show_acount.Location = new System.Drawing.Point(1, 384);
            this.btn_show_acount.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_acount.Name = "btn_show_acount";
            this.btn_show_acount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_acount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_acount.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_acount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_acount.selected = false;
            this.btn_show_acount.Size = new System.Drawing.Size(178, 25);
            this.btn_show_acount.TabIndex = 53;
            this.btn_show_acount.Text = "عرض الحسابات";
            this.btn_show_acount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_acount.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_acount.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_acount.Click += new System.EventHandler(this.btn_show_acount_Click);
            // 
            // btn_update_emp
            // 
            this.btn_update_emp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_emp.BorderRadius = 0;
            this.btn_update_emp.ButtonText = "تعديل العاملين";
            this.btn_update_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_emp.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_emp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_emp.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update_emp.Iconimage = null;
            this.btn_update_emp.Iconimage_right = null;
            this.btn_update_emp.Iconimage_right_Selected = null;
            this.btn_update_emp.Iconimage_Selected = null;
            this.btn_update_emp.IconMarginLeft = 0;
            this.btn_update_emp.IconMarginRight = 0;
            this.btn_update_emp.IconRightVisible = true;
            this.btn_update_emp.IconRightZoom = 0D;
            this.btn_update_emp.IconVisible = true;
            this.btn_update_emp.IconZoom = 40D;
            this.btn_update_emp.IsTab = false;
            this.btn_update_emp.Location = new System.Drawing.Point(-4, 175);
            this.btn_update_emp.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_emp.Name = "btn_update_emp";
            this.btn_update_emp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_emp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_emp.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_emp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_emp.selected = false;
            this.btn_update_emp.Size = new System.Drawing.Size(178, 25);
            this.btn_update_emp.TabIndex = 64;
            this.btn_update_emp.Text = "تعديل العاملين";
            this.btn_update_emp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update_emp.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_emp.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_emp.Click += new System.EventHandler(this.btn_update_emp_Click);
            // 
            // btn_update_room
            // 
            this.btn_update_room.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_room.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_room.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_room.BorderRadius = 0;
            this.btn_update_room.ButtonText = "تعديل غرفة";
            this.btn_update_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_room.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_room.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_room.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update_room.Iconimage = null;
            this.btn_update_room.Iconimage_right = null;
            this.btn_update_room.Iconimage_right_Selected = null;
            this.btn_update_room.Iconimage_Selected = null;
            this.btn_update_room.IconMarginLeft = 0;
            this.btn_update_room.IconMarginRight = 0;
            this.btn_update_room.IconRightVisible = true;
            this.btn_update_room.IconRightZoom = 0D;
            this.btn_update_room.IconVisible = true;
            this.btn_update_room.IconZoom = 40D;
            this.btn_update_room.IsTab = false;
            this.btn_update_room.Location = new System.Drawing.Point(-4, 280);
            this.btn_update_room.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_room.Name = "btn_update_room";
            this.btn_update_room.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_room.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_room.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_room.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_room.selected = false;
            this.btn_update_room.Size = new System.Drawing.Size(178, 25);
            this.btn_update_room.TabIndex = 61;
            this.btn_update_room.Text = "تعديل غرفة";
            this.btn_update_room.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update_room.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_room.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_room.Click += new System.EventHandler(this.btn_update_room_Click);
            // 
            // btn_add_acount
            // 
            this.btn_add_acount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_acount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_acount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_acount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_acount.BorderRadius = 0;
            this.btn_add_acount.ButtonText = "إضافة حساب";
            this.btn_add_acount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_acount.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_acount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_acount.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_acount.Iconimage = null;
            this.btn_add_acount.Iconimage_right = null;
            this.btn_add_acount.Iconimage_right_Selected = null;
            this.btn_add_acount.Iconimage_Selected = null;
            this.btn_add_acount.IconMarginLeft = 0;
            this.btn_add_acount.IconMarginRight = 0;
            this.btn_add_acount.IconRightVisible = true;
            this.btn_add_acount.IconRightZoom = 0D;
            this.btn_add_acount.IconVisible = true;
            this.btn_add_acount.IconZoom = 40D;
            this.btn_add_acount.IsTab = false;
            this.btn_add_acount.Location = new System.Drawing.Point(1, 35);
            this.btn_add_acount.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_acount.Name = "btn_add_acount";
            this.btn_add_acount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_acount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_acount.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_acount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_acount.selected = false;
            this.btn_add_acount.Size = new System.Drawing.Size(178, 25);
            this.btn_add_acount.TabIndex = 59;
            this.btn_add_acount.Text = "إضافة حساب";
            this.btn_add_acount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_acount.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_acount.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_acount.Click += new System.EventHandler(this.btn_add_acount_Click);
            // 
            // btn_update_working_period
            // 
            this.btn_update_working_period.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_working_period.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_working_period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_working_period.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_working_period.BorderRadius = 0;
            this.btn_update_working_period.ButtonText = "تعديل فترة عمل";
            this.btn_update_working_period.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_working_period.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_working_period.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_working_period.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update_working_period.Iconimage = null;
            this.btn_update_working_period.Iconimage_right = null;
            this.btn_update_working_period.Iconimage_right_Selected = null;
            this.btn_update_working_period.Iconimage_Selected = null;
            this.btn_update_working_period.IconMarginLeft = 0;
            this.btn_update_working_period.IconMarginRight = 0;
            this.btn_update_working_period.IconRightVisible = true;
            this.btn_update_working_period.IconRightZoom = 0D;
            this.btn_update_working_period.IconVisible = true;
            this.btn_update_working_period.IconZoom = 40D;
            this.btn_update_working_period.IsTab = false;
            this.btn_update_working_period.Location = new System.Drawing.Point(-1, 314);
            this.btn_update_working_period.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_working_period.Name = "btn_update_working_period";
            this.btn_update_working_period.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_working_period.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_working_period.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_working_period.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_working_period.selected = false;
            this.btn_update_working_period.Size = new System.Drawing.Size(178, 25);
            this.btn_update_working_period.TabIndex = 63;
            this.btn_update_working_period.Text = "تعديل فترة عمل";
            this.btn_update_working_period.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update_working_period.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_working_period.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_working_period.Click += new System.EventHandler(this.btn_update_working_period_Click);
            // 
            // btn_add_interval
            // 
            this.btn_add_interval.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_interval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_interval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_interval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_interval.BorderRadius = 0;
            this.btn_add_interval.ButtonText = "إضافة فترة";
            this.btn_add_interval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_interval.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_interval.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_interval.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_interval.Iconimage = null;
            this.btn_add_interval.Iconimage_right = null;
            this.btn_add_interval.Iconimage_right_Selected = null;
            this.btn_add_interval.Iconimage_Selected = null;
            this.btn_add_interval.IconMarginLeft = 0;
            this.btn_add_interval.IconMarginRight = 0;
            this.btn_add_interval.IconRightVisible = true;
            this.btn_add_interval.IconRightZoom = 0D;
            this.btn_add_interval.IconVisible = true;
            this.btn_add_interval.IconZoom = 40D;
            this.btn_add_interval.IsTab = false;
            this.btn_add_interval.Location = new System.Drawing.Point(1, 70);
            this.btn_add_interval.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_interval.Name = "btn_add_interval";
            this.btn_add_interval.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_interval.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_interval.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_interval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_interval.selected = false;
            this.btn_add_interval.Size = new System.Drawing.Size(178, 25);
            this.btn_add_interval.TabIndex = 60;
            this.btn_add_interval.Text = "إضافة فترة";
            this.btn_add_interval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_interval.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_interval.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_interval.Click += new System.EventHandler(this.btn_add_interval_Click);
            // 
            // btn_add_room
            // 
            this.btn_add_room.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_room.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_room.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_room.BorderRadius = 0;
            this.btn_add_room.ButtonText = "إضافة غرفة";
            this.btn_add_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_room.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_room.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_room.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_room.Iconimage = null;
            this.btn_add_room.Iconimage_right = null;
            this.btn_add_room.Iconimage_right_Selected = null;
            this.btn_add_room.Iconimage_Selected = null;
            this.btn_add_room.IconMarginLeft = 0;
            this.btn_add_room.IconMarginRight = 0;
            this.btn_add_room.IconRightVisible = true;
            this.btn_add_room.IconRightZoom = 0D;
            this.btn_add_room.IconVisible = true;
            this.btn_add_room.IconZoom = 40D;
            this.btn_add_room.IsTab = false;
            this.btn_add_room.Location = new System.Drawing.Point(1, 105);
            this.btn_add_room.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_room.Name = "btn_add_room";
            this.btn_add_room.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_room.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_room.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_room.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_room.selected = false;
            this.btn_add_room.Size = new System.Drawing.Size(178, 25);
            this.btn_add_room.TabIndex = 61;
            this.btn_add_room.Text = "إضافة غرفة";
            this.btn_add_room.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_room.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_room.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_room.Click += new System.EventHandler(this.btn_add_room_Click);
            // 
            // panel_form
            // 
            this.panel_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form.Location = new System.Drawing.Point(2, 65);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(919, 619);
            this.panel_form.TabIndex = 7;
            // 
            // Main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 689);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_admin";
            this.Text = "Main_admin";
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
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_emp;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_working_period;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_acount;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_interval;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_room;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update_acount;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update_interval;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update_emp;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update_room;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update_working_period;
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_working_period;
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_department;
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_emp;
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_room;
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_acount;
    }
}