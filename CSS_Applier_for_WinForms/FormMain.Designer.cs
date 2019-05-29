namespace CSS
{
    partial class FormMain
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
            this.btnTest = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.tbTest = new System.Windows.Forms.TextBox();
            this.chbTest = new System.Windows.Forms.CheckBox();
            this.cbTest = new System.Windows.Forms.ComboBox();
            this.rbTest = new System.Windows.Forms.RadioButton();
            this.lbTest = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTest.Location = new System.Drawing.Point(13, 13);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 75);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test text";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(95, 13);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(53, 13);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "Test label";
            // 
            // tbTest
            // 
            this.tbTest.Location = new System.Drawing.Point(98, 30);
            this.tbTest.Name = "tbTest";
            this.tbTest.Size = new System.Drawing.Size(380, 20);
            this.tbTest.TabIndex = 2;
            // 
            // chbTest
            // 
            this.chbTest.AutoSize = true;
            this.chbTest.Location = new System.Drawing.Point(98, 57);
            this.chbTest.Name = "chbTest";
            this.chbTest.Size = new System.Drawing.Size(100, 17);
            this.chbTest.TabIndex = 3;
            this.chbTest.Text = "Test check box";
            this.chbTest.UseVisualStyleBackColor = true;
            // 
            // cbTest
            // 
            this.cbTest.FormattingEnabled = true;
            this.cbTest.Items.AddRange(new object[] {
            "some",
            "text"});
            this.cbTest.Location = new System.Drawing.Point(13, 95);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(75, 21);
            this.cbTest.TabIndex = 4;
            // 
            // rbTest
            // 
            this.rbTest.AutoSize = true;
            this.rbTest.Location = new System.Drawing.Point(98, 98);
            this.rbTest.Name = "rbTest";
            this.rbTest.Size = new System.Drawing.Size(105, 17);
            this.rbTest.TabIndex = 5;
            this.rbTest.TabStop = true;
            this.rbTest.Text = "Test radio button";
            this.rbTest.UseVisualStyleBackColor = true;
            // 
            // lbTest
            // 
            this.lbTest.FormattingEnabled = true;
            this.lbTest.Items.AddRange(new object[] {
            "test item 1",
            "test item 2"});
            this.lbTest.Location = new System.Drawing.Point(209, 57);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(269, 56);
            this.lbTest.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.rbTest);
            this.Controls.Add(this.cbTest);
            this.Controls.Add(this.chbTest);
            this.Controls.Add(this.tbTest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnTest);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox tbTest;
        private System.Windows.Forms.CheckBox chbTest;
        private System.Windows.Forms.ComboBox cbTest;
        private System.Windows.Forms.RadioButton rbTest;
        private System.Windows.Forms.ListBox lbTest;
    }
}

