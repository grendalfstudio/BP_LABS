namespace OP_Lab2_1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FirstTask = new System.Windows.Forms.TabPage();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridOneDArray = new System.Windows.Forms.DataGridView();
            this.textDiff = new System.Windows.Forms.TextBox();
            this.textThree = new System.Windows.Forms.TextBox();
            this.textEven = new System.Windows.Forms.TextBox();
            this.textSize = new System.Windows.Forms.TextBox();
            this.SecondTask = new System.Windows.Forms.TabPage();
            this.btnCalc2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridResultBefore = new System.Windows.Forms.DataGridView();
            this.dataGridResultAfter = new System.Windows.Forms.DataGridView();
            this.dataGridTwoD = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textSizeTwoD = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.FirstTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOneDArray)).BeginInit();
            this.SecondTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTwoD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FirstTask);
            this.tabControl1.Controls.Add(this.SecondTask);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // FirstTask
            // 
            this.FirstTask.Controls.Add(this.btnCalc1);
            this.FirstTask.Controls.Add(this.label5);
            this.FirstTask.Controls.Add(this.label4);
            this.FirstTask.Controls.Add(this.label3);
            this.FirstTask.Controls.Add(this.label2);
            this.FirstTask.Controls.Add(this.label1);
            this.FirstTask.Controls.Add(this.dataGridOneDArray);
            this.FirstTask.Controls.Add(this.textDiff);
            this.FirstTask.Controls.Add(this.textThree);
            this.FirstTask.Controls.Add(this.textEven);
            this.FirstTask.Controls.Add(this.textSize);
            this.FirstTask.Location = new System.Drawing.Point(4, 22);
            this.FirstTask.Name = "FirstTask";
            this.FirstTask.Padding = new System.Windows.Forms.Padding(3);
            this.FirstTask.Size = new System.Drawing.Size(790, 420);
            this.FirstTask.TabIndex = 0;
            this.FirstTask.Text = "FirstTask";
            this.FirstTask.UseVisualStyleBackColor = true;
            // 
            // btnCalc1
            // 
            this.btnCalc1.Location = new System.Drawing.Point(158, 228);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(100, 23);
            this.btnCalc1.TabIndex = 1;
            this.btnCalc1.Text = "Calculate";
            this.btnCalc1.UseVisualStyleBackColor = true;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Difference Max-Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of 3-dividable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of even";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Array";
            // 
            // dataGridOneDArray
            // 
            this.dataGridOneDArray.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridOneDArray.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOneDArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOneDArray.ColumnHeadersVisible = false;
            this.dataGridOneDArray.Location = new System.Drawing.Point(324, 101);
            this.dataGridOneDArray.Name = "dataGridOneDArray";
            this.dataGridOneDArray.ReadOnly = true;
            this.dataGridOneDArray.RowHeadersVisible = false;
            this.dataGridOneDArray.Size = new System.Drawing.Size(407, 34);
            this.dataGridOneDArray.TabIndex = 4;
            // 
            // textDiff
            // 
            this.textDiff.Location = new System.Drawing.Point(158, 184);
            this.textDiff.Name = "textDiff";
            this.textDiff.ReadOnly = true;
            this.textDiff.Size = new System.Drawing.Size(100, 20);
            this.textDiff.TabIndex = 3;
            // 
            // textThree
            // 
            this.textThree.Location = new System.Drawing.Point(158, 134);
            this.textThree.Name = "textThree";
            this.textThree.ReadOnly = true;
            this.textThree.Size = new System.Drawing.Size(100, 20);
            this.textThree.TabIndex = 2;
            // 
            // textEven
            // 
            this.textEven.Location = new System.Drawing.Point(158, 80);
            this.textEven.Name = "textEven";
            this.textEven.ReadOnly = true;
            this.textEven.Size = new System.Drawing.Size(100, 20);
            this.textEven.TabIndex = 1;
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(158, 31);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(100, 20);
            this.textSize.TabIndex = 0;
            // 
            // SecondTask
            // 
            this.SecondTask.Controls.Add(this.btnCalc2);
            this.SecondTask.Controls.Add(this.label9);
            this.SecondTask.Controls.Add(this.label8);
            this.SecondTask.Controls.Add(this.label7);
            this.SecondTask.Controls.Add(this.dataGridResultBefore);
            this.SecondTask.Controls.Add(this.dataGridResultAfter);
            this.SecondTask.Controls.Add(this.dataGridTwoD);
            this.SecondTask.Controls.Add(this.label6);
            this.SecondTask.Controls.Add(this.textSizeTwoD);
            this.SecondTask.Location = new System.Drawing.Point(4, 22);
            this.SecondTask.Name = "SecondTask";
            this.SecondTask.Padding = new System.Windows.Forms.Padding(3);
            this.SecondTask.Size = new System.Drawing.Size(790, 420);
            this.SecondTask.TabIndex = 1;
            this.SecondTask.Text = "SecondTask";
            this.SecondTask.UseVisualStyleBackColor = true;
            // 
            // btnCalc2
            // 
            this.btnCalc2.Location = new System.Drawing.Point(344, 384);
            this.btnCalc2.Name = "btnCalc2";
            this.btnCalc2.Size = new System.Drawing.Size(100, 23);
            this.btnCalc2.TabIndex = 15;
            this.btnCalc2.Text = "Calculate";
            this.btnCalc2.UseVisualStyleBackColor = true;
            this.btnCalc2.Click += new System.EventHandler(this.btnCalc2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sums before last negative";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sums after first negative";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Array";
            // 
            // dataGridResultBefore
            // 
            this.dataGridResultBefore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridResultBefore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridResultBefore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResultBefore.ColumnHeadersVisible = false;
            this.dataGridResultBefore.Location = new System.Drawing.Point(397, 103);
            this.dataGridResultBefore.Name = "dataGridResultBefore";
            this.dataGridResultBefore.ReadOnly = true;
            this.dataGridResultBefore.RowHeadersVisible = false;
            this.dataGridResultBefore.Size = new System.Drawing.Size(353, 34);
            this.dataGridResultBefore.TabIndex = 11;
            // 
            // dataGridResultAfter
            // 
            this.dataGridResultAfter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridResultAfter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridResultAfter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResultAfter.ColumnHeadersVisible = false;
            this.dataGridResultAfter.Location = new System.Drawing.Point(397, 344);
            this.dataGridResultAfter.Name = "dataGridResultAfter";
            this.dataGridResultAfter.ReadOnly = true;
            this.dataGridResultAfter.RowHeadersVisible = false;
            this.dataGridResultAfter.Size = new System.Drawing.Size(353, 34);
            this.dataGridResultAfter.TabIndex = 10;
            // 
            // dataGridTwoD
            // 
            this.dataGridTwoD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridTwoD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridTwoD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTwoD.ColumnHeadersVisible = false;
            this.dataGridTwoD.Location = new System.Drawing.Point(70, 103);
            this.dataGridTwoD.Name = "dataGridTwoD";
            this.dataGridTwoD.RowHeadersVisible = false;
            this.dataGridTwoD.Size = new System.Drawing.Size(275, 275);
            this.dataGridTwoD.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Size";
            // 
            // textSizeTwoD
            // 
            this.textSizeTwoD.Location = new System.Drawing.Point(344, 32);
            this.textSizeTwoD.Name = "textSizeTwoD";
            this.textSizeTwoD.Size = new System.Drawing.Size(100, 20);
            this.textSizeTwoD.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.FirstTask.ResumeLayout(false);
            this.FirstTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOneDArray)).EndInit();
            this.SecondTask.ResumeLayout(false);
            this.SecondTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTwoD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FirstTask;
        private System.Windows.Forms.TabPage SecondTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridOneDArray;
        private System.Windows.Forms.TextBox textDiff;
        private System.Windows.Forms.TextBox textThree;
        private System.Windows.Forms.TextBox textEven;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.DataGridView dataGridTwoD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSizeTwoD;
        private System.Windows.Forms.DataGridView dataGridResultBefore;
        private System.Windows.Forms.DataGridView dataGridResultAfter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.Button btnCalc2;
    }
}

