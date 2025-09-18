using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using OData_Chap04.Context;

namespace OData_Chap04.Controllers
{
    public class RecoveredsController : ControllerBase
    {
        private readonly ODataContext _context;

        public RecoveredsController(ODataContext context)
        {
            _context = context;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Recovereds);
        }
    }
}
