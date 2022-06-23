using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowingly.TaxCalculator.Business.Extensions
{
    public static class StringToDoubleExtension
    {
        public static double ToDouble(this string input)
        {
            var totalAsString = input.Replace(",", "");
            double.TryParse(totalAsString, NumberStyles.Any, CultureInfo.InvariantCulture, out double output);
            return output;
        }
    }
}
