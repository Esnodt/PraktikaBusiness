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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.MainTable = new HashSet<MainTable>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Cost { get; set; }
        public string Product { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<System.DateTime> OrderCompletionDate { get; set; }
        public Nullable<System.DateTime> DateOfReceiptOfTheOrder { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MainTable> MainTable { get; set; }
    }
}