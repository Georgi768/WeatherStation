namespace NHLweatherStation
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tempFoption = new System.Windows.Forms.RadioButton();
            this.tempCoption = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.intervalOption = new System.Windows.Forms.ComboBox();
            this.typeCityOption = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select city,Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select type of temperature";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tempFoption
            // 
            this.tempFoption.AutoSize = true;
            this.tempFoption.Location = new System.Drawing.Point(183, 244);
            this.tempFoption.Name = "tempFoption";
            this.tempFoption.Size = new System.Drawing.Size(37, 20);
            this.tempFoption.TabIndex = 3;
            this.tempFoption.TabStop = true;
            this.tempFoption.Text = "F";
            this.tempFoption.UseVisualStyleBackColor = true;
            // 
            // tempCoption
            // 
            this.tempCoption.AutoSize = true;
            this.tempCoption.Location = new System.Drawing.Point(226, 244);
            this.tempCoption.Name = "tempCoption";
            this.tempCoption.Size = new System.Drawing.Size(38, 20);
            this.tempCoption.TabIndex = 4;
            this.tempCoption.TabStop = true;
            this.tempCoption.Text = "C";
            this.tempCoption.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interval";
            // 
            // intervalOption
            // 
            this.intervalOption.FormattingEnabled = true;
            this.intervalOption.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.intervalOption.Location = new System.Drawing.Point(183, 133);
            this.intervalOption.Name = "intervalOption";
            this.intervalOption.Size = new System.Drawing.Size(121, 24);
            this.intervalOption.TabIndex = 6;
            // 
            // typeCityOption
            // 
            this.typeCityOption.Location = new System.Drawing.Point(183, 41);
            this.typeCityOption.Name = "typeCityOption";
            this.typeCityOption.Size = new System.Drawing.Size(100, 22);
            this.typeCityOption.TabIndex = 7;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NHLweatherStation.Properties.Resources._102471858_261539758400374_1048870286864154624_n;
            this.ClientSize = new System.Drawing.Size(416, 370);
            this.Controls.Add(this.typeCityOption);
            this.Controls.Add(this.intervalOption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tempCoption);
            this.Controls.Add(this.tempFoption);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton tempFoption;
        private System.Windows.Forms.RadioButton tempCoption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox intervalOption;
        private System.Windows.Forms.TextBox typeCityOption;
    }
}