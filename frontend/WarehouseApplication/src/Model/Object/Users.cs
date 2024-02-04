namespace WarehouseApplication.src.Model.Object
{
    public class Users
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string roleId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public string refreshToken { get; set; }
        public bool active { get; set; }
    }
}
