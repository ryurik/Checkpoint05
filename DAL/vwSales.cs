//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwSales
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string Article { get; set; }
        public string Manager { get; set; }
        public string ClientName { get; set; }
        public decimal Sum { get; set; }
    }
}
