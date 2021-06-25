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
            this.maxBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.minBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_hospital_name = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_update_acount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_show_department = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_interval = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_emp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_room = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_working_period = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_emp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_working_period = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_acount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_interval = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_room = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_form = new System.Windows.Forms.Panel();
            this.addPanel_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewPanle_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panel_hospital_name.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel_title.Controls.Add(this.maxBtn);
            this.panel_title.Controls.Add(this.exitBtn);
            this.panel_title.Controls.Add(this.minBtn);
            this.panel_title.Location = new System.Drawing.Point(-1, -1);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1118, 67);
            this.panel_title.TabIndex = 5;
            this.panel_title.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_title_Paint);
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseMove);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseUp);
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
            // panel_hospital_name
            // 
            this.panel_hospital_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel_hospital_name.Controls.Add(this.Title);
            this.panel_hospital_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_hospital_name.Location = new System.Drawing.Point(0, 0);
            this.panel_hospital_name.Name = "panel_hospital_name";
            this.panel_hospital_name.Size = new System.Drawing.Size(192, 67);
            this.panel_hospital_name.TabIndex = 2;
            // 
            // Title
            // 
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
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.panel.Controls.Add(this.btn_update_acount);
            this.panel.Controls.Add(this.btn_show_department);
            this.panel.Controls.Add(this.btn_update_interval);
            this.panel.Controls.Add(this.btn_update_emp);
            this.panel.Controls.Add(this.btn_update_room);
            this.panel.Controls.Add(this.btn_update_working_period);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 357);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(192, 250);
            this.panel.TabIndex = 6;
            this.panel.Visible = false;
            // 
            // btn_update_acount
            // 
            this.btn_update_acount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_acount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_acount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_acount.BorderRadius = 0;
            this.btn_update_acount.ButtonText = "عرض وتعديل الحسابات";
            this.btn_update_acount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_acount.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_acount.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_update_acount.Location = new System.Drawing.Point(0, 200);
            this.btn_update_acount.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_acount.Name = "btn_update_acount";
            this.btn_update_acount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_acount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_acount.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_acount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_acount.selected = false;
            this.btn_update_acount.Size = new System.Drawing.Size(192, 40);
            this.btn_update_acount.TabIndex = 66;
            this.btn_update_acount.Text = "عرض وتعديل الحسابات";
            this.btn_update_acount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_acount.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_acount.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_acount.Click += new System.EventHandler(this.btn_update_acount_Click);
            // 
            // btn_show_department
            // 
            this.btn_show_department.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_department.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_department.BorderRadius = 0;
            this.btn_show_department.ButtonText = "عرض الأقسام";
            this.btn_show_department.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_department.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_department.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_show_department.Location = new System.Drawing.Point(0, 160);
            this.btn_show_department.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_department.Name = "btn_show_department";
            this.btn_show_department.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_department.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_department.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_department.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_department.selected = false;
            this.btn_show_department.Size = new System.Drawing.Size(192, 40);
            this.btn_show_department.TabIndex = 55;
            this.btn_show_department.Text = "عرض الأقسام";
            this.btn_show_department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show_department.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_department.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_department.Click += new System.EventHandler(this.btn_show_department_Click);
            // 
            // btn_update_interval
            // 
            this.btn_update_interval.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_interval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_interval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_interval.BorderRadius = 0;
            this.btn_update_interval.ButtonText = "عرض وتعديل فترة";
            this.btn_update_interval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_interval.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_interval.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_update_interval.Location = new System.Drawing.Point(0, 120);
            this.btn_update_interval.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_interval.Name = "btn_update_interval";
            this.btn_update_interval.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_interval.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_interval.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_interval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_interval.selected = false;
            this.btn_update_interval.Size = new System.Drawing.Size(192, 40);
            this.btn_update_interval.TabIndex = 65;
            this.btn_update_interval.Text = "عرض وتعديل فترة";
            this.btn_update_interval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_interval.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_interval.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_interval.Click += new System.EventHandler(this.btn_update_interval_Click);
            // 
            // btn_update_emp
            // 
            this.btn_update_emp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_emp.BorderRadius = 0;
            this.btn_update_emp.ButtonText = "عرض وتعديل العاملين";
            this.btn_update_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_emp.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_emp.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_update_emp.Location = new System.Drawing.Point(0, 80);
            this.btn_update_emp.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_emp.Name = "btn_update_emp";
            this.btn_update_emp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_emp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_emp.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_emp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_emp.selected = false;
            this.btn_update_emp.Size = new System.Drawing.Size(192, 40);
            this.btn_update_emp.TabIndex = 64;
            this.btn_update_emp.Text = "عرض وتعديل العاملين";
            this.btn_update_emp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_emp.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_emp.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_emp.Click += new System.EventHandler(this.btn_update_emp_Click);
            // 
            // btn_update_room
            // 
            this.btn_update_room.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_room.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_room.BorderRadius = 0;
            this.btn_update_room.ButtonText = "عرض وتعديل الغرف";
            this.btn_update_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_room.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_room.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_update_room.Location = new System.Drawing.Point(0, 40);
            this.btn_update_room.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_room.Name = "btn_update_room";
            this.btn_update_room.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_room.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_room.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_room.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_room.selected = false;
            this.btn_update_room.Size = new System.Drawing.Size(192, 40);
            this.btn_update_room.TabIndex = 61;
            this.btn_update_room.Text = "عرض وتعديل الغرف";
            this.btn_update_room.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_room.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_room.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_room.Click += new System.EventHandler(this.btn_update_room_Click);
            // 
            // btn_update_working_period
            // 
            this.btn_update_working_period.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_working_period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_working_period.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_working_period.BorderRadius = 0;
            this.btn_update_working_period.ButtonText = "عرض وتعديل فترة عمل";
            this.btn_update_working_period.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_working_period.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_working_period.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_update_working_period.Location = new System.Drawing.Point(0, 0);
            this.btn_update_working_period.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_working_period.Name = "btn_update_working_period";
            this.btn_update_working_period.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_working_period.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_working_period.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_working_period.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_working_period.selected = false;
            this.btn_update_working_period.Size = new System.Drawing.Size(192, 40);
            this.btn_update_working_period.TabIndex = 63;
            this.btn_update_working_period.Text = "عرض وتعديل فترة عمل";
            this.btn_update_working_period.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_working_period.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_working_period.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_working_period.Click += new System.EventHandler(this.btn_update_working_period_Click);
            // 
            // btn_add_emp
            // 
            this.btn_add_emp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_emp.BorderRadius = 0;
            this.btn_add_emp.ButtonText = "إضافة عاملين";
            this.btn_add_emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_emp.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_emp.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_add_emp.Location = new System.Drawing.Point(0, 0);
            this.btn_add_emp.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_emp.Name = "btn_add_emp";
            this.btn_add_emp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_emp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_emp.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_emp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_emp.selected = false;
            this.btn_add_emp.Size = new System.Drawing.Size(192, 40);
            this.btn_add_emp.TabIndex = 58;
            this.btn_add_emp.Text = "إضافة عاملين";
            this.btn_add_emp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_emp.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_emp.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_emp.Click += new System.EventHandler(this.btn_add_emp_Click);
            // 
            // btn_add_working_period
            // 
            this.btn_add_working_period.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_working_period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_working_period.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_working_period.BorderRadius = 0;
            this.btn_add_working_period.ButtonText = "إضافة فترة عمل";
            this.btn_add_working_period.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_working_period.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_working_period.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_add_working_period.Location = new System.Drawing.Point(0, 160);
            this.btn_add_working_period.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_working_period.Name = "btn_add_working_period";
            this.btn_add_working_period.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_working_period.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_working_period.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_working_period.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_working_period.selected = false;
            this.btn_add_working_period.Size = new System.Drawing.Size(192, 40);
            this.btn_add_working_period.TabIndex = 63;
            this.btn_add_working_period.Text = "إضافة فترة عمل";
            this.btn_add_working_period.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_working_period.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_working_period.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_working_period.Click += new System.EventHandler(this.btn_add_working_period_Click);
            // 
            // btn_add_acount
            // 
            this.btn_add_acount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_acount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_acount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_acount.BorderRadius = 0;
            this.btn_add_acount.ButtonText = "إضافة حساب";
            this.btn_add_acount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_acount.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_acount.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_add_acount.Location = new System.Drawing.Point(0, 120);
            this.btn_add_acount.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_acount.Name = "btn_add_acount";
            this.btn_add_acount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_acount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_acount.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_acount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_acount.selected = false;
            this.btn_add_acount.Size = new System.Drawing.Size(192, 40);
            this.btn_add_acount.TabIndex = 59;
            this.btn_add_acount.Text = "إضافة حساب";
            this.btn_add_acount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_acount.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_acount.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_acount.Click += new System.EventHandler(this.btn_add_acount_Click);
            // 
            // btn_add_interval
            // 
            this.btn_add_interval.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_interval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_interval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_interval.BorderRadius = 0;
            this.btn_add_interval.ButtonText = "إضافة فترة";
            this.btn_add_interval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_interval.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_interval.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_add_interval.Location = new System.Drawing.Point(0, 40);
            this.btn_add_interval.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_interval.Name = "btn_add_interval";
            this.btn_add_interval.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_interval.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_interval.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_interval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_interval.selected = false;
            this.btn_add_interval.Size = new System.Drawing.Size(192, 40);
            this.btn_add_interval.TabIndex = 60;
            this.btn_add_interval.Text = "إضافة فترة";
            this.btn_add_interval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_interval.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_interval.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_interval.Click += new System.EventHandler(this.btn_add_interval_Click);
            // 
            // btn_add_room
            // 
            this.btn_add_room.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_room.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_room.BorderRadius = 0;
            this.btn_add_room.ButtonText = "إضافة غرفة";
            this.btn_add_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_room.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_room.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.btn_add_room.Location = new System.Drawing.Point(0, 80);
            this.btn_add_room.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_room.Name = "btn_add_room";
            this.btn_add_room.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_room.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_room.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_room.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_room.selected = false;
            this.btn_add_room.Size = new System.Drawing.Size(192, 40);
            this.btn_add_room.TabIndex = 61;
            this.btn_add_room.Text = "إضافة غرفة";
            this.btn_add_room.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel_form.Size = new System.Drawing.Size(932, 635);
            this.panel_form.TabIndex = 7;
            // 
            // addPanel_btn
            // 
            this.addPanel_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.addPanel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.addPanel_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addPanel_btn.BorderRadius = 0;
            this.addPanel_btn.ButtonText = "إضافة ";
            this.addPanel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPanel_btn.DisabledColor = System.Drawing.Color.Gray;
            this.addPanel_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPanel_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.addPanel_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.addPanel_btn.Iconimage = null;
            this.addPanel_btn.Iconimage_right = null;
            this.addPanel_btn.Iconimage_right_Selected = null;
            this.addPanel_btn.Iconimage_Selected = null;
            this.addPanel_btn.IconMarginLeft = 0;
            this.addPanel_btn.IconMarginRight = 0;
            this.addPanel_btn.IconRightVisible = true;
            this.addPanel_btn.IconRightZoom = 0D;
            this.addPanel_btn.IconVisible = true;
            this.addPanel_btn.IconZoom = 40D;
            this.addPanel_btn.IsTab = false;
            this.addPanel_btn.Location = new System.Drawing.Point(0, 67);
            this.addPanel_btn.Margin = new System.Windows.Forms.Padding(5);
            this.addPanel_btn.Name = "addPanel_btn";
            this.addPanel_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.addPanel_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.addPanel_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.addPanel_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addPanel_btn.selected = false;
            this.addPanel_btn.Size = new System.Drawing.Size(192, 40);
            this.addPanel_btn.TabIndex = 59;
            this.addPanel_btn.Text = "إضافة ";
            this.addPanel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPanel_btn.Textcolor = System.Drawing.Color.Gainsboro;
            this.addPanel_btn.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.addPanel_btn.Click += new System.EventHandler(this.addPanel_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.viewPanle_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addPanel_btn);
            this.panel1.Controls.Add(this.panel_hospital_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(924, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 705);
            this.panel1.TabIndex = 8;
            // 
            // viewPanle_btn
            // 
            this.viewPanle_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.viewPanle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.viewPanle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewPanle_btn.BorderRadius = 0;
            this.viewPanle_btn.ButtonText = "عرض و تعديل";
            this.viewPanle_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPanle_btn.DisabledColor = System.Drawing.Color.Gray;
            this.viewPanle_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewPanle_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.viewPanle_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.viewPanle_btn.Iconimage = null;
            this.viewPanle_btn.Iconimage_right = null;
            this.viewPanle_btn.Iconimage_right_Selected = null;
            this.viewPanle_btn.Iconimage_Selected = null;
            this.viewPanle_btn.IconMarginLeft = 0;
            this.viewPanle_btn.IconMarginRight = 0;
            this.viewPanle_btn.IconRightVisible = true;
            this.viewPanle_btn.IconRightZoom = 0D;
            this.viewPanle_btn.IconVisible = true;
            this.viewPanle_btn.IconZoom = 40D;
            this.viewPanle_btn.IsTab = false;
            this.viewPanle_btn.Location = new System.Drawing.Point(0, 317);
            this.viewPanle_btn.Margin = new System.Windows.Forms.Padding(5);
            this.viewPanle_btn.Name = "viewPanle_btn";
            this.viewPanle_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.viewPanle_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.viewPanle_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.viewPanle_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.viewPanle_btn.selected = false;
            this.viewPanle_btn.Size = new System.Drawing.Size(192, 40);
            this.viewPanle_btn.TabIndex = 62;
            this.viewPanle_btn.Text = "عرض و تعديل";
            this.viewPanle_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewPanle_btn.Textcolor = System.Drawing.Color.Gainsboro;
            this.viewPanle_btn.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.viewPanle_btn.Click += new System.EventHandler(this.viewPanle_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.btn_add_working_period);
            this.panel2.Controls.Add(this.btn_add_acount);
            this.panel2.Controls.Add(this.btn_add_room);
            this.panel2.Controls.Add(this.btn_add_interval);
            this.panel2.Controls.Add(this.btn_add_emp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 210);
            this.panel2.TabIndex = 60;
            this.panel2.Visible = false;
            // 
            // Main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_admin";
            this.Text = "Main_admin";
            this.panel_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panel_hospital_name.ResumeLayout(false);
            this.panel_hospital_name.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel;
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
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_department;
        private Bunifu.Framework.UI.BunifuFlatButton addPanel_btn;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton viewPanle_btn;
        private System.Windows.Forms.Panel panel2;
    }
}