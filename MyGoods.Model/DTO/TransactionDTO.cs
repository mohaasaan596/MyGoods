using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGoods.Model.DTO
{
    public class TransactionDTO
    {
        public int TransactionID { get; set; }
        public int TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TotalTransactionPrice { get; set; }
        public int UserID { get; set;}
    }
}
