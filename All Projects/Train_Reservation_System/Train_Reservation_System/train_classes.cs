//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Train_Reservation_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class train_classes
    {
        public int serialNo { get; set; }
        public decimal trainNo { get; set; }
        public double C1AC { get; set; }
        public double C2AC { get; set; }
        public double C3AC { get; set; }
        public double SL { get; set; }
    
        public virtual train_details train_details { get; set; }
    }
}
