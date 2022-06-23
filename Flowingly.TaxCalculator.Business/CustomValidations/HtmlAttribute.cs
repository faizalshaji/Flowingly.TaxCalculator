using HtmlAgilityPack;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Flowingly.TaxCalculator.Business.CustomValidations
{
    public class HtmlAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string strValue = value as string;

            var htmlDoc = new HtmlDocument();

            htmlDoc.LoadHtml(strValue);

            return htmlDoc.ParseErrors.Count() <= 0;
        }
    }
}
