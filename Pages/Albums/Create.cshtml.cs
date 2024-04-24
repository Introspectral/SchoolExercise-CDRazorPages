using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AlbumLogger.Data;
using RazorPages_AlbumProject.Data;

namespace RazorPages_AlbumProject.Pages.Albums
{
    public class CreateModel : PageModel
    {
        private readonly IAlbum AlbumRep;

        public CreateModel(IAlbum AlbumRep)
        {
            this.AlbumRep = AlbumRep;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Album Album { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(Album album)
        {
          if (!ModelState.IsValid || AlbumRep == null || Album == null)
            {
                return Page();
            }

            AlbumRep.Add(Album);
            
            AlbumRep.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
