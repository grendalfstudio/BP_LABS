namespace BP_LAB_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPlace = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.textIndexR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSetSize = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemoveByIndex = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textIndex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textIdR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveById = new System.Windows.Forms.Button();
            this.boxSortChoice = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(38, 12);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(100, 20);
            this.textSize.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size of list";
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(37, 98);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(100, 20);
            this.textType.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(37, 124);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 0;
            // 
            // textPlace
            // 
            this.textPlace.Location = new System.Drawing.Point(37, 150);
            this.textPlace.Name = "textPlace";
            this.textPlace.Size = new System.Drawing.Size(100, 20);
            this.textPlace.TabIndex = 0;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(37, 202);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 0;
            // 
            // textIndexR
            // 
            this.textIndexR.Location = new System.Drawing.Point(37, 297);
            this.textIndexR.Name = "textIndexR";
            this.textIndexR.Size = new System.Drawing.Size(100, 20);
            this.textIndexR.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Index";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Place";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Type";
            // 
            // btnSetSize
            // 
            this.btnSetSize.Location = new System.Drawing.Point(37, 38);
            this.btnSetSize.Name = "btnSetSize";
            this.btnSetSize.Size = new System.Drawing.Size(101, 23);
            this.btnSetSize.TabIndex = 8;
            this.btnSetSize.Text = "Create";
            this.btnSetSize.UseVisualStyleBackColor = true;
            this.btnSetSize.Click += new System.EventHandler(this.btnSetSize_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(207, 124);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemoveByIndex
            // 
            this.btnRemoveByIndex.Location = new System.Drawing.Point(38, 330);
            this.btnRemoveByIndex.Name = "btnRemoveByIndex";
            this.btnRemoveByIndex.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveByIndex.TabIndex = 11;
            this.btnRemoveByIndex.Text = "Remove by index";
            this.btnRemoveByIndex.UseVisualStyleBackColor = true;
            this.btnRemoveByIndex.Click += new System.EventHandler(this.btnRemoveByIndex_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textIndex
            // 
            this.textIndex.Location = new System.Drawing.Point(207, 98);
            this.textIndex.Name = "textIndex";
            this.textIndex.Size = new System.Drawing.Size(100, 20);
            this.textIndex.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Index";
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(37, 176);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(100, 20);
            this.textWeight.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Weight";
            // 
            // textIdR
            // 
            this.textIdR.Location = new System.Drawing.Point(207, 297);
            this.textIdR.Name = "textIdR";
            this.textIdR.Size = new System.Drawing.Size(100, 20);
            this.textIdR.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id";
            // 
            // btnRemoveById
            // 
            this.btnRemoveById.Location = new System.Drawing.Point(207, 330);
            this.btnRemoveById.Name = "btnRemoveById";
            this.btnRemoveById.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveById.TabIndex = 13;
            this.btnRemoveById.Text = "Remove by id";
            this.btnRemoveById.UseVisualStyleBackColor = true;
            // 
            // boxSortChoice
            // 
            this.boxSortChoice.FormattingEnabled = true;
            this.boxSortChoice.Items.AddRange(new object[] {
            "Type",
            "Name"});
            this.boxSortChoice.Location = new System.Drawing.Point(207, 166);
            this.boxSortChoice.Name = "boxSortChoice";
            this.boxSortChoice.Size = new System.Drawing.Size(100, 21);
            this.boxSortChoice.TabIndex = 14;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(207, 200);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 23);
            this.btnSort.TabIndex = 15;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.boxSortChoice);
            this.Controls.Add(this.btnRemoveById);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemoveByIndex);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSetSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textPlace);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textIdR);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textIndex);
            this.Controls.Add(this.textIndexR);
            this.Controls.Add(this.textSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPlace;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textIndexR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSetSize;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemoveByIndex;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textIndex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textIdR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveById;
        private System.Windows.Forms.ComboBox boxSortChoice;
        private System.Windows.Forms.Button btnSort;
    }
}

