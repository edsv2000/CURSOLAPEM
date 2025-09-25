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
    public class NormaService
    {
        public async Task ObtenerNormasAsync()
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Norma");
            ResponseDTO response = await request.Get();

            if (response.Success)
            {
                Console.WriteLine(response.Data);


            }
            else
            {
                Console.WriteLine("ERROR: " + response.Data);
            }
        }

        public async Task ObtenerNormasCfeAsync()
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Norma");
            ResponseDTO response = await request.Get();

            if (response.Success)
            {
                Console.WriteLine(response.Data);


            }
            else
            {
                Console.WriteLine("ERROR: " + response.Data);
            }
        }
        public async Task<bool> RegistrarNormaAsync(NormaDTO norma)
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Norma");
            ResponseDTO response = await request.Post(norma);

            if (response.Success)
            {
                Console.WriteLine("Se registro correctamente. " + response.Data);
                return true;
            }
            else
            {
                Console.WriteLine("No se realizo el registro correctamere. ERROR:" + response.Data);
                return false;
            }
        }

        public async Task<bool> ActualizarNormaAsync(NormaDTO norma)
        {

            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Norma");
            ResponseDTO response = await request.Put(norma);

            if (response.Success)
            {
                Console.WriteLine("Se actualizo correctamente. " + response.Data);
                return true;
            }
            else
            {
                Console.WriteLine("No se actualizo el registro correctamente. ERROR:" + response.Data);
                return false;
            }
        }
    }
}
