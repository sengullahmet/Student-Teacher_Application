namespace Student_Teacher_Application
{
    partial class FrmExamNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExamNotes));
            this.dgwNotes = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pctSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctRemove = new System.Windows.Forms.PictureBox();
            this.pctUpdated = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtThırdExam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.lblclup = new System.Windows.Forms.Label();
            this.txtFrstExam = new System.Windows.Forms.TextBox();
            this.lblsurname = new System.Windows.Forms.Label();
            this.txtScndExam = new System.Windows.Forms.TextBox();
            this.lblstudentId = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.pctReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwNotes
            // 
            this.dgwNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNotes.Location = new System.Drawing.Point(2, 304);
            this.dgwNotes.Name = "dgwNotes";
            this.dgwNotes.RowHeadersWidth = 51;
            this.dgwNotes.RowTemplate.Height = 24;
            this.dgwNotes.Size = new System.Drawing.Size(1143, 219);
            this.dgwNotes.TabIndex = 0;
            this.dgwNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwNotes_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pctReturn);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pctSearch);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pctRemove);
            this.panel2.Controls.Add(this.pctUpdated);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnCompute);
            this.panel2.Controls.Add(this.txtState);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtProject);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAverage);
            this.panel2.Controls.Add(this.txtThırdExam);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbName);
            this.panel2.Controls.Add(this.lblclup);
            this.panel2.Controls.Add(this.txtFrstExam);
            this.panel2.Controls.Add(this.lblsurname);
            this.panel2.Controls.Add(this.txtScndExam);
            this.panel2.Controls.Add(this.lblstudentId);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Location = new System.Drawing.Point(2, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 277);
            this.panel2.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(249, 39);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(187, 22);
            this.txtId.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(945, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 27;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctSearch
            // 
            this.pctSearch.Image = ((System.Drawing.Image)(resources.GetObject("pctSearch.Image")));
            this.pctSearch.Location = new System.Drawing.Point(903, 220);
            this.pctSearch.Name = "pctSearch";
            this.pctSearch.Size = new System.Drawing.Size(34, 30);
            this.pctSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSearch.TabIndex = 26;
            this.pctSearch.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(905, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pctRemove
            // 
            this.pctRemove.Image = ((System.Drawing.Image)(resources.GetObject("pctRemove.Image")));
            this.pctRemove.Location = new System.Drawing.Point(905, 164);
            this.pctRemove.Name = "pctRemove";
            this.pctRemove.Size = new System.Drawing.Size(34, 33);
            this.pctRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctRemove.TabIndex = 24;
            this.pctRemove.TabStop = false;
            // 
            // pctUpdated
            // 
            this.pctUpdated.Image = ((System.Drawing.Image)(resources.GetObject("pctUpdated.Image")));
            this.pctUpdated.Location = new System.Drawing.Point(905, 103);
            this.pctUpdated.Name = "pctUpdated";
            this.pctUpdated.Size = new System.Drawing.Size(34, 33);
            this.pctUpdated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUpdated.TabIndex = 23;
            this.pctUpdated.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(945, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 33);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Sienna;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(945, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 33);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.Sienna;
            this.btnCompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompute.ForeColor = System.Drawing.Color.Transparent;
            this.btnCompute.Location = new System.Drawing.Point(945, 39);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(142, 33);
            this.btnCompute.TabIndex = 20;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(670, 132);
            this.txtState.Multiline = true;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(187, 22);
            this.txtState.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(562, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "State  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(534, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Average  :";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(670, 42);
            this.txtProject.Multiline = true;
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(187, 22);
            this.txtProject.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(553, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Project :";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(670, 88);
            this.txtAverage.Multiline = true;
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(187, 22);
            this.txtAverage.TabIndex = 14;
            // 
            // txtThırdExam
            // 
            this.txtThırdExam.Location = new System.Drawing.Point(249, 214);
            this.txtThırdExam.Multiline = true;
            this.txtThırdExam.Name = "txtThırdExam";
            this.txtThırdExam.Size = new System.Drawing.Size(187, 22);
            this.txtThırdExam.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(100, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Third Exam  :";
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(249, 73);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(187, 33);
            this.cmbName.TabIndex = 11;
            // 
            // lblclup
            // 
            this.lblclup.AutoSize = true;
            this.lblclup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblclup.Location = new System.Drawing.Point(77, 167);
            this.lblclup.Name = "lblclup";
            this.lblclup.Size = new System.Drawing.Size(151, 25);
            this.lblclup.TabIndex = 6;
            this.lblclup.Text = "Second Exam  :";
            // 
            // txtFrstExam
            // 
            this.txtFrstExam.Location = new System.Drawing.Point(249, 124);
            this.txtFrstExam.Multiline = true;
            this.txtFrstExam.Name = "txtFrstExam";
            this.txtFrstExam.Size = new System.Drawing.Size(187, 22);
            this.txtFrstExam.TabIndex = 5;
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsurname.Location = new System.Drawing.Point(113, 124);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(115, 25);
            this.lblsurname.TabIndex = 4;
            this.lblsurname.Text = "First Exam :";
            // 
            // txtScndExam
            // 
            this.txtScndExam.Location = new System.Drawing.Point(249, 170);
            this.txtScndExam.Multiline = true;
            this.txtScndExam.Name = "txtScndExam";
            this.txtScndExam.Size = new System.Drawing.Size(187, 22);
            this.txtScndExam.TabIndex = 3;
            // 
            // lblstudentId
            // 
            this.lblstudentId.AutoSize = true;
            this.lblstudentId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstudentId.Location = new System.Drawing.Point(86, 36);
            this.lblstudentId.Name = "lblstudentId";
            this.lblstudentId.Size = new System.Drawing.Size(142, 25);
            this.lblstudentId.TabIndex = 0;
            this.lblstudentId.Text = "STUDENT ID :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblname.Location = new System.Drawing.Point(69, 76);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(159, 25);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Lessons Name  :";
            // 
            // pctReturn
            // 
            this.pctReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctReturn.Image = ((System.Drawing.Image)(resources.GetObject("pctReturn.Image")));
            this.pctReturn.Location = new System.Drawing.Point(757, 214);
            this.pctReturn.Name = "pctReturn";
            this.pctReturn.Size = new System.Drawing.Size(100, 33);
            this.pctReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctReturn.TabIndex = 29;
            this.pctReturn.TabStop = false;
            this.pctReturn.Click += new System.EventHandler(this.pctReturn_Click);
            // 
            // FrmExamNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1146, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgwNotes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmExamNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExamNotes";
            this.Load += new System.EventHandler(this.FrmExamNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwNotes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtThırdExam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label lblclup;
        private System.Windows.Forms.TextBox txtFrstExam;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.TextBox txtScndExam;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentId;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.PictureBox pctUpdated;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctRemove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctSearch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox pctReturn;
    }
}