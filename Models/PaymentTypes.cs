using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApplication.Models
{
    public class PaymentTypes
    {
        public int Id { get; set; }
        public string PaymentType { get; set; }
    }

    public class PaymentTypesCollection
    {
        public List<PaymentTypes> paymentTypes { get; set; }
    }
}
