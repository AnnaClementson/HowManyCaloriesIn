using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowManyCaloriesIn.Models;
using HowManyCaloriesIn.Data;

namespace HowManyCaloriesIn.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.Item.AsEnumerable();

            return View(items);
        }
    }
}
