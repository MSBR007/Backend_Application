using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
        [HttpGet]
        [Route("AddNumbers")]
        public async Task<IActionResult> AddNumbers(decimal? firstNumber, decimal? secondNumber)
        {
            if (firstNumber != null && secondNumber != null)
            {
                return Ok(await Task.FromResult(firstNumber + secondNumber));
            }
            else
            {
                return BadRequest("Both numbers must be provided.");
            }
        }

        [HttpGet]
        [Route("SubtractNumbers")]
        public async Task<IActionResult> SubtractNumbers(decimal? firstNumber, decimal? secondNumber)
        {
            if (firstNumber != null && secondNumber != null)
            {
                return Ok(await Task.FromResult(firstNumber - secondNumber));
            }
            else
            {
                return BadRequest("Both numbers must be provided.");
            }
        }

        [HttpGet]
        [Route("MultiplyNumbers")]
        public async Task<IActionResult> MultiplyNumbers(decimal? firstNumber, decimal? secondNumber)
        {
            if (firstNumber != null && secondNumber != null)
            {
                return Ok(await Task.FromResult(firstNumber * secondNumber));
            }
            else
            {
                return BadRequest("Both numbers must be provided.");
            }
        }

        [HttpGet]
        [Route("DivideNumbers")]
        public async Task<IActionResult> DivideNumbers(decimal? firstNumber, decimal? secondNumber)
        {
            if (firstNumber != null && secondNumber != null)
            {
                if (secondNumber != 0)
                {
                    return Ok(await Task.FromResult(firstNumber / secondNumber));
                }
                else
                {
                    return BadRequest("Second number should not be zero when dividing");
                }
                
            }
            else
            {
                return BadRequest("Both numbers must be provided.");
            }
        }
    }
}
