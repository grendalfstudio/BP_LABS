namespace BP_LAB_4
{
    partial class FormFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFile));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMinEven = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.richTextViewFile = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnCalc = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelMultiplication = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxMultiplication = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.richTextBoxFileContents = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textMinEven);
            this.tabPage1.Controls.Add(this.textMax);
            this.tabPage1.Controls.Add(this.richTextViewFile);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "First task";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Min of elements with even numbers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max element";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textMinEven
            // 
            this.textMinEven.Location = new System.Drawing.Point(561, 148);
            this.textMinEven.Name = "textMinEven";
            this.textMinEven.ReadOnly = true;
            this.textMinEven.Size = new System.Drawing.Size(100, 20);
            this.textMinEven.TabIndex = 5;
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(561, 67);
            this.textMax.Name = "textMax";
            this.textMax.ReadOnly = true;
            this.textMax.Size = new System.Drawing.Size(100, 20);
            this.textMax.TabIndex = 4;
            // 
            // richTextViewFile
            // 
            this.richTextViewFile.Location = new System.Drawing.Point(10, 31);
            this.richTextViewFile.Name = "richTextViewFile";
            this.richTextViewFile.Size = new System.Drawing.Size(541, 385);
            this.richTextViewFile.TabIndex = 3;
            this.richTextViewFile.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnClose,
            this.btnCalc,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(787, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(59, 22);
            this.btnOpen.Text = "Open file";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 22);
            this.btnClose.Text = "Close file";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCalc.Image = ((System.Drawing.Image)(resources.GetObject("btnCalc.Image")));
            this.btnCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(60, 22);
            this.btnCalc.Text = "Calculate";
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelMultiplication);
            this.tabPage2.Controls.Add(this.labelSum);
            this.tabPage2.Controls.Add(this.textBoxMultiplication);
            this.tabPage2.Controls.Add(this.textBoxSum);
            this.tabPage2.Controls.Add(this.richTextBoxFileContents);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Second task";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelMultiplication
            // 
            this.labelMultiplication.AutoSize = true;
            this.labelMultiplication.Location = new System.Drawing.Point(556, 132);
            this.labelMultiplication.Name = "labelMultiplication";
            this.labelMultiplication.Size = new System.Drawing.Size(181, 13);
            this.labelMultiplication.TabIndex = 12;
            this.labelMultiplication.Text = "Multiplication of the double elements:";
            this.labelMultiplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(557, 51);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(141, 13);
            this.labelSum.TabIndex = 11;
            this.labelSum.Text = "Sum of the double elements:";
            this.labelSum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxMultiplication
            // 
            this.textBoxMultiplication.Location = new System.Drawing.Point(560, 148);
            this.textBoxMultiplication.Name = "textBoxMultiplication";
            this.textBoxMultiplication.ReadOnly = true;
            this.textBoxMultiplication.Size = new System.Drawing.Size(100, 20);
            this.textBoxMultiplication.TabIndex = 10;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(560, 67);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 9;
            // 
            // richTextBoxFileContents
            // 
            this.richTextBoxFileContents.Location = new System.Drawing.Point(9, 31);
            this.richTextBoxFileContents.Name = "richTextBoxFileContents";
            this.richTextBoxFileContents.Size = new System.Drawing.Size(541, 385);
            this.richTextBoxFileContents.TabIndex = 8;
            this.richTextBoxFileContents.Text = "";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(787, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton1.Text = "Open file";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton2.Text = "Close file";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton3.Text = "Calculate";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 22);
            this.toolStripButton4.Text = "Exit";
            // 
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormFile";
            this.Text = "BP_LAB_4";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextViewFile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnCalc;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMinEven;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.Label labelMultiplication;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.TextBox textBoxMultiplication;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.RichTextBox richTextBoxFileContents;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

