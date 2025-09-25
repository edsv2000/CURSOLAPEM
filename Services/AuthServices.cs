using Siad.Models.DTOs;
using Siad.Models.Responses;
using SiadApiClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Services
{
    public class AuthServices
    {
        public async Task<int> LoginAsync(string username, string password)
        {
            ApiClient request = new ApiClient("F0_Acceso","Login");

            LoginRequest loginRequest = new LoginRequest { 
                username = username,
                password = password 
            };

           ResponseDTO response = await request.Post(loginRequest);

            Console.WriteLine(response.Data);


            return 0;

        }

        public async Task<int> ConfigurarEmpresaAsync()
        {
            ApiClient request = new ApiClient("F0_Acceso", "Configuracion");

            ResponseDTO response = await request.Get();

            Console.WriteLine(response.Data);

            return 0;

        }


    }
}
