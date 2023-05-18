using Microsoft.AspNetCore.Mvc;
using personnel_access_control.Models;
using personnel_access_control.Services;

namespace personnel_access_control.Controllers
{
    [Route("api/Access")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        private readonly IAccessService _accessService;
        public AccessController(IAccessService accessService)
        {
            _accessService = accessService;
        }

        [HttpPost("AccessRegister")]
        public ActionResult AccessRegister(RegisterAccessDto registerAccessDto)
        {
            try
            {
                _accessService.AccessRegister(registerAccessDto);
                return Ok("Access registered successfully");
            }
            catch (ArgumentException exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet("Search")]
        public ActionResult<SearchDto> Search(DateTime dateFrom, DateTime dateTo, string? descriptionFilter, int companyBranchId)
        {
            try
            {
                var response = _accessService.Search(dateFrom, dateTo, descriptionFilter, companyBranchId);
                return Ok(response);
            }
            catch (ArgumentException exception)
            {

                return BadRequest(exception.Message);
            }
        }

        [HttpGet("Average")]
        public ActionResult<AverageDto> Average(DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                var response = _accessService.Average(dateFrom, dateTo);
                return Ok(response);
            }
            catch (ArgumentException exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
