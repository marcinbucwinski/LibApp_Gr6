using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp_Gr6.Models;

namespace LibApp_Gr6.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Random()
        {
            var firstBook = new Book() { Name = "English dictionary" };

            return View(firstBook);
        }
    }
}
