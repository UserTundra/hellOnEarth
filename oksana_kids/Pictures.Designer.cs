namespace oksana_kids
{
    partial class Pictures
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
            this.testPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.testPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // testPicture
            // 
            this.testPicture.Location = new System.Drawing.Point(12, 12);
            this.testPicture.Name = "testPicture";
            this.testPicture.Size = new System.Drawing.Size(660, 591);
            this.testPicture.TabIndex = 0;
            this.testPicture.TabStop = false;
            // 
            // Pictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 615);
            this.Controls.Add(this.testPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pictures";
            this.Text = "Pictures";
            this.Load += new System.EventHandler(this.Pictures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox testPicture;
    }
}