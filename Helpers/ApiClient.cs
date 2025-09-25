using Microsoft.Extensions.Configuration;
using Siad.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SiadApiClient.Helpers
{
    public class ApiClient
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;
        string _BASE_URL = "https://lapem.cfe.gob.mx/sid_evaluacion/";
 

        public ApiClient (string MODULE, string ENDPOINT){
            _client = new HttpClient
            {
                BaseAddress = new Uri($"{_BASE_URL}{MODULE}/{ENDPOINT}")
            };

            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJFREVSIERBRU4gU0FMVkFET1IgVklMTEVHQVMiLCJmdWxsTmFtZSI6IkVERVIgREFFTiBTQUxWQURPUiBWSUxMRUdBUyIsInVzZXJuYW1lIjoiZS5zdmlsbGVnYXNAY29uZHVtZXguY29tLm14IiwicmZjIjoiU0FWRTAxMDUxNUhQMCIsImVtcHJlc2EiOiJFREVSIERBRU4gU0FMVkFET1IgVklMTEVHQVMiLCJJZEVtcHJlc2EiOiI2ODUyMiIsInJvbGUiOiJVc2VyIiwiaXAiOiIxMC40NC42Ni4yOCIsIm1heGltb0ludGVudG9zUHJ1ZWJhcyI6IjMiLCJqdGkiOiI1MWEzMGU3MS1lZDM1LTQ1N2YtODNhYi1mYTFhYzVlMDE0NjEiLCJuYmYiOjE3NTg4MjUzODksImV4cCI6MTc1ODkxMTc4OSwiaWF0IjoxNzU4ODI1Mzg5LCJpc3MiOiJodHRwczovL2xhcGVtLmNmZS5nb2IubXgvc2lkLyIsImF1ZCI6Imh0dHBzOi8vbGFwZW0uY2ZlLmdvYi5teC9zaWQvIn0.JO5fqB03Mg_3On_Z55qvKBAaFWDWabZMnHv-ZIsVYTg";
            if (!string.IsNullOrEmpty(token))
            {
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }
            
        }

        public async Task<ResponseDTO> Post(dynamic data, bool serializado = false)
        {
            HttpContent content;

            if (!serializado)
            {
                var json = JsonSerializer.Serialize(data);
                content = new StringContent(json, Encoding.UTF8, "application/json");
            }
            else
            {
                content = data; // ya es HttpContent
            }

            var request = await _client.PostAsync("", content);
            var responseBody = await request.Content.ReadAsStringAsync();

            return new ResponseDTO
            {
                Success = request.IsSuccessStatusCode,
                Code = (int)request.StatusCode,
                Data = responseBody
            };
        }


        public async Task<ResponseDTO> Get() {

       
            var request = await _client.GetAsync("");
            var responseBody = await request.Content.ReadAsStringAsync();
            var response = new ResponseDTO
                {
                    Success = request.IsSuccessStatusCode,
                    Code = (int)request.StatusCode,
                    Data = responseBody               
            };
            return response;


        }

        public async Task<ResponseDTO> Put(dynamic data, bool serializado = false)
        {


            HttpContent content;

            if (!serializado)
            {
                var json = JsonSerializer.Serialize(data);
                content = new StringContent(json, Encoding.UTF8, "application/json");
            }
            else
            {
                content = data; 
            }

            var request = await _client.PutAsync("", content);
            var responseBody = await request.Content.ReadAsStringAsync();
            var response =  new ResponseDTO
                {
                    Success = request.IsSuccessStatusCode,
                    Code = (int)request.StatusCode,
                    Data = responseBody
                
            };
            return response;

        }
    }
}
