namespace Final_project
{
    partial class Add_working_period
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_working_period));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_situation = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combox_situations = new System.Windows.Forms.ComboBox();
            this.theSituationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitallDataSet45 = new Final_project.hospitallDataSet45();
            this.lbl_period = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combox_period = new System.Windows.Forms.ComboBox();
            this.timePeriodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitallDataSet44 = new Final_project.hospitallDataSet44();
            this.hospitallDataSet43 = new Final_project.hospitallDataSet43();
            this.typeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeeTableAdapter = new Final_project.hospitallDataSet43TableAdapters.TypeeTableAdapter();
            this.timePeriodsTableAdapter = new Final_project.hospitallDataSet44TableAdapters.TimePeriodsTableAdapter();
            this.theSituationTableAdapter = new Final_project.hospitallDataSet45TableAdapters.TheSituationTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theSituationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePeriodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkedListBox3);
            this.panel1.Controls.Add(this.checkedListBox2);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.lbl_situation);
            this.panel1.Controls.Add(this.combox_situations);
            this.panel1.Controls.Add(this.lbl_period);
            this.panel1.Controls.Add(this.combox_period);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 313);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(641, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "المستخدمين";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(390, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "الممرضين";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(168, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "الأطباء";
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(624, 193);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox3.TabIndex = 41;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(360, 193);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox2.TabIndex = 40;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(122, 193);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 39;
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
            this.btn_add.Location = new System.Drawing.Point(285, 356);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(220, 66);
            this.btn_add.TabIndex = 38;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_situation
            // 
            this.lbl_situation.Location = new System.Drawing.Point(132, 23);
            this.lbl_situation.Name = "lbl_situation";
            this.lbl_situation.Size = new System.Drawing.Size(130, 56);
            this.lbl_situation.TabIndex = 36;
            this.lbl_situation.Text = "الوضع";
            this.lbl_situation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combox_situations
            // 
            this.combox_situations.BackColor = System.Drawing.Color.White;
            this.combox_situations.DataSource = this.theSituationBindingSource;
            this.combox_situations.DisplayMember = "TheSituation";
            this.combox_situations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_situations.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_situations.FormattingEnabled = true;
            this.combox_situations.Location = new System.Drawing.Point(72, 97);
            this.combox_situations.Name = "combox_situations";
            this.combox_situations.Size = new System.Drawing.Size(220, 27);
            this.combox_situations.TabIndex = 35;
            this.combox_situations.ValueMember = "Situationid";
            // 
            // theSituationBindingSource
            // 
            this.theSituationBindingSource.DataMember = "TheSituation";
            this.theSituationBindingSource.DataSource = this.hospitallDataSet45;
            // 
            // hospitallDataSet45
            // 
            this.hospitallDataSet45.DataSetName = "hospitallDataSet45";
            this.hospitallDataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_period
            // 
            this.lbl_period.Location = new System.Drawing.Point(535, 23);
            this.lbl_period.Name = "lbl_period";
            this.lbl_period.Size = new System.Drawing.Size(130, 56);
            this.lbl_period.TabIndex = 26;
            this.lbl_period.Text = "الفترات الزمنية";
            this.lbl_period.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combox_period
            // 
            this.combox_period.BackColor = System.Drawing.Color.White;
            this.combox_period.DataSource = this.timePeriodsBindingSource;
            this.combox_period.DisplayMember = "ThePeriod";
            this.combox_period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_period.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_period.FormattingEnabled = true;
            this.combox_period.Location = new System.Drawing.Point(486, 97);
            this.combox_period.Name = "combox_period";
            this.combox_period.Size = new System.Drawing.Size(220, 27);
            this.combox_period.TabIndex = 24;
            this.combox_period.ValueMember = "periodnumber";
            this.combox_period.SelectedIndexChanged += new System.EventHandler(this.combox_period_SelectedIndexChanged);
            // 
            // timePeriodsBindingSource
            // 
            this.timePeriodsBindingSource.DataMember = "TimePeriods";
            this.timePeriodsBindingSource.DataSource = this.hospitallDataSet44;
            // 
            // hospitallDataSet44
            // 
            this.hospitallDataSet44.DataSetName = "hospitallDataSet44";
            this.hospitallDataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitallDataSet43
            // 
            this.hospitallDataSet43.DataSetName = "hospitallDataSet43";
            this.hospitallDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeeBindingSource
            // 
            this.typeeBindingSource.DataMember = "Typee";
            this.typeeBindingSource.DataSource = this.hospitallDataSet43;
            // 
            // typeeTableAdapter
            // 
            this.typeeTableAdapter.ClearBeforeFill = true;
            // 
            // timePeriodsTableAdapter
            // 
            this.timePeriodsTableAdapter.ClearBeforeFill = true;
            // 
            // theSituationTableAdapter
            // 
            this.theSituationTableAdapter.ClearBeforeFill = true;
            // 
            // Add_working_period
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_working_period";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Add_working_period_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theSituationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePeriodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combox_period;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_situation;
        private System.Windows.Forms.ComboBox combox_situations;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_period;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private hospitallDataSet43 hospitallDataSet43;
        private System.Windows.Forms.BindingSource typeeBindingSource;
        private hospitallDataSet43TableAdapters.TypeeTableAdapter typeeTableAdapter;
        private hospitallDataSet44 hospitallDataSet44;
        private System.Windows.Forms.BindingSource timePeriodsBindingSource;
        private hospitallDataSet44TableAdapters.TimePeriodsTableAdapter timePeriodsTableAdapter;
        private hospitallDataSet45 hospitallDataSet45;
        private System.Windows.Forms.BindingSource theSituationBindingSource;
        private hospitallDataSet45TableAdapters.TheSituationTableAdapter theSituationTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}