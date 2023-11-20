namespace Student_Teacher_Application
{
    partial class frmLessons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLessons));
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lblLessons = new System.Windows.Forms.Label();
            this.pctReturn = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pctRemove = new System.Windows.Forms.PictureBox();
            this.btnUpdated = new System.Windows.Forms.Button();
            this.pctUpdated = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgwLessons = new System.Windows.Forms.DataGridView();
            this.pctAdd = new System.Windows.Forms.PictureBox();
            this.btnListing = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pctList = new System.Windows.Forms.PictureBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblLesName = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.lblLesId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLessons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdd)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(671, 12);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(27, 25);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctExit.TabIndex = 7;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // lblLessons
            // 
            this.lblLessons.AutoSize = true;
            this.lblLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLessons.Location = new System.Drawing.Point(107, 12);
            this.lblLessons.Name = "lblLessons";
            this.lblLessons.Size = new System.Drawing.Size(287, 25);
            this.lblLessons.TabIndex = 4;
            this.lblLessons.Text = "LESSON PROCESS PANEL";
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
            this.pctReturn.Click += new System.EventHandler(this.pctReturn_Click);
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
            // dgwLessons
            // 
            this.dgwLessons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLessons.Location = new System.Drawing.Point(-40, 56);
            this.dgwLessons.Name = "dgwLessons";
            this.dgwLessons.RowHeadersWidth = 51;
            this.dgwLessons.RowTemplate.Height = 24;
            this.dgwLessons.Size = new System.Drawing.Size(738, 171);
            this.dgwLessons.TabIndex = 5;
            this.dgwLessons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLessons_CellClick);
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
            this.panel3.Location = new System.Drawing.Point(-40, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 140);
            this.panel3.TabIndex = 9;
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
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(337, 67);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(187, 22);
            this.txtname.TabIndex = 3;
            // 
            // lblLesName
            // 
            this.lblLesName.AutoSize = true;
            this.lblLesName.Location = new System.Drawing.Point(160, 64);
            this.lblLesName.Name = "lblLesName";
            this.lblLesName.Size = new System.Drawing.Size(173, 25);
            this.lblLesName.TabIndex = 2;
            this.lblLesName.Text = "LESSON NAME  :";
            // 
            // txtıd
            // 
            this.txtıd.Enabled = false;
            this.txtıd.Location = new System.Drawing.Point(337, 27);
            this.txtıd.Multiline = true;
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(187, 22);
            this.txtıd.TabIndex = 1;
            // 
            // lblLesId
            // 
            this.lblLesId.AutoSize = true;
            this.lblLesId.Location = new System.Drawing.Point(202, 24);
            this.lblLesId.Name = "lblLesId";
            this.lblLesId.Size = new System.Drawing.Size(129, 25);
            this.lblLesId.TabIndex = 0;
            this.lblLesId.Text = "LESSON ID :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.lblLesName);
            this.panel2.Controls.Add(this.txtıd);
            this.panel2.Controls.Add(this.lblLesId);
            this.panel2.Location = new System.Drawing.Point(-40, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 109);
            this.panel2.TabIndex = 8;
            // 
            // pctSettings
            // 
            this.pctSettings.Image = ((System.Drawing.Image)(resources.GetObject("pctSettings.Image")));
            this.pctSettings.Location = new System.Drawing.Point(1, 12);
            this.pctSettings.Name = "pctSettings";
            this.pctSettings.Size = new System.Drawing.Size(100, 25);
            this.pctSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSettings.TabIndex = 6;
            this.pctSettings.TabStop = false;
            // 
            // frmLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 515);
            this.Controls.Add(this.pctExit);
            this.Controls.Add(this.lblLessons);
            this.Controls.Add(this.dgwLessons);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pctSettings);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLessons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLessons";
            this.Load += new System.EventHandler(this.frmLessons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLessons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdd)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Label lblLessons;
        private System.Windows.Forms.PictureBox pctReturn;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pctRemove;
        private System.Windows.Forms.Button btnUpdated;
        private System.Windows.Forms.PictureBox pctUpdated;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgwLessons;
        private System.Windows.Forms.PictureBox pctAdd;
        private System.Windows.Forms.Button btnListing;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pctList;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblLesName;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label lblLesId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctSettings;
    }
}