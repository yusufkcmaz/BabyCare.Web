using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.DataAccess.Settings;
using BabyCare.Web.Services.GenericService;

namespace BabyCare.Web.Services.BannerService
{
    public class BannerService : GenericService<Banner>, IBannerService
    {
        public BannerService(IDataBaseSettings settings) : base(settings, settings.BannerCollectionName)
        {
        }
    }
}
