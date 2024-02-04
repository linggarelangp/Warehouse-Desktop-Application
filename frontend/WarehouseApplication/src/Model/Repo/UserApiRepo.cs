using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseApplication.src.Model.Object;

namespace WarehouseApplication.src.Model.Repo
{
    public class UserApiRepo
    {
        private string baseUrl = "http://localhost:5000/api";
        private RestClient client;
        private RestRequest req;
        private IRestResponse res;
        private ApiResponse<Users> response;
        private Users user;

        public UserApiRepo(Users _user)
        {
            this.client = new RestClient(this.baseUrl);
            this.user = _user;
        }

        public async Task<ApiResponse<Users>> login()
        {
            try
            {
                // Get API Destination
                const string endpoint = "/user/login";

                this.req = new RestRequest(endpoint);

                // Convert Object to JSON
                string userData = JsonConvert.SerializeObject(this.user);

                // Create Parameters For an API
                this.req.AddParameter("application/json; charset=utf-8", userData, ParameterType.RequestBody);
                this.req.RequestFormat = DataFormat.Json;

                // Execute and Get Data From API
                this.res = await this.client.ExecuteAsync(this.req, Method.POST);

                // Convert Response JSON Data From API to Object
                this.response = JsonConvert.DeserializeObject<ApiResponse<Users>>(this.res.Content);

                // Handling Response If Status is 500
                if (this.response.status == 500)
                {
                    return new ApiResponse<Users>
                    {
                        status = 500,
                        message = "Couldn\'t Write to Database",
                        data = new List<Users>()
                    };
                }

                // Handling Response If Status Not Equals to 200 (OK)
                if (this.response.status != 200)
                {
                    this.response.data = new List<Users>();
                    return this.response;
                }
            }
            catch (Exception ex)
            {
                // Handling If Server API Error
                return new ApiResponse<Users>
                {
                    status = 500,
                    message = $"Internal Server Error \n Error : {ex.Message}",
                    data = new List<Users>()
                };
            }

            // Return Data if status 200 (OK)
            return this.response;
        }
    }
}
