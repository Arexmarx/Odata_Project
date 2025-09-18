using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers; // 🔹 Lưu ý import ODataController
using OData_Chap04.Context;

namespace OData_Chap04.Controllers
{
    [Route("odata/[controller]")] // 🔹 Chú ý route OData chuẩn
    public class ConfirmsController : ODataController
    {
        private readonly ODataContext _context;

        public ConfirmsController(ODataContext context)
        {
            _context = context;
        }

        [EnableQuery] // 🔹 Cho phép OData query: $filter, $top, $orderby, $count…
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Confirmeds);
        }
    }
}
