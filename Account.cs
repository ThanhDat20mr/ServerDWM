//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public string username { get; set; }
        public string pass { get; set; }
        public string ip { get; set; }
        public string status { get; set; }
    
        public virtual Connection Connection { get; set; }
        public virtual Chatting Chatting { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
