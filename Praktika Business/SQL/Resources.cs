//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praktika_Business.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Resources
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resources()
        {
            this.MainTable = new HashSet<MainTable>();
        }
    
        public int ID { get; set; }
        public string PerformersDepartment { get; set; }
        public string PhoneNumberOfPerformers { get; set; }
        public Nullable<int> HoursToCompleteTheOrder { get; set; }
        public string ResponsibleForTheOrder { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MainTable> MainTable { get; set; }
    }
}
