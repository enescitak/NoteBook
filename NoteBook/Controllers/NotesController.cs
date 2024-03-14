using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NoteBook.Controllers
{
    public class HomeController : Controller 
    {
        // GET: /<controller>
        public IActionResult Index()
        {
            return View();
        }

        //public async Task<IActionResult> ListNotes()
        //{
        //    var notes = await _context.Users
        //                              .Where(n => n.id == User.Identity.)
        //                              .ToListAsync();
        //    return View(notes);
        //}
    }
}

