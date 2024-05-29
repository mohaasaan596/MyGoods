using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGoods.Model.DTO
{
    public class SubTransaction
    {
        public int SubTransactionID { get; set; }
        public int TransactionID { get; set; }
        public int GoodID { get; set; }
        public int SubTransactionCount { get; set; }
        public int SubTransactionPrice { get; set; }
    }
}
