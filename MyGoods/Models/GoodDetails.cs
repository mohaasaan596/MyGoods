using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGoods.Model.DTO
{
    public class GoodDetails
    {
        public int GoodDetailsID { get; set; }
        public int ManufactureID { get; set; }
        public DateTime SupplyDate { get; set;}
    }
}
