namespace BP_LAB_7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageVariant1 = new System.Windows.Forms.TabPage();
            this.tabPageVariant3 = new System.Windows.Forms.TabPage();
            this.comboBoxChooseEmployeeToShow = new System.Windows.Forms.ComboBox();
            this.labelChooseEmployeeToShow = new System.Windows.Forms.Label();
            this.comboBoxChooseFirmToAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseOfficeToShow = new System.Windows.Forms.ComboBox();
            this.labelChooseOfficeToShow = new System.Windows.Forms.Label();
            this.labelChooseFirmToAdd = new System.Windows.Forms.Label();
            this.groupBoxGiveAccessToOffice = new System.Windows.Forms.GroupBox();
            this.comboBoxChooseOfficeToAdd = new System.Windows.Forms.ComboBox();
            this.labelChooseOfficeToAdd = new System.Windows.Forms.Label();
            this.buttonGiveAccessToOffice = new System.Windows.Forms.Button();
            this.comboBoxChooseEmployeeToAdd = new System.Windows.Forms.ComboBox();
            this.labelChooseEmployeeToAdd = new System.Windows.Forms.Label();
            this.comboBoxChooseFirmToShow = new System.Windows.Forms.ComboBox();
            this.groupBoxAddEmployee = new System.Windows.Forms.GroupBox();
            this.textBoxEmployeeSurname = new System.Windows.Forms.TextBox();
            this.labelEmployeeSurname = new System.Windows.Forms.Label();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelChooseFirmToShow = new System.Windows.Forms.Label();
            this.groupBoxRentOffice = new System.Windows.Forms.GroupBox();
            this.buttonAddOffice = new System.Windows.Forms.Button();
            this.textBoxOfficeNumber = new System.Windows.Forms.TextBox();
            this.labelOfficeNumber = new System.Windows.Forms.Label();
            this.groupBoxFirmOfficesAndEmployees = new System.Windows.Forms.GroupBox();
            this.labelFirmOffices = new System.Windows.Forms.Label();
            this.labelFirmEmployees = new System.Windows.Forms.Label();
            this.listBoxFirmOffices = new System.Windows.Forms.ListBox();
            this.listBoxFirmEmployees = new System.Windows.Forms.ListBox();
            this.groupBoxAddFirm = new System.Windows.Forms.GroupBox();
            this.buttonAddFirm = new System.Windows.Forms.Button();
            this.textBoxFirmName = new System.Windows.Forms.TextBox();
            this.labelFirmName = new System.Windows.Forms.Label();
            this.groupBoxEmployeeOffices = new System.Windows.Forms.GroupBox();
            this.labelAccessableOffices = new System.Windows.Forms.Label();
            this.listBoxAccessableOffices = new System.Windows.Forms.ListBox();
            this.groupBoxOfficeStaff = new System.Windows.Forms.GroupBox();
            this.labelOfficeStaff = new System.Windows.Forms.Label();
            this.listBoxOfficeStaff = new System.Windows.Forms.ListBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageVariant3.SuspendLayout();
            this.groupBoxGiveAccessToOffice.SuspendLayout();
            this.groupBoxAddEmployee.SuspendLayout();
            this.groupBoxRentOffice.SuspendLayout();
            this.groupBoxFirmOfficesAndEmployees.SuspendLayout();
            this.groupBoxAddFirm.SuspendLayout();
            this.groupBoxEmployeeOffices.SuspendLayout();
            this.groupBoxOfficeStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageVariant1);
            this.tabControlMain.Controls.Add(this.tabPageVariant3);
            this.tabControlMain.Location = new System.Drawing.Point(-1, -1);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1070, 549);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageVariant1
            // 
            this.tabPageVariant1.Location = new System.Drawing.Point(4, 22);
            this.tabPageVariant1.Name = "tabPageVariant1";
            this.tabPageVariant1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVariant1.Size = new System.Drawing.Size(1062, 396);
            this.tabPageVariant1.TabIndex = 0;
            this.tabPageVariant1.Text = "Variant 1";
            this.tabPageVariant1.UseVisualStyleBackColor = true;
            // 
            // tabPageVariant3
            // 
            this.tabPageVariant3.Controls.Add(this.groupBoxOfficeStaff);
            this.tabPageVariant3.Controls.Add(this.groupBoxEmployeeOffices);
            this.tabPageVariant3.Controls.Add(this.comboBoxChooseFirmToAdd);
            this.tabPageVariant3.Controls.Add(this.labelChooseFirmToAdd);
            this.tabPageVariant3.Controls.Add(this.groupBoxGiveAccessToOffice);
            this.tabPageVariant3.Controls.Add(this.comboBoxChooseFirmToShow);
            this.tabPageVariant3.Controls.Add(this.groupBoxAddEmployee);
            this.tabPageVariant3.Controls.Add(this.labelChooseFirmToShow);
            this.tabPageVariant3.Controls.Add(this.groupBoxRentOffice);
            this.tabPageVariant3.Controls.Add(this.groupBoxFirmOfficesAndEmployees);
            this.tabPageVariant3.Controls.Add(this.groupBoxAddFirm);
            this.tabPageVariant3.Location = new System.Drawing.Point(4, 22);
            this.tabPageVariant3.Name = "tabPageVariant3";
            this.tabPageVariant3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVariant3.Size = new System.Drawing.Size(1062, 523);
            this.tabPageVariant3.TabIndex = 1;
            this.tabPageVariant3.Text = "Variant 3";
            this.tabPageVariant3.UseVisualStyleBackColor = true;
            // 
            // comboBoxChooseEmployeeToShow
            // 
            this.comboBoxChooseEmployeeToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChooseEmployeeToShow.FormattingEnabled = true;
            this.comboBoxChooseEmployeeToShow.Location = new System.Drawing.Point(14, 70);
            this.comboBoxChooseEmployeeToShow.Name = "comboBoxChooseEmployeeToShow";
            this.comboBoxChooseEmployeeToShow.Size = new System.Drawing.Size(150, 21);
            this.comboBoxChooseEmployeeToShow.TabIndex = 13;
            this.comboBoxChooseEmployeeToShow.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChooseEmployeeToShow_SelectedIndexChanged);
            // 
            // labelChooseEmployeeToShow
            // 
            this.labelChooseEmployeeToShow.AutoSize = true;
            this.labelChooseEmployeeToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseEmployeeToShow.Location = new System.Drawing.Point(35, 54);
            this.labelChooseEmployeeToShow.Name = "labelChooseEmployeeToShow";
            this.labelChooseEmployeeToShow.Size = new System.Drawing.Size(109, 13);
            this.labelChooseEmployeeToShow.TabIndex = 14;
            this.labelChooseEmployeeToShow.Text = "Choose an employee:";
            // 
            // comboBoxChooseFirmToAdd
            // 
            this.comboBoxChooseFirmToAdd.FormattingEnabled = true;
            this.comboBoxChooseFirmToAdd.Location = new System.Drawing.Point(127, 62);
            this.comboBoxChooseFirmToAdd.Name = "comboBoxChooseFirmToAdd";
            this.comboBoxChooseFirmToAdd.Size = new System.Drawing.Size(150, 21);
            this.comboBoxChooseFirmToAdd.TabIndex = 11;
            this.comboBoxChooseFirmToAdd.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChooseFirmToAdd_SelectedIndexChanged);
            // 
            // comboBoxChooseOfficeToShow
            // 
            this.comboBoxChooseOfficeToShow.FormattingEnabled = true;
            this.comboBoxChooseOfficeToShow.Location = new System.Drawing.Point(14, 70);
            this.comboBoxChooseOfficeToShow.Name = "comboBoxChooseOfficeToShow";
            this.comboBoxChooseOfficeToShow.Size = new System.Drawing.Size(150, 24);
            this.comboBoxChooseOfficeToShow.TabIndex = 13;
            this.comboBoxChooseOfficeToShow.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChooseOfficeToShow_SelectedIndexChanged);
            // 
            // labelChooseOfficeToShow
            // 
            this.labelChooseOfficeToShow.AutoSize = true;
            this.labelChooseOfficeToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseOfficeToShow.Location = new System.Drawing.Point(47, 54);
            this.labelChooseOfficeToShow.Name = "labelChooseOfficeToShow";
            this.labelChooseOfficeToShow.Size = new System.Drawing.Size(90, 13);
            this.labelChooseOfficeToShow.TabIndex = 14;
            this.labelChooseOfficeToShow.Text = "Choose an office:";
            // 
            // labelChooseFirmToAdd
            // 
            this.labelChooseFirmToAdd.AutoSize = true;
            this.labelChooseFirmToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseFirmToAdd.Location = new System.Drawing.Point(28, 63);
            this.labelChooseFirmToAdd.Name = "labelChooseFirmToAdd";
            this.labelChooseFirmToAdd.Size = new System.Drawing.Size(93, 16);
            this.labelChooseFirmToAdd.TabIndex = 12;
            this.labelChooseFirmToAdd.Text = "Choose a firm:";
            // 
            // groupBoxGiveAccessToOffice
            // 
            this.groupBoxGiveAccessToOffice.Controls.Add(this.comboBoxChooseOfficeToAdd);
            this.groupBoxGiveAccessToOffice.Controls.Add(this.labelChooseOfficeToAdd);
            this.groupBoxGiveAccessToOffice.Controls.Add(this.buttonGiveAccessToOffice);
            this.groupBoxGiveAccessToOffice.Controls.Add(this.comboBoxChooseEmployeeToAdd);
            this.groupBoxGiveAccessToOffice.Controls.Add(this.labelChooseEmployeeToAdd);
            this.groupBoxGiveAccessToOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGiveAccessToOffice.Location = new System.Drawing.Point(6, 226);
            this.groupBoxGiveAccessToOffice.Name = "groupBoxGiveAccessToOffice";
            this.groupBoxGiveAccessToOffice.Size = new System.Drawing.Size(333, 75);
            this.groupBoxGiveAccessToOffice.TabIndex = 15;
            this.groupBoxGiveAccessToOffice.TabStop = false;
            this.groupBoxGiveAccessToOffice.Text = "Give access to the office";
            // 
            // comboBoxChooseOfficeToAdd
            // 
            this.comboBoxChooseOfficeToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChooseOfficeToAdd.FormattingEnabled = true;
            this.comboBoxChooseOfficeToAdd.Location = new System.Drawing.Point(121, 46);
            this.comboBoxChooseOfficeToAdd.Name = "comboBoxChooseOfficeToAdd";
            this.comboBoxChooseOfficeToAdd.Size = new System.Drawing.Size(150, 21);
            this.comboBoxChooseOfficeToAdd.TabIndex = 13;
            // 
            // labelChooseOfficeToAdd
            // 
            this.labelChooseOfficeToAdd.AutoSize = true;
            this.labelChooseOfficeToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseOfficeToAdd.Location = new System.Drawing.Point(6, 49);
            this.labelChooseOfficeToAdd.Name = "labelChooseOfficeToAdd";
            this.labelChooseOfficeToAdd.Size = new System.Drawing.Size(90, 13);
            this.labelChooseOfficeToAdd.TabIndex = 14;
            this.labelChooseOfficeToAdd.Text = "Choose an office:";
            // 
            // buttonGiveAccessToOffice
            // 
            this.buttonGiveAccessToOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGiveAccessToOffice.Location = new System.Drawing.Point(277, 19);
            this.buttonGiveAccessToOffice.Name = "buttonGiveAccessToOffice";
            this.buttonGiveAccessToOffice.Size = new System.Drawing.Size(50, 48);
            this.buttonGiveAccessToOffice.TabIndex = 9;
            this.buttonGiveAccessToOffice.Text = "Add";
            this.buttonGiveAccessToOffice.UseVisualStyleBackColor = true;
            this.buttonGiveAccessToOffice.Click += new System.EventHandler(this.ButtonGiveAccessToOffice_Click);
            // 
            // comboBoxChooseEmployeeToAdd
            // 
            this.comboBoxChooseEmployeeToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChooseEmployeeToAdd.FormattingEnabled = true;
            this.comboBoxChooseEmployeeToAdd.Location = new System.Drawing.Point(121, 19);
            this.comboBoxChooseEmployeeToAdd.Name = "comboBoxChooseEmployeeToAdd";
            this.comboBoxChooseEmployeeToAdd.Size = new System.Drawing.Size(150, 21);
            this.comboBoxChooseEmployeeToAdd.TabIndex = 11;
            // 
            // labelChooseEmployeeToAdd
            // 
            this.labelChooseEmployeeToAdd.AutoSize = true;
            this.labelChooseEmployeeToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseEmployeeToAdd.Location = new System.Drawing.Point(6, 22);
            this.labelChooseEmployeeToAdd.Name = "labelChooseEmployeeToAdd";
            this.labelChooseEmployeeToAdd.Size = new System.Drawing.Size(109, 13);
            this.labelChooseEmployeeToAdd.TabIndex = 12;
            this.labelChooseEmployeeToAdd.Text = "Choose an employee:";
            // 
            // comboBoxChooseFirmToShow
            // 
            this.comboBoxChooseFirmToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChooseFirmToShow.FormattingEnabled = true;
            this.comboBoxChooseFirmToShow.Location = new System.Drawing.Point(495, 6);
            this.comboBoxChooseFirmToShow.Name = "comboBoxChooseFirmToShow";
            this.comboBoxChooseFirmToShow.Size = new System.Drawing.Size(150, 21);
            this.comboBoxChooseFirmToShow.TabIndex = 13;
            this.comboBoxChooseFirmToShow.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChooseFirmToShow_SelectedIndexChanged);
            // 
            // groupBoxAddEmployee
            // 
            this.groupBoxAddEmployee.Controls.Add(this.textBoxEmployeeSurname);
            this.groupBoxAddEmployee.Controls.Add(this.labelEmployeeSurname);
            this.groupBoxAddEmployee.Controls.Add(this.buttonAddEmployee);
            this.groupBoxAddEmployee.Controls.Add(this.textBoxEmployeeName);
            this.groupBoxAddEmployee.Controls.Add(this.labelEmployeeName);
            this.groupBoxAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAddEmployee.Location = new System.Drawing.Point(6, 145);
            this.groupBoxAddEmployee.Name = "groupBoxAddEmployee";
            this.groupBoxAddEmployee.Size = new System.Drawing.Size(333, 75);
            this.groupBoxAddEmployee.TabIndex = 13;
            this.groupBoxAddEmployee.TabStop = false;
            this.groupBoxAddEmployee.Text = "Add an employee";
            // 
            // textBoxEmployeeSurname
            // 
            this.textBoxEmployeeSurname.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmployeeSurname.Location = new System.Drawing.Point(121, 45);
            this.textBoxEmployeeSurname.Name = "textBoxEmployeeSurname";
            this.textBoxEmployeeSurname.Size = new System.Drawing.Size(150, 20);
            this.textBoxEmployeeSurname.TabIndex = 14;
            // 
            // labelEmployeeSurname
            // 
            this.labelEmployeeSurname.AutoSize = true;
            this.labelEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmployeeSurname.Location = new System.Drawing.Point(6, 48);
            this.labelEmployeeSurname.Name = "labelEmployeeSurname";
            this.labelEmployeeSurname.Size = new System.Drawing.Size(52, 13);
            this.labelEmployeeSurname.TabIndex = 13;
            this.labelEmployeeSurname.Text = "Surname:";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddEmployee.Location = new System.Drawing.Point(277, 19);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(50, 46);
            this.buttonAddEmployee.TabIndex = 9;
            this.buttonAddEmployee.Text = "Add";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.ButtonAddEmployee_Click);
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmployeeName.Location = new System.Drawing.Point(121, 19);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(150, 20);
            this.textBoxEmployeeName.TabIndex = 9;
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmployeeName.Location = new System.Drawing.Point(6, 22);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(38, 13);
            this.labelEmployeeName.TabIndex = 1;
            this.labelEmployeeName.Text = "Name:";
            // 
            // labelChooseFirmToShow
            // 
            this.labelChooseFirmToShow.AutoSize = true;
            this.labelChooseFirmToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseFirmToShow.Location = new System.Drawing.Point(396, 7);
            this.labelChooseFirmToShow.Name = "labelChooseFirmToShow";
            this.labelChooseFirmToShow.Size = new System.Drawing.Size(93, 16);
            this.labelChooseFirmToShow.TabIndex = 14;
            this.labelChooseFirmToShow.Text = "Choose a firm:";
            // 
            // groupBoxRentOffice
            // 
            this.groupBoxRentOffice.Controls.Add(this.buttonAddOffice);
            this.groupBoxRentOffice.Controls.Add(this.textBoxOfficeNumber);
            this.groupBoxRentOffice.Controls.Add(this.labelOfficeNumber);
            this.groupBoxRentOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRentOffice.Location = new System.Drawing.Point(6, 89);
            this.groupBoxRentOffice.Name = "groupBoxRentOffice";
            this.groupBoxRentOffice.Size = new System.Drawing.Size(333, 50);
            this.groupBoxRentOffice.TabIndex = 9;
            this.groupBoxRentOffice.TabStop = false;
            this.groupBoxRentOffice.Text = "Rent an office";
            // 
            // buttonAddOffice
            // 
            this.buttonAddOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddOffice.Location = new System.Drawing.Point(277, 19);
            this.buttonAddOffice.Name = "buttonAddOffice";
            this.buttonAddOffice.Size = new System.Drawing.Size(50, 25);
            this.buttonAddOffice.TabIndex = 9;
            this.buttonAddOffice.Text = "Add";
            this.buttonAddOffice.UseVisualStyleBackColor = true;
            this.buttonAddOffice.Click += new System.EventHandler(this.ButtonAddOffice_Click);
            // 
            // textBoxOfficeNumber
            // 
            this.textBoxOfficeNumber.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOfficeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOfficeNumber.Location = new System.Drawing.Point(121, 22);
            this.textBoxOfficeNumber.Name = "textBoxOfficeNumber";
            this.textBoxOfficeNumber.Size = new System.Drawing.Size(150, 20);
            this.textBoxOfficeNumber.TabIndex = 9;
            // 
            // labelOfficeNumber
            // 
            this.labelOfficeNumber.AutoSize = true;
            this.labelOfficeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOfficeNumber.Location = new System.Drawing.Point(6, 25);
            this.labelOfficeNumber.Name = "labelOfficeNumber";
            this.labelOfficeNumber.Size = new System.Drawing.Size(76, 13);
            this.labelOfficeNumber.TabIndex = 1;
            this.labelOfficeNumber.Text = "Office number:";
            // 
            // groupBoxFirmOfficesAndEmployees
            // 
            this.groupBoxFirmOfficesAndEmployees.Controls.Add(this.labelFirmOffices);
            this.groupBoxFirmOfficesAndEmployees.Controls.Add(this.labelFirmEmployees);
            this.groupBoxFirmOfficesAndEmployees.Controls.Add(this.listBoxFirmOffices);
            this.groupBoxFirmOfficesAndEmployees.Controls.Add(this.listBoxFirmEmployees);
            this.groupBoxFirmOfficesAndEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFirmOfficesAndEmployees.Location = new System.Drawing.Point(345, 33);
            this.groupBoxFirmOfficesAndEmployees.Name = "groupBoxFirmOfficesAndEmployees";
            this.groupBoxFirmOfficesAndEmployees.Size = new System.Drawing.Size(350, 140);
            this.groupBoxFirmOfficesAndEmployees.TabIndex = 4;
            this.groupBoxFirmOfficesAndEmployees.TabStop = false;
            this.groupBoxFirmOfficesAndEmployees.Text = "Offices and employees of a firm";
            // 
            // labelFirmOffices
            // 
            this.labelFirmOffices.AutoSize = true;
            this.labelFirmOffices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirmOffices.Location = new System.Drawing.Point(175, 22);
            this.labelFirmOffices.Name = "labelFirmOffices";
            this.labelFirmOffices.Size = new System.Drawing.Size(43, 13);
            this.labelFirmOffices.TabIndex = 18;
            this.labelFirmOffices.Text = "Offices:";
            // 
            // labelFirmEmployees
            // 
            this.labelFirmEmployees.AutoSize = true;
            this.labelFirmEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirmEmployees.Location = new System.Drawing.Point(6, 22);
            this.labelFirmEmployees.Name = "labelFirmEmployees";
            this.labelFirmEmployees.Size = new System.Drawing.Size(61, 13);
            this.labelFirmEmployees.TabIndex = 17;
            this.labelFirmEmployees.Text = "Employees:";
            // 
            // listBoxFirmOffices
            // 
            this.listBoxFirmOffices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFirmOffices.FormattingEnabled = true;
            this.listBoxFirmOffices.Items.AddRange(new object[] {
            "36t46",
            "dgdg",
            "fgfd",
            "g",
            "d",
            "g",
            "gd",
            "gd"});
            this.listBoxFirmOffices.Location = new System.Drawing.Point(178, 38);
            this.listBoxFirmOffices.Name = "listBoxFirmOffices";
            this.listBoxFirmOffices.Size = new System.Drawing.Size(166, 95);
            this.listBoxFirmOffices.TabIndex = 16;
            // 
            // listBoxFirmEmployees
            // 
            this.listBoxFirmEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFirmEmployees.FormattingEnabled = true;
            this.listBoxFirmEmployees.Items.AddRange(new object[] {
            "36t46",
            "dgdg",
            "fgfd",
            "g",
            "d",
            "g",
            "gd",
            "gd"});
            this.listBoxFirmEmployees.Location = new System.Drawing.Point(6, 38);
            this.listBoxFirmEmployees.Name = "listBoxFirmEmployees";
            this.listBoxFirmEmployees.Size = new System.Drawing.Size(166, 95);
            this.listBoxFirmEmployees.TabIndex = 15;
            // 
            // groupBoxAddFirm
            // 
            this.groupBoxAddFirm.Controls.Add(this.buttonAddFirm);
            this.groupBoxAddFirm.Controls.Add(this.textBoxFirmName);
            this.groupBoxAddFirm.Controls.Add(this.labelFirmName);
            this.groupBoxAddFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAddFirm.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAddFirm.Name = "groupBoxAddFirm";
            this.groupBoxAddFirm.Size = new System.Drawing.Size(333, 50);
            this.groupBoxAddFirm.TabIndex = 0;
            this.groupBoxAddFirm.TabStop = false;
            this.groupBoxAddFirm.Text = "Add a firm";
            // 
            // buttonAddFirm
            // 
            this.buttonAddFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddFirm.Location = new System.Drawing.Point(277, 19);
            this.buttonAddFirm.Name = "buttonAddFirm";
            this.buttonAddFirm.Size = new System.Drawing.Size(50, 25);
            this.buttonAddFirm.TabIndex = 8;
            this.buttonAddFirm.Text = "Add";
            this.buttonAddFirm.UseVisualStyleBackColor = true;
            this.buttonAddFirm.Click += new System.EventHandler(this.ButtonAddFirm_Click);
            // 
            // textBoxFirmName
            // 
            this.textBoxFirmName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirmName.Location = new System.Drawing.Point(121, 22);
            this.textBoxFirmName.Name = "textBoxFirmName";
            this.textBoxFirmName.Size = new System.Drawing.Size(150, 20);
            this.textBoxFirmName.TabIndex = 7;
            // 
            // labelFirmName
            // 
            this.labelFirmName.AutoSize = true;
            this.labelFirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirmName.Location = new System.Drawing.Point(6, 25);
            this.labelFirmName.Name = "labelFirmName";
            this.labelFirmName.Size = new System.Drawing.Size(58, 13);
            this.labelFirmName.TabIndex = 0;
            this.labelFirmName.Text = "Firm name:";
            // 
            // groupBoxEmployeeOffices
            // 
            this.groupBoxEmployeeOffices.Controls.Add(this.labelAccessableOffices);
            this.groupBoxEmployeeOffices.Controls.Add(this.listBoxAccessableOffices);
            this.groupBoxEmployeeOffices.Controls.Add(this.labelChooseEmployeeToShow);
            this.groupBoxEmployeeOffices.Controls.Add(this.comboBoxChooseEmployeeToShow);
            this.groupBoxEmployeeOffices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxEmployeeOffices.Location = new System.Drawing.Point(345, 179);
            this.groupBoxEmployeeOffices.Name = "groupBoxEmployeeOffices";
            this.groupBoxEmployeeOffices.Size = new System.Drawing.Size(350, 140);
            this.groupBoxEmployeeOffices.TabIndex = 19;
            this.groupBoxEmployeeOffices.TabStop = false;
            this.groupBoxEmployeeOffices.Text = "The offices that are accessable to the employee";
            // 
            // labelAccessableOffices
            // 
            this.labelAccessableOffices.AutoSize = true;
            this.labelAccessableOffices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccessableOffices.Location = new System.Drawing.Point(175, 22);
            this.labelAccessableOffices.Name = "labelAccessableOffices";
            this.labelAccessableOffices.Size = new System.Drawing.Size(99, 13);
            this.labelAccessableOffices.TabIndex = 18;
            this.labelAccessableOffices.Text = "Accessable offices:";
            // 
            // listBoxAccessableOffices
            // 
            this.listBoxAccessableOffices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxAccessableOffices.FormattingEnabled = true;
            this.listBoxAccessableOffices.Items.AddRange(new object[] {
            "36t46",
            "dgdg",
            "fgfd",
            "g",
            "d",
            "g",
            "gd",
            "gd"});
            this.listBoxAccessableOffices.Location = new System.Drawing.Point(178, 38);
            this.listBoxAccessableOffices.Name = "listBoxAccessableOffices";
            this.listBoxAccessableOffices.Size = new System.Drawing.Size(166, 95);
            this.listBoxAccessableOffices.TabIndex = 16;
            // 
            // groupBoxOfficeStaff
            // 
            this.groupBoxOfficeStaff.Controls.Add(this.labelOfficeStaff);
            this.groupBoxOfficeStaff.Controls.Add(this.listBoxOfficeStaff);
            this.groupBoxOfficeStaff.Controls.Add(this.labelChooseOfficeToShow);
            this.groupBoxOfficeStaff.Controls.Add(this.comboBoxChooseOfficeToShow);
            this.groupBoxOfficeStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOfficeStaff.Location = new System.Drawing.Point(345, 325);
            this.groupBoxOfficeStaff.Name = "groupBoxOfficeStaff";
            this.groupBoxOfficeStaff.Size = new System.Drawing.Size(350, 140);
            this.groupBoxOfficeStaff.TabIndex = 20;
            this.groupBoxOfficeStaff.TabStop = false;
            this.groupBoxOfficeStaff.Text = "Employees that has access to the office";
            // 
            // labelOfficeStaff
            // 
            this.labelOfficeStaff.AutoSize = true;
            this.labelOfficeStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOfficeStaff.Location = new System.Drawing.Point(175, 22);
            this.labelOfficeStaff.Name = "labelOfficeStaff";
            this.labelOfficeStaff.Size = new System.Drawing.Size(61, 13);
            this.labelOfficeStaff.TabIndex = 17;
            this.labelOfficeStaff.Text = "Office staff:";
            // 
            // listBoxOfficeStaff
            // 
            this.listBoxOfficeStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxOfficeStaff.FormattingEnabled = true;
            this.listBoxOfficeStaff.Items.AddRange(new object[] {
            "36t46",
            "dgdg",
            "fgfd",
            "g",
            "d",
            "g",
            "gd",
            "gd"});
            this.listBoxOfficeStaff.Location = new System.Drawing.Point(178, 38);
            this.listBoxOfficeStaff.Name = "listBoxOfficeStaff";
            this.listBoxOfficeStaff.Size = new System.Drawing.Size(166, 95);
            this.listBoxOfficeStaff.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 582);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "BP_LAB_7";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageVariant3.ResumeLayout(false);
            this.tabPageVariant3.PerformLayout();
            this.groupBoxGiveAccessToOffice.ResumeLayout(false);
            this.groupBoxGiveAccessToOffice.PerformLayout();
            this.groupBoxAddEmployee.ResumeLayout(false);
            this.groupBoxAddEmployee.PerformLayout();
            this.groupBoxRentOffice.ResumeLayout(false);
            this.groupBoxRentOffice.PerformLayout();
            this.groupBoxFirmOfficesAndEmployees.ResumeLayout(false);
            this.groupBoxFirmOfficesAndEmployees.PerformLayout();
            this.groupBoxAddFirm.ResumeLayout(false);
            this.groupBoxAddFirm.PerformLayout();
            this.groupBoxEmployeeOffices.ResumeLayout(false);
            this.groupBoxEmployeeOffices.PerformLayout();
            this.groupBoxOfficeStaff.ResumeLayout(false);
            this.groupBoxOfficeStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageVariant1;
        private System.Windows.Forms.TabPage tabPageVariant3;
        private System.Windows.Forms.GroupBox groupBoxFirmOfficesAndEmployees;
        private System.Windows.Forms.GroupBox groupBoxAddFirm;
        private System.Windows.Forms.Label labelOfficeNumber;
        private System.Windows.Forms.Label labelFirmName;
        private System.Windows.Forms.Button buttonAddFirm;
        private System.Windows.Forms.TextBox textBoxFirmName;
        private System.Windows.Forms.TextBox textBoxOfficeNumber;
        private System.Windows.Forms.Label labelChooseFirmToAdd;
        private System.Windows.Forms.ComboBox comboBoxChooseFirmToAdd;
        private System.Windows.Forms.GroupBox groupBoxRentOffice;
        private System.Windows.Forms.GroupBox groupBoxAddEmployee;
        private System.Windows.Forms.TextBox textBoxEmployeeSurname;
        private System.Windows.Forms.Label labelEmployeeSurname;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Button buttonAddOffice;
        private System.Windows.Forms.GroupBox groupBoxGiveAccessToOffice;
        private System.Windows.Forms.Button buttonGiveAccessToOffice;
        private System.Windows.Forms.ComboBox comboBoxChooseEmployeeToAdd;
        private System.Windows.Forms.Label labelChooseEmployeeToAdd;
        private System.Windows.Forms.ComboBox comboBoxChooseOfficeToAdd;
        private System.Windows.Forms.Label labelChooseOfficeToAdd;
        private System.Windows.Forms.ListBox listBoxFirmEmployees;
        private System.Windows.Forms.ComboBox comboBoxChooseFirmToShow;
        private System.Windows.Forms.Label labelChooseFirmToShow;
        private System.Windows.Forms.ListBox listBoxFirmOffices;
        private System.Windows.Forms.ComboBox comboBoxChooseOfficeToShow;
        private System.Windows.Forms.Label labelChooseOfficeToShow;
        private System.Windows.Forms.ComboBox comboBoxChooseEmployeeToShow;
        private System.Windows.Forms.Label labelChooseEmployeeToShow;
        private System.Windows.Forms.Label labelFirmOffices;
        private System.Windows.Forms.Label labelFirmEmployees;
        private System.Windows.Forms.GroupBox groupBoxOfficeStaff;
        private System.Windows.Forms.Label labelOfficeStaff;
        private System.Windows.Forms.ListBox listBoxOfficeStaff;
        private System.Windows.Forms.GroupBox groupBoxEmployeeOffices;
        private System.Windows.Forms.Label labelAccessableOffices;
        private System.Windows.Forms.ListBox listBoxAccessableOffices;
    }
}

