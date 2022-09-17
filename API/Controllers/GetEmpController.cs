
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProcessLayer;

namespace API.Controllers
{

    [ApiController]
    public class GetEmpController : ControllerBase
    {
        private IEmployeeProcess _IEmp;
       public GetEmpController(IEmployeeProcess _IEmp)
        {
            this._IEmp = _IEmp;
        }
        [HttpGet]
        [Route("api/getEmployeeList")]
        public IActionResult getEmployeeList()
        {
           return Ok(_IEmp.getEmployeeData());

        }

    }
}
