using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oksana_kids
{
    class FileParser
    {

        bd_kidsEntitiesConn bd = new bd_kidsEntitiesConn();
        List<string> picsAnswer = new List<string>();
        List<string> picsQuestion = new List<string>();
        string add = @"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\oksanas_kids\oksana_kids\bin\Debug\";
        
        private IEnumerable<string> get(int testId)
        {
            long test_id = testId;

            var linq = (from a in bd.T02_tests
                        join b in bd.B05_testing_task_modules_to_tests on a.id_test equals b.id_test
                        join c in bd.T03_testing_task_modules on b.id_module equals c.id_module
                        join d in bd.T04_testing_tasks on c.id_task equals d.id_task
                        where a.id_test == test_id
                        select new
                        {
                            //taskID = d.id_task,
                            //nameTask = d.name_task,
                            file = d.file_location,
                            type = d.code_type
                        }).ToList().Select(x=> x.file);
            return linq;
            
        }

        public List<Image> IMages(int test)
        {
            var files = this.get(test);
            List<Image> lst = new List<Image>();
            foreach (var item in files)
            {
                lst.Add(this.getImage(item));
            }
            return lst;
        }

        public Image getImage(string path)
        {
            return new Bitmap(path);
        }

        private void parse(string fileLocation, int taskType)
        {
            fileLocation = '\"' + fileLocation + '\"';

            StreamReader objReader = new StreamReader(fileLocation);

            string sLine = "";
            List<string> arrText = new List<string>();            

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();

            foreach (var item in arrText)
            {
                if (item.Contains("answer"))
                {
                    picsAnswer.Add('\u0022' + item + '\u0022');
                }
                else if (item.Contains("question"))
                {
                    picsQuestion.Add('\u0022' + item + '\u0022');
                }

                if (taskType == 1)
                {

                }
            }

        }
    }
}
