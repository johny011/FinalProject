namespace Final_project
{
    partial class Laboratory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laboratory));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_hospital_name = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.maxBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.minBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_button = new System.Windows.Forms.Panel();
            this.btn_show_required_analyzes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_analyz = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_update_analyz = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_show_analyz = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_show_test_results = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_add_result_of_an_analysis = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panel_title.Size = new System.Drawing.Size(888, 68);
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
            this.panel_hospital_name.Location = new System.Drawing.Point(707, 1);
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
            this.panel_button.Controls.Add(this.btn_show_required_analyzes);
            this.panel_button.Controls.Add(this.btn_add_analyz);
            this.panel_button.Controls.Add(this.btn_update_analyz);
            this.panel_button.Controls.Add(this.btn_show_analyz);
            this.panel_button.Controls.Add(this.btn_show_test_results);
            this.panel_button.Controls.Add(this.btn_add_result_of_an_analysis);
            this.panel_button.Location = new System.Drawing.Point(706, 66);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(181, 575);
            this.panel_button.TabIndex = 6;
            // 
            // btn_show_required_analyzes
            // 
            this.btn_show_required_analyzes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_required_analyzes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_required_analyzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_required_analyzes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_required_analyzes.BorderRadius = 0;
            this.btn_show_required_analyzes.ButtonText = "عرض التحاليل المطلوبةلمريض";
            this.btn_show_required_analyzes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_required_analyzes.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_required_analyzes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_required_analyzes.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show_required_analyzes.Iconimage = null;
            this.btn_show_required_analyzes.Iconimage_right = null;
            this.btn_show_required_analyzes.Iconimage_right_Selected = null;
            this.btn_show_required_analyzes.Iconimage_Selected = null;
            this.btn_show_required_analyzes.IconMarginLeft = 0;
            this.btn_show_required_analyzes.IconMarginRight = 0;
            this.btn_show_required_analyzes.IconRightVisible = true;
            this.btn_show_required_analyzes.IconRightZoom = 0D;
            this.btn_show_required_analyzes.IconVisible = true;
            this.btn_show_required_analyzes.IconZoom = 40D;
            this.btn_show_required_analyzes.IsTab = false;
            this.btn_show_required_analyzes.Location = new System.Drawing.Point(1, 203);
            this.btn_show_required_analyzes.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_required_analyzes.Name = "btn_show_required_analyzes";
            this.btn_show_required_analyzes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_required_analyzes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_required_analyzes.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_required_analyzes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_required_analyzes.selected = false;
            this.btn_show_required_analyzes.Size = new System.Drawing.Size(178, 40);
            this.btn_show_required_analyzes.TabIndex = 23;
            this.btn_show_required_analyzes.Text = "عرض التحاليل المطلوبةلمريض";
            this.btn_show_required_analyzes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_required_analyzes.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_required_analyzes.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_required_analyzes.Click += new System.EventHandler(this.btn_show_required_analyzes_Click);
            // 
            // btn_add_analyz
            // 
            this.btn_add_analyz.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_analyz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_analyz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_analyz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_analyz.BorderRadius = 0;
            this.btn_add_analyz.ButtonText = "إضافة تحليل";
            this.btn_add_analyz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_analyz.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_analyz.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_analyz.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_analyz.Iconimage = null;
            this.btn_add_analyz.Iconimage_right = null;
            this.btn_add_analyz.Iconimage_right_Selected = null;
            this.btn_add_analyz.Iconimage_Selected = null;
            this.btn_add_analyz.IconMarginLeft = 0;
            this.btn_add_analyz.IconMarginRight = 0;
            this.btn_add_analyz.IconRightVisible = true;
            this.btn_add_analyz.IconRightZoom = 0D;
            this.btn_add_analyz.IconVisible = true;
            this.btn_add_analyz.IconZoom = 40D;
            this.btn_add_analyz.IsTab = false;
            this.btn_add_analyz.Location = new System.Drawing.Point(1, 3);
            this.btn_add_analyz.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_analyz.Name = "btn_add_analyz";
            this.btn_add_analyz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_analyz.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_analyz.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_analyz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_analyz.selected = false;
            this.btn_add_analyz.Size = new System.Drawing.Size(178, 40);
            this.btn_add_analyz.TabIndex = 24;
            this.btn_add_analyz.Text = "إضافة تحليل";
            this.btn_add_analyz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_analyz.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_analyz.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_analyz.Click += new System.EventHandler(this.btn_add_analyz_Click);
            // 
            // btn_update_analyz
            // 
            this.btn_update_analyz.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_analyz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_analyz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_analyz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update_analyz.BorderRadius = 0;
            this.btn_update_analyz.ButtonText = "تعديل تحليل";
            this.btn_update_analyz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_analyz.DisabledColor = System.Drawing.Color.Gray;
            this.btn_update_analyz.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_analyz.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_update_analyz.Iconimage = null;
            this.btn_update_analyz.Iconimage_right = null;
            this.btn_update_analyz.Iconimage_right_Selected = null;
            this.btn_update_analyz.Iconimage_Selected = null;
            this.btn_update_analyz.IconMarginLeft = 0;
            this.btn_update_analyz.IconMarginRight = 0;
            this.btn_update_analyz.IconRightVisible = true;
            this.btn_update_analyz.IconRightZoom = 0D;
            this.btn_update_analyz.IconVisible = true;
            this.btn_update_analyz.IconZoom = 40D;
            this.btn_update_analyz.IsTab = false;
            this.btn_update_analyz.Location = new System.Drawing.Point(1, 103);
            this.btn_update_analyz.Margin = new System.Windows.Forms.Padding(5);
            this.btn_update_analyz.Name = "btn_update_analyz";
            this.btn_update_analyz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_update_analyz.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_update_analyz.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update_analyz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_update_analyz.selected = false;
            this.btn_update_analyz.Size = new System.Drawing.Size(178, 40);
            this.btn_update_analyz.TabIndex = 26;
            this.btn_update_analyz.Text = "تعديل تحليل";
            this.btn_update_analyz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update_analyz.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_update_analyz.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update_analyz.Click += new System.EventHandler(this.btn_update_analyz_Click);
            // 
            // btn_show_analyz
            // 
            this.btn_show_analyz.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_analyz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_analyz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_analyz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_analyz.BorderRadius = 0;
            this.btn_show_analyz.ButtonText = "عرض التحاليل ";
            this.btn_show_analyz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_analyz.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_analyz.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_analyz.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show_analyz.Iconimage = null;
            this.btn_show_analyz.Iconimage_right = null;
            this.btn_show_analyz.Iconimage_right_Selected = null;
            this.btn_show_analyz.Iconimage_Selected = null;
            this.btn_show_analyz.IconMarginLeft = 0;
            this.btn_show_analyz.IconMarginRight = 0;
            this.btn_show_analyz.IconRightVisible = true;
            this.btn_show_analyz.IconRightZoom = 0D;
            this.btn_show_analyz.IconVisible = true;
            this.btn_show_analyz.IconZoom = 40D;
            this.btn_show_analyz.IsTab = false;
            this.btn_show_analyz.Location = new System.Drawing.Point(1, 153);
            this.btn_show_analyz.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_analyz.Name = "btn_show_analyz";
            this.btn_show_analyz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_analyz.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_analyz.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_analyz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_analyz.selected = false;
            this.btn_show_analyz.Size = new System.Drawing.Size(178, 40);
            this.btn_show_analyz.TabIndex = 27;
            this.btn_show_analyz.Text = "عرض التحاليل ";
            this.btn_show_analyz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_analyz.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_analyz.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_analyz.Click += new System.EventHandler(this.btn_show_analyz_Click);
            // 
            // btn_show_test_results
            // 
            this.btn_show_test_results.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_test_results.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_test_results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_test_results.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_test_results.BorderRadius = 0;
            this.btn_show_test_results.ButtonText = "عرض نتائج التحاليل لمريض";
            this.btn_show_test_results.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_test_results.DisabledColor = System.Drawing.Color.Gray;
            this.btn_show_test_results.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_test_results.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_show_test_results.Iconimage = null;
            this.btn_show_test_results.Iconimage_right = null;
            this.btn_show_test_results.Iconimage_right_Selected = null;
            this.btn_show_test_results.Iconimage_Selected = null;
            this.btn_show_test_results.IconMarginLeft = 0;
            this.btn_show_test_results.IconMarginRight = 0;
            this.btn_show_test_results.IconRightVisible = true;
            this.btn_show_test_results.IconRightZoom = 0D;
            this.btn_show_test_results.IconVisible = true;
            this.btn_show_test_results.IconZoom = 40D;
            this.btn_show_test_results.IsTab = false;
            this.btn_show_test_results.Location = new System.Drawing.Point(1, 253);
            this.btn_show_test_results.Margin = new System.Windows.Forms.Padding(5);
            this.btn_show_test_results.Name = "btn_show_test_results";
            this.btn_show_test_results.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_show_test_results.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_show_test_results.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_show_test_results.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_show_test_results.selected = false;
            this.btn_show_test_results.Size = new System.Drawing.Size(178, 40);
            this.btn_show_test_results.TabIndex = 28;
            this.btn_show_test_results.Text = "عرض نتائج التحاليل لمريض";
            this.btn_show_test_results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_show_test_results.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_show_test_results.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_test_results.Click += new System.EventHandler(this.btn_show_test_results_Click);
            // 
            // btn_add_result_of_an_analysis
            // 
            this.btn_add_result_of_an_analysis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_result_of_an_analysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_result_of_an_analysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_result_of_an_analysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_result_of_an_analysis.BorderRadius = 0;
            this.btn_add_result_of_an_analysis.ButtonText = "إضافة نتيجة تحليل";
            this.btn_add_result_of_an_analysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_result_of_an_analysis.DisabledColor = System.Drawing.Color.Gray;
            this.btn_add_result_of_an_analysis.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_result_of_an_analysis.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add_result_of_an_analysis.Iconimage = null;
            this.btn_add_result_of_an_analysis.Iconimage_right = null;
            this.btn_add_result_of_an_analysis.Iconimage_right_Selected = null;
            this.btn_add_result_of_an_analysis.Iconimage_Selected = null;
            this.btn_add_result_of_an_analysis.IconMarginLeft = 0;
            this.btn_add_result_of_an_analysis.IconMarginRight = 0;
            this.btn_add_result_of_an_analysis.IconRightVisible = true;
            this.btn_add_result_of_an_analysis.IconRightZoom = 0D;
            this.btn_add_result_of_an_analysis.IconVisible = true;
            this.btn_add_result_of_an_analysis.IconZoom = 40D;
            this.btn_add_result_of_an_analysis.IsTab = false;
            this.btn_add_result_of_an_analysis.Location = new System.Drawing.Point(1, 53);
            this.btn_add_result_of_an_analysis.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_result_of_an_analysis.Name = "btn_add_result_of_an_analysis";
            this.btn_add_result_of_an_analysis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.btn_add_result_of_an_analysis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.btn_add_result_of_an_analysis.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add_result_of_an_analysis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add_result_of_an_analysis.selected = false;
            this.btn_add_result_of_an_analysis.Size = new System.Drawing.Size(178, 40);
            this.btn_add_result_of_an_analysis.TabIndex = 25;
            this.btn_add_result_of_an_analysis.Text = "إضافة نتيجة تحليل";
            this.btn_add_result_of_an_analysis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add_result_of_an_analysis.Textcolor = System.Drawing.Color.Gainsboro;
            this.btn_add_result_of_an_analysis.TextFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_result_of_an_analysis.Click += new System.EventHandler(this.btn_add_result_of_an_analysis_Click);
            // 
            // panel_form
            // 
            this.panel_form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_form.Location = new System.Drawing.Point(0, 66);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(706, 539);
            this.panel_form.TabIndex = 7;
            // 
            // Laboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 606);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_button);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laboratory";
            this.Text = "Laboratory";
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
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_required_analyzes;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_analyz;
        private Bunifu.Framework.UI.BunifuFlatButton btn_update_analyz;
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_analyz;
        private Bunifu.Framework.UI.BunifuFlatButton btn_show_test_results;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add_result_of_an_analysis;
    }
}