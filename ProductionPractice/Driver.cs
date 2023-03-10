//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductionPractice
{
    using System;
    using System.Collections.Generic;
    
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            this.Cars = new HashSet<Car>();
            this.Licences = new HashSet<Licence>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public int PassportSerial { get; set; }
        public int PassportNumber { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string CityLife { get; set; }
        public string AddressLife { get; set; }
        public string Company { get; set; }
        public string JobName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Cars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licence> Licences { get; set; }
    }
}
