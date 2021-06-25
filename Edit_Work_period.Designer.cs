namespace Final_project
{
    partial class Edit_Work_period
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Work_period));
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.combox_situation = new System.Windows.Forms.ComboBox();
            this.theSituationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitallDataSet56 = new Final_project.hospitallDataSet56();
            this.label1 = new System.Windows.Forms.Label();
            this.theSituationTableAdapter = new Final_project.hospitallDataSet56TableAdapters.TheSituationTableAdapter();
            this.panel_title = new System.Windows.Forms.Panel();
            this.panel_hospital_name = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.maxBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.minBtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.theSituationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet56)).BeginInit();
            this.panel_title.SuspendLayout();
            this.panel_hospital_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            this.SuspendLayout();
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
            this.btn_add.Location = new System.Drawing.Point(187, 213);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(150, 50);
            this.btn_add.TabIndex = 26;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // combox_situation
            // 
            this.combox_situation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combox_situation.BackColor = System.Drawing.Color.White;
            this.combox_situation.DataSource = this.theSituationBindingSource;
            this.combox_situation.DisplayMember = "TheSituation";
            this.combox_situation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_situation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_situation.FormattingEnabled = true;
            this.combox_situation.Location = new System.Drawing.Point(154, 178);
            this.combox_situation.Name = "combox_situation";
            this.combox_situation.Size = new System.Drawing.Size(220, 27);
            this.combox_situation.TabIndex = 32;
            this.combox_situation.ValueMember = "Situationid";
            // 
            // theSituationBindingSource
            // 
            this.theSituationBindingSource.DataMember = "TheSituation";
            this.theSituationBindingSource.DataSource = this.hospitallDataSet56;
            // 
            // hospitallDataSet56
            // 
            this.hospitallDataSet56.DataSetName = "hospitallDataSet56";
            this.hospitallDataSet56.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(323, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "الحالة";
            // 
            // theSituationTableAdapter
            // 
            this.theSituationTableAdapter.ClearBeforeFill = true;
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
            this.panel_title.Size = new System.Drawing.Size(497, 67);
            this.panel_title.TabIndex = 34;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseMove);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseUp);
            // 
            // panel_hospital_name
            // 
            this.panel_hospital_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_hospital_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            this.panel_hospital_name.Controls.Add(this.Title);
            this.panel_hospital_name.Location = new System.Drawing.Point(327, 1);
            this.panel_hospital_name.Name = "panel_hospital_name";
            this.panel_hospital_name.Size = new System.Drawing.Size(168, 67);
            this.panel_hospital_name.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Gainsboro;
            this.Title.Location = new System.Drawing.Point(14, 22);
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
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
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
            // Edit_Work_period
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 277);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combox_situation);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_Work_period";
            this.Text = "Edit_Work_period";
            this.Load += new System.EventHandler(this.Edit_Work_period_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theSituationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet56)).EndInit();
            this.panel_title.ResumeLayout(false);
            this.panel_hospital_name.ResumeLayout(false);
            this.panel_hospital_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox combox_situation;
        private System.Windows.Forms.Label label1;
        private hospitallDataSet56 hospitallDataSet56;
        private System.Windows.Forms.BindingSource theSituationBindingSource;
        private hospitallDataSet56TableAdapters.TheSituationTableAdapter theSituationTableAdapter;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Panel panel_hospital_name;
        protected System.Windows.Forms.Label Title;
        private Bunifu.Framework.UI.BunifuImageButton maxBtn;
        private Bunifu.Framework.UI.BunifuImageButton exitBtn;
        private Bunifu.Framework.UI.BunifuImageButton minBtn;
    }
}