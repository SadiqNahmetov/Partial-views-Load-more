using EmbryoFrontToBack.Data;
using EmbryoFrontToBack.Models;
using EmbryoFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmbryoFrontToBack.Controllers
{
    public class AccessoriesController : Controller
    {
        private readonly AppDbContext _context;

        public AccessoriesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Accessories> accessories = await _context.Accessories.Where(m=>!m.IsDeleted).ToListAsync();

            AccessoriesVM accessoriesVM = new AccessoriesVM
            {
               Accessories = accessories
            };
            return View(accessoriesVM);
        }

        public async Task<IActionResult> LoadMore()
        {
            IEnumerable<Accessories> accessories = await _context.Accessories.Where(m=>!m.IsDeleted).Skip(3).Take(3).ToListAsync();
            return View("_ProductsPartial", accessories);
        }

    }
}
