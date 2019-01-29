namespace oksana_kids
{
    partial class References
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.R01_people_category = new System.Windows.Forms.TabPage();
            this.R01addButton = new System.Windows.Forms.Button();
            this.R01changeButton = new System.Windows.Forms.Button();
            this.R01deleteButton = new System.Windows.Forms.Button();
            this.R01 = new System.Windows.Forms.DataGridView();
            this.codecategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r01peoplecategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdkidsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet = new oksana_kids.bd_kidsDataSet();
            this.R01_note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.R01_name_category = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.R02_pupils_classes = new System.Windows.Forms.TabPage();
            this.R03_testing_types = new System.Windows.Forms.TabPage();
            this.R04_end_testing_reasons = new System.Windows.Forms.TabPage();
            this.R05_legal_ownership_forms = new System.Windows.Forms.TabPage();
            this.R06_testing_aims = new System.Windows.Forms.TabPage();
            this.R07_methodical_materials = new System.Windows.Forms.TabPage();
            this.R08_study_courses = new System.Windows.Forms.TabPage();
            this.R09_study_subjects = new System.Windows.Forms.TabPage();
            this.R10_next_action_variants = new System.Windows.Forms.TabPage();
            this.R11_variants_of_passing_tasks_results_analysis = new System.Windows.Forms.TabPage();
            this.R12_instructions_to_test_tasks_types = new System.Windows.Forms.TabPage();
            this.R13_play_result_variants = new System.Windows.Forms.TabPage();
            this.R14_track_types = new System.Windows.Forms.TabPage();
            this.R15_task_key_words = new System.Windows.Forms.TabPage();
            this.r01_people_categoryTableAdapter = new oksana_kids.bd_kidsDataSetTableAdapters.R01_people_categoryTableAdapter();
            this.tabControl1.SuspendLayout();
            this.R01_people_category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r01peoplecategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdkidsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.R01_people_category);
            this.tabControl1.Controls.Add(this.R02_pupils_classes);
            this.tabControl1.Controls.Add(this.R03_testing_types);
            this.tabControl1.Controls.Add(this.R04_end_testing_reasons);
            this.tabControl1.Controls.Add(this.R05_legal_ownership_forms);
            this.tabControl1.Controls.Add(this.R06_testing_aims);
            this.tabControl1.Controls.Add(this.R07_methodical_materials);
            this.tabControl1.Controls.Add(this.R08_study_courses);
            this.tabControl1.Controls.Add(this.R09_study_subjects);
            this.tabControl1.Controls.Add(this.R10_next_action_variants);
            this.tabControl1.Controls.Add(this.R11_variants_of_passing_tasks_results_analysis);
            this.tabControl1.Controls.Add(this.R12_instructions_to_test_tasks_types);
            this.tabControl1.Controls.Add(this.R13_play_result_variants);
            this.tabControl1.Controls.Add(this.R14_track_types);
            this.tabControl1.Controls.Add(this.R15_task_key_words);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // R01_people_category
            // 
            this.R01_people_category.Controls.Add(this.R01addButton);
            this.R01_people_category.Controls.Add(this.R01changeButton);
            this.R01_people_category.Controls.Add(this.R01deleteButton);
            this.R01_people_category.Controls.Add(this.R01);
            this.R01_people_category.Controls.Add(this.R01_note);
            this.R01_people_category.Controls.Add(this.label2);
            this.R01_people_category.Controls.Add(this.R01_name_category);
            this.R01_people_category.Controls.Add(this.label1);
            this.R01_people_category.Location = new System.Drawing.Point(4, 22);
            this.R01_people_category.Name = "R01_people_category";
            this.R01_people_category.Padding = new System.Windows.Forms.Padding(3);
            this.R01_people_category.Size = new System.Drawing.Size(804, 354);
            this.R01_people_category.TabIndex = 0;
            this.R01_people_category.Text = "Категории физических лиц";
            this.R01_people_category.UseVisualStyleBackColor = true;
            // 
            // R01addButton
            // 
            this.R01addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R01addButton.Location = new System.Drawing.Point(356, 288);
            this.R01addButton.Name = "R01addButton";
            this.R01addButton.Size = new System.Drawing.Size(123, 47);
            this.R01addButton.TabIndex = 1;
            this.R01addButton.Text = "Добавить";
            this.R01addButton.UseVisualStyleBackColor = true;
            this.R01addButton.Click += new System.EventHandler(this.R01addButton_Click);
            // 
            // R01changeButton
            // 
            this.R01changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R01changeButton.Location = new System.Drawing.Point(514, 288);
            this.R01changeButton.Name = "R01changeButton";
            this.R01changeButton.Size = new System.Drawing.Size(123, 47);
            this.R01changeButton.TabIndex = 2;
            this.R01changeButton.Text = "Изменить";
            this.R01changeButton.UseVisualStyleBackColor = true;
            this.R01changeButton.Click += new System.EventHandler(this.R01changeButton_Click);
            // 
            // R01deleteButton
            // 
            this.R01deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R01deleteButton.Location = new System.Drawing.Point(675, 288);
            this.R01deleteButton.Name = "R01deleteButton";
            this.R01deleteButton.Size = new System.Drawing.Size(123, 47);
            this.R01deleteButton.TabIndex = 3;
            this.R01deleteButton.Text = "Удалить";
            this.R01deleteButton.UseVisualStyleBackColor = true;
            this.R01deleteButton.Click += new System.EventHandler(this.R01deleteButton_Click);
            // 
            // R01
            // 
            this.R01.AutoGenerateColumns = false;
            this.R01.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.R01.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.R01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.R01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codecategoryDataGridViewTextBoxColumn,
            this.namecategoryDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.R01.DataSource = this.r01peoplecategoryBindingSource;
            this.R01.Location = new System.Drawing.Point(356, 12);
            this.R01.Name = "R01";
            this.R01.Size = new System.Drawing.Size(442, 270);
            this.R01.TabIndex = 4;
            // 
            // codecategoryDataGridViewTextBoxColumn
            // 
            this.codecategoryDataGridViewTextBoxColumn.DataPropertyName = "code_category";
            this.codecategoryDataGridViewTextBoxColumn.HeaderText = "code_category";
            this.codecategoryDataGridViewTextBoxColumn.Name = "codecategoryDataGridViewTextBoxColumn";
            this.codecategoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // namecategoryDataGridViewTextBoxColumn
            // 
            this.namecategoryDataGridViewTextBoxColumn.DataPropertyName = "name_category";
            this.namecategoryDataGridViewTextBoxColumn.HeaderText = "Название категории физического лица";
            this.namecategoryDataGridViewTextBoxColumn.Name = "namecategoryDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // r01peoplecategoryBindingSource
            // 
            this.r01peoplecategoryBindingSource.DataMember = "R01_people_category";
            this.r01peoplecategoryBindingSource.DataSource = this.bdkidsDataSetBindingSource;
            // 
            // bdkidsDataSetBindingSource
            // 
            this.bdkidsDataSetBindingSource.DataSource = this.bd_kidsDataSet;
            this.bdkidsDataSetBindingSource.Position = 0;
            // 
            // bd_kidsDataSet
            // 
            this.bd_kidsDataSet.DataSetName = "bd_kidsDataSet";
            this.bd_kidsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // R01_note
            // 
            this.R01_note.Location = new System.Drawing.Point(171, 52);
            this.R01_note.Multiline = true;
            this.R01_note.Name = "R01_note";
            this.R01_note.Size = new System.Drawing.Size(163, 20);
            this.R01_note.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Примечание";
            // 
            // R01_name_category
            // 
            this.R01_name_category.Location = new System.Drawing.Point(171, 19);
            this.R01_name_category.Name = "R01_name_category";
            this.R01_name_category.Size = new System.Drawing.Size(163, 20);
            this.R01_name_category.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название категории \r\nфизического лица";
            // 
            // R02_pupils_classes
            // 
            this.R02_pupils_classes.Location = new System.Drawing.Point(4, 22);
            this.R02_pupils_classes.Name = "R02_pupils_classes";
            this.R02_pupils_classes.Padding = new System.Windows.Forms.Padding(3);
            this.R02_pupils_classes.Size = new System.Drawing.Size(804, 354);
            this.R02_pupils_classes.TabIndex = 1;
            this.R02_pupils_classes.Text = "Классы обучающихся лиц";
            this.R02_pupils_classes.UseVisualStyleBackColor = true;
            // 
            // R03_testing_types
            // 
            this.R03_testing_types.Location = new System.Drawing.Point(4, 22);
            this.R03_testing_types.Name = "R03_testing_types";
            this.R03_testing_types.Padding = new System.Windows.Forms.Padding(3);
            this.R03_testing_types.Size = new System.Drawing.Size(804, 354);
            this.R03_testing_types.TabIndex = 2;
            this.R03_testing_types.Text = "Типы тестовых заданий";
            this.R03_testing_types.UseVisualStyleBackColor = true;
            // 
            // R04_end_testing_reasons
            // 
            this.R04_end_testing_reasons.Location = new System.Drawing.Point(4, 22);
            this.R04_end_testing_reasons.Name = "R04_end_testing_reasons";
            this.R04_end_testing_reasons.Size = new System.Drawing.Size(804, 354);
            this.R04_end_testing_reasons.TabIndex = 3;
            this.R04_end_testing_reasons.Text = "Причины завершения работы с тестами";
            this.R04_end_testing_reasons.UseVisualStyleBackColor = true;
            // 
            // R05_legal_ownership_forms
            // 
            this.R05_legal_ownership_forms.Location = new System.Drawing.Point(4, 22);
            this.R05_legal_ownership_forms.Name = "R05_legal_ownership_forms";
            this.R05_legal_ownership_forms.Size = new System.Drawing.Size(804, 354);
            this.R05_legal_ownership_forms.TabIndex = 4;
            this.R05_legal_ownership_forms.Text = "Юридические формы собственности";
            this.R05_legal_ownership_forms.UseVisualStyleBackColor = true;
            // 
            // R06_testing_aims
            // 
            this.R06_testing_aims.Location = new System.Drawing.Point(4, 22);
            this.R06_testing_aims.Name = "R06_testing_aims";
            this.R06_testing_aims.Size = new System.Drawing.Size(804, 354);
            this.R06_testing_aims.TabIndex = 5;
            this.R06_testing_aims.Text = "Цели тестирования";
            this.R06_testing_aims.UseVisualStyleBackColor = true;
            // 
            // R07_methodical_materials
            // 
            this.R07_methodical_materials.Location = new System.Drawing.Point(4, 22);
            this.R07_methodical_materials.Name = "R07_methodical_materials";
            this.R07_methodical_materials.Size = new System.Drawing.Size(804, 354);
            this.R07_methodical_materials.TabIndex = 6;
            this.R07_methodical_materials.Text = "Методические материалы";
            this.R07_methodical_materials.UseVisualStyleBackColor = true;
            // 
            // R08_study_courses
            // 
            this.R08_study_courses.Location = new System.Drawing.Point(4, 22);
            this.R08_study_courses.Name = "R08_study_courses";
            this.R08_study_courses.Size = new System.Drawing.Size(804, 354);
            this.R08_study_courses.TabIndex = 7;
            this.R08_study_courses.Text = "Учебные курсы";
            this.R08_study_courses.UseVisualStyleBackColor = true;
            // 
            // R09_study_subjects
            // 
            this.R09_study_subjects.Location = new System.Drawing.Point(4, 22);
            this.R09_study_subjects.Name = "R09_study_subjects";
            this.R09_study_subjects.Size = new System.Drawing.Size(804, 354);
            this.R09_study_subjects.TabIndex = 8;
            this.R09_study_subjects.Text = "Учебные темы";
            this.R09_study_subjects.UseVisualStyleBackColor = true;
            // 
            // R10_next_action_variants
            // 
            this.R10_next_action_variants.Location = new System.Drawing.Point(4, 22);
            this.R10_next_action_variants.Name = "R10_next_action_variants";
            this.R10_next_action_variants.Size = new System.Drawing.Size(804, 354);
            this.R10_next_action_variants.TabIndex = 9;
            this.R10_next_action_variants.Text = "Варианты последующих действий";
            this.R10_next_action_variants.UseVisualStyleBackColor = true;
            // 
            // R11_variants_of_passing_tasks_results_analysis
            // 
            this.R11_variants_of_passing_tasks_results_analysis.Location = new System.Drawing.Point(4, 22);
            this.R11_variants_of_passing_tasks_results_analysis.Name = "R11_variants_of_passing_tasks_results_analysis";
            this.R11_variants_of_passing_tasks_results_analysis.Size = new System.Drawing.Size(804, 354);
            this.R11_variants_of_passing_tasks_results_analysis.TabIndex = 10;
            this.R11_variants_of_passing_tasks_results_analysis.Text = "Варианты анализа результатов выполнения тестового задания";
            this.R11_variants_of_passing_tasks_results_analysis.UseVisualStyleBackColor = true;
            // 
            // R12_instructions_to_test_tasks_types
            // 
            this.R12_instructions_to_test_tasks_types.Location = new System.Drawing.Point(4, 22);
            this.R12_instructions_to_test_tasks_types.Name = "R12_instructions_to_test_tasks_types";
            this.R12_instructions_to_test_tasks_types.Size = new System.Drawing.Size(804, 354);
            this.R12_instructions_to_test_tasks_types.TabIndex = 11;
            this.R12_instructions_to_test_tasks_types.Text = "Типы указаний к выполнению тестового задания";
            this.R12_instructions_to_test_tasks_types.UseVisualStyleBackColor = true;
            // 
            // R13_play_result_variants
            // 
            this.R13_play_result_variants.Location = new System.Drawing.Point(4, 22);
            this.R13_play_result_variants.Name = "R13_play_result_variants";
            this.R13_play_result_variants.Size = new System.Drawing.Size(804, 354);
            this.R13_play_result_variants.TabIndex = 12;
            this.R13_play_result_variants.Text = "Типы вариантов воспроизведения результатов теста";
            this.R13_play_result_variants.UseVisualStyleBackColor = true;
            // 
            // R14_track_types
            // 
            this.R14_track_types.Location = new System.Drawing.Point(4, 22);
            this.R14_track_types.Name = "R14_track_types";
            this.R14_track_types.Size = new System.Drawing.Size(804, 354);
            this.R14_track_types.TabIndex = 13;
            this.R14_track_types.Text = "Типы файлов сопровождений";
            this.R14_track_types.UseVisualStyleBackColor = true;
            // 
            // R15_task_key_words
            // 
            this.R15_task_key_words.Location = new System.Drawing.Point(4, 22);
            this.R15_task_key_words.Name = "R15_task_key_words";
            this.R15_task_key_words.Size = new System.Drawing.Size(804, 354);
            this.R15_task_key_words.TabIndex = 14;
            this.R15_task_key_words.Text = "Ключевые слова тестов";
            this.R15_task_key_words.UseVisualStyleBackColor = true;
            // 
            // r01_people_categoryTableAdapter
            // 
            this.r01_people_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // References
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 397);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "References";
            this.Text = "Справочнки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.References_FormClosing);
            this.Load += new System.EventHandler(this.References_Load);
            this.tabControl1.ResumeLayout(false);
            this.R01_people_category.ResumeLayout(false);
            this.R01_people_category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r01peoplecategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdkidsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage R01_people_category;
        private System.Windows.Forms.TabPage R02_pupils_classes;
        private System.Windows.Forms.TabPage R03_testing_types;
        private System.Windows.Forms.TabPage R04_end_testing_reasons;
        private System.Windows.Forms.TabPage R05_legal_ownership_forms;
        private System.Windows.Forms.TabPage R06_testing_aims;
        private System.Windows.Forms.TabPage R07_methodical_materials;
        private System.Windows.Forms.TabPage R08_study_courses;
        private System.Windows.Forms.TabPage R09_study_subjects;
        private System.Windows.Forms.TabPage R10_next_action_variants;
        private System.Windows.Forms.TabPage R11_variants_of_passing_tasks_results_analysis;
        private System.Windows.Forms.TabPage R12_instructions_to_test_tasks_types;
        private System.Windows.Forms.TabPage R13_play_result_variants;
        private System.Windows.Forms.TabPage R14_track_types;
        private System.Windows.Forms.TextBox R01_note;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox R01_name_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage R15_task_key_words;
        private System.Windows.Forms.Button R01addButton;
        private System.Windows.Forms.Button R01changeButton;
        private System.Windows.Forms.Button R01deleteButton;
        private System.Windows.Forms.DataGridView R01;
        private System.Windows.Forms.BindingSource bdkidsDataSetBindingSource;
        private bd_kidsDataSet bd_kidsDataSet;
        private System.Windows.Forms.BindingSource r01peoplecategoryBindingSource;
        private bd_kidsDataSetTableAdapters.R01_people_categoryTableAdapter r01_people_categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codecategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}