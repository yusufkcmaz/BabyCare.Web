using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.DataAccess.Settings;
using BabyCare.Web.Services.GenericService;

namespace BabyCare.Web.Services.EventService
{
    public class EventService : GenericService<Event>, IEventService
    {
        public EventService(IDataBaseSettings settings) : base(settings, settings.EventCollectionName)
        {
        }
    }
}
