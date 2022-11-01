﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Goldan_Maria_Valentina_lab2.Data;
using Goldan_Maria_Valentina_lab2.Models;
using Goldan_Maria_Valentina_lab2.Models.ViewModels;

namespace Goldan_Maria_Valentina_lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Goldan_Maria_Valentina_lab2.Data.Goldan_Maria_Valentina_lab2Context _context;

        public IndexModel(Goldan_Maria_Valentina_lab2.Data.Goldan_Maria_Valentina_lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;
        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoryIndexData();
            CategoryData.Categories = await _context.Category
                .Include(i => i.BookCategories)
                    .ThenInclude(c => c.Book)
            .OrderBy(i => i.CategoryName)
            .ToListAsync();

            if (id != null)
            {
                CategoryID = id.Value;
                Category publisher = CategoryData.Categories
                .Where(i => i.ID == id.Value).Single();
                CategoryData.Books = Category.BookCategories.Books;
            }

            ///public async Task OnGetAsync()
            ///{
            ///if (_context.Category != null)
            ///{
            ///Category = await _context.Category.ToListAsync();
            ///}
        }
    }
}
