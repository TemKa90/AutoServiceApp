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
    
    public partial class Auto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Auto()
        {
            this.Repair = new HashSet<Repair>();
        }
    
        public int IdAuto { get; set; }
        public string NumAuto { get; set; }
        public string VIN { get; set; }
        public string Color { get; set; }
        public int IdClient { get; set; }
        public Nullable<int> IdModel { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual NameModel NameModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Repair> Repair { get; set; }
    }
}