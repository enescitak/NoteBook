using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NoteBook.Data;
using NoteBook.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NoteBook.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;


        public AccountController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Users
                                         .FirstOrDefaultAsync(u => u.username == model.username
                                                                && u.password == model.password);
                if (user != null)
                {
                    // Kullanıcı doğrulaması başarılı, ListNotes view'ına yönlendir
                    return RedirectToAction("ListNotes");
                }
                else
                {
                    // Kullanıcı adı veya şifre hatalı, hata mesajı ekle ve view'ı geri döndür
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }
            return View(model);
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

