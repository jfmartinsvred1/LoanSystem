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
            return Ok(new Response(request));
        }
    }
}
