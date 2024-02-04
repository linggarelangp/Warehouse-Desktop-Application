using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseApplication.src.Model.Object;

namespace WarehouseApplication.src.Model.Repo
{
    public class TransactionApiRepo
    {
        private const string baseUrl = "http://localhost:5000/api";
        private RestClient client;
        private RestRequest req;
        private IRestResponse res;
        private ApiResponse<Transaction> response;

        public TransactionApiRepo()
        {
            this.client = new RestClient(baseUrl);
        }

        public async Task<ApiResponse<Transaction>> add(Transaction transaction)
        {
            try
            {
                const string endpoint = "/desktop/transaction/add";

                this.req = new RestRequest(endpoint);

                // Convert Object to JSON
                string transactionData = JsonConvert.SerializeObject(transaction);

                // Add Body
                this.req.AddParameter("application/json; charset=utf-8", transactionData, ParameterType.RequestBody);
                this.req.RequestFormat = DataFormat.Json;

                this.res = await this.client.ExecuteAsync<ApiResponse<Transaction>>(this.req, Method.POST);

                this.response = JsonConvert.DeserializeObject<ApiResponse<Transaction>>(this.res.Content);

                if (this.response.status != 201)
                {
                    this.response.data = new List<Transaction>();
                    return this.response;
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse<Transaction>
                {
                    status = 500,
                    message = ex.Message,
                    data = new List<Transaction>()
                };
            }

            return this.response;
        }

        public async Task<ApiResponse<Transaction>> getAll(string userId)
        {
            try
            {
                string endpoint = "/desktop/transaction/get/" + userId;

                this.req = new RestRequest(endpoint);

                this.res = await this.client.ExecuteAsync(this.req, Method.GET);

                this.response = JsonConvert.DeserializeObject<ApiResponse<Transaction>>(this.res.Content);

                if (this.response.status != 200)
                {
                    this.response.data = new List<Transaction>();
                    return this.response;
                }

            }
            catch (Exception ex)
            {
                return new ApiResponse<Transaction>
                {
                    status = 500,
                    message = ex.Message,
                    data = new List<Transaction>()
                };
            }

            return this.response;
        }

        public async Task<ApiResponse<Transaction>> getById(string id, string userId)
        {
            try
            {
                string endpoint = $"/desktop/transaction/get/{id}/{userId}";

                this.req = new RestRequest(endpoint);

                this.res = await this.client.ExecuteAsync(this.req, Method.GET);

                this.response = JsonConvert.DeserializeObject<ApiResponse<Transaction>>(this.res.Content);

                if (this.response.status != 200)
                {
                    this.response.data = new List<Transaction>();
                    return this.response;
                }

            }
            catch (Exception ex)
            {
                return new ApiResponse<Transaction>
                {
                    status = 500,
                    message = ex.Message,
                    data = new List<Transaction>()
                };
            }

            return this.response;
        }

        public async Task<ApiResponse<Transaction>> getByProductname(string userId, string productName)
        {
            try
            {
                string endpoint = $"/desktop/transaction/get/product/{userId}?productName=" + productName;

                this.req = new RestRequest(endpoint);

                this.res = await this.client.ExecuteAsync(this.req, Method.GET);

                this.response = JsonConvert.DeserializeObject<ApiResponse<Transaction>>(this.res.Content);

                if (this.response.status != 200)
                {
                    this.response.data = new List<Transaction>();
                    return this.response;
                }

            }
            catch (Exception ex)
            {
                return new ApiResponse<Transaction>
                {
                    status = 500,
                    message = ex.Message,
                    data = new List<Transaction>()
                };
            }

            return this.response;
        }
    }
}