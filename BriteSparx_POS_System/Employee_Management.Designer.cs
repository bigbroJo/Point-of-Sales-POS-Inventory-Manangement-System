
namespace BriteSparx_POS_System
{
    partial class Employee_Management
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
            this.dgvEmployeeManagement = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCellphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g17Wst2024DataSet = new BriteSparx_POS_System.G17Wst2024DataSet();
            this.txtEmployeeSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbArchiveStatus = new System.Windows.Forms.ComboBox();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployeeInfo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.EmployeePassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNewEmployeeCell = new System.Windows.Forms.TextBox();
            this.txtNewEmployeePosition = new System.Windows.Forms.TextBox();
            this.txtNewEmployeeSalary = new System.Windows.Forms.TextBox();
            this.txtNewEmployeeIDno = new System.Windows.Forms.TextBox();
            this.txtNewEmployeeSurname = new System.Windows.Forms.TextBox();
            this.txtNewEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtNewEmployeePassword = new System.Windows.Forms.TextBox();
            this.txtNewEmployeeName = new System.Windows.Forms.TextBox();
            this.eMPLOYEEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taEmployee = new BriteSparx_POS_System.G17Wst2024DataSetTableAdapters.EMPLOYEETableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCellphoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSalary = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIDNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g17Wst2024DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCellphoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIDNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeeManagement
            // 
            this.dgvEmployeeManagement.AutoGenerateColumns = false;
            this.dgvEmployeeManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeSurnameDataGridViewTextBoxColumn,
            this.employeeCellphoneDataGridViewTextBoxColumn,
            this.employeeEmailDataGridViewTextBoxColumn,
            this.Employee_Password,
            this.employeeSalaryDataGridViewTextBoxColumn,
            this.employeePositionDataGridViewTextBoxColumn,
            this.iDNumberDataGridViewTextBoxColumn,
            this.archiveStatusDataGridViewTextBoxColumn});
            this.dgvEmployeeManagement.DataSource = this.eMPLOYEEBindingSource;
            this.dgvEmployeeManagement.Location = new System.Drawing.Point(39, 102);
            this.dgvEmployeeManagement.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployeeManagement.Name = "dgvEmployeeManagement";
            this.dgvEmployeeManagement.Size = new System.Drawing.Size(1588, 185);
            this.dgvEmployeeManagement.TabIndex = 0;
            this.dgvEmployeeManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeManagement_CellContentClick);
            this.dgvEmployeeManagement.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployeeManagement_RowHeaderMouseClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 116;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // employeeSurnameDataGridViewTextBoxColumn
            // 
            this.employeeSurnameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Surname";
            this.employeeSurnameDataGridViewTextBoxColumn.HeaderText = "Employee_Surname";
            this.employeeSurnameDataGridViewTextBoxColumn.Name = "employeeSurnameDataGridViewTextBoxColumn";
            // 
            // employeeCellphoneDataGridViewTextBoxColumn
            // 
            this.employeeCellphoneDataGridViewTextBoxColumn.DataPropertyName = "Employee_Cellphone";
            this.employeeCellphoneDataGridViewTextBoxColumn.HeaderText = "Employee_Cellphone";
            this.employeeCellphoneDataGridViewTextBoxColumn.Name = "employeeCellphoneDataGridViewTextBoxColumn";
            // 
            // employeeEmailDataGridViewTextBoxColumn
            // 
            this.employeeEmailDataGridViewTextBoxColumn.DataPropertyName = "Employee_Email";
            this.employeeEmailDataGridViewTextBoxColumn.HeaderText = "Employee_Email";
            this.employeeEmailDataGridViewTextBoxColumn.Name = "employeeEmailDataGridViewTextBoxColumn";
            // 
            // Employee_Password
            // 
            this.Employee_Password.DataPropertyName = "Employee_Password";
            this.Employee_Password.HeaderText = "Employee_Password";
            this.Employee_Password.Name = "Employee_Password";
            this.Employee_Password.Visible = false;
            // 
            // employeeSalaryDataGridViewTextBoxColumn
            // 
            this.employeeSalaryDataGridViewTextBoxColumn.DataPropertyName = "Employee_Salary";
            this.employeeSalaryDataGridViewTextBoxColumn.HeaderText = "Employee_Salary";
            this.employeeSalaryDataGridViewTextBoxColumn.Name = "employeeSalaryDataGridViewTextBoxColumn";
            // 
            // employeePositionDataGridViewTextBoxColumn
            // 
            this.employeePositionDataGridViewTextBoxColumn.DataPropertyName = "Employee_Position";
            this.employeePositionDataGridViewTextBoxColumn.HeaderText = "Employee_Position";
            this.employeePositionDataGridViewTextBoxColumn.Name = "employeePositionDataGridViewTextBoxColumn";
            // 
            // iDNumberDataGridViewTextBoxColumn
            // 
            this.iDNumberDataGridViewTextBoxColumn.DataPropertyName = "ID_Number";
            this.iDNumberDataGridViewTextBoxColumn.HeaderText = "ID_Number";
            this.iDNumberDataGridViewTextBoxColumn.Name = "iDNumberDataGridViewTextBoxColumn";
            // 
            // archiveStatusDataGridViewTextBoxColumn
            // 
            this.archiveStatusDataGridViewTextBoxColumn.DataPropertyName = "Archive_Status";
            this.archiveStatusDataGridViewTextBoxColumn.HeaderText = "Archive_Status";
            this.archiveStatusDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.archiveStatusDataGridViewTextBoxColumn.Name = "archiveStatusDataGridViewTextBoxColumn";
            this.archiveStatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.archiveStatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.g17Wst2024DataSet;
            // 
            // g17Wst2024DataSet
            // 
            this.g17Wst2024DataSet.DataSetName = "G17Wst2024DataSet";
            this.g17Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEmployeeSearch
            // 
            this.txtEmployeeSearch.Location = new System.Drawing.Point(248, 48);
            this.txtEmployeeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeSearch.Name = "txtEmployeeSearch";
            this.txtEmployeeSearch.Size = new System.Drawing.Size(132, 23);
            this.txtEmployeeSearch.TabIndex = 1;
            this.txtEmployeeSearch.TextChanged += new System.EventHandler(this.txtEmployeeSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Employee Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbArchiveStatus);
            this.groupBox1.Controls.Add(this.btnAddNewEmployee);
            this.groupBox1.Controls.Add(this.btnUpdateEmployeeInfo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Salary);
            this.groupBox1.Controls.Add(this.EmployeePassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtNewEmployeeCell);
            this.groupBox1.Controls.Add(this.txtNewEmployeePosition);
            this.groupBox1.Controls.Add(this.txtNewEmployeeSalary);
            this.groupBox1.Controls.Add(this.txtNewEmployeeIDno);
            this.groupBox1.Controls.Add(this.txtNewEmployeeSurname);
            this.groupBox1.Controls.Add(this.txtNewEmployeeEmail);
            this.groupBox1.Controls.Add(this.txtNewEmployeePassword);
            this.groupBox1.Controls.Add(this.txtNewEmployeeName);
            this.groupBox1.Location = new System.Drawing.Point(39, 364);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1385, 370);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Employee Details";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(615, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(161, 47);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(940, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Archive Status:";
            // 
            // cbArchiveStatus
            // 
            this.cbArchiveStatus.FormattingEnabled = true;
            this.cbArchiveStatus.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbArchiveStatus.Location = new System.Drawing.Point(1049, 225);
            this.cbArchiveStatus.Name = "cbArchiveStatus";
            this.cbArchiveStatus.Size = new System.Drawing.Size(121, 24);
            this.cbArchiveStatus.TabIndex = 17;
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Location = new System.Drawing.Point(347, 281);
            this.btnAddNewEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(173, 47);
            this.btnAddNewEmployee.TabIndex = 4;
            this.btnAddNewEmployee.Text = "Add New Employee";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // btnUpdateEmployeeInfo
            // 
            this.btnUpdateEmployeeInfo.Location = new System.Drawing.Point(71, 281);
            this.btnUpdateEmployeeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateEmployeeInfo.Name = "btnUpdateEmployeeInfo";
            this.btnUpdateEmployeeInfo.Size = new System.Drawing.Size(173, 47);
            this.btnUpdateEmployeeInfo.TabIndex = 5;
            this.btnUpdateEmployeeInfo.Text = "Update Employee Profile";
            this.btnUpdateEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnUpdateEmployeeInfo.Click += new System.EventHandler(this.btnUpdateEmployeeInfo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(962, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(979, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Position:";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(540, 229);
            this.Salary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(52, 17);
            this.Salary.TabIndex = 14;
            this.Salary.Text = "Salary:";
            // 
            // EmployeePassword
            // 
            this.EmployeePassword.AutoSize = true;
            this.EmployeePassword.Location = new System.Drawing.Point(517, 164);
            this.EmployeePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeePassword.Name = "EmployeePassword";
            this.EmployeePassword.Size = new System.Drawing.Size(73, 17);
            this.EmployeePassword.TabIndex = 13;
            this.EmployeePassword.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cellphone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Surname:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Name:";
            // 
            // txtNewEmployeeCell
            // 
            this.txtNewEmployeeCell.Location = new System.Drawing.Point(185, 225);
            this.txtNewEmployeeCell.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewEmployeeCell.Name = "txtNewEmployeeCell";
            this.txtNewEmployeeCell.Size = new System.Drawing.Size(132, 23);
            this.txtNewEmployeeCell.TabIndex = 7;
            this.txtNewEmployeeCell.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.txtNewEmployeeCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewEmployeeCell_KeyPress);
            // 
            // txtNewEmployeePosition
            // 
            this.txtNewEmployeePosition.Location = new System.Drawing.Point(1049, 95);
            this.txtNewEmployeePosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewEmployeePosition.Name = "txtNewEmployeePosition";
            this.txtNewEmployeePosition.Size = new System.Drawing.Size(132, 23);
            this.txtNewEmployeePosition.TabIndex = 6;
            this.txtNewEmployeePosition.TextChanged += new System.EventHandler(this.txtNewEmployeePosition_TextChanged);
            // 
            // txtNewEmployeeSalary
            // 
            this.txtNewEmployeeSalary.Location = new System.Drawing.Point(600, 225);
            this.txtNewEmployeeSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewEmployeeSalary.Name = "txtNewEmployeeSalary";
            this.txtNewEmployeeSalary.Size = new System.Drawing.Size(132, 23);
            this.txtNewEmployeeSalary.TabIndex = 5;
            this.txtNewEmployeeSalary.TextChanged += new System.EventHandler(this.txtNewEmployeeSalary_TextChanged);
            this.txtNewEmployeeSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewEmployeeSalary_KeyPress);
            // 
            // txtNewEmployeeIDno
            // 
            this.txtNewEmployeeIDno.Location = new System.Drawing.Point(1049, 160);
            this.txtNewEmployeeIDno.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewEmployeeIDno.Name = "txtNewEmployeeIDno";
            this.txtNewEmployeeIDno.Size = new System.Drawing.Size(132, 23);
            this.txtNewEmployeeIDno.TabIndex = 4;
            this.txtNewEmployeeIDno.TextChanged += new System.EventHandler(this.txtNewEmployeeIDno_TextChanged);
            this.txtNewEmployeeIDno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewEmployeeIDno_KeyPress);
            // 
            // txtNewEmployeeSurname
            // 
            this.txtNewEmployeeSurname.Location = new System.Drawing.Point(185, 160);
            this.txtNewEmployeeSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewEmployeeSurname.Name = "txtNewEmployeeSurname";
            this.txtNewEmployeeSurname.Size = new System.Drawing.Size(132, 23);
            this.txtNewEmployeeSurname.TabIndex = 3;
            this.txtNewEmployeeSurname.TextChanged += new System.EventHandler(this.txtNewEmployeeSurname_TextChanged);
            // 
            // txtNewEmployeeEmail
            // 
            this.txtNewEmployeeEmail.Location = new System.Drawing.Point(600, 95);
            this.txtNewEmployeeEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewEmployeeEmail.Name = "txtNewEmployeeEmail";
            this.txtNewEmployeeEmail.Size = new System.Drawing.Size(132, 23);
            this.txtNewEmployeeEmail.TabIndex = 2;
            this.txtNewEmployeeEmail.TextChanged += new System.EventHandler(this.txtNewEmployeeEmail_TextChanged);
            // 
            // txtNewEmployeePassword
            // 
            this.txtNewEmployeePassword.Location = new System.Drawing.Point(600, 160);
            this.txtNewEmployeePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewEmployeePassword.Name = "txtNewEmployeePassword";
            this.txtNewEmployeePassword.Size = new System.Drawing.Size(132, 23);
            this.txtNewEmployeePassword.TabIndex = 1;
            this.txtNewEmployeePassword.TextChanged += new System.EventHandler(this.txtNewEmployeePassword_TextChanged);
            // 
            // txtNewEmployeeName
            // 
            this.txtNewEmployeeName.Location = new System.Drawing.Point(185, 95);
            this.txtNewEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewEmployeeName.Name = "txtNewEmployeeName";
            this.txtNewEmployeeName.Size = new System.Drawing.Size(132, 23);
            this.txtNewEmployeeName.TabIndex = 0;
            this.txtNewEmployeeName.TextChanged += new System.EventHandler(this.txtNewEmployeeName_TextChanged);
            // 
            // eMPLOYEEBindingSource1
            // 
            this.eMPLOYEEBindingSource1.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource1.DataSource = this.g17Wst2024DataSet;
            // 
            // taEmployee
            // 
            this.taEmployee.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(39, 773);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(163, 47);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Return";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderSurname
            // 
            this.errorProviderSurname.ContainerControl = this;
            // 
            // errorProviderCellphoneNumber
            // 
            this.errorProviderCellphoneNumber.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // errorProviderSalary
            // 
            this.errorProviderSalary.ContainerControl = this;
            // 
            // errorProviderIDNumber
            // 
            this.errorProviderIDNumber.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Employee_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 853);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeSearch);
            this.Controls.Add(this.dgvEmployeeManagement);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee_Management";
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g17Wst2024DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCellphoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIDNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeManagement;
        private G17Wst2024DataSet g17Wst2024DataSet;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private G17Wst2024DataSetTableAdapters.EMPLOYEETableAdapter taEmployee;
        private System.Windows.Forms.TextBox txtEmployeeSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Button btnUpdateEmployeeInfo;
        private System.Windows.Forms.TextBox txtNewEmployeeCell;
        private System.Windows.Forms.TextBox txtNewEmployeePosition;
        private System.Windows.Forms.TextBox txtNewEmployeeSalary;
        private System.Windows.Forms.TextBox txtNewEmployeeIDno;
        private System.Windows.Forms.TextBox txtNewEmployeeSurname;
        private System.Windows.Forms.TextBox txtNewEmployeeEmail;
        private System.Windows.Forms.TextBox txtNewEmployeePassword;
        private System.Windows.Forms.TextBox txtNewEmployeeName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label EmployeePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource1;
        private System.Windows.Forms.ComboBox cbArchiveStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderSurname;
        private System.Windows.Forms.ErrorProvider errorProviderCellphoneNumber;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.ErrorProvider errorProviderSalary;
        private System.Windows.Forms.ErrorProvider errorProviderIDNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCellphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn archiveStatusDataGridViewTextBoxColumn;
    }
}