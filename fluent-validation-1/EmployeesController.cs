using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace fluent_validation_1;

[ApiController]
[Route("api/employees")]
public class EmployeesController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateEmployee([FromBody] CreateEmployeeInput input)
    {
        var validate = new CreateEmployeeInputValidate().Validate(input);

        if (!validate.IsValid)
        {
            //
            return BadRequest(new CustomValidationResult(validate));
        }
        return Created(string.Empty, input);
    }
}
