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
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageVariant1);
            this.tabControlMain.Controls.Add(this.tabPageVariant3);
            this.tabControlMain.Location = new System.Drawing.Point(-1, -1);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(802, 451);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageVariant1
            // 
            this.tabPageVariant1.Location = new System.Drawing.Point(4, 22);
            this.tabPageVariant1.Name = "tabPageVariant1";
            this.tabPageVariant1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVariant1.Size = new System.Drawing.Size(794, 425);
            this.tabPageVariant1.TabIndex = 0;
            this.tabPageVariant1.Text = "Variant 1";
            this.tabPageVariant1.UseVisualStyleBackColor = true;
            // 
            // tabPageVariant3
            // 
            this.tabPageVariant3.Location = new System.Drawing.Point(4, 22);
            this.tabPageVariant3.Name = "tabPageVariant3";
            this.tabPageVariant3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVariant3.Size = new System.Drawing.Size(794, 425);
            this.tabPageVariant3.TabIndex = 1;
            this.tabPageVariant3.Text = "Variant 3";
            this.tabPageVariant3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "BP_LAB_7";
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageVariant1;
        private System.Windows.Forms.TabPage tabPageVariant3;
    }
}

