using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.DataAccess.Settings;
using BabyCare.Web.Services.GenericService;

namespace BabyCare.Web.Services.MessageService
{
    public class MessageService : GenericService<Message>, IMessageService
    {
        public MessageService(IDataBaseSettings settings) : base(settings , settings.MessageCollectionName )
        {
        }
    }
}
