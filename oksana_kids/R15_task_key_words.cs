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
    
    public partial class R15_task_key_words
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public R15_task_key_words()
        {
            this.T11_task_answers = new HashSet<T11_task_answers>();
        }
    
        public long code_key_word { get; set; }
        public string name_key_word { get; set; }
        public string note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T11_task_answers> T11_task_answers { get; set; }
    }
}