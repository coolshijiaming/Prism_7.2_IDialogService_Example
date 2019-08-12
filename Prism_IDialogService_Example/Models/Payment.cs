using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism_IDialogService_Example.Models
{
    public class Payment
    {
        public DateTime? PaymentDate { get; set; }
        public DateTime? PaymentEndDate { get; set; }
        public string Note { get; set; }
        public double? AmountOwed { get; set; }
        public double AmoundPayed { get; set; }
    }
}
