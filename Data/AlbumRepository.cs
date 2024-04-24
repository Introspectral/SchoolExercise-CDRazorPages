using AlbumLogger.Data;
using RazorPages_AlbumProject.Data;

    public class AlbumRepository : IAlbum
    {
        private readonly RazorPages_AlbumProjectContext applicationDbContext;

        public AlbumRepository(RazorPages_AlbumProjectContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public void Add(Album album)
        {
            applicationDbContext.Add(album);
        }

        public void Delete(Album album)
        {
            applicationDbContext.Remove(album);
        }

        public IEnumerable<Album> GetAll()
        {
            return applicationDbContext.Album.OrderBy(x => x.AlbumId);
        }

        public Album GetById(int ID)
        {
            return applicationDbContext.Album.Find(ID);
        }

        public void SaveChanges()
        {
            applicationDbContext.SaveChanges();
        }

        public void Update(Album album)
        {
            applicationDbContext.Update(album);
        }
    }

            

  
