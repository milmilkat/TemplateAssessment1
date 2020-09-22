namespace TemplateAssessment1
{
    partial class MainForm
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
            this.BackgroundImage = new System.Windows.Forms.PictureBox();
            this.ShootHeadButton = new System.Windows.Forms.Button();
            this.ShootAwayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundImage
            // 
            this.BackgroundImage.Image = global::TemplateAssessment1.Properties.Resources.AngerPic;
            this.BackgroundImage.Location = new System.Drawing.Point(0, 1);
            this.BackgroundImage.Name = "BackgroundImage";
            this.BackgroundImage.Size = new System.Drawing.Size(454, 320);
            this.BackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImage.TabIndex = 0;
            this.BackgroundImage.TabStop = false;
            // 
            // ShootHeadButton
            // 
            this.ShootHeadButton.Location = new System.Drawing.Point(12, 12);
            this.ShootHeadButton.Name = "ShootHeadButton";
            this.ShootHeadButton.Size = new System.Drawing.Size(89, 64);
            this.ShootHeadButton.TabIndex = 1;
            this.ShootHeadButton.Text = "Shoot At Head";
            this.ShootHeadButton.UseVisualStyleBackColor = true;
            this.ShootHeadButton.Click += new System.EventHandler(this.ShootHeadButton_Click);
            // 
            // ShootAwayButton
            // 
            this.ShootAwayButton.Location = new System.Drawing.Point(12, 95);
            this.ShootAwayButton.Name = "ShootAwayButton";
            this.ShootAwayButton.Size = new System.Drawing.Size(89, 64);
            this.ShootAwayButton.TabIndex = 2;
            this.ShootAwayButton.Text = "Shoot Away";
            this.ShootAwayButton.UseVisualStyleBackColor = true;
            this.ShootAwayButton.Click += new System.EventHandler(this.ShootAwayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 320);
            this.Controls.Add(this.ShootAwayButton);
            this.Controls.Add(this.ShootHeadButton);
            this.Controls.Add(this.BackgroundImage);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundImage;
        private System.Windows.Forms.Button ShootHeadButton;
        private System.Windows.Forms.Button ShootAwayButton;
    }
}

