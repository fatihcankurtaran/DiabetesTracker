//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public int MessageId { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> MessageDate { get; set; }
        public string MessageLength { get; set; }
        public int SenderId { get; set; }
        public Nullable<int> IsRead { get; set; }
    
        public virtual UserDetail UserDetail { get; set; }
        public virtual UserDetail UserDetail1 { get; set; }
    }
}