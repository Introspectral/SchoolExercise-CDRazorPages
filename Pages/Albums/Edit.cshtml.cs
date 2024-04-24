using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlbumLogger.Data;
using RazorPages_AlbumProject.Data;

namespace RazorPages_AlbumProject.Pages.Albums
{
    public class EditModel : PageModel
    {
        private readonly IAlbum AlbumRep;

        public EditModel(IAlbum AlbumRep)
        {
            this.AlbumRep = AlbumRep;
        }

        [BindProperty]
        public Album Album { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (AlbumRep == null)
            {
                return NotFound();
            }

            var album = AlbumRep.GetById(id);
            if (album == null)
            {
                return NotFound();
            }
            Album = album;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            try
            {
                AlbumRep.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlbumExists(Album.AlbumId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AlbumExists(int id)
        {
          return AlbumRep.GetAll().Any(e => e.AlbumId == id);
        }
    }
}
