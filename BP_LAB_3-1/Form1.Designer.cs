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
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.btnSetSize = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ShowBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.btnShowRecord = new System.Windows.Forms.Button();
            this.numericIndex = new System.Windows.Forms.NumericUpDown();
            this.textBoxIDView = new System.Windows.Forms.TextBox();
            this.labelIDShow = new System.Windows.Forms.Label();
            this.labelWeightShow = new System.Windows.Forms.Label();
            this.labelPlaceShow = new System.Windows.Forms.Label();
            this.labelTypeShow = new System.Windows.Forms.Label();
            this.textBoxWeightView = new System.Windows.Forms.TextBox();
            this.textBoxPlaceView = new System.Windows.Forms.TextBox();
            this.textBoxTypeShow = new System.Windows.Forms.TextBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.ShowBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(124, 6);
            this.textBoxCapacity.MaxLength = 3;
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(47, 20);
            this.textBoxCapacity.TabIndex = 0;
            // 
            // btnSetSize
            // 
            this.btnSetSize.Location = new System.Drawing.Point(177, 5);
            this.btnSetSize.Name = "btnSetSize";
            this.btnSetSize.Size = new System.Drawing.Size(87, 20);
            this.btnSetSize.TabIndex = 1;
            this.btnSetSize.Text = "Accept";
            this.btnSetSize.UseVisualStyleBackColor = true;
            this.btnSetSize.Click += new System.EventHandler(this.BtnSetSize_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(123, 120);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Enabled = false;
            this.textBoxWeight.Location = new System.Drawing.Point(123, 94);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 3;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Enabled = false;
            this.textBoxPlace.Location = new System.Drawing.Point(123, 68);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlace.TabIndex = 4;
            // 
            // textBoxType
            // 
            this.textBoxType.Enabled = false;
            this.textBoxType.Location = new System.Drawing.Point(123, 42);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(229, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 46);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add a record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ShowBox
            // 
            this.ShowBox.Controls.Add(this.label12);
            this.ShowBox.Controls.Add(this.labelRecord);
            this.ShowBox.Controls.Add(this.btnShowRecord);
            this.ShowBox.Controls.Add(this.numericIndex);
            this.ShowBox.Controls.Add(this.textBoxIDView);
            this.ShowBox.Controls.Add(this.labelIDShow);
            this.ShowBox.Controls.Add(this.labelWeightShow);
            this.ShowBox.Controls.Add(this.labelPlaceShow);
            this.ShowBox.Controls.Add(this.labelTypeShow);
            this.ShowBox.Controls.Add(this.textBoxWeightView);
            this.ShowBox.Controls.Add(this.textBoxPlaceView);
            this.ShowBox.Controls.Add(this.textBoxTypeShow);
            this.ShowBox.Location = new System.Drawing.Point(12, 146);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(305, 131);
            this.ShowBox.TabIndex = 8;
            this.ShowBox.TabStop = false;
            this.ShowBox.Text = "Database";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 18;
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Location = new System.Drawing.Point(217, 22);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(85, 13);
            this.labelRecord.TabIndex = 15;
            this.labelRecord.Text = "Record Number:";
            // 
            // btnShowRecord
            // 
            this.btnShowRecord.Location = new System.Drawing.Point(232, 72);
            this.btnShowRecord.Name = "btnShowRecord";
            this.btnShowRecord.Size = new System.Drawing.Size(55, 45);
            this.btnShowRecord.TabIndex = 5;
            this.btnShowRecord.Text = "Show a record";
            this.btnShowRecord.UseVisualStyleBackColor = true;
            this.btnShowRecord.Click += new System.EventHandler(this.btnShowRecord_Click);
            // 
            // numericIndex
            // 
            this.numericIndex.Location = new System.Drawing.Point(232, 46);
            this.numericIndex.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericIndex.Name = "numericIndex";
            this.numericIndex.Size = new System.Drawing.Size(55, 20);
            this.numericIndex.TabIndex = 4;
            // 
            // textBoxIDView
            // 
            this.textBoxIDView.Location = new System.Drawing.Point(111, 97);
            this.textBoxIDView.Name = "textBoxIDView";
            this.textBoxIDView.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDView.TabIndex = 3;
            // 
            // labelIDShow
            // 
            this.labelIDShow.AutoSize = true;
            this.labelIDShow.Location = new System.Drawing.Point(6, 100);
            this.labelIDShow.Name = "labelIDShow";
            this.labelIDShow.Size = new System.Drawing.Size(41, 13);
            this.labelIDShow.TabIndex = 11;
            this.labelIDShow.Text = "ID (int):";
            // 
            // labelWeightShow
            // 
            this.labelWeightShow.AutoSize = true;
            this.labelWeightShow.Location = new System.Drawing.Point(6, 74);
            this.labelWeightShow.Name = "labelWeightShow";
            this.labelWeightShow.Size = new System.Drawing.Size(99, 13);
            this.labelWeightShow.TabIndex = 12;
            this.labelWeightShow.Text = "Weight in kg (float):";
            // 
            // labelPlaceShow
            // 
            this.labelPlaceShow.AutoSize = true;
            this.labelPlaceShow.Location = new System.Drawing.Point(6, 48);
            this.labelPlaceShow.Name = "labelPlaceShow";
            this.labelPlaceShow.Size = new System.Drawing.Size(57, 13);
            this.labelPlaceShow.TabIndex = 13;
            this.labelPlaceShow.Text = "Place (int):";
            // 
            // labelTypeShow
            // 
            this.labelTypeShow.AutoSize = true;
            this.labelTypeShow.Location = new System.Drawing.Point(6, 22);
            this.labelTypeShow.Name = "labelTypeShow";
            this.labelTypeShow.Size = new System.Drawing.Size(54, 13);
            this.labelTypeShow.TabIndex = 14;
            this.labelTypeShow.Text = "Type (str):";
            // 
            // textBoxWeightView
            // 
            this.textBoxWeightView.Location = new System.Drawing.Point(111, 71);
            this.textBoxWeightView.Name = "textBoxWeightView";
            this.textBoxWeightView.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightView.TabIndex = 2;
            // 
            // textBoxPlaceView
            // 
            this.textBoxPlaceView.Location = new System.Drawing.Point(111, 45);
            this.textBoxPlaceView.Name = "textBoxPlaceView";
            this.textBoxPlaceView.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlaceView.TabIndex = 1;
            // 
            // textBoxTypeShow
            // 
            this.textBoxTypeShow.Location = new System.Drawing.Point(111, 19);
            this.textBoxTypeShow.Name = "textBoxTypeShow";
            this.textBoxTypeShow.Size = new System.Drawing.Size(100, 20);
            this.textBoxTypeShow.TabIndex = 0;
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Location = new System.Drawing.Point(21, 9);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(97, 13);
            this.labelCapacity.TabIndex = 9;
            this.labelCapacity.Text = "Number of records:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(21, 97);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(96, 13);
            this.labelWeight.TabIndex = 10;
            this.labelWeight.Text = "Weight in kg(float):";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(21, 123);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(41, 13);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID (int):";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(21, 45);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(54, 13);
            this.labelType.TabIndex = 16;
            this.labelType.Text = "Type (str):";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(21, 71);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(57, 13);
            this.labelPlace.TabIndex = 17;
            this.labelPlace.Text = "Place (int):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 290);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.ShowBox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btnSetSize);
            this.Controls.Add(this.textBoxCapacity);
            this.Name = "Form1";
            this.Text = "Struct";
            this.ShowBox.ResumeLayout(false);
            this.ShowBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.Button btnSetSize;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox ShowBox;
        private System.Windows.Forms.NumericUpDown numericIndex;
        private System.Windows.Forms.TextBox textBoxIDView;
        private System.Windows.Forms.TextBox textBoxWeightView;
        private System.Windows.Forms.TextBox textBoxPlaceView;
        private System.Windows.Forms.TextBox textBoxTypeShow;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Button btnShowRecord;
        private System.Windows.Forms.Label labelIDShow;
        private System.Windows.Forms.Label labelWeightShow;
        private System.Windows.Forms.Label labelPlaceShow;
        private System.Windows.Forms.Label labelTypeShow;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label label12;
    }
}

