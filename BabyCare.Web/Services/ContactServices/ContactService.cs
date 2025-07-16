using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.DataAccess.Settings;
using BabyCare.Web.Services.GenericService;

namespace BabyCare.Web.Services.ContactServices
{
    public class ContactService : GenericService<Contact>, IContactService
    {
        public ContactService(IDataBaseSettings settings) : base(settings , settings.ContactCollectionName)
        {
        }
    }
}
