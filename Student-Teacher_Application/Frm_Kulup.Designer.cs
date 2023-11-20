namespace Student_Teacher_Application
{
    partial class Frm_Kulup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Kulup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctSettings = new System.Windows.Forms.PictureBox();
            this.lblclup = new System.Windows.Forms.Label();
            this.dgwClup = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblclupname = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.lblclupıd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pctRemove = new System.Windows.Forms.PictureBox();
            this.btnUpdated = new System.Windows.Forms.Button();
            this.pctUpdated = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pctAdd = new System.Windows.Forms.PictureBox();
            this.pctList = new System.Windows.Forms.PictureBox();
            this.btnListing = new System.Windows.Forms.Button();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.pctReturn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClup)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pctExit);
            this.panel1.Controls.Add(this.pctSettings);
            this.panel1.Controls.Add(this.lblclup);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 59);
            this.panel1.TabIndex = 0;
            // 
            // pctSettings
            // 
            this.pctSettings.Image = ((System.Drawing.Image)(resources.GetObject("pctSettings.Image")));
            this.pctSettings.Location = new System.Drawing.Point(8, 19);
            this.pctSettings.Name = "pctSettings";
            this.pctSettings.Size = new System.Drawing.Size(100, 25);
            this.pctSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSettings.TabIndex = 1;
            this.pctSettings.TabStop = false;
            // 
            // lblclup
            // 
            this.lblclup.AutoSize = true;
            this.lblclup.Location = new System.Drawing.Point(114, 19);
            this.lblclup.Name = "lblclup";
            this.lblclup.Size = new System.Drawing.Size(238, 25);
            this.lblclup.TabIndex = 0;
            this.lblclup.Text = "CLUP PROCESS PANEL";
            // 
            // dgwClup
            // 
            this.dgwClup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwClup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClup.Location = new System.Drawing.Point(2, 93);
            this.dgwClup.Name = "dgwClup";
            this.dgwClup.RowHeadersWidth = 51;
            this.dgwClup.RowTemplate.Height = 24;
            this.dgwClup.Size = new System.Drawing.Size(738, 171);
            this.dgwClup.TabIndex = 1;
            this.dgwClup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.lblclupname);
            this.panel2.Controls.Add(this.txtıd);
            this.panel2.Controls.Add(this.lblclupıd);
            this.panel2.Location = new System.Drawing.Point(2, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 109);
            this.panel2.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(301, 67);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(187, 22);
            this.txtname.TabIndex = 3;
            // 
            // lblclupname
            // 
            this.lblclupname.AutoSize = true;
            this.lblclupname.Location = new System.Drawing.Point(160, 64);
            this.lblclupname.Name = "lblclupname";
            this.lblclupname.Size = new System.Drawing.Size(144, 25);
            this.lblclupname.TabIndex = 2;
            this.lblclupname.Text = "CLUP NAME  :";
            // 
            // txtıd
            // 
            this.txtıd.Enabled = false;
            this.txtıd.Location = new System.Drawing.Point(301, 27);
            this.txtıd.Multiline = true;
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(187, 22);
            this.txtıd.TabIndex = 1;
            // 
            // lblclupıd
            // 
            this.lblclupıd.AutoSize = true;
            this.lblclupıd.Location = new System.Drawing.Point(202, 24);
            this.lblclupıd.Name = "lblclupıd";
            this.lblclupıd.Size = new System.Drawing.Size(100, 25);
            this.lblclupıd.TabIndex = 0;
            this.lblclupıd.Text = "CLUP ID :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pctReturn);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.pctRemove);
            this.panel3.Controls.Add(this.btnUpdated);
            this.panel3.Controls.Add(this.pctUpdated);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.pctAdd);
            this.panel3.Controls.Add(this.pctList);
            this.panel3.Controls.Add(this.btnListing);
            this.panel3.Location = new System.Drawing.Point(2, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 140);
            this.panel3.TabIndex = 3;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(473, 78);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(142, 33);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pctRemove
            // 
            this.pctRemove.Image = ((System.Drawing.Image)(resources.GetObject("pctRemove.Image")));
            this.pctRemove.Location = new System.Drawing.Point(367, 78);
            this.pctRemove.Name = "pctRemove";
            this.pctRemove.Size = new System.Drawing.Size(100, 33);
            this.pctRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRemove.TabIndex = 6;
            this.pctRemove.TabStop = false;
            // 
            // btnUpdated
            // 
            this.btnUpdated.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdated.Location = new System.Drawing.Point(473, 22);
            this.btnUpdated.Name = "btnUpdated";
            this.btnUpdated.Size = new System.Drawing.Size(142, 33);
            this.btnUpdated.TabIndex = 5;
            this.btnUpdated.Text = "UPDATED";
            this.btnUpdated.UseVisualStyleBackColor = false;
            this.btnUpdated.Click += new System.EventHandler(this.btnUpdated_Click);
            // 
            // pctUpdated
            // 
            this.pctUpdated.Image = ((System.Drawing.Image)(resources.GetObject("pctUpdated.Image")));
            this.pctUpdated.Location = new System.Drawing.Point(367, 22);
            this.pctUpdated.Name = "pctUpdated";
            this.pctUpdated.Size = new System.Drawing.Size(100, 33);
            this.pctUpdated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUpdated.TabIndex = 4;
            this.pctUpdated.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(166, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pctAdd
            // 
            this.pctAdd.Image = ((System.Drawing.Image)(resources.GetObject("pctAdd.Image")));
            this.pctAdd.Location = new System.Drawing.Point(60, 78);
            this.pctAdd.Name = "pctAdd";
            this.pctAdd.Size = new System.Drawing.Size(100, 33);
            this.pctAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAdd.TabIndex = 2;
            this.pctAdd.TabStop = false;
            // 
            // pctList
            // 
            this.pctList.Image = ((System.Drawing.Image)(resources.GetObject("pctList.Image")));
            this.pctList.Location = new System.Drawing.Point(60, 22);
            this.pctList.Name = "pctList";
            this.pctList.Size = new System.Drawing.Size(100, 33);
            this.pctList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctList.TabIndex = 1;
            this.pctList.TabStop = false;
            // 
            // btnListing
            // 
            this.btnListing.BackColor = System.Drawing.Color.RosyBrown;
            this.btnListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListing.Location = new System.Drawing.Point(166, 22);
            this.btnListing.Name = "btnListing";
            this.btnListing.Size = new System.Drawing.Size(142, 33);
            this.btnListing.TabIndex = 0;
            this.btnListing.Text = "LİSTİNG";
            this.btnListing.UseVisualStyleBackColor = false;
            this.btnListing.Click += new System.EventHandler(this.btnListing_Click);
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(708, 19);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(27, 25);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctExit.TabIndex = 2;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pctExit.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pctExit.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pctReturn
            // 
            this.pctReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctReturn.Image = ((System.Drawing.Image)(resources.GetObject("pctReturn.Image")));
            this.pctReturn.Location = new System.Drawing.Point(621, 51);
            this.pctReturn.Name = "pctReturn";
            this.pctReturn.Size = new System.Drawing.Size(100, 33);
            this.pctReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctReturn.TabIndex = 8;
            this.pctReturn.TabStop = false;
            this.pctReturn.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pctReturn.MouseLeave += new System.EventHandler(this.pctReturn_MouseLeave);
            this.pctReturn.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // Frm_Kulup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(746, 549);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgwClup);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_Kulup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Kulup";
            this.Load += new System.EventHandler(this.Frm_Kulup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClup)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctSettings;
        private System.Windows.Forms.Label lblclup;
        private System.Windows.Forms.DataGridView dgwClup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblclupname;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label lblclupıd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pctRemove;
        private System.Windows.Forms.Button btnUpdated;
        private System.Windows.Forms.PictureBox pctUpdated;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pctAdd;
        private System.Windows.Forms.PictureBox pctList;
        private System.Windows.Forms.Button btnListing;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.PictureBox pctReturn;
    }
}