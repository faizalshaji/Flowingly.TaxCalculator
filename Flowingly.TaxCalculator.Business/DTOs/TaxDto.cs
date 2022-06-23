using Flowingly.TaxCalculator.Business.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowingly.TaxCalculator.Business.DTOs
{
    public class TaxDto
    {
        [Required(ErrorMessage = "Text is required")]
        [Html(ErrorMessage = "Not a valid html string")]
        [RequiredTotalTag(ErrorMessage = "'total' tag is missing")]
        public string Text { get; set; }
    }
}
