//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace oksana_kids
{
    using System;
    using System.Collections.Generic;
    
    public partial class T11_task_answers
    {
        public long id { get; set; }
        public Nullable<long> id_task { get; set; }
        public Nullable<long> code_key_word { get; set; }
        public string string_value { get; set; }
        public string image_value { get; set; }
        public string sound_value { get; set; }
        public Nullable<long> is_correct { get; set; }
        public Nullable<long> group_no { get; set; }
    
        public virtual R15_task_key_words R15_task_key_words { get; set; }
        public virtual T04_testing_tasks T04_testing_tasks { get; set; }
    }
}
