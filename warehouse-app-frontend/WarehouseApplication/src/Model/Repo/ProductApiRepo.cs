using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseApplication.src.Model.Object;

namespace WarehouseApplication.src.Model.Repo
{
    public class ProductApiRepo
    {
        private const string baseUrl = "http://localhost:5000/api";
        private RestClient client;
        private RestRequest req;
        private IRestResponse res;
        private ApiResponse<Products> response;
        private Users user;

        public ProductApiRepo(Users _user)
        {
            this.client = new RestClient(baseUrl);
            this.user = _user;
        }

        public async Task<ApiResponse<Products>> add(Products product)
        {
            try
            {
                const string endpoint = "/desktop/product/add";

                this.req = new RestRequest(endpoint);

                // Convert Object to JSON
                string productData = JsonConvert.SerializeObject(product);

                // Add Body
                this.req.AddParameter("application/json; charset=utf-8", productData, ParameterType.RequestBody);
                this.req.RequestFormat = DataFormat.Json;

                this.res = await this.client.ExecuteAsync(this.req, Method.POST);

                this.response = JsonConvert.DeserializeObject<ApiResponse<Products>>(this.res.Content);

                if (this.response.status != 201)
                {
                    this.response.data = new List<Products>();
                    return this.response;
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse<Products>
                {
                    status = 500,
                    message = ex.Message,
                    data = new List<Products>()
                };
            }

            return this.response;
        }

        public async Task<ApiResponse<Products>> getAll()
        {
            try
            {
                const string endpoint = "/desktop/product/get";

                this.req = new RestRequest(endpoint);

                this.res = await this.client.ExecuteAsync(this.req, Method.GET);

                this.response = JsonConvert.DeserializeObject<ApiResponse<Products>>(this.res.Content);

                if (this.response.status != 200)
                {
                    this.response.data = new List<Products>();
                    return this.response;
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse<Products>
                {
                    status = 500,
                    message = ex.Message,
                    data = new List<Products>()
                };
            }

            return this.response;
        }

        public async Task<ApiResponse<Products>> getById(string productId)
        {
            try
            {
                string endpoint = "/desktop/product/get/" + productId;

                this.req = new RestRequest(endpoint);

                this.res = await this.client.ExecuteAsync(this.req, Method.GET);

                this.response = JsonConvert.DeserializeObject<ApiResponse<Products>>(this.res.Content);

                if (this.response.status != 200)
                {
                    this.response.data = new List<Products>();
                    return this.response;
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse<Products>
                {
                    status = 500,
                    message = ex.Message,
                    data = new List<Products>()
                };
            }

            return this.response;
        }

        public async Task<ApiResponse<Products>> getByName(string productName)
        {
            try
            {
                string endpoint = "/desktop/product/get?productName=" + productName;

                this.req = new RestRequest(endpoint);

                this.res = await this.client.ExecuteAsync(this.req, Method.GET);

                this.response = JsonConvert.DeserializeObject<ApiResponse<Products>>(this.res.Content);

                if (this.response.status != 200)
                {
                    this.response.data = new List<Products>();
                    return this.response;
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse<Products>
                {
                    status = 500,
                    message = ex.Message,
                    data = new List<Products>()
                };
            }
            return this.response;
        }

        public async Task<ApiResponse<Products>> update(Products product, string id)
        {
            try
            {
                string endpoint = "/desktop/product/put/" + id;

                this.req = new RestRequest(endpoint);

                // Convert Object to JSON
                string productData = JsonConvert.SerializeObject(product);

                // Add Body
                this.req.AddParameter("application/json; charset=utf-8", productData, ParameterType.RequestBody);
                this.req.RequestFormat = DataFormat.Json;

                this.res = await this.client.ExecuteAsync(this.req, Method.PUT);

                this.response = JsonConvert.DeserializeObject<ApiResponse<Products>>(this.res.Content);

                if (this.response.status != 200)
                {
                    this.response.data = new List<Products>();
                    return this.response;
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse<Products>
                {
                    status = 500,
                    message = ex.Message,
                    data = new List<Products>()
                };
            }

            return this.response;
        }

        public async Task<ApiResponse<Products>> delete(string productId)
        {
            string endpoint = "/desktop/product/delete/" + productId;

            this.req = new RestRequest(endpoint);

            this.res = await this.client.ExecuteAsync(this.req, Method.DELETE);

            this.response = JsonConvert.DeserializeObject<ApiResponse<Products>>(this.res.Content);

            if (this.response.status != 200)
            {
                this.response.data = new List<Products>();
                return this.response;
            }

            return this.response;
        }
    }
}
