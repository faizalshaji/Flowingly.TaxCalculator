using Flowingly.TaxCalculator.Business.DTOs;
using Flowingly.TaxCalculator.Business.Extensions;
using Flowingly.TaxCalculator.Business.Models;
using System.IO;
using System.Xml.Serialization;

namespace Flowingly.TaxCalculator.Business.Services
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        public TaxResultDto Calculate(TaxDto taxDto, double taxPercentage)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(expense));
            using (TextReader reader = new StringReader(taxDto.Text))
            {
                var expense = (expense)serializer.Deserialize(reader);

                double total = expense.total.ToDouble();
                double totalExcludingSalesTax = GetTotalExcludingSalesTax(taxPercentage, total);

                return new TaxResultDto()
                {
                    CostCentre = expense.cost_centre,
                    Total = total,
                    PaymentMethod = expense.payment_method,
                    SalesTaxPercentage = 5,
                    TotalExcludingSalesTax = totalExcludingSalesTax,
                    SalesTax = totalExcludingSalesTax * taxPercentage / 100
                };
            }
        }

        private static double GetTotalExcludingSalesTax(double taxPercentage, double total)
        {
            return total - (total / (1 + (taxPercentage / 100)) * (taxPercentage / 100));
        }
    }
}
