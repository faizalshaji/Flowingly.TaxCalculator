namespace Flowingly.TaxCalculator.Business.Models
{
    public class expense
    {

        private string _cost_centre;

        public string cost_centre
        {
            get
            {
                return string.IsNullOrEmpty(_cost_centre) ? "UNKNOWN" : _cost_centre;
            }
            set { _cost_centre = value; }
        }



        public string total { get; set; }

        public string payment_method { get; set; }
    }
}



