using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using api_test.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;
        private EmployeeDataAccess employeeDataAccess;

        public EmployeesController(ILogger<EmployeesController> logger)
        {
            employeeDataAccess = new EmployeeDataAccess();
            _logger = logger;
        }

        public IActionResult Get() {

            string actionName = this.ControllerContext.RouteData.Values["action"].ToString();
            string controllerName = this.ControllerContext.RouteData.Values["controller"].ToString();
            List<Employee> employees = new List<Employee>();
            try
            {
                employees = employeeDataAccess.GetEmployeeList();
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    action = actionName + "/" + controllerName,
                    isError = true,
                    message = ex.Message,
                    responseException = ex,
                    result = employees,
                    statusCode = HttpStatusCode.BadRequest,
                    version = Assembly.GetExecutingAssembly().GetName().Version.ToString()
                });
            }


            return Ok(new
            {
                action = actionName + "/" + controllerName,
                isError = false,
                message = "Successful",
                responseException = "(null)",
                result = employees,
                statusCode = HttpStatusCode.OK,
                version = Assembly.GetExecutingAssembly().GetName().Version.ToString()
            });
        }

    }
}
