using Flowingly.TaxCalculator.Api.Models;
using Flowingly.TaxCalculator.Business.DTOs;
using Flowingly.TaxCalculator.Business.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace Flowingly.TaxCalculator.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly ILogger<TaxController> logger;
        private readonly IConfiguration configuration;
        private readonly ITaxCalculatorService taxCalculatorService;

        public TaxController(ILogger<TaxController> logger, IConfiguration Configuration, ITaxCalculatorService taxCalculatorService)
        {
            this.logger = logger;
            configuration = Configuration;
            this.taxCalculatorService = taxCalculatorService;
        }
        [HttpPost]
        public IActionResult CalculateTax(TaxDto taxDto)
        {
            try
            {
                var appSetting = new AppSetting();
                configuration.GetSection("AppSettings").Bind(appSetting);

                var result = taxCalculatorService.Calculate(taxDto, appSetting.TaxPercentage);
                return Ok(result);
            }
            catch (Exception exception)
            {
                logger.LogError(exception.Message);
                return StatusCode(500, "Some Error.Please contact app administrator");
            }

        }
    }
}
