using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oksana_kids
{
    class LinqWork
    {
        bd_kidsEntitiesConn bd = new bd_kidsEntitiesConn();

        Dictionary<int, int> codes = new Dictionary<int, int>();

        Dictionary<Dictionary<int, int>, string> tasks = new Dictionary<Dictionary<int, int>, string>();

        public string taskName = "";

        public string oneQuestionPicture;
        public string oneQuestionString;
        public string oneQuestionSound;

        List<string> multipleQuestionPicture = new List<string>();
        List<string> multipleQuestionString = new List<string>();
        List<string> multipleQuestionSound = new List<string>();

        private void getTasks(int testID)
        {
            int test_id = (int)new PupilSelectionWindow().getTestID();

            var linq = (from a in bd.B05_testing_task_modules_to_tests
                        join b in bd.T03_testing_task_modules on a.id_module equals b.id_module
                        join c in bd.T04_testing_tasks on b.id_task equals c.id_task
                        where a.id_test == test_id
                        select new
                        {
                            id = c.id_task,
                            name = c.name_task,
                            code = c.code_type
                        }).ToList();

            foreach (var item in linq)
            {
                codes.Add((int)item.id, (int)item.code);
                tasks.Add(codes, item.name);
            }
        }

        public void getAnswers(Dictionary<Dictionary<int, int>, string> tasks)
        {
            foreach (var item in tasks)
            {
                taskName = item.Value;

                foreach (var it in item.Key)
                {
                    var linq = bd.T11_task_answers
                                    .Where(x => x.id_task == it.Key)
                                    .Select(x => new
                                    {
                                       type = x.code_key_word == 1? "ans" : "qwes",
                                       x.image_value,
                                       x.string_value,
                                       x.sound_value,
                                       x.is_correct,
                                    });
                    //var linq = (from a in bd.T11_task_answers
                    //            where a.id_task == it.Key
                    //            select new
                    //            {
                    //                //count_answers = 
                    //                type_answer = (from i in k select i.code_key_word == 1 ? "ans" : "qwes"),
                    //                is_correct = (from i in k select i.is_correct),
                    //                string_value = (from i in k select i.string_value),
                    //                image_value = (from i in k select i.image_value),
                    //                sound_value = (from i in k select i.sound_value),


                    //            }).ToList();

                    foreach (var t in linq)
                    {
                        if (it.Value >= 1 && it.Value <= 8) // выбор из предопределенного набора : выбор лишнего или выбор верного
                        {
                            if (it.Value == 1 || it.Value == 5)
                            {
                                oneQuestionString = "";
                                oneQuestionPicture = Path.GetFullPath(t.image_value);
                            }
                        }
                        else if (it.Value >= 9 && it.Value <= 12) // соответствие : 2 группы
                        {

                        }
                        else if (it.Value >= 13 && it.Value <= 16) // соответствие : 3 группы
                        {

                        }
                    }
                }

                
            }
        }
    }
}
