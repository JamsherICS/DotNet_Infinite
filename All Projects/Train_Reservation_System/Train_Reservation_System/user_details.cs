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
    
    public partial class user_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_details()
        {
            this.booked_ticket = new HashSet<booked_ticket>();
            this.canceled_ticket = new HashSet<canceled_ticket>();
        }
    
        public int userId { get; set; }
        public string userName { get; set; }
        public Nullable<int> age { get; set; }
        public string passcode { get; set; }
        public string mobile_number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<booked_ticket> booked_ticket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<canceled_ticket> canceled_ticket { get; set; }
    }
}
