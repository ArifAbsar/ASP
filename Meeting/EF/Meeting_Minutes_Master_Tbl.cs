//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Meeting.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meeting_Minutes_Master_Tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meeting_Minutes_Master_Tbl()
        {
            this.Meeting_Minutes_Details_Tbl = new HashSet<Meeting_Minutes_Details_Tbl>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string CustomerType { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string MeetingPlace { get; set; }
        public string AttendsFromClientSide { get; set; }
        public string AttendsFromHostSide { get; set; }
        public string MeetingAgenda { get; set; }
        public string MeetingDiscussion { get; set; }
        public string MeetingDecision { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meeting_Minutes_Details_Tbl> Meeting_Minutes_Details_Tbl { get; set; }
    }
}