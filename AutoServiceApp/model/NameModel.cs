//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoServiceApp.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class NameModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NameModel()
        {
            this.Auto = new HashSet<Auto>();
        }
    
        public int IdModel { get; set; }
        public string NameModel1 { get; set; }
        public Nullable<int> IdMark { get; set; }
        public Nullable<int> IdType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auto> Auto { get; set; }
        public virtual AutoType AutoType { get; set; }
        public virtual NameMark NameMark { get; set; }
    }
}
