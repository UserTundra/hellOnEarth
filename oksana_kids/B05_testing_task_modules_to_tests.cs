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
    
    public partial class B05_testing_task_modules_to_tests
    {
        public long id { get; set; }
        public Nullable<long> id_test { get; set; }
        public Nullable<long> id_module { get; set; }
        public Nullable<long> serial_number_module { get; set; }
        public string note { get; set; }
    
        public virtual T03_testing_task_modules T03_testing_task_modules { get; set; }
        public virtual T02_tests T02_tests { get; set; }
    }
}