using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlbumLogger.Data;
using RazorPages_AlbumProject.Data;

namespace RazorPages_AlbumProject.Pages.Albums
{
    public class DeleteModel : PageModel
    {
        private readonly IAlbum AlbumRep;

        public DeleteModel(IAlbum AlbumRep)
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
            else 
            {
                Album = album;
            }
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            if (AlbumRep == null)
            {
                return NotFound();
            }
            var album = AlbumRep.GetById(id);

            if (album != null)
            {
                Album = album;
                AlbumRep.Delete(album);
                AlbumRep.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}
