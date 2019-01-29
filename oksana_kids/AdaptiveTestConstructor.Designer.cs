namespace oksana_kids
{
    partial class AdaptiveTestConstructor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.max_try_number = new System.Windows.Forms.TextBox();
            this.change_answer_numbers = new System.Windows.Forms.TextBox();
            this.T01addButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 164);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.T01addButton);
            this.tabPage1.Controls.Add(this.change_answer_numbers);
            this.tabPage1.Controls.Add(this.max_try_number);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ТЗ 1-го типа";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ТЗ 2-го типа";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(490, 244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ТЗ 3-го типа";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Максимальное количество попыток";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Изменение количество ответов при следующей попытке";

            // 
            // max_try_number
            // 
            this.max_try_number.Location = new System.Drawing.Point(394, 13);
            this.max_try_number.Name = "max_try_number";
            this.max_try_number.Size = new System.Drawing.Size(90, 20);
            this.max_try_number.TabIndex = 5;
            // 
            // change_answer_numbers
            // 
            this.change_answer_numbers.Location = new System.Drawing.Point(394, 39);
            this.change_answer_numbers.Name = "change_answer_numbers";
            this.change_answer_numbers.Size = new System.Drawing.Size(90, 20);
            this.change_answer_numbers.TabIndex = 6;
            // 
            // T01addButton
            // 
            this.T01addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T01addButton.Location = new System.Drawing.Point(361, 78);
            this.T01addButton.Name = "T01addButton";
            this.T01addButton.Size = new System.Drawing.Size(123, 47);
            this.T01addButton.TabIndex = 7;
            this.T01addButton.Text = "Задать";
            this.T01addButton.UseVisualStyleBackColor = true;
            // 
            // AdaptiveTestConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 181);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdaptiveTestConstructor";
            this.Text = "Конструктор параметров адаптивного теста";
            this.Load += new System.EventHandler(this.AdaptiveTestConstructor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox change_answer_numbers;
        private System.Windows.Forms.TextBox max_try_number;
        private System.Windows.Forms.Button T01addButton;
    }
}