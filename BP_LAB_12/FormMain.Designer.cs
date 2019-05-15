namespace BP_LAB_12
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.labelFirstTrapezoid = new System.Windows.Forms.Label();
            this.textBoxFirstTrapezoid = new System.Windows.Forms.TextBox();
            this.textBoxSecondTrapezoid = new System.Windows.Forms.TextBox();
            this.labelSecondTrapezoid = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBoxDeserialized = new System.Windows.Forms.PictureBox();
            this.labelDeserialized = new System.Windows.Forms.Label();
            this.labelColl = new System.Windows.Forms.Label();
            this.progressColl = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeserialized)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Location = new System.Drawing.Point(424, 12);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(600, 400);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // labelFirstTrapezoid
            // 
            this.labelFirstTrapezoid.AutoSize = true;
            this.labelFirstTrapezoid.Location = new System.Drawing.Point(12, 15);
            this.labelFirstTrapezoid.Name = "labelFirstTrapezoid";
            this.labelFirstTrapezoid.Size = new System.Drawing.Size(234, 13);
            this.labelFirstTrapezoid.TabIndex = 1;
            this.labelFirstTrapezoid.Text = "Input the angle of the first trapezoid (in degrees):";
            // 
            // textBoxFirstTrapezoid
            // 
            this.textBoxFirstTrapezoid.Location = new System.Drawing.Point(258, 12);
            this.textBoxFirstTrapezoid.MaxLength = 5;
            this.textBoxFirstTrapezoid.Name = "textBoxFirstTrapezoid";
            this.textBoxFirstTrapezoid.Size = new System.Drawing.Size(50, 20);
            this.textBoxFirstTrapezoid.TabIndex = 2;
            // 
            // textBoxSecondTrapezoid
            // 
            this.textBoxSecondTrapezoid.Location = new System.Drawing.Point(258, 38);
            this.textBoxSecondTrapezoid.MaxLength = 5;
            this.textBoxSecondTrapezoid.Name = "textBoxSecondTrapezoid";
            this.textBoxSecondTrapezoid.Size = new System.Drawing.Size(50, 20);
            this.textBoxSecondTrapezoid.TabIndex = 4;
            // 
            // labelSecondTrapezoid
            // 
            this.labelSecondTrapezoid.AutoSize = true;
            this.labelSecondTrapezoid.Location = new System.Drawing.Point(12, 41);
            this.labelSecondTrapezoid.Name = "labelSecondTrapezoid";
            this.labelSecondTrapezoid.Size = new System.Drawing.Size(235, 13);
            this.labelSecondTrapezoid.TabIndex = 3;
            this.labelSecondTrapezoid.Text = "Input the angle of second trapezoid (in degrees):";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(15, 57);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(101, 36);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // pictureBoxDeserialized
            // 
            this.pictureBoxDeserialized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDeserialized.Location = new System.Drawing.Point(12, 112);
            this.pictureBoxDeserialized.Name = "pictureBoxDeserialized";
            this.pictureBoxDeserialized.Size = new System.Drawing.Size(406, 300);
            this.pictureBoxDeserialized.TabIndex = 6;
            this.pictureBoxDeserialized.TabStop = false;
            // 
            // labelDeserialized
            // 
            this.labelDeserialized.AutoSize = true;
            this.labelDeserialized.Location = new System.Drawing.Point(12, 96);
            this.labelDeserialized.Name = "labelDeserialized";
            this.labelDeserialized.Size = new System.Drawing.Size(101, 13);
            this.labelDeserialized.TabIndex = 7;
            this.labelDeserialized.Text = "Deserialized figures:";
            // 
            // labelColl
            // 
            this.labelColl.AutoSize = true;
            this.labelColl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColl.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelColl.Location = new System.Drawing.Point(334, 13);
            this.labelColl.Name = "labelColl";
            this.labelColl.Size = new System.Drawing.Size(60, 17);
            this.labelColl.TabIndex = 8;
            this.labelColl.Text = "Collision";
            // 
            // progressColl
            // 
            this.progressColl.Location = new System.Drawing.Point(156, 69);
            this.progressColl.Name = "progressColl";
            this.progressColl.Size = new System.Drawing.Size(262, 23);
            this.progressColl.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 424);
            this.Controls.Add(this.progressColl);
            this.Controls.Add(this.labelColl);
            this.Controls.Add(this.labelDeserialized);
            this.Controls.Add(this.pictureBoxDeserialized);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxSecondTrapezoid);
            this.Controls.Add(this.labelSecondTrapezoid);
            this.Controls.Add(this.textBoxFirstTrapezoid);
            this.Controls.Add(this.labelFirstTrapezoid);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "FormMain";
            this.Text = "BP_LAB_12";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeserialized)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label labelFirstTrapezoid;
        private System.Windows.Forms.TextBox textBoxFirstTrapezoid;
        private System.Windows.Forms.TextBox textBoxSecondTrapezoid;
        private System.Windows.Forms.Label labelSecondTrapezoid;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxDeserialized;
        private System.Windows.Forms.Label labelDeserialized;
        private System.Windows.Forms.Label labelColl;
        private System.Windows.Forms.ProgressBar progressColl;
    }
}

