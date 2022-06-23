using Flowingly.TaxCalculator.Business.DTOs;

namespace Flowingly.TaxCalculator.Business.Services
{
    public interface ITaxCalculatorService
    {
        TaxResultDto Calculate(TaxDto taxDto, double taxPercentage);
    }
}
