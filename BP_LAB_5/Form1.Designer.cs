namespace BP_LAB_5
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextOutput = new System.Windows.Forms.RichTextBox();
            this.richTextInput = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.TextBox();
            this.btnClearSec = new System.Windows.Forms.Button();
            this.btnCalcSec = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textLength = new System.Windows.Forms.TextBox();
            this.richTextInputSec = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextOutput);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.btnCalc);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textN);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.richTextInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.textCount);
            this.splitContainer1.Panel2.Controls.Add(this.btnClearSec);
            this.splitContainer1.Panel2.Controls.Add(this.btnCalcSec);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.textLength);
            this.splitContainer1.Panel2.Controls.Add(this.richTextInputSec);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(464, 381);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(226, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 20);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(127, 121);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(78, 21);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "N";
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(34, 121);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(78, 20);
            this.textN.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Output string";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input string";
            // 
            // richTextOutput
            // 
            this.richTextOutput.Location = new System.Drawing.Point(12, 86);
            this.richTextOutput.Name = "richTextOutput";
            this.richTextOutput.ReadOnly = true;
            this.richTextOutput.Size = new System.Drawing.Size(439, 27);
            this.richTextOutput.TabIndex = 0;
            this.richTextOutput.Text = "";
            // 
            // richTextInput
            // 
            this.richTextInput.Location = new System.Drawing.Point(12, 37);
            this.richTextInput.Name = "richTextInput";
            this.richTextInput.Size = new System.Drawing.Size(439, 27);
            this.richTextInput.TabIndex = 0;
            this.richTextInput.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Count";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textCount
            // 
            this.textCount.Location = new System.Drawing.Point(373, 77);
            this.textCount.Name = "textCount";
            this.textCount.ReadOnly = true;
            this.textCount.Size = new System.Drawing.Size(78, 20);
            this.textCount.TabIndex = 11;
            // 
            // btnClearSec
            // 
            this.btnClearSec.Location = new System.Drawing.Point(242, 76);
            this.btnClearSec.Name = "btnClearSec";
            this.btnClearSec.Size = new System.Drawing.Size(75, 21);
            this.btnClearSec.TabIndex = 10;
            this.btnClearSec.Text = "Clear";
            this.btnClearSec.UseVisualStyleBackColor = true;
            this.btnClearSec.Click += new System.EventHandler(this.btnClearSec_Click);
            // 
            // btnCalcSec
            // 
            this.btnCalcSec.Location = new System.Drawing.Point(155, 76);
            this.btnCalcSec.Name = "btnCalcSec";
            this.btnCalcSec.Size = new System.Drawing.Size(78, 21);
            this.btnCalcSec.TabIndex = 9;
            this.btnCalcSec.Text = "Calculate";
            this.btnCalcSec.UseVisualStyleBackColor = true;
            this.btnCalcSec.Click += new System.EventHandler(this.btnCalcSec_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Length";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(55, 77);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(78, 20);
            this.textLength.TabIndex = 7;
            // 
            // richTextInputSec
            // 
            this.richTextInputSec.Location = new System.Drawing.Point(12, 25);
            this.richTextInputSec.Name = "richTextInputSec";
            this.richTextInputSec.Size = new System.Drawing.Size(439, 27);
            this.richTextInputSec.TabIndex = 6;
            this.richTextInputSec.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Input string";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 381);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "BP_LAB_5";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextOutput;
        private System.Windows.Forms.RichTextBox richTextInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.Button btnClearSec;
        private System.Windows.Forms.Button btnCalcSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.RichTextBox richTextInputSec;
        private System.Windows.Forms.Label label4;
    }
}

