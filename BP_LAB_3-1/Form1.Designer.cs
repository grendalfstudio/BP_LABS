namespace BP_LAB_3_1
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
            this.textSize = new System.Windows.Forms.TextBox();
            this.btnSetSize = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textPlace = new System.Windows.Forms.TextBox();
            this.textType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(72, 45);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(100, 20);
            this.textSize.TabIndex = 0;
            // 
            // btnSetSize
            // 
            this.btnSetSize.Location = new System.Drawing.Point(204, 45);
            this.btnSetSize.Name = "btnSetSize";
            this.btnSetSize.Size = new System.Drawing.Size(75, 20);
            this.btnSetSize.TabIndex = 1;
            this.btnSetSize.Text = "button1";
            this.btnSetSize.UseVisualStyleBackColor = true;
            this.btnSetSize.Click += new System.EventHandler(this.BtnSetSize_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(72, 168);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 2;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(72, 142);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(100, 20);
            this.textWeight.TabIndex = 3;
            // 
            // textPlace
            // 
            this.textPlace.Location = new System.Drawing.Point(72, 116);
            this.textPlace.Name = "textPlace";
            this.textPlace.Size = new System.Drawing.Size(100, 20);
            this.textPlace.TabIndex = 4;
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(72, 90);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(100, 20);
            this.textType.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 19);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "button2";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textPlace);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.btnSetSize);
            this.Controls.Add(this.textSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Button btnSetSize;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.TextBox textPlace;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}

