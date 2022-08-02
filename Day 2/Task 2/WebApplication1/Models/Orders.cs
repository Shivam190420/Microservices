using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int Order_amount { get; set; }
        public string Customer_name { get; set; }
        public DateTime Order_date { get; set; }
    }
}