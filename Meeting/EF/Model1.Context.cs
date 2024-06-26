﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class M_ModuleEntities1 : DbContext
    {
        public M_ModuleEntities1()
            : base("name=M_ModuleEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Corporate_Customer_Tbl> Corporate_Customer_Tbl { get; set; }
        public virtual DbSet<Individual_Customer_Tbl> Individual_Customer_Tbl { get; set; }
        public virtual DbSet<Meeting_Minutes_Details_Tbl> Meeting_Minutes_Details_Tbl { get; set; }
        public virtual DbSet<Meeting_Minutes_Master_Tbl> Meeting_Minutes_Master_Tbl { get; set; }
        public virtual DbSet<Products_Service_Tbl> Products_Service_Tbl { get; set; }
    
        public virtual int Meeting_Minutes_Details_Save_SP(Nullable<int> meetingMinutesMasterId, Nullable<int> productServiceId, Nullable<int> quantity, string unit)
        {
            var meetingMinutesMasterIdParameter = meetingMinutesMasterId.HasValue ?
                new ObjectParameter("MeetingMinutesMasterId", meetingMinutesMasterId) :
                new ObjectParameter("MeetingMinutesMasterId", typeof(int));
    
            var productServiceIdParameter = productServiceId.HasValue ?
                new ObjectParameter("ProductServiceId", productServiceId) :
                new ObjectParameter("ProductServiceId", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            var unitParameter = unit != null ?
                new ObjectParameter("Unit", unit) :
                new ObjectParameter("Unit", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Meeting_Minutes_Details_Save_SP", meetingMinutesMasterIdParameter, productServiceIdParameter, quantityParameter, unitParameter);
        }
    
        public virtual int Meeting_Minutes_Master_Save_SP(Nullable<int> customerId, string customerType, Nullable<System.DateTime> date, string meetingPlace, string attendsFromClientSide, string attendsFromHostSide, string meetingAgenda, string meetingDiscussion, string meetingDecision, ObjectParameter id)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("CustomerId", customerId) :
                new ObjectParameter("CustomerId", typeof(int));
    
            var customerTypeParameter = customerType != null ?
                new ObjectParameter("CustomerType", customerType) :
                new ObjectParameter("CustomerType", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var meetingPlaceParameter = meetingPlace != null ?
                new ObjectParameter("MeetingPlace", meetingPlace) :
                new ObjectParameter("MeetingPlace", typeof(string));
    
            var attendsFromClientSideParameter = attendsFromClientSide != null ?
                new ObjectParameter("AttendsFromClientSide", attendsFromClientSide) :
                new ObjectParameter("AttendsFromClientSide", typeof(string));
    
            var attendsFromHostSideParameter = attendsFromHostSide != null ?
                new ObjectParameter("AttendsFromHostSide", attendsFromHostSide) :
                new ObjectParameter("AttendsFromHostSide", typeof(string));
    
            var meetingAgendaParameter = meetingAgenda != null ?
                new ObjectParameter("MeetingAgenda", meetingAgenda) :
                new ObjectParameter("MeetingAgenda", typeof(string));
    
            var meetingDiscussionParameter = meetingDiscussion != null ?
                new ObjectParameter("MeetingDiscussion", meetingDiscussion) :
                new ObjectParameter("MeetingDiscussion", typeof(string));
    
            var meetingDecisionParameter = meetingDecision != null ?
                new ObjectParameter("MeetingDecision", meetingDecision) :
                new ObjectParameter("MeetingDecision", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Meeting_Minutes_Master_Save_SP", customerIdParameter, customerTypeParameter, dateParameter, meetingPlaceParameter, attendsFromClientSideParameter, attendsFromHostSideParameter, meetingAgendaParameter, meetingDiscussionParameter, meetingDecisionParameter, id);
        }
    }
}
