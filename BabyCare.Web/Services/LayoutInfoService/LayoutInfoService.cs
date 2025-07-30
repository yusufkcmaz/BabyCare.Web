using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.DataAccess.Settings;
using BabyCare.Web.Services.GenericService;

namespace BabyCare.Web.Services.LayoutInfoService
{
    public class LayoutInfoService : GenericService<LayoutInfo>, ILayoutInfoService
    {
        public LayoutInfoService(IDataBaseSettings settings) : base(settings , settings.LayoutInfoCollectionName )
        {
        }
    }
}
