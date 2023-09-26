using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SLN8Dapper.SERVICE.IService;

namespace SLN8Dapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryMasterController : ControllerBase
    {
        private readonly ICountryMaster _countryMaster;
        public CountryMasterController(ICountryMaster countryMaster) 
        { 
            _countryMaster = countryMaster;
        }
        [HttpGet, Route("get-all-countries")]
        public async Task<IActionResult> GetAllCountries() 
        {
            try
            {
                var getdetails = await _countryMaster.GetAllCountries();
                if (getdetails != null)
                {
                    return Ok(getdetails);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
  