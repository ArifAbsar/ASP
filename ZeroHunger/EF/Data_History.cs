//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroHunger.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Data_History
    {
        public string Histid { get; set; }
        public int Restid { get; set; }
        public int Collectid { get; set; }
        public string PreserveTime { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public Nullable<int> Received_By { get; set; }
        public Nullable<int> Approved_By { get; set; }
    
        public virtual Collect_Request Collect_Request { get; set; }
        public virtual Resturant Resturant { get; set; }
    }
}
