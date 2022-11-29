﻿using Api.Interfaces;
using Api.ViewModel;
using RestSharp;
using Newtonsoft.Json;

namespace Api.Services
{
    public class HttpRestSharpService : IHttpService
    {
        public async Task<ResponseCepViewModel> Get(string cep, string uri)
        {
            var url = $"{uri}/{cep}/json";
            //var client = new RestClient(url);
            //var request = new RestRequest(uri, Method.Get);
            //request.AddHeader("Content-Type", "application/json");
            //RestResponse response = await client.ExecuteAsync(request);
            ////var result = response.Content;
            //var result = JsonConvert.DeserializeObject<ResponseCepViewModel>(response.Content);

            var client = new RestClient(url);
            var request = new RestRequest(url);
            var response = await client.GetAsync(request);
            var result = JsonConvert.DeserializeObject<ResponseCepViewModel>(response.Content);


            return result;

        }
    }
}