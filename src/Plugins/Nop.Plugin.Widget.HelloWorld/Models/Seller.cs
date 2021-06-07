using Nop.Web.Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widget.BestSeller.Models
{
    public class Seller 
    {
        public int Id { get; set; }
        public string SellerName { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        
    }
}
