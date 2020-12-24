
namespace Lab02_02
{
    partial class fQuanLySinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAverage = new System.Windows.Forms.TextBox();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.rBtnFemale = new System.Windows.Forms.RadioButton();
            this.cBoxFaculty = new System.Windows.Forms.ComboBox();
            this.gBoxStudent = new System.Windows.Forms.GroupBox();
            this.gBoxData = new System.Windows.Forms.GroupBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Clbnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClbGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClbAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClbFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBnumberFemale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBnumberMale = new System.Windows.Forms.TextBox();
            this.gBoxStudent.SuspendLayout();
            this.gBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm TB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chuyên Ngành";
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(134, 41);
            this.txtBoxNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(128, 24);
            this.txtBoxNumber.TabIndex = 7;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(134, 80);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(225, 24);
            this.txtBoxName.TabIndex = 8;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // txtBoxAverage
            // 
            this.txtBoxAverage.Location = new System.Drawing.Point(133, 160);
            this.txtBoxAverage.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAverage.Name = "txtBoxAverage";
            this.txtBoxAverage.Size = new System.Drawing.Size(76, 24);
            this.txtBoxAverage.TabIndex = 9;
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.Location = new System.Drawing.Point(133, 123);
            this.rBtnMale.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(54, 21);
            this.rBtnMale.TabIndex = 10;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Nam";
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // rBtnFemale
            // 
            this.rBtnFemale.AutoSize = true;
            this.rBtnFemale.Location = new System.Drawing.Point(198, 123);
            this.rBtnFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rBtnFemale.Name = "rBtnFemale";
            this.rBtnFemale.Size = new System.Drawing.Size(44, 21);
            this.rBtnFemale.TabIndex = 11;
            this.rBtnFemale.TabStop = true;
            this.rBtnFemale.Text = "Nữ";
            this.rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // cBoxFaculty
            // 
            this.cBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFaculty.FormattingEnabled = true;
            this.cBoxFaculty.Items.AddRange(new object[] {
            "CNTT",
            "QTKD",
            "NNA",
            "XD",
            "DT"});
            this.cBoxFaculty.Location = new System.Drawing.Point(130, 204);
            this.cBoxFaculty.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxFaculty.Name = "cBoxFaculty";
            this.cBoxFaculty.Size = new System.Drawing.Size(213, 25);
            this.cBoxFaculty.TabIndex = 12;
            // 
            // gBoxStudent
            // 
            this.gBoxStudent.Controls.Add(this.label2);
            this.gBoxStudent.Controls.Add(this.label3);
            this.gBoxStudent.Controls.Add(this.txtBoxAverage);
            this.gBoxStudent.Controls.Add(this.label6);
            this.gBoxStudent.Controls.Add(this.cBoxFaculty);
            this.gBoxStudent.Controls.Add(this.label4);
            this.gBoxStudent.Controls.Add(this.rBtnFemale);
            this.gBoxStudent.Controls.Add(this.txtBoxName);
            this.gBoxStudent.Controls.Add(this.label5);
            this.gBoxStudent.Controls.Add(this.txtBoxNumber);
            this.gBoxStudent.Controls.Add(this.rBtnMale);
            this.gBoxStudent.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxStudent.Location = new System.Drawing.Point(0, 67);
            this.gBoxStudent.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxStudent.Name = "gBoxStudent";
            this.gBoxStudent.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxStudent.Size = new System.Drawing.Size(378, 265);
            this.gBoxStudent.TabIndex = 13;
            this.gBoxStudent.TabStop = false;
            this.gBoxStudent.Text = "Thông Tin Sinh Viên";
            // 
            // gBoxData
            // 
            this.gBoxData.Controls.Add(this.dgvStudent);
            this.gBoxData.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxData.Location = new System.Drawing.Point(382, 68);
            this.gBoxData.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxData.Name = "gBoxData";
            this.gBoxData.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxData.Size = new System.Drawing.Size(508, 295);
            this.gBoxData.TabIndex = 14;
            this.gBoxData.TabStop = false;
            this.gBoxData.Text = "Hiển thị";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clbnumber,
            this.ClbName,
            this.ClbGender,
            this.ClbAverage,
            this.ClbFaculty});
            this.dgvStudent.Location = new System.Drawing.Point(0, 12);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(508, 283);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // Clbnumber
            // 
            this.Clbnumber.HeaderText = "MSSV";
            this.Clbnumber.MinimumWidth = 6;
            this.Clbnumber.Name = "Clbnumber";
            this.Clbnumber.ReadOnly = true;
            this.Clbnumber.Width = 125;
            // 
            // ClbName
            // 
            this.ClbName.HeaderText = "Họ Tên";
            this.ClbName.MinimumWidth = 6;
            this.ClbName.Name = "ClbName";
            this.ClbName.ReadOnly = true;
            this.ClbName.Width = 125;
            // 
            // ClbGender
            // 
            this.ClbGender.HeaderText = "Giới Tính";
            this.ClbGender.MinimumWidth = 6;
            this.ClbGender.Name = "ClbGender";
            this.ClbGender.ReadOnly = true;
            this.ClbGender.Width = 125;
            // 
            // ClbAverage
            // 
            this.ClbAverage.HeaderText = "ĐTB";
            this.ClbAverage.MinimumWidth = 6;
            this.ClbAverage.Name = "ClbAverage";
            this.ClbAverage.ReadOnly = true;
            this.ClbAverage.Width = 125;
            // 
            // ClbFaculty
            // 
            this.ClbFaculty.HeaderText = "Khoa";
            this.ClbFaculty.MinimumWidth = 6;
            this.ClbFaculty.Name = "ClbFaculty";
            this.ClbFaculty.ReadOnly = true;
            this.ClbFaculty.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thêm/ Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 333);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(645, 371);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tổng SV Nam";
            // 
            // txtBnumberFemale
            // 
            this.txtBnumberFemale.Enabled = false;
            this.txtBnumberFemale.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBnumberFemale.Location = new System.Drawing.Point(838, 368);
            this.txtBnumberFemale.Margin = new System.Windows.Forms.Padding(2);
            this.txtBnumberFemale.Name = "txtBnumberFemale";
            this.txtBnumberFemale.Size = new System.Drawing.Size(54, 24);
            this.txtBnumberFemale.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(804, 371);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nữ";
            // 
            // txtBnumberMale
            // 
            this.txtBnumberMale.Enabled = false;
            this.txtBnumberMale.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBnumberMale.Location = new System.Drawing.Point(740, 368);
            this.txtBnumberMale.Margin = new System.Windows.Forms.Padding(2);
            this.txtBnumberMale.Name = "txtBnumberMale";
            this.txtBnumberMale.Size = new System.Drawing.Size(54, 24);
            this.txtBnumberMale.TabIndex = 20;
            // 
            // fQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 395);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBnumberMale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBnumberFemale);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gBoxData);
            this.Controls.Add(this.gBoxStudent);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.fQuanLySinhVien_Load);
            this.gBoxStudent.ResumeLayout(false);
            this.gBoxStudent.PerformLayout();
            this.gBoxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAverage;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.RadioButton rBtnFemale;
        private System.Windows.Forms.ComboBox cBoxFaculty;
        private System.Windows.Forms.GroupBox gBoxStudent;
        private System.Windows.Forms.GroupBox gBoxData;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clbnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClbGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClbAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClbFaculty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBnumberFemale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBnumberMale;
    }
}

