//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blogging.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public Nullable<int> Id { get; set; }
        public string Content { get; set; }
        public System.DateTime PublicationDate { get; set; }
        public int PostId { get; set; }
    
        public virtual Post Post { get; set; }
    }
}
