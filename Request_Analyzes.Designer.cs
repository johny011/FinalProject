namespace Final_project
{
    partial class Request_Analyzes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request_Analyzes));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.analysisnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analysisnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectAnalyzes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.analyzesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitallDataSet50 = new Final_project.hospitallDataSet50();
            this.txt_Admissionid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Request = new Bunifu.Framework.UI.BunifuThinButton2();
            this.analyzesTableAdapter = new Final_project.hospitallDataSet50TableAdapters.AnalyzesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet50)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.analysisnumberDataGridViewTextBoxColumn,
            this.analysisnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.processingDataGridViewTextBoxColumn,
            this.selectAnalyzes});
            this.dataGridView1.DataSource = this.analyzesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // analysisnumberDataGridViewTextBoxColumn
            // 
            this.analysisnumberDataGridViewTextBoxColumn.DataPropertyName = "Analysisnumber";
            this.analysisnumberDataGridViewTextBoxColumn.HeaderText = "Analysisnumber";
            this.analysisnumberDataGridViewTextBoxColumn.Name = "analysisnumberDataGridViewTextBoxColumn";
            this.analysisnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // analysisnameDataGridViewTextBoxColumn
            // 
            this.analysisnameDataGridViewTextBoxColumn.DataPropertyName = "Analysisname";
            this.analysisnameDataGridViewTextBoxColumn.HeaderText = "Analysisname";
            this.analysisnameDataGridViewTextBoxColumn.Name = "analysisnameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // processingDataGridViewTextBoxColumn
            // 
            this.processingDataGridViewTextBoxColumn.DataPropertyName = "processing";
            this.processingDataGridViewTextBoxColumn.HeaderText = "processing";
            this.processingDataGridViewTextBoxColumn.Name = "processingDataGridViewTextBoxColumn";
            // 
            // selectAnalyzes
            // 
            this.selectAnalyzes.HeaderText = "select analyze";
            this.selectAnalyzes.Name = "selectAnalyzes";
            this.selectAnalyzes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selectAnalyzes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // analyzesBindingSource
            // 
            this.analyzesBindingSource.DataMember = "Analyzes";
            this.analyzesBindingSource.DataSource = this.hospitallDataSet50;
            // 
            // hospitallDataSet50
            // 
            this.hospitallDataSet50.DataSetName = "hospitallDataSet50";
            this.hospitallDataSet50.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_Admissionid
            // 
            this.txt_Admissionid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Admissionid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Admissionid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Admissionid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Admissionid.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Admissionid.HintText = "رقم دخولية المريض";
            this.txt_Admissionid.isPassword = false;
            this.txt_Admissionid.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_Admissionid.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Admissionid.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_Admissionid.LineThickness = 4;
            this.txt_Admissionid.Location = new System.Drawing.Point(418, 13);
            this.txt_Admissionid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Admissionid.Name = "txt_Admissionid";
            this.txt_Admissionid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Admissionid.Size = new System.Drawing.Size(220, 60);
            this.txt_Admissionid.TabIndex = 29;
            this.txt_Admissionid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Admissionid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Admissionid_KeyPress);
            // 
            // btn_Request
            // 
            this.btn_Request.ActiveBorderThickness = 1;
            this.btn_Request.ActiveCornerRadius = 20;
            this.btn_Request.ActiveFillColor = System.Drawing.Color.White;
            this.btn_Request.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Request.ActiveLineColor = System.Drawing.Color.White;
            this.btn_Request.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Request.BackColor = System.Drawing.Color.White;
            this.btn_Request.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Request.BackgroundImage")));
            this.btn_Request.ButtonText = "طلب";
            this.btn_Request.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Request.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Request.ForeColor = System.Drawing.Color.Black;
            this.btn_Request.IdleBorderThickness = 1;
            this.btn_Request.IdleCornerRadius = 20;
            this.btn_Request.IdleFillColor = System.Drawing.Color.White;
            this.btn_Request.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Request.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Request.Location = new System.Drawing.Point(163, 10);
            this.btn_Request.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(220, 66);
            this.btn_Request.TabIndex = 28;
            this.btn_Request.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            // 
            // analyzesTableAdapter
            // 
            this.analyzesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Request);
            this.panel1.Controls.Add(this.txt_Admissionid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 30;
            // 
            // Request_Analyzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Request_Analyzes";
            this.Text = "Request_Analyzes";
            this.Load += new System.EventHandler(this.Request_Analyzes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet50)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Admissionid;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Request;
        private hospitallDataSet50 hospitallDataSet50;
        private System.Windows.Forms.BindingSource analyzesBindingSource;
        private hospitallDataSet50TableAdapters.AnalyzesTableAdapter analyzesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn analysisnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn analysisnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectAnalyzes;
        private System.Windows.Forms.Panel panel1;
    }
}