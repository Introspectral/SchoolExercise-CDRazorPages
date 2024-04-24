using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AlbumLogger.Data;
using RazorPages_AlbumProject.Data;

namespace RazorPages_AlbumProject.Pages.Songs
{
    public class CreateModel : PageModel
    {
        private readonly ISong songRep;

        public CreateModel(ISong SongRep)
        {
            songRep = SongRep;
        }


        public IActionResult OnGet(int id)
        {
            Song = new Song();
            Song.RecordID = id;
            return Page();
        }

        [BindProperty]
        public Song Song { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(Song song)
        {
            if (!ModelState.IsValid || songRep == null || Song == null)
            {
                return Page();
            }

            songRep.Add(song);
            songRep.SaveChanges();

            return RedirectToPage("/Albums/Details", new { id = Song.RecordID });
        }
    }
}
