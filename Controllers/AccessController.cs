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
        public ActionResult AccessRegister(RegisterAccessDto AccessData) 
        {
            var SuccessfulReg = _accessService.AccessRegister(AccessData);

            if (!SuccessfulReg)
            {
                return BadRequest("Error in access register");
            }

            return Ok("Access registered successfully");

        }
    }
}
