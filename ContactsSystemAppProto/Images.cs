//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactsSystemAppProto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Images
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Contact Contact { get; set; }
    }
}
