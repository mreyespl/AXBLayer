using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AXBLayer.Models
{
    public class SalesQuotation
    {
        public string ID { get; set; }
        public string AccountID { get; set; }
        public decimal Total { get; set; }
    }
}