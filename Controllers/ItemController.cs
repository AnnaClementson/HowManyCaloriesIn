using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowManyCaloriesIn.Models;

namespace HowManyCaloriesIn.Controllers
{
    public class ItemController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ItemInformationContext iic = new ItemInformationContext();
            List<Item> myItems = iic.Items.ToList();
            return View(myItems);
        }
    }
}
