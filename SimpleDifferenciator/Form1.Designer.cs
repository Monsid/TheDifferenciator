
namespace SimpleDifferenciator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FolderBrowse = new System.Windows.Forms.Button();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.ProduceCSV = new System.Windows.Forms.Button();
            this.cropSquare = new System.Windows.Forms.TextBox();
            this.centerPositionX = new System.Windows.Forms.TextBox();
            this.centerPositionY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FolderBrowseOutput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.foldernameOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TestCrop = new System.Windows.Forms.Button();
            this.selectedPixelBrightness = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "crop square(size in pixels)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "center position X";
            // 
            // FolderBrowse
            // 
            this.FolderBrowse.Location = new System.Drawing.Point(52, 153);
            this.FolderBrowse.Name = "FolderBrowse";
            this.FolderBrowse.Size = new System.Drawing.Size(75, 23);
            this.FolderBrowse.TabIndex = 14;
            this.FolderBrowse.Text = "Browse Folder";
            this.FolderBrowse.UseVisualStyleBackColor = true;
            this.FolderBrowse.Click += new System.EventHandler(this.FolderBrowse_Click);
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Location = new System.Drawing.Point(140, 158);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(58, 13);
            this.folderPathLabel.TabIndex = 13;
            this.folderPathLabel.Text = "FolderPath";
            // 
            // folderPath
            // 
            this.folderPath.Enabled = false;
            this.folderPath.Location = new System.Drawing.Point(204, 156);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(371, 20);
            this.folderPath.TabIndex = 12;
            // 
            // ProduceCSV
            // 
            this.ProduceCSV.Location = new System.Drawing.Point(63, 275);
            this.ProduceCSV.Name = "ProduceCSV";
            this.ProduceCSV.Size = new System.Drawing.Size(106, 30);
            this.ProduceCSV.TabIndex = 15;
            this.ProduceCSV.Text = "Produce CSV";
            this.ProduceCSV.UseVisualStyleBackColor = true;
            this.ProduceCSV.Click += new System.EventHandler(this.ProduceCSV_Click);
            // 
            // cropSquare
            // 
            this.cropSquare.Location = new System.Drawing.Point(204, 51);
            this.cropSquare.Name = "cropSquare";
            this.cropSquare.Size = new System.Drawing.Size(65, 20);
            this.cropSquare.TabIndex = 16;
            // 
            // centerPositionX
            // 
            this.centerPositionX.Location = new System.Drawing.Point(204, 80);
            this.centerPositionX.Name = "centerPositionX";
            this.centerPositionX.Size = new System.Drawing.Size(65, 20);
            this.centerPositionX.TabIndex = 17;
            // 
            // centerPositionY
            // 
            this.centerPositionY.Location = new System.Drawing.Point(204, 116);
            this.centerPositionY.Name = "centerPositionY";
            this.centerPositionY.Size = new System.Drawing.Size(65, 20);
            this.centerPositionY.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "center position Y";
            // 
            // FolderBrowseOutput
            // 
            this.FolderBrowseOutput.Location = new System.Drawing.Point(52, 202);
            this.FolderBrowseOutput.Name = "FolderBrowseOutput";
            this.FolderBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.FolderBrowseOutput.TabIndex = 22;
            this.FolderBrowseOutput.Text = "Browse Folder";
            this.FolderBrowseOutput.UseVisualStyleBackColor = true;
            this.FolderBrowseOutput.Click += new System.EventHandler(this.FolderBrowseOutput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "FolderPath";
            // 
            // foldernameOutput
            // 
            this.foldernameOutput.Enabled = false;
            this.foldernameOutput.Location = new System.Drawing.Point(204, 205);
            this.foldernameOutput.Name = "foldernameOutput";
            this.foldernameOutput.Size = new System.Drawing.Size(371, 20);
            this.foldernameOutput.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "INPUT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "OUTPUT";
            // 
            // TestCrop
            // 
            this.TestCrop.Location = new System.Drawing.Point(219, 275);
            this.TestCrop.Name = "TestCrop";
            this.TestCrop.Size = new System.Drawing.Size(106, 30);
            this.TestCrop.TabIndex = 25;
            this.TestCrop.Text = "TestCrop";
            this.TestCrop.UseVisualStyleBackColor = true;
            this.TestCrop.Click += new System.EventHandler(this.TestCrop_Click);
            // 
            // selectedPixelBrightness
            // 
            this.selectedPixelBrightness.Location = new System.Drawing.Point(402, 80);
            this.selectedPixelBrightness.Name = "selectedPixelBrightness";
            this.selectedPixelBrightness.Size = new System.Drawing.Size(65, 20);
            this.selectedPixelBrightness.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "pixel Brightness";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "float with which 0 means pure black 1 means pure white";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 317);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectedPixelBrightness);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TestCrop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FolderBrowseOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.foldernameOutput);
            this.Controls.Add(this.centerPositionY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.centerPositionX);
            this.Controls.Add(this.cropSquare);
            this.Controls.Add(this.ProduceCSV);
            this.Controls.Add(this.FolderBrowse);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FolderBrowse;
        private System.Windows.Forms.Label folderPathLabel;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button ProduceCSV;
        private System.Windows.Forms.TextBox cropSquare;
        private System.Windows.Forms.TextBox centerPositionX;
        private System.Windows.Forms.TextBox centerPositionY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FolderBrowseOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox foldernameOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TestCrop;
        private System.Windows.Forms.TextBox selectedPixelBrightness;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

