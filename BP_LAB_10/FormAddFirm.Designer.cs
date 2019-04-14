namespace BP_LAB_10
{
    partial class FormAddFirm
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
            this.labelFirmName = new System.Windows.Forms.Label();
            this.textBoxFirmName = new System.Windows.Forms.TextBox();
            this.buttonCreateFirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirmName
            // 
            this.labelFirmName.AutoSize = true;
            this.labelFirmName.Location = new System.Drawing.Point(12, 18);
            this.labelFirmName.Name = "labelFirmName";
            this.labelFirmName.Size = new System.Drawing.Size(65, 13);
            this.labelFirmName.TabIndex = 0;
            this.labelFirmName.Text = "Firm\'s name:";
            // 
            // textBoxFirmName
            // 
            this.textBoxFirmName.Location = new System.Drawing.Point(83, 15);
            this.textBoxFirmName.Name = "textBoxFirmName";
            this.textBoxFirmName.Size = new System.Drawing.Size(150, 20);
            this.textBoxFirmName.TabIndex = 1;
            // 
            // buttonCreateFirm
            // 
            this.buttonCreateFirm.Location = new System.Drawing.Point(239, 12);
            this.buttonCreateFirm.Name = "buttonCreateFirm";
            this.buttonCreateFirm.Size = new System.Drawing.Size(70, 25);
            this.buttonCreateFirm.TabIndex = 2;
            this.buttonCreateFirm.Text = "Create!";
            this.buttonCreateFirm.UseVisualStyleBackColor = true;
            this.buttonCreateFirm.Click += new System.EventHandler(this.ButtonCreateFirm_Click);
            // 
            // FormNewFirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 49);
            this.Controls.Add(this.buttonCreateFirm);
            this.Controls.Add(this.textBoxFirmName);
            this.Controls.Add(this.labelFirmName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormNewFirm";
            this.ShowIcon = false;
            this.Text = "Create new firm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirmName;
        private System.Windows.Forms.TextBox textBoxFirmName;
        private System.Windows.Forms.Button buttonCreateFirm;
    }
}