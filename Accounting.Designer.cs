namespace Final_project
{
    partial class Accounting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_hospital_name = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.maxBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.minBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_form = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_refresh = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel_title.SuspendLayout();
            this.panel_hospital_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.panel_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(136)))));
            this.panel_title.Controls.Add(this.panel_hospital_name);
            this.panel_title.Controls.Add(this.maxBtn);
            this.panel_title.Controls.Add(this.exitBtn);
            this.panel_title.Controls.Add(this.minBtn);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(916, 67);
            this.panel_title.TabIndex = 24;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseMove);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseUp);
            // 
            // panel_hospital_name
            // 
            this.panel_hospital_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_hospital_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel_hospital_name.Controls.Add(this.Title);
            this.panel_hospital_name.Location = new System.Drawing.Point(735, 1);
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
            // panel_form
            // 
            this.panel_form.Controls.Add(this.label25);
            this.panel_form.Controls.Add(this.bunifuThinButton21);
            this.panel_form.Controls.Add(this.btn_refresh);
            this.panel_form.Controls.Add(this.label19);
            this.panel_form.Controls.Add(this.label15);
            this.panel_form.Controls.Add(this.label14);
            this.panel_form.Controls.Add(this.label11);
            this.panel_form.Controls.Add(this.textBox3);
            this.panel_form.Controls.Add(this.label18);
            this.panel_form.Controls.Add(this.label12);
            this.panel_form.Controls.Add(this.textBox4);
            this.panel_form.Controls.Add(this.label20);
            this.panel_form.Controls.Add(this.label24);
            this.panel_form.Controls.Add(this.label16);
            this.panel_form.Controls.Add(this.label13);
            this.panel_form.Controls.Add(this.label23);
            this.panel_form.Controls.Add(this.label22);
            this.panel_form.Controls.Add(this.label21);
            this.panel_form.Controls.Add(this.textBox2);
            this.panel_form.Controls.Add(this.label10);
            this.panel_form.Controls.Add(this.label8);
            this.panel_form.Controls.Add(this.label9);
            this.panel_form.Controls.Add(this.label7);
            this.panel_form.Controls.Add(this.label6);
            this.panel_form.Controls.Add(this.label5);
            this.panel_form.Controls.Add(this.label4);
            this.panel_form.Controls.Add(this.label2);
            this.panel_form.Controls.Add(this.label17);
            this.panel_form.Controls.Add(this.label1);
            this.panel_form.Controls.Add(this.dateTimePicker1);
            this.panel_form.Controls.Add(this.dataGridView1);
            this.panel_form.Controls.Add(this.dataGridView2);
            this.panel_form.Controls.Add(this.textBox1);
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Location = new System.Drawing.Point(0, 67);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(916, 692);
            this.panel_form.TabIndex = 25;
            this.panel_form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_form_Paint);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label25.Location = new System.Drawing.Point(637, 100);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(156, 19);
            this.label25.TabIndex = 56;
            this.label25.Text = "رقم دخولية المريض";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "طباعة";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(180, 635);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(220, 52);
            this.bunifuThinButton21.TabIndex = 54;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_refresh
            // 
            this.btn_refresh.ActiveBorderThickness = 1;
            this.btn_refresh.ActiveCornerRadius = 20;
            this.btn_refresh.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_refresh.ActiveForecolor = System.Drawing.Color.White;
            this.btn_refresh.ActiveLineColor = System.Drawing.Color.White;
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh.BackgroundImage")));
            this.btn_refresh.ButtonText = "تحديث";
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.IdleBorderThickness = 1;
            this.btn_refresh.IdleCornerRadius = 20;
            this.btn_refresh.IdleFillColor = System.Drawing.Color.White;
            this.btn_refresh.IdleForecolor = System.Drawing.Color.Black;
            this.btn_refresh.IdleLineColor = System.Drawing.Color.Black;
            this.btn_refresh.Location = new System.Drawing.Point(491, 635);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(5);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(220, 52);
            this.btn_refresh.TabIndex = 53;
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.Location = new System.Drawing.Point(563, 603);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 14);
            this.label19.TabIndex = 52;
            this.label19.Text = "ليرة";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(488, 603);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 14);
            this.label15.TabIndex = 51;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(244, 599);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 19);
            this.label14.TabIndex = 50;
            this.label14.Text = "المبلغ النهائي الواجب دفعه";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(29, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 19);
            this.label11.TabIndex = 49;
            this.label11.Text = "نسبة التأمينات";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.HintForeColor = System.Drawing.Color.Empty;
            this.textBox3.HintText = "";
            this.textBox3.isPassword = false;
            this.textBox3.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox3.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox3.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox3.LineThickness = 4;
            this.textBox3.Location = new System.Drawing.Point(154, 497);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(140, 47);
            this.textBox3.TabIndex = 48;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label18.Location = new System.Drawing.Point(303, 513);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 14);
            this.label18.TabIndex = 47;
            this.label18.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(514, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 46;
            this.label12.Text = "الضرائب";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.HintForeColor = System.Drawing.Color.Empty;
            this.textBox4.HintText = "";
            this.textBox4.isPassword = false;
            this.textBox4.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox4.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox4.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox4.LineThickness = 4;
            this.textBox4.Location = new System.Drawing.Point(617, 481);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(140, 47);
            this.textBox4.TabIndex = 45;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label20.Location = new System.Drawing.Point(786, 503);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 14);
            this.label20.TabIndex = 44;
            this.label20.Text = "ليرة";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label24.Location = new System.Drawing.Point(547, 563);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 14);
            this.label24.TabIndex = 43;
            this.label24.Text = "ليرة";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(483, 564);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 14);
            this.label16.TabIndex = 42;
            this.label16.Text = "label16";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(363, 558);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 19);
            this.label13.TabIndex = 41;
            this.label13.Text = "نسبة الحسم";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label23.Location = new System.Drawing.Point(699, 372);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 14);
            this.label23.TabIndex = 40;
            this.label23.Text = "ليرة";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Location = new System.Drawing.Point(638, 415);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 14);
            this.label22.TabIndex = 39;
            this.label22.Text = "ليرة";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label21.Location = new System.Drawing.Point(638, 443);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 14);
            this.label21.TabIndex = 38;
            this.label21.Text = "ليرة";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.HintForeColor = System.Drawing.Color.Empty;
            this.textBox2.HintText = "";
            this.textBox2.isPassword = false;
            this.textBox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.LineThickness = 4;
            this.textBox2.Location = new System.Drawing.Point(448, 351);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(220, 47);
            this.textBox2.TabIndex = 37;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(458, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 14);
            this.label10.TabIndex = 36;
            this.label10.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 35;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(197, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "المجموع  المترتب كامل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(208, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "الدفعة الأولية المعطاة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(209, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "مبلغ التكاليف المترتبة";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(529, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "الصور التي تم اجرائها ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(101, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "التحاليل التي تم إجرائها";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(637, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "تاريخ الفاتورة";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Location = new System.Drawing.Point(644, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 19);
            this.label17.TabIndex = 28;
            this.label17.Text = "رقم الفاتورة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(410, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(429, 185);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(346, 150);
            this.dataGridView2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.HintForeColor = System.Drawing.Color.Empty;
            this.textBox1.HintText = "";
            this.textBox1.isPassword = false;
            this.textBox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.LineThickness = 4;
            this.textBox1.Location = new System.Drawing.Point(390, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(220, 51);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.OnValueChanged += new System.EventHandler(this.textBox1_OnValueChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 759);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accounting";
            this.Text = "Accounting";
            this.panel_title.ResumeLayout(false);
            this.panel_hospital_name.ResumeLayout(false);
            this.panel_hospital_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.panel_form.ResumeLayout(false);
            this.panel_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label25;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_refresh;
    }
}