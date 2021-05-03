namespace Final_project
{
    partial class Request_X_ray
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request_X_ray));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.picturesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picturesnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presenceOfThepicturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectpic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.picturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitallDataSet27 = new Final_project.hospitallDataSet27();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Admissionid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Request = new Bunifu.Framework.UI.BunifuThinButton2();
            this.picturesTableAdapter = new Final_project.hospitallDataSet27TableAdapters.picturesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet27)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.picturesidDataGridViewTextBoxColumn,
            this.picturesnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.presenceOfThepicturesDataGridViewTextBoxColumn,
            this.processingDataGridViewTextBoxColumn,
            this.selectpic});
            this.dataGridView1.DataSource = this.picturesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 24;
            // 
            // picturesidDataGridViewTextBoxColumn
            // 
            this.picturesidDataGridViewTextBoxColumn.DataPropertyName = "picturesid";
            this.picturesidDataGridViewTextBoxColumn.HeaderText = "picturesid";
            this.picturesidDataGridViewTextBoxColumn.Name = "picturesidDataGridViewTextBoxColumn";
            this.picturesidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // picturesnameDataGridViewTextBoxColumn
            // 
            this.picturesnameDataGridViewTextBoxColumn.DataPropertyName = "picturesname";
            this.picturesnameDataGridViewTextBoxColumn.HeaderText = "picturesname";
            this.picturesnameDataGridViewTextBoxColumn.Name = "picturesnameDataGridViewTextBoxColumn";
            this.picturesnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // presenceOfThepicturesDataGridViewTextBoxColumn
            // 
            this.presenceOfThepicturesDataGridViewTextBoxColumn.DataPropertyName = "presenceOfThepictures";
            this.presenceOfThepicturesDataGridViewTextBoxColumn.HeaderText = "presenceOfThepictures";
            this.presenceOfThepicturesDataGridViewTextBoxColumn.Name = "presenceOfThepicturesDataGridViewTextBoxColumn";
            this.presenceOfThepicturesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // processingDataGridViewTextBoxColumn
            // 
            this.processingDataGridViewTextBoxColumn.DataPropertyName = "processing";
            this.processingDataGridViewTextBoxColumn.HeaderText = "processing";
            this.processingDataGridViewTextBoxColumn.Name = "processingDataGridViewTextBoxColumn";
            this.processingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selectpic
            // 
            this.selectpic.HeaderText = "select picture";
            this.selectpic.Name = "selectpic";
            // 
            // picturesBindingSource
            // 
            this.picturesBindingSource.DataMember = "pictures";
            this.picturesBindingSource.DataSource = this.hospitallDataSet27;
            // 
            // hospitallDataSet27
            // 
            this.hospitallDataSet27.DataSetName = "hospitallDataSet27";
            this.hospitallDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Admissionid);
            this.panel1.Controls.Add(this.btn_Request);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
            // 
            // txt_Admissionid
            // 
            this.txt_Admissionid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Admissionid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Admissionid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Admissionid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Admissionid.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Admissionid.HintText = "";
            this.txt_Admissionid.isPassword = false;
            this.txt_Admissionid.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_Admissionid.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Admissionid.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_Admissionid.LineThickness = 4;
            this.txt_Admissionid.Location = new System.Drawing.Point(521, 370);
            this.txt_Admissionid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Admissionid.Name = "txt_Admissionid";
            this.txt_Admissionid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Admissionid.Size = new System.Drawing.Size(220, 60);
            this.txt_Admissionid.TabIndex = 27;
            this.txt_Admissionid.Text = "رقم دخولية المريض";
            this.txt_Admissionid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Admissionid.OnValueChanged += new System.EventHandler(this.txt_Admissionid_OnValueChanged);
            // 
            // btn_Request
            // 
            this.btn_Request.ActiveBorderThickness = 1;
            this.btn_Request.ActiveCornerRadius = 20;
            this.btn_Request.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_Request.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Request.ActiveLineColor = System.Drawing.Color.White;
            this.btn_Request.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Request.BackColor = System.Drawing.SystemColors.Control;
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
            this.btn_Request.Location = new System.Drawing.Point(195, 370);
            this.btn_Request.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(220, 66);
            this.btn_Request.TabIndex = 26;
            this.btn_Request.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Request.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // picturesTableAdapter
            // 
            this.picturesTableAdapter.ClearBeforeFill = true;
            // 
            // Request_X_ray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Request_X_ray";
            this.Text = "Required_X_ray";
            this.Load += new System.EventHandler(this.Required_X_ray_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallDataSet27)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Request;
        private hospitallDataSet27 hospitallDataSet27;
        private System.Windows.Forms.BindingSource picturesBindingSource;
        private hospitallDataSet27TableAdapters.picturesTableAdapter picturesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturesnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presenceOfThepicturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectpic;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Admissionid;
    }
}