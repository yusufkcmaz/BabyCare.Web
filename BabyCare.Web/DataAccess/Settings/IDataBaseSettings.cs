namespace BabyCare.Web.DataAccess.Settings
{
    public interface IDataBaseSettings
    {
        public string ConnectionString { get; set; }  // MongoDB bağlantı adresi
        public string DatabaseName { get; set; }      // Kullanılacak veritabanı adı
        public string ProductCollectionName { get; set; }   // Koleksiyon adı
        public string InstructorCollectionName { get; set; }   // Koleksiyon adı
         string AboutCollectionName { get; set; }
        string BannerCollectionName { get; set; }
        string ContactCollectionName { get; set; }
        string EventCollectionName { get; set; }
        string GallaryCollectionName { get; set; }
        string ServicesCollectionName { get; set; }
        string MessageCollectionName { get; set; }

    }
}
