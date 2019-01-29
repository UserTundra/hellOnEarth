namespace oksana_kids
{
    partial class TeacherSelectionMindow
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
            this.references = new System.Windows.Forms.Button();
            this.tables = new System.Windows.Forms.Button();
            this.shower = new System.Windows.Forms.ListBox();
            this.goToButton = new System.Windows.Forms.Button();
            this.tests = new System.Windows.Forms.Button();
            this.personal_data = new System.Windows.Forms.Button();
            this.others = new System.Windows.Forms.Button();
            this.files = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Учителю";
            // 
            // references
            // 
            this.references.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.references.Location = new System.Drawing.Point(17, 60);
            this.references.Name = "references";
            this.references.Size = new System.Drawing.Size(144, 42);
            this.references.TabIndex = 2;
            this.references.Text = "Справочники";
            this.references.UseVisualStyleBackColor = true;
            this.references.Click += new System.EventHandler(this.references_Click);
            // 
            // tables
            // 
            this.tables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tables.Location = new System.Drawing.Point(17, 108);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(144, 42);
            this.tables.TabIndex = 5;
            this.tables.Text = "Данные";
            this.tables.UseVisualStyleBackColor = true;
            this.tables.Click += new System.EventHandler(this.tables_Click);
            // 
            // shower
            // 
            this.shower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shower.FormattingEnabled = true;
            this.shower.HorizontalExtent = 1;
            this.shower.HorizontalScrollbar = true;
            this.shower.ItemHeight = 18;
            this.shower.Location = new System.Drawing.Point(192, 12);
            this.shower.Name = "shower";
            this.shower.Size = new System.Drawing.Size(503, 364);
            this.shower.TabIndex = 6;
            // 
            // goToButton
            // 
            this.goToButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToButton.Location = new System.Drawing.Point(701, 12);
            this.goToButton.Name = "goToButton";
            this.goToButton.Size = new System.Drawing.Size(144, 42);
            this.goToButton.TabIndex = 7;
            this.goToButton.Text = "Перейти";
            this.goToButton.UseVisualStyleBackColor = true;
            this.goToButton.Click += new System.EventHandler(this.goToButton_Click);
            // 
            // tests
            // 
            this.tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tests.Location = new System.Drawing.Point(60, 156);
            this.tests.Name = "tests";
            this.tests.Size = new System.Drawing.Size(101, 35);
            this.tests.TabIndex = 8;
            this.tests.Text = "Тесты";
            this.tests.UseVisualStyleBackColor = true;
            this.tests.Visible = false;
            this.tests.Click += new System.EventHandler(this.tests_Click);
            // 
            // personal_data
            // 
            this.personal_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personal_data.Location = new System.Drawing.Point(60, 197);
            this.personal_data.Name = "personal_data";
            this.personal_data.Size = new System.Drawing.Size(101, 64);
            this.personal_data.TabIndex = 9;
            this.personal_data.Text = "Физические\r\nлица";
            this.personal_data.UseVisualStyleBackColor = true;
            this.personal_data.Visible = false;
            this.personal_data.Click += new System.EventHandler(this.personal_data_Click);
            // 
            // others
            // 
            this.others.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.others.Location = new System.Drawing.Point(60, 308);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(101, 35);
            this.others.TabIndex = 10;
            this.others.Text = "Другое";
            this.others.UseVisualStyleBackColor = true;
            this.others.Visible = false;
            this.others.Click += new System.EventHandler(this.others_Click);
            // 
            // files
            // 
            this.files.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.files.Location = new System.Drawing.Point(60, 267);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(101, 35);
            this.files.TabIndex = 11;
            this.files.Text = "Файлы";
            this.files.UseVisualStyleBackColor = true;
            this.files.Visible = false;
            this.files.Click += new System.EventHandler(this.files_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 414);
            this.Controls.Add(this.files);
            this.Controls.Add(this.others);
            this.Controls.Add(this.personal_data);
            this.Controls.Add(this.tests);
            this.Controls.Add(this.goToButton);
            this.Controls.Add(this.shower);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.references);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Программа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button references;
        private System.Windows.Forms.Button tables;
        private System.Windows.Forms.ListBox shower;
        private System.Windows.Forms.Button goToButton;
        private System.Windows.Forms.Button tests;
        private System.Windows.Forms.Button personal_data;
        private System.Windows.Forms.Button others;
        private System.Windows.Forms.Button files;
    }
}