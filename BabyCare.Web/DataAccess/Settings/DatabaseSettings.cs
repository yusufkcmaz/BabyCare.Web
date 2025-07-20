namespace BabyCare.Web.DataAccess.Settings
{
    public class DatabaseSettings : IDataBaseSettings
    {
        public string ConnectionString { get; set; }  
        public string DatabaseName { get; set; }     
        public string ProductCollectionName { get; set; }   
        public string InstructorCollectionName { get; set; }
        public string AboutCollectionName { get; set; }
        public string BannerCollectionName { get; set; }
        public string ContactCollectionName  { get; set; }
        public string EventCollectionName  { get; set; }
        public string GallaryCollectionName  { get; set; }
        public string ServicesCollectionName  { get; set; }
        public string MessageCollectionName  { get; set; }

    }
}
