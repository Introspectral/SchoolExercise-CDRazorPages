using RazorPages_AlbumProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace K_popbibliotek.Components
{
    public class SongListViewComponent:ViewComponent
    {
        private readonly ISong iSong;

        public SongListViewComponent(ISong ISong)
        {
            this.iSong = ISong;
        }
        public IViewComponentResult Invoke(int recordId)
        {
            var items = iSong.GetAll().Where(x => x.RecordID == recordId).ToList();
            return View(items);
        }
    }
}
