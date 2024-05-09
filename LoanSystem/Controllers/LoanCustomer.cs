using LoanSystem.System.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoanSystem.Controllers
{
    [ApiController]
    [Route("/customer-loans")]
    public class LoanCustomer:ControllerBase
    {
        [HttpPost]
        public IActionResult PossibilitiesOfLoans(Request request)
        {
            var response = new Response(request);
            return Ok(response);
        }
    }
}
