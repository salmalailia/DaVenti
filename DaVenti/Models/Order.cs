//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DaVenti.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public string id_order { get; set; }
        public int fk_id_emp { get; set; }
        public string fk_id_payment { get; set; }
        public string fk_id_cust { get; set; }
        public System.DateTime date_order { get; set; }
        public string status { get; set; }
    }
}
