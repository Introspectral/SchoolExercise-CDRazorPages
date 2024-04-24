using AlbumLogger.Data;
using RazorPages_AlbumProject.Data;

public class SongRepository : ISong
{
    private readonly RazorPages_AlbumProjectContext applicationDbContext;

    public SongRepository(RazorPages_AlbumProjectContext applicationDbContext)
    {
        this.applicationDbContext = applicationDbContext;
    }

    public void Add(Song song)
    {
        applicationDbContext.Add(song);
    }

    public void Delete(Song song)
    {
        applicationDbContext.Remove(song);
    }

    public IEnumerable<Song> GetAll()
    {
        return applicationDbContext.Song.OrderBy(x => x.SongId);
    }

    public Song GetById(int id)
    {
        return applicationDbContext.Song.Find(id);
    }

    public void SaveChanges()
    {
        applicationDbContext.SaveChanges();
    }

    public void Update(Song song)
    {
        applicationDbContext.Update(song);
    }
}