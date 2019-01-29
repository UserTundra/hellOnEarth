using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids.Test
{
    public partial class TestForm : Form
    {
        public const string FINISH_STRING = "Закончить тестирование";
        public const string NEXT_TASK_STRING = "Следующий вопрос";
        public const int MAX_BLOCKS_SIZE = 8;

        public PupilSelectionWindow callback;

        public int SelectedCheckBoxIdx = 0;
        public int RightAnswersCount = 0;

        public List<SimplyTest> testCollection;
        public int currentTestIndex = 0;
        private SimplyTest _currentValue;
        public SimplyTest CurrentTest
        {
            get
            {
                return _currentValue;
            }
            set
            {
                InitTest(value);
                _currentValue = value;
            }
        }

        private void InitTest(SimplyTest test)
        {
            this.labelQuestionBody.Text = test.Question.StringValue;
            if (test.Question.ImageValue != null)
            { 
                this.pictureBoxQuestion1.Image = test.Question.ImageValue;
                pictureBoxQuestion1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            labelQuestionTitle.Text = "Вопрос Номер: " + (this.currentTestIndex+1);

            for (int i = 1; i <= MAX_BLOCKS_SIZE; i++)
            {
                var checkBox = this.Controls["checkBox" + i] as CheckBox;
                checkBox.Checked = false;
            }


            int counter = 0;
            foreach (var el in test.Variables)
            {
                try {
                    this.Controls["checkBox" + (++counter)].Text = el.StringValue;
                    this.Controls["pictureBox" + (counter)].BackgroundImage = el.ImageValue;
                } catch(Exception ee)
                {
                    MessageBox.Show("Упс, что то пошло не так!");
                }
            }
            for (int i = counter+1; i <= MAX_BLOCKS_SIZE; i++)
            {
                this.Controls["checkBox" + i].Visible = false;
                this.Controls["pictureBox" + i].Visible = false;
            }

        }

        public int AnswersCount { get; set; }

        public TestForm(List<SimplyTest> tests, PupilSelectionWindow callback)
        {
            this.callback = callback;

            InitializeComponent();
            this.testCollection = tests;
            this.CurrentTest = this.testCollection.FirstOrDefault();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.AnswersCount = 1;
            checkBoxInit();
            buttonNext.Text = NEXT_TASK_STRING;
        }

        private void checkBoxInit()
        {
            this.checkBox1.Click += new System.EventHandler(this.checkBoxClick);
            this.checkBox2.Click += new System.EventHandler(this.checkBoxClick);
            this.checkBox3.Click += new System.EventHandler(this.checkBoxClick);
            this.checkBox4.Click += new System.EventHandler(this.checkBoxClick);

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.CurrentTest.RightIdx == this.SelectedCheckBoxIdx)
                this.RightAnswersCount++;
            if (currentTestIndex < testCollection.Count - 1) {
                this.CurrentTest = testCollection[++currentTestIndex];
                QuestionInit(this.CurrentTest);
            }else
            {
                MessageBox.Show("Тестирование окончено\n\rВерных ответов: "+this.RightAnswersCount);
                this.Hide();
                this.callback.Show();
            }
            
        }

        private void QuestionInit(AbstractTest test)
        {

        }

        private void checkBoxClick(object sender, EventArgs e)
        {
            if(this.AnswersCount == 1)
            {
                var currentCheckBox = sender as CheckBox;
                var currentCheckBoxName = currentCheckBox.Name;
                this.SelectedCheckBoxIdx = int.Parse(currentCheckBox.Name.Substring(currentCheckBox.Name.Length - 1));
                var checkBoxArrayToCheck = new List<CheckBox>()
                {
                    this.checkBox1,
                    this.checkBox2,
                    this.checkBox3,
                    this.checkBox4,
                    this.checkBox5,
                    this.checkBox6,
                    this.checkBox7,
                };

                foreach (CheckBox box in checkBoxArrayToCheck)
                {
                    if(box.Name != currentCheckBoxName)
                    {
                        box.Checked = false;
                    }
                    else
                    {
                        box.Checked = true;
                    }
                }
            }
            if(this.currentTestIndex == this.testCollection.Count-1)
            {
                buttonNext.Text = FINISH_STRING;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxQuestion1_Click(object sender, EventArgs e)
        {

        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[1].Show();
        }
    }
}
