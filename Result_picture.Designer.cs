namespace Final_project
{
    partial class Result_picture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result_picture));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_find_result = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Admissionid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_save = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 231);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_find_result
            // 
            this.btn_find_result.ActiveBorderThickness = 1;
            this.btn_find_result.ActiveCornerRadius = 20;
            this.btn_find_result.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_find_result.ActiveForecolor = System.Drawing.Color.White;
            this.btn_find_result.ActiveLineColor = System.Drawing.Color.White;
            this.btn_find_result.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_find_result.BackColor = System.Drawing.SystemColors.Control;
            this.btn_find_result.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_find_result.BackgroundImage")));
            this.btn_find_result.ButtonText = "البحث عن النتيجة";
            this.btn_find_result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_find_result.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_find_result.ForeColor = System.Drawing.Color.Black;
            this.btn_find_result.IdleBorderThickness = 1;
            this.btn_find_result.IdleCornerRadius = 20;
            this.btn_find_result.IdleFillColor = System.Drawing.Color.White;
            this.btn_find_result.IdleForecolor = System.Drawing.Color.Black;
            this.btn_find_result.IdleLineColor = System.Drawing.Color.Black;
            this.btn_find_result.Location = new System.Drawing.Point(565, 109);
            this.btn_find_result.Margin = new System.Windows.Forms.Padding(5);
            this.btn_find_result.Name = "btn_find_result";
            this.btn_find_result.Size = new System.Drawing.Size(220, 66);
            this.btn_find_result.TabIndex = 37;
            this.btn_find_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_find_result.Click += new System.EventHandler(this.btn_find_result_Click);
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
            this.txt_Admissionid.Location = new System.Drawing.Point(565, 26);
            this.txt_Admissionid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_Admissionid.Name = "txt_Admissionid";
            this.txt_Admissionid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Admissionid.Size = new System.Drawing.Size(220, 60);
            this.txt_Admissionid.TabIndex = 36;
            this.txt_Admissionid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 201);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.ActiveBorderThickness = 1;
            this.btn_save.ActiveCornerRadius = 20;
            this.btn_save.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_save.ActiveForecolor = System.Drawing.Color.White;
            this.btn_save.ActiveLineColor = System.Drawing.Color.White;
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.ButtonText = "حفظ الصورة";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.IdleBorderThickness = 1;
            this.btn_save.IdleCornerRadius = 20;
            this.btn_save.IdleFillColor = System.Drawing.Color.White;
            this.btn_save.IdleForecolor = System.Drawing.Color.Black;
            this.btn_save.IdleLineColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(388, 109);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(155, 66);
            this.btn_save.TabIndex = 39;
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Result_picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_find_result);
            this.Controls.Add(this.txt_Admissionid);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result_picture";
            this.Text = "Result_picture";
            this.Load += new System.EventHandler(this.Result_picture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_find_result;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Admissionid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_save;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}