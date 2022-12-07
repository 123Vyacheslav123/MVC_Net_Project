using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Net_Project.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Person { get; set; }

        public string Addres { get; set; }

        public int IdBook { get; set; }

        public DateTime Date { get; set; }
    }
}