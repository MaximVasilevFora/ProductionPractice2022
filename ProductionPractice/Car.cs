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
    
    public partial class Car
    {
        public int Id { get; set; }
        public string Vin { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Weight { get; set; }
        public string DriveType { get; set; }
        public int IdColor { get; set; }
        public int IdEngine { get; set; }
        public int IdDriver { get; set; }
    
        public virtual Color Color { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual Engine Engine { get; set; }
    }
}
