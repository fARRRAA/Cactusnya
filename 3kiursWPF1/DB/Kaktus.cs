//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3kiursWPF1.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kaktus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kaktus()
        {
            this.Collection = new HashSet<Collection>();
        }
    
        public int Id_kaktus { get; set; }
        public int Id_Type { get; set; }
        public string Otkuda { get; set; }
        public int Age { get; set; }
        public int Price { get; set; }
        public string Uhod { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Collection> Collection { get; set; }
        public virtual Type Type { get; set; }
    }
}
