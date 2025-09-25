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
    public class PrototipoService
    {
        public async Task ObtenerPrototiposAsync()
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial","Prototipo");
            ResponseDTO response = await request.Get();

            if (response.Success)
            {
                Console.WriteLine(response.Data);


            }
            else {
                Console.WriteLine("ERROR: " + response.Data);
            }


        }

        public async Task<bool> RegistrarPrototipoAsync(PrototipoDTO data)
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Prototipo");
            ResponseDTO response = await request.Post(data);

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

        public async Task<bool> ActualizarPrototipoAsync(PrototipoDTO data)
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Prototipo");
            ResponseDTO response = await request.Post(data);

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
