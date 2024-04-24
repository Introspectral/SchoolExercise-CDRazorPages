using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlbumLogger.Data;
using RazorPages_AlbumProject.Data;

namespace RazorPages_AlbumProject.Pages.Songs
{
    public class IndexModel : PageModel
    {
        private readonly ISong SongRep;

        public IndexModel(ISong SongRep)
        {
            this.SongRep = SongRep;
        }

        public IList<Song>? Song { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (SongRep != null)
            {
                Song = SongRep.GetAll().ToList();
            }
        }
    }
}
