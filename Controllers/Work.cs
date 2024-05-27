using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuthSystem.Data;
using AuthSystem.Models;

namespace AuthSystem.Controllers
{
    public class Work : Controller
    {
        private readonly AuthDBContext _context;

        public Work(AuthDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> WorkPage()
        {
            return View(await _context.Items.ToListAsync());
        }
    }
}