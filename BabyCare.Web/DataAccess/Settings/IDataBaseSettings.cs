namespace BabyCare.Web.DataAccess.Settings
{
    public interface IDataBaseSettings
    {
        public string ConnectionString { get; set; }  // MongoDB bağlantı adresi
        public string DatabaseName { get; set; }      // Kullanılacak veritabanı adı
        public string ProductCollectionName { get; set; }   // Koleksiyon adı
        public string InstructorCollectionName { get; set; }   // Koleksiyon adı
    }
}
