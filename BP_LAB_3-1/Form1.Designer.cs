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
            this.ShowBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.numericIndex = new System.Windows.Forms.NumericUpDown();
            this.textIDView = new System.Windows.Forms.TextBox();
            this.labelIDShow = new System.Windows.Forms.Label();
            this.labelWeightShow = new System.Windows.Forms.Label();
            this.labelPlaceShow = new System.Windows.Forms.Label();
            this.labelTypeShow = new System.Windows.Forms.Label();
            this.textWeightView = new System.Windows.Forms.TextBox();
            this.textPlaceView = new System.Windows.Forms.TextBox();
            this.textTypeView = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.ShowBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(115, 6);
            this.textSize.MaxLength = 3;
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(47, 20);
            this.textSize.TabIndex = 0;
            // 
            // btnSetSize
            // 
            this.btnSetSize.Location = new System.Drawing.Point(168, 5);
            this.btnSetSize.Name = "btnSetSize";
            this.btnSetSize.Size = new System.Drawing.Size(87, 20);
            this.btnSetSize.TabIndex = 1;
            this.btnSetSize.Text = "Accept";
            this.btnSetSize.UseVisualStyleBackColor = true;
            this.btnSetSize.Click += new System.EventHandler(this.BtnSetSize_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(62, 120);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 2;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(62, 94);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(100, 20);
            this.textWeight.TabIndex = 3;
            this.textWeight.TextChanged += new System.EventHandler(this.textWeight_TextChanged);
            // 
            // textPlace
            // 
            this.textPlace.Location = new System.Drawing.Point(62, 68);
            this.textPlace.Name = "textPlace";
            this.textPlace.Size = new System.Drawing.Size(100, 20);
            this.textPlace.TabIndex = 4;
            this.textPlace.TextChanged += new System.EventHandler(this.textPlace_TextChanged);
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(62, 42);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(100, 20);
            this.textType.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(168, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 46);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add a record";
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
            // ShowBox
            // 
            this.ShowBox.Controls.Add(this.label12);
            this.ShowBox.Controls.Add(this.labelRecord);
            this.ShowBox.Controls.Add(this.btnShow);
            this.ShowBox.Controls.Add(this.numericIndex);
            this.ShowBox.Controls.Add(this.textIDView);
            this.ShowBox.Controls.Add(this.labelIDShow);
            this.ShowBox.Controls.Add(this.labelWeightShow);
            this.ShowBox.Controls.Add(this.labelPlaceShow);
            this.ShowBox.Controls.Add(this.labelTypeShow);
            this.ShowBox.Controls.Add(this.textWeightView);
            this.ShowBox.Controls.Add(this.textPlaceView);
            this.ShowBox.Controls.Add(this.textTypeView);
            this.ShowBox.Location = new System.Drawing.Point(261, 9);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(274, 131);
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
            this.labelRecord.Location = new System.Drawing.Point(180, 22);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(85, 13);
            this.labelRecord.TabIndex = 15;
            this.labelRecord.Text = "Record Number:";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(195, 72);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(55, 45);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show a record";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // numericIndex
            // 
            this.numericIndex.Location = new System.Drawing.Point(195, 46);
            this.numericIndex.Name = "numericIndex";
            this.numericIndex.Size = new System.Drawing.Size(55, 20);
            this.numericIndex.TabIndex = 4;
            // 
            // textIDView
            // 
            this.textIDView.Location = new System.Drawing.Point(74, 97);
            this.textIDView.Name = "textIDView";
            this.textIDView.Size = new System.Drawing.Size(100, 20);
            this.textIDView.TabIndex = 3;
            // 
            // labelIDShow
            // 
            this.labelIDShow.AutoSize = true;
            this.labelIDShow.Location = new System.Drawing.Point(6, 100);
            this.labelIDShow.Name = "labelIDShow";
            this.labelIDShow.Size = new System.Drawing.Size(21, 13);
            this.labelIDShow.TabIndex = 11;
            this.labelIDShow.Text = "ID:";
            // 
            // labelWeightShow
            // 
            this.labelWeightShow.AutoSize = true;
            this.labelWeightShow.Location = new System.Drawing.Point(6, 74);
            this.labelWeightShow.Name = "labelWeightShow";
            this.labelWeightShow.Size = new System.Drawing.Size(44, 13);
            this.labelWeightShow.TabIndex = 12;
            this.labelWeightShow.Text = "Weight:";
            // 
            // labelPlaceShow
            // 
            this.labelPlaceShow.AutoSize = true;
            this.labelPlaceShow.Location = new System.Drawing.Point(6, 48);
            this.labelPlaceShow.Name = "labelPlaceShow";
            this.labelPlaceShow.Size = new System.Drawing.Size(60, 13);
            this.labelPlaceShow.TabIndex = 13;
            this.labelPlaceShow.Text = "Placement:";
            // 
            // labelTypeShow
            // 
            this.labelTypeShow.AutoSize = true;
            this.labelTypeShow.Location = new System.Drawing.Point(6, 22);
            this.labelTypeShow.Name = "labelTypeShow";
            this.labelTypeShow.Size = new System.Drawing.Size(34, 13);
            this.labelTypeShow.TabIndex = 14;
            this.labelTypeShow.Text = "Type:";
            // 
            // textWeightView
            // 
            this.textWeightView.Location = new System.Drawing.Point(74, 71);
            this.textWeightView.Name = "textWeightView";
            this.textWeightView.Size = new System.Drawing.Size(100, 20);
            this.textWeightView.TabIndex = 2;
            // 
            // textPlaceView
            // 
            this.textPlaceView.Location = new System.Drawing.Point(74, 45);
            this.textPlaceView.Name = "textPlaceView";
            this.textPlaceView.Size = new System.Drawing.Size(100, 20);
            this.textPlaceView.TabIndex = 1;
            // 
            // textTypeView
            // 
            this.textTypeView.Location = new System.Drawing.Point(74, 19);
            this.textTypeView.Name = "textTypeView";
            this.textTypeView.Size = new System.Drawing.Size(100, 20);
            this.textTypeView.TabIndex = 0;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(12, 9);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(97, 13);
            this.labelSize.TabIndex = 9;
            this.labelSize.Text = "Number of records:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(12, 97);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(44, 13);
            this.labelWeight.TabIndex = 10;
            this.labelWeight.Text = "Weight:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 123);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 45);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 16;
            this.labelType.Text = "Type:";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(12, 71);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(37, 13);
            this.labelPlace.TabIndex = 17;
            this.labelPlace.Text = "Place:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 151);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.ShowBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textPlace);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.btnSetSize);
            this.Controls.Add(this.textSize);
            this.Name = "Form1";
            this.Text = "Struct";
            this.ShowBox.ResumeLayout(false);
            this.ShowBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).EndInit();
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
        private System.Windows.Forms.GroupBox ShowBox;
        private System.Windows.Forms.NumericUpDown numericIndex;
        private System.Windows.Forms.TextBox textIDView;
        private System.Windows.Forms.TextBox textWeightView;
        private System.Windows.Forms.TextBox textPlaceView;
        private System.Windows.Forms.TextBox textTypeView;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label labelIDShow;
        private System.Windows.Forms.Label labelWeightShow;
        private System.Windows.Forms.Label labelPlaceShow;
        private System.Windows.Forms.Label labelTypeShow;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label label12;
    }
}

