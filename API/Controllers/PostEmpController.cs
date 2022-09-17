using Entity;
using Microsoft.AspNetCore.Mvc;
using ProcessLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
 
    [ApiController]
    public class PostEmpController : ControllerBase
    {

        private IEmployeeProcess _IEmp;
        public PostEmpController(IEmployeeProcess _IEmp)
        {
            this._IEmp = _IEmp;
        }

        [HttpPost]
        [Route ("api/PostEmployee")]
        public IActionResult PostEmployee([FromBody] Employee  emp)
        {
            if (ModelState.IsValid) {
               if(_IEmp.PostEmplyee(emp))
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
             
            }
            else
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }

        }

        //Delete
        [HttpPost]
        [Route("api/DeleteEmployee")]
        public IActionResult DeleteEmployee([FromBody] Employee emp)
        {
            if (ModelState.IsValid)
            {
                if (_IEmp.DeleteEmployee(emp))
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

            }
            else
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }

        }
    }

      
    }

