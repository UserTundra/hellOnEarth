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
    
    public partial class B01_testing_aims_to_tests
    {
        public long id { get; set; }
        public Nullable<long> code_aim { get; set; }
        public Nullable<long> is_main_aim { get; set; }
        public Nullable<long> id_test { get; set; }
        public string note { get; set; }
    
        public virtual R06_testing_aims R06_testing_aims { get; set; }
        public virtual T02_tests T02_tests { get; set; }
    }
}
