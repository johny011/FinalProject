﻿namespace Final_project
{
    partial class Search_Admission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Admission));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_id_admission = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_add.ActiveForecolor = System.Drawing.Color.White;
            this.btn_add.ActiveLineColor = System.Drawing.Color.White;
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "بحث";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.Black;
            this.btn_add.IdleLineColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(0, 60);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(800, 60);
            this.btn_add.TabIndex = 25;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_id_admission
            // 
            this.txt_id_admission.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_admission.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_id_admission.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_admission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id_admission.HintForeColor = System.Drawing.Color.Empty;
            this.txt_id_admission.HintText = "";
            this.txt_id_admission.isPassword = false;
            this.txt_id_admission.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id_admission.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_id_admission.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id_admission.LineThickness = 4;
            this.txt_id_admission.Location = new System.Drawing.Point(0, 0);
            this.txt_id_admission.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txt_id_admission.Name = "txt_id_admission";
            this.txt_id_admission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_id_admission.Size = new System.Drawing.Size(800, 60);
            this.txt_id_admission.TabIndex = 24;
            this.txt_id_admission.Text = "رقم الدخولية";
            this.txt_id_admission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 330);
            this.dataGridView1.TabIndex = 26;
            // 
            // Search_Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_id_admission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search_Admission";
            this.Text = "Search_Admission";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_id_admission;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}