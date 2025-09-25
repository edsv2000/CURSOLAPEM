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
    public class OrdenFabricacionService
    {
        public async Task<bool> CrearOrdenFabricacionAsync(OrdenFabricacionDTO orden)
        {
            ApiClient request = new ApiClient("F2_PreparacionFabricacion", "OrdenFabricacion");
            ResponseDTO response = await request.Post(orden);

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

        public async Task<bool> ActualizarOrdenFabricacionAsync(OrdenFabricacionDTO orden)
        {
            ApiClient request = new ApiClient("F2_PreparacionFabricacion", "OrdenFabricacion");
            ResponseDTO response = await request.Put(orden);

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

        public async Task ObtenerOrdenFabricacionAsync(string ordenId)
        {
            ApiClient request = new ApiClient("F2_PreparacionFabricacion", $"OrdenFabricacion/{ordenId}");
            ResponseDTO response = await request.Get();

            if (response.Success)
            {
                Console.WriteLine(response.Data);

            }
            else
            {
                Console.WriteLine($"ERROR: {response.Data}");
            }
        }
        public async Task<bool> ValidarOrdenCompletaAsync(string ordenId)
        {
            return false;
        }
    }
}
