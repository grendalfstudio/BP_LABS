namespace BP_LAB_10
{
    partial class FormMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCheck = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxCheckSurname = new System.Windows.Forms.TextBox();
            this.textBoxCheckName = new System.Windows.Forms.TextBox();
            this.labelCheckName = new System.Windows.Forms.Label();
            this.labelCheckSurname = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.maskedTextBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxAddSurname = new System.Windows.Forms.TextBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.labelAddSurname = new System.Windows.Forms.Label();
            this.labelAddName = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.groupBoxCheck.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemCreate,
            this.menuStripItemWrite,
            this.menuStripItemCheck,
            this.menuStripItemExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(482, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuStripItemCreate
            // 
            this.menuStripItemCreate.Name = "menuStripItemCreate";
            this.menuStripItemCreate.Size = new System.Drawing.Size(137, 20);
            this.menuStripItemCreate.Text = "Створити нову фірму";
            this.menuStripItemCreate.Click += new System.EventHandler(this.MenuStripItemCreate_Click);
            // 
            // menuStripItemWrite
            // 
            this.menuStripItemWrite.Name = "menuStripItemWrite";
            this.menuStripItemWrite.Size = new System.Drawing.Size(111, 20);
            this.menuStripItemWrite.Text = "Записати в файл";
            this.menuStripItemWrite.Click += new System.EventHandler(this.MenuStripItemWrite_Click);
            // 
            // menuStripItemCheck
            // 
            this.menuStripItemCheck.Name = "menuStripItemCheck";
            this.menuStripItemCheck.Size = new System.Drawing.Size(147, 20);
            this.menuStripItemCheck.Text = "Перевірити працівника";
            this.menuStripItemCheck.Click += new System.EventHandler(this.MenuStripItemCheck_Click);
            // 
            // menuStripItemExit
            // 
            this.menuStripItemExit.Name = "menuStripItemExit";
            this.menuStripItemExit.Size = new System.Drawing.Size(47, 20);
            this.menuStripItemExit.Text = "Вихід";
            this.menuStripItemExit.Click += new System.EventHandler(this.MenuStripItemExit_Click);
            // 
            // groupBoxCheck
            // 
            this.groupBoxCheck.Controls.Add(this.buttonCheck);
            this.groupBoxCheck.Controls.Add(this.textBoxCheckSurname);
            this.groupBoxCheck.Controls.Add(this.textBoxCheckName);
            this.groupBoxCheck.Controls.Add(this.labelCheckName);
            this.groupBoxCheck.Controls.Add(this.labelCheckSurname);
            this.groupBoxCheck.Enabled = false;
            this.groupBoxCheck.Location = new System.Drawing.Point(247, 27);
            this.groupBoxCheck.Name = "groupBoxCheck";
            this.groupBoxCheck.Size = new System.Drawing.Size(224, 161);
            this.groupBoxCheck.TabIndex = 1;
            this.groupBoxCheck.TabStop = false;
            this.groupBoxCheck.Text = "Check the employee";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(58, 130);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(100, 25);
            this.buttonCheck.TabIndex = 9;
            this.buttonCheck.Text = "Check!";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // textBoxCheckSurname
            // 
            this.textBoxCheckSurname.Location = new System.Drawing.Point(111, 45);
            this.textBoxCheckSurname.MaxLength = 50;
            this.textBoxCheckSurname.Name = "textBoxCheckSurname";
            this.textBoxCheckSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxCheckSurname.TabIndex = 12;
            // 
            // textBoxCheckName
            // 
            this.textBoxCheckName.Location = new System.Drawing.Point(111, 19);
            this.textBoxCheckName.MaxLength = 50;
            this.textBoxCheckName.Name = "textBoxCheckName";
            this.textBoxCheckName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCheckName.TabIndex = 11;
            // 
            // labelCheckName
            // 
            this.labelCheckName.AutoSize = true;
            this.labelCheckName.Location = new System.Drawing.Point(6, 22);
            this.labelCheckName.Name = "labelCheckName";
            this.labelCheckName.Size = new System.Drawing.Size(38, 13);
            this.labelCheckName.TabIndex = 9;
            this.labelCheckName.Text = "Name:";
            // 
            // labelCheckSurname
            // 
            this.labelCheckSurname.AutoSize = true;
            this.labelCheckSurname.Location = new System.Drawing.Point(6, 48);
            this.labelCheckSurname.Name = "labelCheckSurname";
            this.labelCheckSurname.Size = new System.Drawing.Size(52, 13);
            this.labelCheckSurname.TabIndex = 10;
            this.labelCheckSurname.Text = "Surname:";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.buttonAdd);
            this.groupBoxAdd.Controls.Add(this.dateTimePicker);
            this.groupBoxAdd.Controls.Add(this.labelTelephone);
            this.groupBoxAdd.Controls.Add(this.labelDate);
            this.groupBoxAdd.Controls.Add(this.maskedTextBoxTelephone);
            this.groupBoxAdd.Controls.Add(this.textBoxAddSurname);
            this.groupBoxAdd.Controls.Add(this.textBoxAddName);
            this.groupBoxAdd.Controls.Add(this.labelAddSurname);
            this.groupBoxAdd.Controls.Add(this.labelAddName);
            this.groupBoxAdd.Enabled = false;
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 27);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(229, 161);
            this.groupBoxAdd.TabIndex = 2;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add an employee";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(59, 130);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 25);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add!";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(116, 71);
            this.dateTimePicker.MaxDate = new System.DateTime(2019, 12, 25, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.Value = new System.DateTime(2019, 4, 14, 0, 0, 0, 0);
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(11, 100);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(99, 13);
            this.labelTelephone.TabIndex = 6;
            this.labelTelephone.Text = "Telephone number:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(11, 74);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(91, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Recruitment date:";
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(116, 97);
            this.maskedTextBoxTelephone.Mask = "(999) 000-0000";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.ResetOnSpace = false;
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTelephone.TabIndex = 4;
            // 
            // textBoxAddSurname
            // 
            this.textBoxAddSurname.Location = new System.Drawing.Point(116, 45);
            this.textBoxAddSurname.MaxLength = 50;
            this.textBoxAddSurname.Name = "textBoxAddSurname";
            this.textBoxAddSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddSurname.TabIndex = 3;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(116, 19);
            this.textBoxAddName.MaxLength = 50;
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddName.TabIndex = 2;
            // 
            // labelAddSurname
            // 
            this.labelAddSurname.AutoSize = true;
            this.labelAddSurname.Location = new System.Drawing.Point(11, 48);
            this.labelAddSurname.Name = "labelAddSurname";
            this.labelAddSurname.Size = new System.Drawing.Size(52, 13);
            this.labelAddSurname.TabIndex = 1;
            this.labelAddSurname.Text = "Surname:";
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(11, 22);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(38, 13);
            this.labelAddName.TabIndex = 0;
            this.labelAddName.Text = "Name:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 193);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.groupBoxCheck);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Firm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxCheck.ResumeLayout(false);
            this.groupBoxCheck.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemCreate;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemWrite;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemCheck;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemExit;
        private System.Windows.Forms.GroupBox groupBoxCheck;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephone;
        private System.Windows.Forms.TextBox textBoxAddSurname;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBoxCheckSurname;
        private System.Windows.Forms.TextBox textBoxCheckName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCheckName;
        private System.Windows.Forms.Label labelCheckSurname;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAddSurname;
        private System.Windows.Forms.Label labelAddName;
    }
}

