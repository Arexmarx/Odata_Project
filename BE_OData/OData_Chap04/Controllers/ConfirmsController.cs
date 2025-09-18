using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers; 
using OData_Chap04.Context;

namespace OData_Chap04.Controllers
{
    [Route("api/[controller]")] 
    public class ConfirmsController : ControllerBase
    {
        private readonly ODataContext _context;

        public ConfirmsController(ODataContext context)
        {
            _context = context;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Confirmeds);
        }
    }
}
