namespace BP_LAB_8
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dictView = new System.Windows.Forms.RichTextBox();
            this.textEnglish = new System.Windows.Forms.TextBox();
            this.textUkainian = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowEn = new System.Windows.Forms.Button();
            this.btnShowUa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textWord = new System.Windows.Forms.TextBox();
            this.textTranslated = new System.Windows.Forms.TextBox();
            this.btnTranslateWord = new System.Windows.Forms.Button();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.richTextTranslated = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 523);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnShowUa);
            this.tabPage1.Controls.Add(this.btnShowEn);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.textUkainian);
            this.tabPage1.Controls.Add(this.textEnglish);
            this.tabPage1.Controls.Add(this.dictView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dictionary setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTranslate);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.richTextTranslated);
            this.tabPage2.Controls.Add(this.richText);
            this.tabPage2.Controls.Add(this.btnTranslateWord);
            this.tabPage2.Controls.Add(this.textTranslated);
            this.tabPage2.Controls.Add(this.textWord);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(617, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Translation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dictView
            // 
            this.dictView.Location = new System.Drawing.Point(8, 122);
            this.dictView.Name = "dictView";
            this.dictView.Size = new System.Drawing.Size(222, 361);
            this.dictView.TabIndex = 0;
            this.dictView.Text = "";
            // 
            // textEnglish
            // 
            this.textEnglish.Location = new System.Drawing.Point(8, 32);
            this.textEnglish.Name = "textEnglish";
            this.textEnglish.Size = new System.Drawing.Size(95, 20);
            this.textEnglish.TabIndex = 1;
            // 
            // textUkainian
            // 
            this.textUkainian.Location = new System.Drawing.Point(135, 32);
            this.textUkainian.Name = "textUkainian";
            this.textUkainian.Size = new System.Drawing.Size(95, 20);
            this.textUkainian.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add word";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowEn
            // 
            this.btnShowEn.Location = new System.Drawing.Point(8, 90);
            this.btnShowEn.Name = "btnShowEn";
            this.btnShowEn.Size = new System.Drawing.Size(95, 23);
            this.btnShowEn.TabIndex = 4;
            this.btnShowEn.Text = "Show En-Ua dict";
            this.btnShowEn.UseVisualStyleBackColor = true;
            this.btnShowEn.Click += new System.EventHandler(this.btnShowEn_Click);
            // 
            // btnShowUa
            // 
            this.btnShowUa.Location = new System.Drawing.Point(135, 90);
            this.btnShowUa.Name = "btnShowUa";
            this.btnShowUa.Size = new System.Drawing.Size(95, 23);
            this.btnShowUa.TabIndex = 5;
            this.btnShowUa.Text = "Show Ua-En dict";
            this.btnShowUa.UseVisualStyleBackColor = true;
            this.btnShowUa.Click += new System.EventHandler(this.btnShowUa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "English wod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ukrainian word";
            // 
            // textWord
            // 
            this.textWord.Location = new System.Drawing.Point(190, 24);
            this.textWord.Name = "textWord";
            this.textWord.Size = new System.Drawing.Size(100, 20);
            this.textWord.TabIndex = 0;
            // 
            // textTranslated
            // 
            this.textTranslated.Location = new System.Drawing.Point(323, 24);
            this.textTranslated.Name = "textTranslated";
            this.textTranslated.Size = new System.Drawing.Size(100, 20);
            this.textTranslated.TabIndex = 1;
            // 
            // btnTranslateWord
            // 
            this.btnTranslateWord.Location = new System.Drawing.Point(247, 50);
            this.btnTranslateWord.Name = "btnTranslateWord";
            this.btnTranslateWord.Size = new System.Drawing.Size(121, 23);
            this.btnTranslateWord.TabIndex = 2;
            this.btnTranslateWord.Text = "Translate word";
            this.btnTranslateWord.UseVisualStyleBackColor = true;
            this.btnTranslateWord.Click += new System.EventHandler(this.btnTranslateWord_Click);
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(7, 107);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(233, 374);
            this.richText.TabIndex = 3;
            this.richText.Text = "";
            // 
            // richTextTranslated
            // 
            this.richTextTranslated.Location = new System.Drawing.Point(374, 107);
            this.richTextTranslated.Name = "richTextTranslated";
            this.richTextTranslated.Size = new System.Drawing.Size(233, 374);
            this.richTextTranslated.TabIndex = 4;
            this.richTextTranslated.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(247, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "To English";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "To Ukarinian";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(247, 198);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(121, 23);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 518);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Dictionaries";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox dictView;
        private System.Windows.Forms.TextBox textUkainian;
        private System.Windows.Forms.TextBox textEnglish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowUa;
        private System.Windows.Forms.Button btnShowEn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox richTextTranslated;
        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.Button btnTranslateWord;
        private System.Windows.Forms.TextBox textTranslated;
        private System.Windows.Forms.TextBox textWord;
    }
}

