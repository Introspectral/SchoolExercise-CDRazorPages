using AlbumLogger.Data;

namespace RazorPages_AlbumProject.Data
{
    public interface IAlbum
    {
        Album GetById(int ID);
        IEnumerable<Album> GetAll();
        void Add(Album album);
        void Update(Album album);
        void Delete(Album albume);
        void SaveChanges();

    }
}
