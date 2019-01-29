using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oksana_kids
{
    public partial class TeacherSelectionMindow : Form
    {
        Dictionary<string, string> names = new Dictionary<string, string>();
        List<string> listR = new List<string>();
        List<string> listT = new List<string>();
        List<string> listP = new List<string>();

        public string currentTable = "";

        public TeacherSelectionMindow()
        {
            InitializeComponent();
            fillDictionary();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void fillDictionary()
        {
            names.Add("B01_testing_aims_to_tests", "Привязка : цели к тестам");
            names.Add("B02_study_courses_to_pupils_classes", "Привязка : учебные курсы к классам обучающихся лиц");
            names.Add("B03_study_subjects_to_courses", "Привязка : учебные темы к курсам");
            names.Add("B04_test_tasks_to_study_subjects", "Привязка : тестовые задания к учебным темам");
            names.Add("B05_testing_task_modules_to_tests", "Привязка : модули к тестам");
            names.Add("R01_people_category", "Категории физических лиц");
            names.Add("R02_pupils_classes", "Классы обучающихся лиц");
            names.Add("R03_testing_types", "Типы тестовых заданий");
            names.Add("R04_end_testing_reasons", "Причины завершения работы с тестами");
            names.Add("R05_legal_ownership_forms", "Юридические формы собственности");
            names.Add("R06_testing_aims", "Цели тестирования");
            names.Add("R07_methodical_materials", "Методические материалы");
            names.Add("R08_study_courses", "Учебные курсы");
            names.Add("R09_study_subjects", "Учебные темы");
            names.Add("R10_next_action_variants", "Варианты последующих действий");
            names.Add("R11_variants_of_passing_tasks_results_analysis", "Варианты оценки результатов выполнения тестового задания");
            names.Add("R12_instructions_to_test_tasks_types", "Типы указаний к выполнению тестовых заданий");
            names.Add("R13_play_result_variants", "Типы вариантов воспроизведения результата теста");
            names.Add("R14_track_types", "Типы файлов сопровождений");
            names.Add("R15_task_key_words", "Ключевые слова тестов");
            names.Add("T01_personalities", "Физические лица");
            names.Add("T02_tests", "Тесты");
            names.Add("T03_testing_task_modules", "Модули спецификации использования тз");
            names.Add("T04_testing_tasks", "Тестовые задания");
            names.Add("T05_test_passing_results", "Результаты прохождения тестов");
            names.Add("T06_teaching_materials", "Обучающие материалы к отдельным тестовым заданиям");
            names.Add("T07_soundtracks", "Звуковые сопровождения");
            names.Add("T08_audio_video_tracks", "Аудио/видео ролики");
            names.Add("T09_comment_variants_on_passing_tasks", "Варианты комментария по результатам выполнения тестового задания");
            names.Add("T10_organizations", "Организации");
        }

        private void getListToFill(string symbolType)
        {
            shower.Items.Clear();

            foreach (var item in names)
            {
                if (item.Key.StartsWith(symbolType))
                {
                    shower.Items.Add(item.Value);
                }
            }
        }

        private void getListToFill(string symbolType, string additional)
        {
            shower.Items.Clear();

            foreach (var item in names)
            {
                if (item.Key.StartsWith(symbolType) && item.Key.Contains(additional))
                {
                    shower.Items.Add(item.Value);
                }
            }
        }

        private string whatTableIs()
        {
            if (shower.SelectedItem == null)
            {
                return "";
            }
            else
            {
                string current = names.Keys.Where(x => names[x] == shower.SelectedItem.ToString()).FirstOrDefault();
                return current;
            }
                       
        }

        private void references_Click(object sender, EventArgs e)
        {
            getListToFill("R");
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) {

                e.Cancel = true;
                AskToLeaveForm a = new AskToLeaveForm();
                a.Show();
            }
        }

        private void tables_Click(object sender, EventArgs e)
        {
            tests.Visible = true;
            personal_data.Visible = true;
            others.Visible = true;
            files.Visible = true;
        }

        private void tests_Click(object sender, EventArgs e)
        {
            getListToFill("T", "test");
        }

        private void others_Click(object sender, EventArgs e)
        {
            shower.Items.Clear();
            shower.Items.Add("Организации");
            shower.Items.Add("Варианты комментария по результатам выполнения тестового задания");
            
        }

        private void files_Click(object sender, EventArgs e)
        {
            shower.Items.Clear();
            shower.Items.Add("Аудио/видео ролики");
            shower.Items.Add("Звуковые сопровождения");
            shower.Items.Add("Обучающие материалы к отдельным тестовым заданиям");
        }

        private void goToButton_Click(object sender, EventArgs e)
        {
            if (whatTableIs() == "")
            {
                MessageBox.Show("Выберите позицию из списка!");
            }
            else if (whatTableIs().StartsWith("R"))
            {
                References r = new References(shower.SelectedIndex);
                r.Show();
            }
            else if (whatTableIs().StartsWith("T01"))
            {
                Personalities p = new Personalities();
                p.Show();
            }
            else if (whatTableIs().StartsWith("T02") || whatTableIs().StartsWith("T03") || whatTableIs().StartsWith("T04") || whatTableIs().StartsWith("T05"))
            {
                Tests t = new Tests(shower.SelectedIndex);
                 t.Show();
            }
            
            
        }

        private void personal_data_Click(object sender, EventArgs e)
        {
            shower.Items.Clear();
            shower.Items.Add("Физические лица");
        }
    }
}
