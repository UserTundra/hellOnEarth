namespace oksana_kids
{
    partial class PupilSelectionWindow
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
            this.testList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.countTZ = new System.Windows.Forms.TextBox();
            this.methodMaterial = new System.Windows.Forms.TextBox();
            this.testName = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.zoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ученику";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбор темы тестирования";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // testList
            // 
            this.testList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testList.FormattingEnabled = true;
            this.testList.ItemHeight = 20;
            this.testList.Location = new System.Drawing.Point(29, 98);
            this.testList.Name = "testList";
            this.testList.Size = new System.Drawing.Size(408, 324);
            this.testList.TabIndex = 2;
            this.testList.Click += new System.EventHandler(this.testList_Click);
            this.testList.DoubleClick += new System.EventHandler(this.testList_DoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(175, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Начать тестирование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(465, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Характеристики теста";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(467, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 54);
            this.label4.TabIndex = 6;
            this.label4.Text = "Максимальная \r\nпродолжительность \r\nтеста (сек) :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(467, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество тестовых\r\nзаданий :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(467, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Методический материал :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // duration
            // 
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.duration.Location = new System.Drawing.Point(652, 154);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(106, 22);
            this.duration.TabIndex = 9;
            this.duration.Click += new System.EventHandler(this.duration_Click);
            // 
            // countTZ
            // 
            this.countTZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countTZ.Location = new System.Drawing.Point(652, 206);
            this.countTZ.Name = "countTZ";
            this.countTZ.Size = new System.Drawing.Size(106, 22);
            this.countTZ.TabIndex = 10;
            this.countTZ.Click += new System.EventHandler(this.countTZ_Click);
            // 
            // methodMaterial
            // 
            this.methodMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodMaterial.Location = new System.Drawing.Point(470, 270);
            this.methodMaterial.Multiline = true;
            this.methodMaterial.Name = "methodMaterial";
            this.methodMaterial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.methodMaterial.Size = new System.Drawing.Size(479, 50);
            this.methodMaterial.TabIndex = 11;
            this.methodMaterial.Click += new System.EventHandler(this.methodMaterial_Click);
            // 
            // testName
            // 
            this.testName.AutoSize = true;
            this.testName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testName.Location = new System.Drawing.Point(745, 103);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(13, 20);
            this.testName.TabIndex = 13;
            this.testName.Text = " ";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::oksana_kids.Properties.Resources.kisspng_hola_yo_hablo_espanol_childrens_learn_spanish_b_smile_learning_5a921089370874_5506914115195219292254;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(764, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 114);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // zoomButton
            // 
            this.zoomButton.BackgroundImage = global::oksana_kids.Properties.Resources.images;
            this.zoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomButton.Location = new System.Drawing.Point(787, 8);
            this.zoomButton.Name = "zoomButton";
            this.zoomButton.Size = new System.Drawing.Size(162, 82);
            this.zoomButton.TabIndex = 5;
            this.zoomButton.UseVisualStyleBackColor = true;
            this.zoomButton.Click += new System.EventHandler(this.zoomButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 502);
            this.Controls.Add(this.testName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.methodMaterial);
            this.Controls.Add(this.countTZ);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zoomButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Программа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox testList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button zoomButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.TextBox countTZ;
        private System.Windows.Forms.TextBox methodMaterial;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label testName;
    }
}