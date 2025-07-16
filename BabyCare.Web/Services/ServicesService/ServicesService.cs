using BabyCare.Web.DataAccess.Settings;
using BabyCare.Web.Services.GenericService;

namespace BabyCare.Web.Services.ServicesService
{
    public class ServicesService : GenericService<BabyCare.Web.DataAccess.Entities.Services>, IServicesService
    {
        public ServicesService(IDataBaseSettings settings) : base(settings,settings.ServicesCollectionName)
        {
        }
    }
}
