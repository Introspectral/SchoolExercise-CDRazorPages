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
    public class IndexModel : PageModel
    {
        private readonly IAlbum AlbumRep;

        public IndexModel(IAlbum AlbumRep)
        {
            this.AlbumRep = AlbumRep;
        }

        public IList<Album> Album { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (AlbumRep != null)
            {
                Album = AlbumRep.GetAll().ToList();
            }
        }
    }
}
