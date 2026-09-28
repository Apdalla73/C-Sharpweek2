namespace Exampleweek2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Practice = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.Mypicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mypicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Practice
            // 
            this.Practice.Location = new System.Drawing.Point(336, 204);
            this.Practice.Name = "Practice";
            this.Practice.Size = new System.Drawing.Size(177, 56);
            this.Practice.TabIndex = 0;
            this.Practice.Text = "Practice";
            this.Practice.UseVisualStyleBackColor = true;
            this.Practice.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(568, 309);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(270, 134);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(136, 309);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(236, 134);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(21, 12);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(193, 46);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.Text = "Abdullahi";
            this.lblDisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // Mypicture
            // 
            this.Mypicture.Image = ((System.Drawing.Image)(resources.GetObject("Mypicture.Image")));
            this.Mypicture.Location = new System.Drawing.Point(685, 12);
            this.Mypicture.Name = "Mypicture";
            this.Mypicture.Size = new System.Drawing.Size(153, 197);
            this.Mypicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mypicture.TabIndex = 4;
            this.Mypicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 455);
            this.Controls.Add(this.Mypicture);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Practice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mypicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Practice;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.PictureBox Mypicture;
    }
}

