using Siad.Models.DTOs;
using Siad.Models.Responses;
using SiadApiClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Siad.Services
{
    public class PruebaService
    {
        public async Task ObtenerPruebasAsync()
        {

            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Prueba");
            ResponseDTO response = await request.Get();

            if (response.Success)
            {
                Console.WriteLine(response.Data);


            }
            else
            {
                Console.WriteLine($"{response.Data}");
            }

        }

        public async Task<string> RegistrarPruebaAsync(PruebaDTO prueba)
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Prueba");
            ResponseDTO response = await request.Post(prueba);

            if (response.Success)
            {
                Console.WriteLine("Se registro correctamente. " + response.Data);
               
            }
            else
            {
                Console.WriteLine("No se realizo el registro correctamere. ERROR:" + response.Data);
         
            }
            return response.Data;

        }

        public async Task<bool> ActualizarPruebaAsync(PruebaDTO prueba)
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Prueba");
            ResponseDTO response = await request.Put(prueba);

            if (response.Success)
            {
                Console.WriteLine("Se actualizo correctamente. " + response.Data);
                return true;
            }
            else
            {
                Console.WriteLine("No se actualizo el registro correctamere. ERROR:" + response.Data);
                return false;
            }
        }
    }
}
