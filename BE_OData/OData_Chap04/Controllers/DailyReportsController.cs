using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using OData_Chap04.Context;

namespace OData_Chap04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyReportsController : ControllerBase
    {
        private readonly ODataContext _context;

        public DailyReportsController(ODataContext context)
        {
            _context = context;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.DailyReports);
        }
    }
}
