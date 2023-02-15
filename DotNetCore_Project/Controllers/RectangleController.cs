using DotNetCore_Project.Interfaces;
using DotNetCore_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RectangleController : ControllerBase
    {
        private readonly IRectangleService _rectangleService;

        public RectangleController(IRectangleService rectangleService)
        {
            _rectangleService = rectangleService;
        }

        [HttpPost]
        public IActionResult AreaOfRectangle()
        {
            try
            {
                var rec = new Rectangle();
                rec.Lenghth = 20;
                rec.Breadth = 15;

                var l = rec.Lenghth;
                var b = rec.Breadth;

                var res = _rectangleService.AreaOfRectangle(l, b);

                return Ok(res);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}