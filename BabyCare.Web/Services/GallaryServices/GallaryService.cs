
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.DataAccess.Settings;
using BabyCare.Web.Services.GenericService;

namespace BabyCare.Web.Services.GallaryServices
{
    public class GallaryService : GenericService<Gallary>, IGallaryService
    {
        public GallaryService(IDataBaseSettings settings) : base(settings , settings.GallaryCollectionName)
        {
        }
    }
}
