using System.Collections.Generic;

namespace WarehouseApplication.src.Model.Object
{
    public class ApiResponse<T>
    {
        public int status { get; set; }
        public string message { get; set; }
        public List<T> data { get; set; }
    }
}
