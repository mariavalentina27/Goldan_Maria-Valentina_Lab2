using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Goldan_Maria_Valentina_lab2.Data;
using Goldan_Maria_Valentina_lab2.Models;

namespace Goldan_Maria_Valentina_lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Goldan_Maria_Valentina_lab2.Data.Goldan_Maria_Valentina_lab2Context _context;

        public DetailsModel(Goldan_Maria_Valentina_lab2.Data.Goldan_Maria_Valentina_lab2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
