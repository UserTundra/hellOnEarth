using oksana_kids.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids
{
    public partial class PupilSelectionWindow : Form
    {
        bd_kidsEntitiesConn bd = new bd_kidsEntitiesConn();
        public string currentTest;
        

        
        public PupilSelectionWindow()
        {
            InitializeComponent();
            getTestList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void setTestId()
        {

        }

        
        private void getTestList()
        {
            var linq = from a in bd.T02_tests
                       select new
                       {
                           test = a.name_test
                       };

            foreach (var item in linq)
            {
                testList.Items.Add(item.test);
            }
        }

        private void getTestInfo()
        {
            long test_id = getTestID();

            try
            {
                var linq = (from a in bd.T02_tests
                            join c in bd.B05_testing_task_modules_to_tests on a.id_test equals c.id_test
                            join d in bd.R07_methodical_materials on a.id_method_material equals d.id_method_material
                            where a.id_test == test_id
                            select new
                            {
                                duration = a.max_passing_duration_sec,
                                material = d.description,
                                count = bd.B05_testing_task_modules_to_tests.Select(x => x.id_module).Count()
                            }).ToList();

                foreach (var item in linq)
                {
                    duration.Text = item.duration.ToString();
                    countTZ.Text = item.count.ToString();
                    methodMaterial.Text = item.material.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                e.Cancel = true;
                AskToLeaveForm a = new AskToLeaveForm();
                a.Show();
            }
        }
        
        private void testList_DoubleClick(object sender, EventArgs e)
        {
            duration.Text = "";
            countTZ.Text = "";
            methodMaterial.Text = "";

            getTestInfo();
        }

        public string getTestName()
        {
            if (testList.SelectedItem.ToString() == "") MessageBox.Show("Выберите тест!");
            else
            {
                currentTest = testList.SelectedItem.ToString();
                testName.Text = currentTest;
            }
            

            if (testList.SelectedItem == null) return "";
            else return currentTest;
        }

        public long getTestID()
        {
            string test_name = getTestName();

            var linq0 = (from a in bd.T02_tests
                         where a.name_test == test_name
                         select new
                         {
                             id_test = a.id_test
                         }).ToList();

            long id_test = linq0.First().id_test;
            //testID = (int)id_test;

            return id_test;
        }

        public void getTasksFromTest()
        {
            int id_test = (int)getTestID();

            //var linq = from a in bd.B05_testing_task_modules_to_tests
            //           join b in bd.T03_testing_task_modules on a.id_module equals b.id_module
            //           join c in bd.T04_testing_tasks on b.id_task equals c.id_task
            //           where a.id_test == id_test
            //           select new
            //           {
            //               listTaskID = 
            //           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var attempts = new FileParser().IMages((int)this.getTestID());
            this.Hide();
            var test_case = new List<SimplyTest>()
            {
                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Отметь \"лишний\" предмет", // вот тут текст вопросa
                        ImageValue = null // картинка вопроса

                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "1", // вот тут текст который будет в варианте ответа
                            //ImageValue = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\oksanas_kids\oksana_kids\bin\Debug\testsources\1\1\1.png") // ккатринка ответа
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\1\1.png")) // ккатринка ответа
                        },
                        new RenderObject()
                        {
                            StringValue = "2",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\1\2.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue = "3",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\1\3.png"))
                        },
                        new RenderObject()
                        {
                            StringValue="4",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\1\4.jpg"))
                        }                        
                    },
                    RightIdx=3 // индекс правильного ответа
                        
                },
                new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Отметь \"лишний\" предмет",
                        ImageValue = null
                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "1",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\2\1.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue = "2",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\2\2.jpg"))
                        },
                        new RenderObject()
                        {
                            StringValue = "3",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\2\3.png"))
                        },
                        new RenderObject()
                        {
                            StringValue="4",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\2\4.png"))
                        }
                    },
                    RightIdx=2

                },
                 new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Отметь \"лишний\" предмет",
                        ImageValue = null
                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "1",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\5\1.png"))

                        },
                        new RenderObject()
                        {
                            StringValue = "2",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\5\2.png"))
                        },
                        new RenderObject()
                        {
                            StringValue = "3",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\5\3.png"))
                        },
                        new RenderObject()
                        {
                            StringValue="4",
                            ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\5\4.png"))
                        }
                    },
                    RightIdx = 3

                },
                 new SimplyTest()
                {
                    TestType = "OneWrong",
                    Question = new RenderObject()
                    {
                        StringValue = "Какого цвета эти предметы?",
                        ImageValue = Image.FromFile(Path.GetFullPath(@"testsources\1\4\4.jpg"))
                    },
                    Variables = new List<RenderObject>()
                    {
                        new RenderObject()
                        {
                            StringValue  = "оранжевого"
                        },
                        new RenderObject()
                        {
                            StringValue = "красного"
                        },
                        new RenderObject()
                        {
                            StringValue = "желтого"
                        },
                        new RenderObject()
                        {
                            StringValue="голубого"
                        }
                    },
                    RightIdx=2

                }
                
            };
           
            Test.TestForm a = new Test.TestForm(test_case,this);
            a.Show();

            var simplyQuestion = new List<SimplyTest>() {
                new SimplyTest() {
                    TestType = "Juxtaposition",
                Question = new RenderObject()
                {
                    StringValue = "Разложи фрукты и ягоды по баночкам"
                },
                Questions = new List<RenderObject>()
                {
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\2.jpg")
                    }
                },
                Variables = new List<RenderObject>()
                {
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\1-1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\1-2.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\1-3.png")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\1-4.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\2-1.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\2-2.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\2-3.jpg")
                    },
                    new RenderObject()
                    {
                        ImageValue = Image.FromFile(@"testsources\1\3\2-4.jpg")
                    }

                },
                RightIdx=30
            } };

            var imageSwapper = new TestForm2(simplyQuestion, this);
            imageSwapper.Show();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string item = imageOrVideoDecider(getItemPath());
            //if (item == "image")
            //{
            //    Pictures p = new Pictures(getItemPath(), getDescription());
            //    p.Show();
            //}

            Videos v = new Videos();
            v.Show();
            
            

        }

        private string imageOrVideoDecider(string path)
        {
            string answer = "";
            Regex regex_image = new Regex(@".*[.](jpg|png|jpeg|gif|GIF|JPG|JPEG|PNG)");
            Regex regex_video    = new Regex(@".*[.](dv|avi|mpeg|mov|dvd|flv|mp3|mp4|DV|AVI|MPEG|MOV|DVD|FLV|MP3|MP4)");

            if (regex_image.IsMatch(path))
                answer = "image";
            else answer = "video";

            return answer;
        }

        public string getItemPath()
        {
            int testID = (int)getTestID();
            string path = "";
            
            var linq = (from a in bd.T06_teaching_materials
                        join b in bd.T02_tests on a.id_teach_material equals b.id_teach_material
                        where b.id_test == testID
                        select new
                        {
                            pic = a.file_location,
                        }).ToList();

            foreach (var item in linq)
            {
                path = Path.GetFullPath(item.pic);
            }

            return path;
        }

        public string getDescription()
        {
            int testID = (int)getTestID();
            string description = "";

            var linq = (from a in bd.T06_teaching_materials
                        join b in bd.T02_tests on a.id_teach_material equals b.id_teach_material
                        where b.id_test == testID
                        select new
                        {
                            text = a.description
                        }).ToList();

            foreach (var item in linq)
            {
                description = item.text;
            }

            return description;
        }

        
            //    if (e.Button == MouseButtons.Right)
            //    {
            //        TextBox textBox = sender as TextBox;
            //        ContextMenuStrip menu = textBox.ContextMenuStrip;
            //        if (menu == null)
            //        {
            //            menu = textBox.ContextMenuStrip = new ContextMenuStrip();
            //            menu.Items.Add(textBox.SelectedText);
            //        }
            //        else
            //        {
            //            menu.Items[0].Text = textBox.SelectedText;
            //        }
            //        menu.Show(textBox, e.Location);
            //    }

            
        

        private void label4_Click(object sender, EventArgs e)
        {
            Label label4 = sender as Label;

            if (label4 != null)
            {
                Clipboard.SetText(label4.Text, TextDataFormat.UnicodeText);
            }
        }

        //private void text()
        //{
        //    string s = testList.SelectedItem.ToString();
        //    duration.SelectionStart = 0;
        //    duration.SelectionLength = duration.TextLength;
        //    string s1 = duration.SelectedText.ToString();

        //    MessageBox.Show(s1);
        //}

        private void zoomButton_Click(object sender, EventArgs e)
        {
            string s = Clipboard.GetText();
            Zoom z = new Zoom(s);
            z.Show();
            Clipboard.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Label label5 = sender as Label;

            if (label5 != null)
            {
                Clipboard.SetText(label5.Text, TextDataFormat.UnicodeText);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Label label6 = sender as Label;

            if (label6 != null)
            {
                Clipboard.SetText(label6.Text, TextDataFormat.UnicodeText);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label label3 = sender as Label;

            if (label3 != null)
            {
                Clipboard.SetText(label3.Text, TextDataFormat.UnicodeText);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label label1 = sender as Label;

            if (label1 != null)
            {
                Clipboard.SetText(label1.Text, TextDataFormat.UnicodeText);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Label label2 = sender as Label;

            if (label2 != null)
            {
                Clipboard.SetText(label2.Text, TextDataFormat.UnicodeText);
            }
        }

        private void duration_Click(object sender, EventArgs e)
        {
            TextBox duration = sender as TextBox;

            if (duration != null)
            {
                Clipboard.SetText(duration.Text, TextDataFormat.UnicodeText);
            }
        }

        private void countTZ_Click(object sender, EventArgs e)
        {
            TextBox countTZ = sender as TextBox;

            if (countTZ != null)
            {
                Clipboard.SetText(countTZ.Text, TextDataFormat.UnicodeText);
            }
        }

        private void methodMaterial_Click(object sender, EventArgs e)
        {
            TextBox methodMaterial = sender as TextBox;

            if (methodMaterial != null)
            {
                Clipboard.SetText(methodMaterial.Text, TextDataFormat.UnicodeText);
            }
        }

        private void testList_Click(object sender, EventArgs e)
        {
            ListBox testList = sender as ListBox;

            if (testList.SelectedItem.ToString() != null)
            {
                string s = testList.SelectedItem.ToString();
                Clipboard.SetText(s, TextDataFormat.UnicodeText);
            }
        }
    }
}
