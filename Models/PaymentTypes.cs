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

        public PaymentTypesCollection()
        {
            paymentTypes = new List<PaymentTypes>()
            {
                new PaymentTypes() { Id=1, PaymentType="PhysicalProduct" },
                new PaymentTypes() { Id=2, PaymentType="Books" },
                new PaymentTypes() { Id=3, PaymentType="Video" },
                new PaymentTypes() { Id=4, PaymentType="Membership" }
            };
        }
    }
}
