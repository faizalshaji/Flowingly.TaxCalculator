using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowingly.TaxCalculator.Business.DTOs
{
    public class TaxResultDto
    {
        public string CostCentre { get; set; }

        public double Total { get; set; }

        public string PaymentMethod { get; set; }

        public double SalesTaxPercentage { get; set; }

        public double SalesTax { get; set; }

        public double TotalExcludingSalesTax { get; set; }
    }
}
