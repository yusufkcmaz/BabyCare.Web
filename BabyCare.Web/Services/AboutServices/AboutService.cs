using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.DataAccess.Settings;
using BabyCare.Web.Services.GenericService;

namespace BabyCare.Web.Services.AboutServices
{
    public class AboutService : GenericService<About>, IAboutService
    {
        public AboutService(IDataBaseSettings settings) : base(settings, settings.AboutCollectionName)
        {
        }
    }
}
