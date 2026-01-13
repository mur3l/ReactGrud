using Microsoft.AspNetCore.Mvc;
using ReactGrud.Data;
using ReactGrud.Server.ViewModels;

namespace ReactGrud.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolController : ControllerBase
    {
        private readonly ReactCrudContext _context;

        public SchoolController
            (
                ReactCrudContext context
            )

        {
            _context = context;
        }

        [HttpGet(Name = "SchoolList")]
        public IActionResult Index()
        {
            var result = _context.Schools
                .Select(x => new SchoolListViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address,
                    StudentCount = x.StudentCount
                })
            .ToList();

            return Ok(result);
        }
    }
}
