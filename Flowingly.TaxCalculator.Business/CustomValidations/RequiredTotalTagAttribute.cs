using HtmlAgilityPack;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Flowingly.TaxCalculator.Business.CustomValidations
{
    public class RequiredTotalTagAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string strValue = value as string;

            var htmlDoc = new HtmlDocument();

            htmlDoc.LoadHtml(strValue);

            return htmlDoc.DocumentNode
                                .Descendants("total")
                                .Any();
        }
    }
}
