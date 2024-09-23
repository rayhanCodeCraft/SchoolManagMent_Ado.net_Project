namespace SchoolManagMent
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.resetBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnSave_Click = new System.Windows.Forms.Button();
            this.ImageGB = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SchoolInfoGB = new System.Windows.Forms.GroupBox();
            this.rbtnBangla = new System.Windows.Forms.RadioButton();
            this.EnglishRbtn = new System.Windows.Forms.RadioButton();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.cmbSchoolType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.studentCodeTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentCdLabel = new System.Windows.Forms.Label();
            this.mediumLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.schooltypeLabel = new System.Windows.Forms.Label();
            this.estLabel = new System.Windows.Forms.Label();
            this.studentNameLable = new System.Windows.Forms.Label();
            this.SchoolList = new System.Windows.Forms.TabPage();
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvSchoolList = new System.Windows.Forms.DataGridView();
            this.schoolListLabal = new System.Windows.Forms.Label();
            this.dgvResultId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSchoolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.ImageGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SchoolInfoGB.SuspendLayout();
            this.SchoolList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.SchoolList);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.resetBtn);
            this.tabPage1.Controls.Add(this.deleteBtn);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSave_Click);
            this.tabPage1.Controls.Add(this.ImageGB);
            this.tabPage1.Controls.Add(this.SchoolInfoGB);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1043, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SchoolDetails";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(528, 463);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(95, 26);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(317, 462);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(120, 27);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvResult);
            this.groupBox1.Location = new System.Drawing.Point(677, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(365, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "School Result";
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvResultId,
            this.dgvSchoolId,
            this.dgvExamType,
            this.dgvTotalMarks});
            this.dgvResult.Location = new System.Drawing.Point(6, 37);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 51;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(352, 350);
            this.dgvResult.TabIndex = 0;
            // 
            // btnSave_Click
            // 
            this.btnSave_Click.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave_Click.Location = new System.Drawing.Point(123, 458);
            this.btnSave_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave_Click.Name = "btnSave_Click";
            this.btnSave_Click.Size = new System.Drawing.Size(95, 32);
            this.btnSave_Click.TabIndex = 1;
            this.btnSave_Click.Text = "Save";
            this.btnSave_Click.UseVisualStyleBackColor = true;
            this.btnSave_Click.Click += new System.EventHandler(this.btnSave_Click_Click);
            // 
            // ImageGB
            // 
            this.ImageGB.Controls.Add(this.clearBtn);
            this.ImageGB.Controls.Add(this.btnBrowse);
            this.ImageGB.Controls.Add(this.pictureBox1);
            this.ImageGB.Location = new System.Drawing.Point(429, 54);
            this.ImageGB.Margin = new System.Windows.Forms.Padding(4);
            this.ImageGB.Name = "ImageGB";
            this.ImageGB.Padding = new System.Windows.Forms.Padding(4);
            this.ImageGB.Size = new System.Drawing.Size(239, 308);
            this.ImageGB.TabIndex = 0;
            this.ImageGB.TabStop = false;
            this.ImageGB.Text = "ImagaUpload";
            // 
            // clearBtn
            // 
            this.clearBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clearBtn.Location = new System.Drawing.Point(132, 256);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 28);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBrowse.Location = new System.Drawing.Point(12, 256);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(95, 32);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse.......";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SchoolInfoGB
            // 
            this.SchoolInfoGB.Controls.Add(this.rbtnBangla);
            this.SchoolInfoGB.Controls.Add(this.EnglishRbtn);
            this.SchoolInfoGB.Controls.Add(this.chkStatus);
            this.SchoolInfoGB.Controls.Add(this.cmbSchoolType);
            this.SchoolInfoGB.Controls.Add(this.dateTimePicker1);
            this.SchoolInfoGB.Controls.Add(this.studentCodeTextBox);
            this.SchoolInfoGB.Controls.Add(this.studentNameTextBox);
            this.SchoolInfoGB.Controls.Add(this.studentCdLabel);
            this.SchoolInfoGB.Controls.Add(this.mediumLabel);
            this.SchoolInfoGB.Controls.Add(this.statusLabel);
            this.SchoolInfoGB.Controls.Add(this.schooltypeLabel);
            this.SchoolInfoGB.Controls.Add(this.estLabel);
            this.SchoolInfoGB.Controls.Add(this.studentNameLable);
            this.SchoolInfoGB.Location = new System.Drawing.Point(11, 50);
            this.SchoolInfoGB.Margin = new System.Windows.Forms.Padding(4);
            this.SchoolInfoGB.Name = "SchoolInfoGB";
            this.SchoolInfoGB.Padding = new System.Windows.Forms.Padding(4);
            this.SchoolInfoGB.Size = new System.Drawing.Size(391, 400);
            this.SchoolInfoGB.TabIndex = 0;
            this.SchoolInfoGB.TabStop = false;
            this.SchoolInfoGB.Text = "SchoolInfo";
            // 
            // rbtnBangla
            // 
            this.rbtnBangla.AutoSize = true;
            this.rbtnBangla.Location = new System.Drawing.Point(125, 292);
            this.rbtnBangla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnBangla.Name = "rbtnBangla";
            this.rbtnBangla.Size = new System.Drawing.Size(71, 20);
            this.rbtnBangla.TabIndex = 6;
            this.rbtnBangla.TabStop = true;
            this.rbtnBangla.Text = "Bangla";
            this.rbtnBangla.UseVisualStyleBackColor = true;
            // 
            // EnglishRbtn
            // 
            this.EnglishRbtn.AutoSize = true;
            this.EnglishRbtn.Location = new System.Drawing.Point(257, 292);
            this.EnglishRbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnglishRbtn.Name = "EnglishRbtn";
            this.EnglishRbtn.Size = new System.Drawing.Size(72, 20);
            this.EnglishRbtn.TabIndex = 5;
            this.EnglishRbtn.TabStop = true;
            this.EnglishRbtn.Text = "English";
            this.EnglishRbtn.UseVisualStyleBackColor = true;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(193, 238);
            this.chkStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(118, 20);
            this.chkStatus.TabIndex = 4;
            this.chkStatus.Text = "Is Government ";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // cmbSchoolType
            // 
            this.cmbSchoolType.FormattingEnabled = true;
            this.cmbSchoolType.Location = new System.Drawing.Point(179, 185);
            this.cmbSchoolType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSchoolType.Name = "cmbSchoolType";
            this.cmbSchoolType.Size = new System.Drawing.Size(139, 24);
            this.cmbSchoolType.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 148);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // studentCodeTextBox
            // 
            this.studentCodeTextBox.Location = new System.Drawing.Point(179, 41);
            this.studentCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentCodeTextBox.Name = "studentCodeTextBox";
            this.studentCodeTextBox.Size = new System.Drawing.Size(139, 22);
            this.studentCodeTextBox.TabIndex = 1;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(179, 101);
            this.studentNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(139, 22);
            this.studentNameTextBox.TabIndex = 1;
            // 
            // studentCdLabel
            // 
            this.studentCdLabel.AutoSize = true;
            this.studentCdLabel.Location = new System.Drawing.Point(20, 47);
            this.studentCdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentCdLabel.Name = "studentCdLabel";
            this.studentCdLabel.Size = new System.Drawing.Size(91, 16);
            this.studentCdLabel.TabIndex = 0;
            this.studentCdLabel.Text = "School Code :";
            // 
            // mediumLabel
            // 
            this.mediumLabel.AutoSize = true;
            this.mediumLabel.Location = new System.Drawing.Point(20, 292);
            this.mediumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mediumLabel.Name = "mediumLabel";
            this.mediumLabel.Size = new System.Drawing.Size(61, 16);
            this.mediumLabel.TabIndex = 0;
            this.mediumLabel.Text = "Madium :";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(20, 234);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 16);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status :";
            // 
            // schooltypeLabel
            // 
            this.schooltypeLabel.AutoSize = true;
            this.schooltypeLabel.Location = new System.Drawing.Point(20, 185);
            this.schooltypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schooltypeLabel.Name = "schooltypeLabel";
            this.schooltypeLabel.Size = new System.Drawing.Size(90, 16);
            this.schooltypeLabel.TabIndex = 0;
            this.schooltypeLabel.Text = "School Type :";
            // 
            // estLabel
            // 
            this.estLabel.AutoSize = true;
            this.estLabel.Location = new System.Drawing.Point(20, 148);
            this.estLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estLabel.Name = "estLabel";
            this.estLabel.Size = new System.Drawing.Size(116, 16);
            this.estLabel.TabIndex = 0;
            this.estLabel.Text = "Established Date :";
            // 
            // studentNameLable
            // 
            this.studentNameLable.AutoSize = true;
            this.studentNameLable.Location = new System.Drawing.Point(20, 107);
            this.studentNameLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentNameLable.Name = "studentNameLable";
            this.studentNameLable.Size = new System.Drawing.Size(98, 16);
            this.studentNameLable.TabIndex = 0;
            this.studentNameLable.Text = "School Name : ";
            // 
            // SchoolList
            // 
            this.SchoolList.Controls.Add(this.btnReport);
            this.SchoolList.Controls.Add(this.dgvSchoolList);
            this.SchoolList.Controls.Add(this.schoolListLabal);
            this.SchoolList.Location = new System.Drawing.Point(4, 25);
            this.SchoolList.Margin = new System.Windows.Forms.Padding(4);
            this.SchoolList.Name = "SchoolList";
            this.SchoolList.Padding = new System.Windows.Forms.Padding(4);
            this.SchoolList.Size = new System.Drawing.Size(1043, 525);
            this.SchoolList.TabIndex = 1;
            this.SchoolList.Text = "SchoolList";
            this.SchoolList.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(870, 469);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(149, 39);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "View Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dgvSchoolList
            // 
            this.dgvSchoolList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchoolList.Location = new System.Drawing.Point(21, 58);
            this.dgvSchoolList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSchoolList.Name = "dgvSchoolList";
            this.dgvSchoolList.RowHeadersWidth = 51;
            this.dgvSchoolList.RowTemplate.Height = 24;
            this.dgvSchoolList.Size = new System.Drawing.Size(999, 386);
            this.dgvSchoolList.TabIndex = 1;
            this.dgvSchoolList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvSchoolList_UserDeletingRow);
            this.dgvSchoolList.DoubleClick += new System.EventHandler(this.dgvSchoolList_DoubleClick);
            // 
            // schoolListLabal
            // 
            this.schoolListLabal.AutoSize = true;
            this.schoolListLabal.Location = new System.Drawing.Point(437, 15);
            this.schoolListLabal.Name = "schoolListLabal";
            this.schoolListLabal.Size = new System.Drawing.Size(72, 16);
            this.schoolListLabal.TabIndex = 0;
            this.schoolListLabal.Text = "School List";
            // 
            // dgvResultId
            // 
            this.dgvResultId.FillWeight = 10F;
            this.dgvResultId.HeaderText = "ResultId";
            this.dgvResultId.MinimumWidth = 6;
            this.dgvResultId.Name = "dgvResultId";
            this.dgvResultId.Visible = false;
            this.dgvResultId.Width = 90;
            // 
            // dgvSchoolId
            // 
            this.dgvSchoolId.FillWeight = 50F;
            this.dgvSchoolId.HeaderText = "SchoolId";
            this.dgvSchoolId.MinimumWidth = 4;
            this.dgvSchoolId.Name = "dgvSchoolId";
            this.dgvSchoolId.Width = 90;
            // 
            // dgvExamType
            // 
            this.dgvExamType.HeaderText = "ExamType";
            this.dgvExamType.MinimumWidth = 10;
            this.dgvExamType.Name = "dgvExamType";
            this.dgvExamType.Width = 90;
            // 
            // dgvTotalMarks
            // 
            this.dgvTotalMarks.HeaderText = "TotalMarks";
            this.dgvTotalMarks.MinimumWidth = 6;
            this.dgvTotalMarks.Name = "dgvTotalMarks";
            this.dgvTotalMarks.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SchoolManagMent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ImageGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SchoolInfoGB.ResumeLayout(false);
            this.SchoolInfoGB.PerformLayout();
            this.SchoolList.ResumeLayout(false);
            this.SchoolList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchoolList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage SchoolList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ImageGB;
        private System.Windows.Forms.GroupBox SchoolInfoGB;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button btnSave_Click;
        private System.Windows.Forms.Label studentCdLabel;
        private System.Windows.Forms.Label mediumLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label schooltypeLabel;
        private System.Windows.Forms.Label estLabel;
        private System.Windows.Forms.Label studentNameLable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox studentCodeTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.RadioButton EnglishRbtn;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.ComboBox cmbSchoolType;
        private System.Windows.Forms.RadioButton rbtnBangla;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label schoolListLabal;
        private System.Windows.Forms.DataGridView dgvSchoolList;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvResultId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSchoolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalMarks;
    }
}

