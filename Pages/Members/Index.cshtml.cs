﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Goldan_Maria_Valentina_lab2.Data;
using Goldan_Maria_Valentina_lab2.Models;

namespace Goldan_Maria_Valentina_lab2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Goldan_Maria_Valentina_lab2.Data.Goldan_Maria_Valentina_lab2Context _context;

        public IndexModel(Goldan_Maria_Valentina_lab2.Data.Goldan_Maria_Valentina_lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
