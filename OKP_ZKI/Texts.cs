//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OKP_ZKI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Texts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Texts()
        {
            this.Answers = new HashSet<Answers>();
        }
    
        public int id_text { get; set; }
        public string Text { get; set; }
        public Nullable<int> id_subject { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answers> Answers { get; set; }
        public virtual Subjects Subjects { get; set; }
    }
}
