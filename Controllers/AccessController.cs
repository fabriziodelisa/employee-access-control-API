using Microsoft.AspNetCore.Mvc;
using personnel_access_control.Entities;
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
            var successfulReg = _accessService.AccessRegister(registerAccessDto);

            if (!successfulReg)
            {
                return BadRequest("Error in access register");
            }

            return Ok("Access registered successfully");
        }

        [HttpGet("Search")]
        public ActionResult<SearchResponseDto> Search (DateTime dateFrom, DateTime dateTo, 
                                                        string? descriptionFilter, int companyBranchId)
        {
            //if (dateFrom > dateTo)
            //{
            //    return BadRequest("Invalid dates provided. The start date cannot be greater than the end date.");
            //}

            //if (dateTo > DateTime.Now)
            //{
            //    return BadRequest("The provided date is invalid. The end date cannot be greater than the current date.");
            //}
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
    }
}
