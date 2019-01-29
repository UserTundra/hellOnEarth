namespace oksana_kids
{
    partial class Zoom
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
            this.zoomText = new System.Windows.Forms.TextBox();
            this.trackText = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackText)).BeginInit();
            this.SuspendLayout();
            // 
            // zoomText
            // 
            this.zoomText.Cursor = System.Windows.Forms.Cursors.Default;
            this.zoomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zoomText.Location = new System.Drawing.Point(13, 13);
            this.zoomText.Multiline = true;
            this.zoomText.Name = "zoomText";
            this.zoomText.ReadOnly = true;
            this.zoomText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.zoomText.Size = new System.Drawing.Size(768, 215);
            this.zoomText.TabIndex = 0;
            this.zoomText.TabStop = false;
            this.zoomText.Text = " ";
            // 
            // trackText
            // 
            this.trackText.Location = new System.Drawing.Point(13, 234);
            this.trackText.Maximum = 72;
            this.trackText.Minimum = 12;
            this.trackText.Name = "trackText";
            this.trackText.Size = new System.Drawing.Size(768, 45);
            this.trackText.TabIndex = 1;
            this.trackText.Value = 12;
            this.trackText.Scroll += new System.EventHandler(this.trackText_Scroll);
            // 
            // Zoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 278);
            this.Controls.Add(this.trackText);
            this.Controls.Add(this.zoomText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Zoom";
            this.Text = "Zoom";
            this.Load += new System.EventHandler(this.Zoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zoomText;
        private System.Windows.Forms.TrackBar trackText;
    }
}