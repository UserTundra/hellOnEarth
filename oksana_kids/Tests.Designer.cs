namespace oksana_kids
{
    partial class Tests
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
            this.T02_tests = new System.Windows.Forms.TabPage();
            this.test_construct_button = new System.Windows.Forms.Button();
            this.datePicker_change = new System.Windows.Forms.DateTimePicker();
            this.datePicker_create = new System.Windows.Forms.DateTimePicker();
            this.note = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testAuthorSelect = new System.Windows.Forms.ComboBox();
            this.t012othersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet5 = new oksana_kids.bd_kidsDataSet5();
            this.label1 = new System.Windows.Forms.Label();
            this.name_test = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t02viewtestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_kidsDataSet3 = new oksana_kids.bd_kidsDataSet3();
            this.T03_testing_task_modules = new System.Windows.Forms.TabPage();
            this.T04_testing_tasks = new System.Windows.Forms.TabPage();
            this.T05_test_passing_results = new System.Windows.Forms.TabPage();
            this.bd_kidsDataSet2 = new oksana_kids.bd_kidsDataSet2();
            this.bdkidsDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t02_view_testsTableAdapter = new oksana_kids.bd_kidsDataSet3TableAdapters.T02_view_testsTableAdapter();
            this.bd_kidsDataSet4 = new oksana_kids.bd_kidsDataSet4();
            this.t01personalitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t01_personalitiesTableAdapter = new oksana_kids.bd_kidsDataSet4TableAdapters.T01_personalitiesTableAdapter();
            this.t01_2_othersTableAdapter = new oksana_kids.bd_kidsDataSet5TableAdapters.T01_2_othersTableAdapter();
            this.idtestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecorrectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxpassingdurationsecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.T02_tests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t012othersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02viewtestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdkidsDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t01personalitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.T02_tests);
            this.tabControl1.Controls.Add(this.T03_testing_task_modules);
            this.tabControl1.Controls.Add(this.T04_testing_tasks);
            this.tabControl1.Controls.Add(this.T05_test_passing_results);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // T02_tests
            // 
            this.T02_tests.Controls.Add(this.test_construct_button);
            this.T02_tests.Controls.Add(this.datePicker_change);
            this.T02_tests.Controls.Add(this.datePicker_create);
            this.T02_tests.Controls.Add(this.note);
            this.T02_tests.Controls.Add(this.label7);
            this.T02_tests.Controls.Add(this.label6);
            this.T02_tests.Controls.Add(this.duration);
            this.T02_tests.Controls.Add(this.label5);
            this.T02_tests.Controls.Add(this.label4);
            this.T02_tests.Controls.Add(this.label3);
            this.T02_tests.Controls.Add(this.testAuthorSelect);
            this.T02_tests.Controls.Add(this.label1);
            this.T02_tests.Controls.Add(this.name_test);
            this.T02_tests.Controls.Add(this.label2);
            this.T02_tests.Controls.Add(this.dataGridView1);
            this.T02_tests.Location = new System.Drawing.Point(4, 22);
            this.T02_tests.Name = "T02_tests";
            this.T02_tests.Padding = new System.Windows.Forms.Padding(3);
            this.T02_tests.Size = new System.Drawing.Size(922, 402);
            this.T02_tests.TabIndex = 0;
            this.T02_tests.Text = "Тесты";
            this.T02_tests.UseVisualStyleBackColor = true;
            // 
            // test_construct_button
            // 
            this.test_construct_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_construct_button.Location = new System.Drawing.Point(231, 166);
            this.test_construct_button.Name = "test_construct_button";
            this.test_construct_button.Size = new System.Drawing.Size(123, 47);
            this.test_construct_button.TabIndex = 16;
            this.test_construct_button.Text = "Конструктор";
            this.test_construct_button.UseVisualStyleBackColor = true;
            this.test_construct_button.Click += new System.EventHandler(this.test_construct_button_Click);
            // 
            // datePicker_change
            // 
            this.datePicker_change.Location = new System.Drawing.Point(155, 89);
            this.datePicker_change.Name = "datePicker_change";
            this.datePicker_change.Size = new System.Drawing.Size(199, 20);
            this.datePicker_change.TabIndex = 15;
            // 
            // datePicker_create
            // 
            this.datePicker_create.Location = new System.Drawing.Point(155, 65);
            this.datePicker_create.Name = "datePicker_create";
            this.datePicker_create.Size = new System.Drawing.Size(199, 20);
            this.datePicker_create.TabIndex = 14;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(155, 140);
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(199, 20);
            this.note.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Примечание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(324, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "сек";
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(155, 115);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(163, 20);
            this.duration.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Длительность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата корректировки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата создания";
            // 
            // testAuthorSelect
            // 
            this.testAuthorSelect.DataSource = this.t012othersBindingSource;
            this.testAuthorSelect.DisplayMember = "fio";
            this.testAuthorSelect.FormattingEnabled = true;
            this.testAuthorSelect.Location = new System.Drawing.Point(155, 39);
            this.testAuthorSelect.Name = "testAuthorSelect";
            this.testAuthorSelect.Size = new System.Drawing.Size(199, 21);
            this.testAuthorSelect.TabIndex = 6;
            this.testAuthorSelect.ValueMember = "id_person";
            // 
            // t012othersBindingSource
            // 
            this.t012othersBindingSource.DataMember = "T01_2_others";
            this.t012othersBindingSource.DataSource = this.bd_kidsDataSet5;
            // 
            // bd_kidsDataSet5
            // 
            this.bd_kidsDataSet5.DataSetName = "bd_kidsDataSet5";
            this.bd_kidsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Автор теста";
            // 
            // name_test
            // 
            this.name_test.Location = new System.Drawing.Point(155, 15);
            this.name_test.Multiline = true;
            this.name_test.Name = "name_test";
            this.name_test.Size = new System.Drawing.Size(199, 20);
            this.name_test.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название теста";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtestDataGridViewTextBoxColumn,
            this.nametestDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.datecreateDataGridViewTextBoxColumn,
            this.datecorrectDataGridViewTextBoxColumn,
            this.maxpassingdurationsecDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.t02viewtestsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(360, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // t02viewtestsBindingSource
            // 
            this.t02viewtestsBindingSource.DataMember = "T02_view_tests";
            this.t02viewtestsBindingSource.DataSource = this.bd_kidsDataSet3;
            // 
            // bd_kidsDataSet3
            // 
            this.bd_kidsDataSet3.DataSetName = "bd_kidsDataSet3";
            this.bd_kidsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // T03_testing_task_modules
            // 
            this.T03_testing_task_modules.Location = new System.Drawing.Point(4, 22);
            this.T03_testing_task_modules.Name = "T03_testing_task_modules";
            this.T03_testing_task_modules.Padding = new System.Windows.Forms.Padding(3);
            this.T03_testing_task_modules.Size = new System.Drawing.Size(922, 402);
            this.T03_testing_task_modules.TabIndex = 1;
            this.T03_testing_task_modules.Text = "Модули спецификации использования тз";
            this.T03_testing_task_modules.UseVisualStyleBackColor = true;
            // 
            // T04_testing_tasks
            // 
            this.T04_testing_tasks.Location = new System.Drawing.Point(4, 22);
            this.T04_testing_tasks.Name = "T04_testing_tasks";
            this.T04_testing_tasks.Size = new System.Drawing.Size(922, 402);
            this.T04_testing_tasks.TabIndex = 2;
            this.T04_testing_tasks.Text = "Тестовые задания";
            this.T04_testing_tasks.UseVisualStyleBackColor = true;
            // 
            // T05_test_passing_results
            // 
            this.T05_test_passing_results.Location = new System.Drawing.Point(4, 22);
            this.T05_test_passing_results.Name = "T05_test_passing_results";
            this.T05_test_passing_results.Size = new System.Drawing.Size(922, 402);
            this.T05_test_passing_results.TabIndex = 3;
            this.T05_test_passing_results.Text = "Результаты прохождения тестов";
            this.T05_test_passing_results.UseVisualStyleBackColor = true;
            // 
            // bd_kidsDataSet2
            // 
            this.bd_kidsDataSet2.DataSetName = "bd_kidsDataSet2";
            this.bd_kidsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdkidsDataSet2BindingSource
            // 
            this.bdkidsDataSet2BindingSource.DataSource = this.bd_kidsDataSet2;
            this.bdkidsDataSet2BindingSource.Position = 0;
            // 
            // t02_view_testsTableAdapter
            // 
            this.t02_view_testsTableAdapter.ClearBeforeFill = true;
            // 
            // bd_kidsDataSet4
            // 
            this.bd_kidsDataSet4.DataSetName = "bd_kidsDataSet4";
            this.bd_kidsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t01personalitiesBindingSource
            // 
            this.t01personalitiesBindingSource.DataMember = "T01_personalities";
            this.t01personalitiesBindingSource.DataSource = this.bd_kidsDataSet4;
            // 
            // t01_personalitiesTableAdapter
            // 
            this.t01_personalitiesTableAdapter.ClearBeforeFill = true;
            // 
            // t01_2_othersTableAdapter
            // 
            this.t01_2_othersTableAdapter.ClearBeforeFill = true;
            // 
            // idtestDataGridViewTextBoxColumn
            // 
            this.idtestDataGridViewTextBoxColumn.DataPropertyName = "id_test";
            this.idtestDataGridViewTextBoxColumn.HeaderText = "id_test";
            this.idtestDataGridViewTextBoxColumn.Name = "idtestDataGridViewTextBoxColumn";
            this.idtestDataGridViewTextBoxColumn.Visible = false;
            // 
            // nametestDataGridViewTextBoxColumn
            // 
            this.nametestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nametestDataGridViewTextBoxColumn.DataPropertyName = "name_test";
            this.nametestDataGridViewTextBoxColumn.HeaderText = "Название теста";
            this.nametestDataGridViewTextBoxColumn.Name = "nametestDataGridViewTextBoxColumn";
            this.nametestDataGridViewTextBoxColumn.Width = 104;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО автора";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.Width = 89;
            // 
            // datecreateDataGridViewTextBoxColumn
            // 
            this.datecreateDataGridViewTextBoxColumn.DataPropertyName = "date_create";
            this.datecreateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.datecreateDataGridViewTextBoxColumn.Name = "datecreateDataGridViewTextBoxColumn";
            // 
            // datecorrectDataGridViewTextBoxColumn
            // 
            this.datecorrectDataGridViewTextBoxColumn.DataPropertyName = "date_correct";
            this.datecorrectDataGridViewTextBoxColumn.HeaderText = "Дата корректировки";
            this.datecorrectDataGridViewTextBoxColumn.Name = "datecorrectDataGridViewTextBoxColumn";
            // 
            // maxpassingdurationsecDataGridViewTextBoxColumn
            // 
            this.maxpassingdurationsecDataGridViewTextBoxColumn.DataPropertyName = "max_passing_duration_sec";
            this.maxpassingdurationsecDataGridViewTextBoxColumn.HeaderText = "Макс. длительность прохождения, сек";
            this.maxpassingdurationsecDataGridViewTextBoxColumn.Name = "maxpassingdurationsecDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 453);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tests";
            this.Text = "Тесты";
            this.Load += new System.EventHandler(this.Tests_Load);
            this.tabControl1.ResumeLayout(false);
            this.T02_tests.ResumeLayout(false);
            this.T02_tests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t012othersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02viewtestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdkidsDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_kidsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t01personalitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage T02_tests;
        private System.Windows.Forms.TabPage T03_testing_task_modules;
        private System.Windows.Forms.TabPage T04_testing_tasks;
        private System.Windows.Forms.TabPage T05_test_passing_results;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bdkidsDataSet2BindingSource;
        private bd_kidsDataSet2 bd_kidsDataSet2;
        private bd_kidsDataSet3 bd_kidsDataSet3;
        private System.Windows.Forms.BindingSource t02viewtestsBindingSource;
        private bd_kidsDataSet3TableAdapters.T02_view_testsTableAdapter t02_view_testsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_test;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox testAuthorSelect;
        private bd_kidsDataSet4 bd_kidsDataSet4;
        private System.Windows.Forms.BindingSource t01personalitiesBindingSource;
        private bd_kidsDataSet4TableAdapters.T01_personalitiesTableAdapter t01_personalitiesTableAdapter;
        private bd_kidsDataSet5 bd_kidsDataSet5;
        private System.Windows.Forms.BindingSource t012othersBindingSource;
        private bd_kidsDataSet5TableAdapters.T01_2_othersTableAdapter t01_2_othersTableAdapter;
        private System.Windows.Forms.DateTimePicker datePicker_create;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePicker_change;
        private System.Windows.Forms.Button test_construct_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecorrectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxpassingdurationsecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}