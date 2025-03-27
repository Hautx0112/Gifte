using Gifte.Repositories.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifte.Services.BusinessModel.PaymentModel
{
    public class ConfirmPayment
    {
        public string? BankTranNo { get; set; }

        public string? BankCode { get; set; }

        public string? TransactionNo { get; set; }

        public PaymentStatus PaymentStatus { get; set; }
    }
}
