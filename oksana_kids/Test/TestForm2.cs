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
    public partial class TestForm2 : Form
    {
        public const string FINISH_STRING = "Закончить тестирование";
        public const string NEXT_TASK_STRING = "Следующий вопрос";
        public const int MAX_BLOCKS_SIZE = 8;

        public PupilSelectionWindow callback;
        public int AnswersCount { get; set; }

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

        private int _Xpos;
        private int _Ypos;

        private PictureBox _selected;
        private bool _dragging = false;


        public TestForm2()
        {
            InitializeComponent();
        }

        public TestForm2(List<SimplyTest> tests, PupilSelectionWindow callback)
        {
            this.callback = callback;

            InitializeComponent();
            this.testCollection = tests;
            this.CurrentTest = this.testCollection.FirstOrDefault();
        }

        private void QuestionInit(AbstractTest test)
        {

        }
        private void TestForm2_Load(object sender, EventArgs e)
        {
            init();
            buttonNext.Text = NEXT_TASK_STRING;
        }

        public void init()
        {
            var pics = new List<PictureBox>()
            {
                this.pictureBoxAnswer1,
                this.pictureBoxAnswer2,
                this.pictureBoxAnswer3,
                this.pictureBoxAnswer4,
                this.pictureBoxAnswer5,
                this.pictureBoxAnswer6,
                this.pictureBoxAnswer7,
                this.pictureBoxAnswer8
            };

            foreach (var el in pics)
            {
                el.Click += new EventHandler(this.pictureClick);
                el.MouseUp += new MouseEventHandler(this.OnPictureBoxMouseUp);
                el.MouseDown += new MouseEventHandler(this.OnPictureBoxMouseDown);
                el.MouseMove += new MouseEventHandler(this.OnPictureBoxMouseMove);
            }
            
            
        }


        private void OnPictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (null == c) return;
            _dragging = false;

            //check if right answer
            var pbNumber = int.Parse(c.Name.Last().ToString());
            if (c.Left <= this.Width/2)
            {
                this.SelectedCheckBoxIdx |= 1 << pbNumber;
            }else
            {
                this.SelectedCheckBoxIdx &= ~(1 << pbNumber);
            }

        }

        private void OnPictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _dragging = true;
            _Xpos = e.X;
            _Ypos = e.Y;
            _selected = sender as PictureBox;
        }

        private void OnPictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!_dragging || null == c || _selected == null || _selected.Name != c.Name) return;
            c.Top = e.Y + c.Top - _Ypos;
            c.Left = e.X + c.Left - _Xpos;
        }

        public void pictureClick(object sender , EventArgs e)
        {
            var pb = sender as PictureBox;
            //var pbNumber = int.Parse(pb.Name.Last().ToString());
            //this.SelectedCheckBoxIdx ^= 1 << pbNumber;
            if (pb.BorderStyle == BorderStyle.Fixed3D)
                pb.BorderStyle = BorderStyle.None;
            else
                pb.BorderStyle = BorderStyle.Fixed3D;

        }

        private void InitTest(SimplyTest test)
        {
            if (test.Question?.StringValue != null)
                this.labelQuestionBody.Text = test.Question.StringValue;
            this.pictureBox1.Image = test.Questions.First().ImageValue;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.pictureBox2.Image = test.Questions.Last().ImageValue;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;


            labelQuestionTitle.Text = "Вопрос Номер: " + (this.currentTestIndex + 1);

            

            int counter = 0;
            foreach (var el in test.Variables)
            {
                try
                {
                    this.Controls["pictureBoxAnswer" + (++counter)].BackgroundImage = el.ImageValue;
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Упс, что то пошло не так!");
                }
            }
            for (int i = counter + 1; i <= MAX_BLOCKS_SIZE; i++)
            {
                this.Controls["pictureBoxAnswer" + i].Visible = false;
            }

        }


        private void InitTest(int idx)
        {

        }


        //private void checkBoxClick(object sender, EventArgs e)
        //{
        //    if (this.AnswersCount == 1)
        //    {
        //        var currentCheckBox = sender as CheckBox;
        //        var currentCheckBoxName = currentCheckBox.Name;
        //        this.SelectedCheckBoxIdx = int.Parse(currentCheckBox.Name.Substring(currentCheckBox.Name.Length - 1));
        //        var checkBoxArrayToCheck = new List<CheckBox>()
        //        {
        //            this.checkBox1,
        //            this.checkBox2,
        //            this.checkBox3,
        //            this.checkBox4,
        //            this.checkBox5,
        //            this.checkBox6,
        //            this.checkBox7,
        //        };

        //        foreach (CheckBox box in checkBoxArrayToCheck)
        //        {
        //            if (box.Name != currentCheckBoxName)
        //            {
        //                box.Checked = false;
        //            }
        //            else
        //            {
        //                box.Checked = true;
        //            }
        //        }
        //    }
        //    if (this.currentTestIndex == this.testCollection.Count - 1)
        //    {
        //        buttonNext.Text = FINISH_STRING;
        //    }
        //}

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.CurrentTest.RightIdx == this.SelectedCheckBoxIdx)
                this.RightAnswersCount++;
            if (currentTestIndex < testCollection.Count - 1)
            {
                this.CurrentTest = testCollection[++currentTestIndex];
                QuestionInit(this.CurrentTest);
            }
            else
            {
                MessageBox.Show("Тестирование окончено\n\rВерных ответов: " + this.RightAnswersCount);
                this.Hide();
                this.callback.Show();
            }

        }

        private void pictureBoxAnswer1_Click(object sender, EventArgs e)
        {

        }
    }
}