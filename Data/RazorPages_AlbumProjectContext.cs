using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlbumLogger.Data;

namespace RazorPages_AlbumProject.Data
{
    public class RazorPages_AlbumProjectContext : DbContext
    {
        public DbSet<AlbumLogger.Data.Album> Album { get; set; } = default!;

        public DbSet<AlbumLogger.Data.Song> Song { get; set; } = default!;
        public RazorPages_AlbumProjectContext(DbContextOptions<RazorPages_AlbumProjectContext> options)
            : base(options)
        {

        }

    }
}
