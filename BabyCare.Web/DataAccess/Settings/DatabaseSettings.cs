namespace BabyCare.Web.DataAccess.Settings
{
    public class DatabaseSettings : IDataBaseSettings
    {
        public string ConnectionString { get; set; }  
        public string DatabaseName { get; set; }     
        public string ProductCollectionName { get; set; }   
        public string InstructorCollectionName { get; set; }
        public string AboutCollectionName { get; set; }

    }
}
