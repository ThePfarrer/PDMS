namespace Personal_Data_Management_System
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
            this.previousButton = new System.Windows.Forms.Button();
            this.promoteToEmployee = new System.Windows.Forms.Button();
            this.promoteToStudent = new System.Windows.Forms.Button();
            this.saveBinButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.saveXMLButton = new System.Windows.Forms.Button();
            this.loadXMLButton = new System.Windows.Forms.Button();
            this.loadBinButton = new System.Windows.Forms.Button();
            this.givenNameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.eyeColorLabel = new System.Windows.Forms.Label();
            this.matricNoLabel = new System.Windows.Forms.Label();
            this.CPLabel = new System.Windows.Forms.Label();
            this.employeeNoLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxGivenName = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxMatriculationNo = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeNo = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxEyeColor = new System.Windows.Forms.ComboBox();
            this.CPOutputLabel = new System.Windows.Forms.Label();
            this.salaryOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(355, 36);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(41, 23);
            this.previousButton.TabIndex = 0;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // promoteToEmployee
            // 
            this.promoteToEmployee.Location = new System.Drawing.Point(500, 167);
            this.promoteToEmployee.Name = "promoteToEmployee";
            this.promoteToEmployee.Size = new System.Drawing.Size(288, 33);
            this.promoteToEmployee.TabIndex = 6;
            this.promoteToEmployee.Text = "Promote to Employee";
            this.promoteToEmployee.UseVisualStyleBackColor = true;
            // 
            // promoteToStudent
            // 
            this.promoteToStudent.Location = new System.Drawing.Point(500, 126);
            this.promoteToStudent.Name = "promoteToStudent";
            this.promoteToStudent.Size = new System.Drawing.Size(288, 33);
            this.promoteToStudent.TabIndex = 7;
            this.promoteToStudent.Text = "Promote to Student";
            this.promoteToStudent.UseVisualStyleBackColor = true;
            // 
            // saveBinButton
            // 
            this.saveBinButton.Location = new System.Drawing.Point(500, 36);
            this.saveBinButton.Name = "saveBinButton";
            this.saveBinButton.Size = new System.Drawing.Size(141, 32);
            this.saveBinButton.TabIndex = 8;
            this.saveBinButton.Text = "save binary";
            this.saveBinButton.UseVisualStyleBackColor = true;
            this.saveBinButton.Click += new System.EventHandler(this.saveBinButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(411, 36);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(41, 23);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // saveXMLButton
            // 
            this.saveXMLButton.Location = new System.Drawing.Point(500, 74);
            this.saveXMLButton.Name = "saveXMLButton";
            this.saveXMLButton.Size = new System.Drawing.Size(141, 32);
            this.saveXMLButton.TabIndex = 10;
            this.saveXMLButton.Text = "save XML";
            this.saveXMLButton.UseVisualStyleBackColor = true;
            // 
            // loadXMLButton
            // 
            this.loadXMLButton.Location = new System.Drawing.Point(647, 74);
            this.loadXMLButton.Name = "loadXMLButton";
            this.loadXMLButton.Size = new System.Drawing.Size(141, 32);
            this.loadXMLButton.TabIndex = 11;
            this.loadXMLButton.Text = "load XML";
            this.loadXMLButton.UseVisualStyleBackColor = true;
            // 
            // loadBinButton
            // 
            this.loadBinButton.Location = new System.Drawing.Point(647, 36);
            this.loadBinButton.Name = "loadBinButton";
            this.loadBinButton.Size = new System.Drawing.Size(141, 32);
            this.loadBinButton.TabIndex = 12;
            this.loadBinButton.Text = "load binary";
            this.loadBinButton.UseVisualStyleBackColor = true;
            this.loadBinButton.Click += new System.EventHandler(this.loadBinButton_Click);
            // 
            // givenNameLabel
            // 
            this.givenNameLabel.AutoSize = true;
            this.givenNameLabel.Location = new System.Drawing.Point(24, 92);
            this.givenNameLabel.Name = "givenNameLabel";
            this.givenNameLabel.Size = new System.Drawing.Size(90, 17);
            this.givenNameLabel.TabIndex = 13;
            this.givenNameLabel.Text = "Given Name:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(45, 64);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(69, 17);
            this.surnameLabel.TabIndex = 17;
            this.surnameLabel.Text = "Surname:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(45, 36);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 17);
            this.typeLabel.TabIndex = 18;
            this.typeLabel.Text = "Type";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(54, 148);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(60, 17);
            this.genderLabel.TabIndex = 21;
            this.genderLabel.Text = "Gender:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(61, 120);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(53, 17);
            this.heightLabel.TabIndex = 22;
            this.heightLabel.Text = "Height:";
            // 
            // eyeColorLabel
            // 
            this.eyeColorLabel.AutoSize = true;
            this.eyeColorLabel.Location = new System.Drawing.Point(41, 178);
            this.eyeColorLabel.Name = "eyeColorLabel";
            this.eyeColorLabel.Size = new System.Drawing.Size(73, 17);
            this.eyeColorLabel.TabIndex = 23;
            this.eyeColorLabel.Text = "Eye Color:";
            // 
            // matricNoLabel
            // 
            this.matricNoLabel.AutoSize = true;
            this.matricNoLabel.Location = new System.Drawing.Point(24, 208);
            this.matricNoLabel.Name = "matricNoLabel";
            this.matricNoLabel.Size = new System.Drawing.Size(146, 17);
            this.matricNoLabel.TabIndex = 24;
            this.matricNoLabel.Text = "Matriculation Number:";
            // 
            // CPLabel
            // 
            this.CPLabel.AutoSize = true;
            this.CPLabel.Location = new System.Drawing.Point(78, 236);
            this.CPLabel.Name = "CPLabel";
            this.CPLabel.Size = new System.Drawing.Size(92, 17);
            this.CPLabel.TabIndex = 25;
            this.CPLabel.Text = "Credit Points:";
            // 
            // employeeNoLabel
            // 
            this.employeeNoLabel.AutoSize = true;
            this.employeeNoLabel.Location = new System.Drawing.Point(42, 259);
            this.employeeNoLabel.Name = "employeeNoLabel";
            this.employeeNoLabel.Size = new System.Drawing.Size(128, 17);
            this.employeeNoLabel.TabIndex = 26;
            this.employeeNoLabel.Text = "Employee Number:";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(118, 287);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(52, 17);
            this.salaryLabel.TabIndex = 27;
            this.salaryLabel.Text = "Salary:";
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(125, 64);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(196, 22);
            this.textBoxSurName.TabIndex = 28;
            this.textBoxSurName.TextChanged += new System.EventHandler(this.textBoxSurName_TextChanged);
            
            // 
            // textBoxGivenName
            // 
            this.textBoxGivenName.Location = new System.Drawing.Point(125, 92);
            this.textBoxGivenName.Name = "textBoxGivenName";
            this.textBoxGivenName.Size = new System.Drawing.Size(196, 22);
            this.textBoxGivenName.TabIndex = 29;
            this.textBoxGivenName.TextChanged += new System.EventHandler(this.textBoxGivenName_TextChanged);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(125, 120);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(196, 22);
            this.textBoxHeight.TabIndex = 30;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            // 
            // textBoxMatriculationNo
            // 
            this.textBoxMatriculationNo.Location = new System.Drawing.Point(192, 208);
            this.textBoxMatriculationNo.Name = "textBoxMatriculationNo";
            this.textBoxMatriculationNo.Size = new System.Drawing.Size(129, 22);
            this.textBoxMatriculationNo.TabIndex = 31;
            this.textBoxMatriculationNo.TextChanged += new System.EventHandler(this.textBoxMatriculationNo_TextChanged);
            // 
            // textBoxEmployeeNo
            // 
            this.textBoxEmployeeNo.Location = new System.Drawing.Point(192, 259);
            this.textBoxEmployeeNo.Name = "textBoxEmployeeNo";
            this.textBoxEmployeeNo.Size = new System.Drawing.Size(129, 22);
            this.textBoxEmployeeNo.TabIndex = 32;
            this.textBoxEmployeeNo.TextChanged += new System.EventHandler(this.textBoxEmployeeNo_TextChanged);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(125, 148);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(196, 24);
            this.comboBoxGender.TabIndex = 33;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // comboBoxEyeColor
            // 
            this.comboBoxEyeColor.FormattingEnabled = true;
            this.comboBoxEyeColor.Location = new System.Drawing.Point(125, 178);
            this.comboBoxEyeColor.Name = "comboBoxEyeColor";
            this.comboBoxEyeColor.Size = new System.Drawing.Size(196, 24);
            this.comboBoxEyeColor.TabIndex = 34;
            this.comboBoxEyeColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxEyeColor_SelectedIndexChanged);
            // 
            // CPOutputLabel
            // 
            this.CPOutputLabel.AutoSize = true;
            this.CPOutputLabel.Location = new System.Drawing.Point(192, 236);
            this.CPOutputLabel.Name = "CPOutputLabel";
            this.CPOutputLabel.Size = new System.Drawing.Size(16, 17);
            this.CPOutputLabel.TabIndex = 36;
            this.CPOutputLabel.Text = "0";
            // 
            // salaryOutputLabel
            // 
            this.salaryOutputLabel.AutoSize = true;
            this.salaryOutputLabel.Location = new System.Drawing.Point(192, 287);
            this.salaryOutputLabel.Name = "salaryOutputLabel";
            this.salaryOutputLabel.Size = new System.Drawing.Size(16, 17);
            this.salaryOutputLabel.TabIndex = 37;
            this.salaryOutputLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salaryOutputLabel);
            this.Controls.Add(this.CPOutputLabel);
            this.Controls.Add(this.comboBoxEyeColor);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxEmployeeNo);
            this.Controls.Add(this.textBoxMatriculationNo);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxGivenName);
            this.Controls.Add(this.textBoxSurName);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.employeeNoLabel);
            this.Controls.Add(this.CPLabel);
            this.Controls.Add(this.matricNoLabel);
            this.Controls.Add(this.eyeColorLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.givenNameLabel);
            this.Controls.Add(this.loadBinButton);
            this.Controls.Add(this.loadXMLButton);
            this.Controls.Add(this.saveXMLButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.saveBinButton);
            this.Controls.Add(this.promoteToStudent);
            this.Controls.Add(this.promoteToEmployee);
            this.Controls.Add(this.previousButton);
            this.Name = "Form1";
            this.Text = "Person Data Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button promoteToEmployee;
        private System.Windows.Forms.Button promoteToStudent;
        private System.Windows.Forms.Button saveBinButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button saveXMLButton;
        private System.Windows.Forms.Button loadXMLButton;
        private System.Windows.Forms.Button loadBinButton;
        private System.Windows.Forms.Label givenNameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label eyeColorLabel;
        private System.Windows.Forms.Label matricNoLabel;
        private System.Windows.Forms.Label CPLabel;
        private System.Windows.Forms.Label employeeNoLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxGivenName;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxMatriculationNo;
        private System.Windows.Forms.TextBox textBoxEmployeeNo;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxEyeColor;
        private System.Windows.Forms.Label CPOutputLabel;
        private System.Windows.Forms.Label salaryOutputLabel;
    }
}

