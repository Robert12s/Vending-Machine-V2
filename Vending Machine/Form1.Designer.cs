namespace Vending_Machine
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submit = new System.Windows.Forms.Button();
            this.drinkSelect = new System.Windows.Forms.ComboBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Vending_Machine.Properties.Resources.SVM_03_grid_940x1024;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(415, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(89, 153);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(196, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Purchase";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // drinkSelect
            // 
            this.drinkSelect.FormattingEnabled = true;
            this.drinkSelect.Items.AddRange(new object[] {
            "Coca-Cola",
            "Coca-Cola Zero",
            "Coca-Cola Diet",
            "Pepsi Max",
            "Pepsi"});
            this.drinkSelect.Location = new System.Drawing.Point(89, 109);
            this.drinkSelect.Name = "drinkSelect";
            this.drinkSelect.Size = new System.Drawing.Size(196, 21);
            this.drinkSelect.TabIndex = 5;
            this.drinkSelect.SelectedIndexChanged += new System.EventHandler(this.drinkSelect_SelectedIndexChanged);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(89, 200);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 13);
            this.labelOutput.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please Select Your Drink";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.drinkSelect);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox drinkSelect;
        public System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label label1;
    }
}

