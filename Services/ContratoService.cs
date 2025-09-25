using Siad.Models.DTOs;
using Siad.Models.Responses;
using SiadApiClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Siad.Services
{
    public class ContratoService
    {
        public async Task ObtenerContratosAsync(int pageNumber = 1,int pageSize = 20)
        {
            ApiClient request = new ApiClient("F2_PreparacionFabricacion", $"Contratos?pageNumber={pageNumber}&pageSize={pageSize}");
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

        public async Task<string> RegistrarContratoAsync(ContratoDTO contrato)
        {
            ApiClient request = new ApiClient("F2_PreparacionFabricacion", "Contratos");

            var json = JsonSerializer.Serialize(contrato);
            json = json.Replace("\"Tipo\":", "\"$Tipo\":");
            var content = new StringContent(json, Encoding.UTF8, "application/json");



            ResponseDTO response = await request.Post(content,true);
           
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

        public async Task<bool> ActualizarContratoAsync(ContratoDTO contrato)
        {

            ApiClient request = new ApiClient("F2_PreparacionFabricacion", "Contratos");

            var json = JsonSerializer.Serialize(contrato);
            json = json.Replace("\"Tipo\":", "\"$Tipo\":");
            var content = new StringContent(json, Encoding.UTF8, "application/json");



            ResponseDTO response = await request.Put(content, true);

            if (response.Success)
            {
                Console.WriteLine("Se actualizo correctamente. " + response.Data);
                return true;
            }
            else
            {
                Console.WriteLine("No se actualico el registro correctamente. ERROR:" + response.Data);
                return false;
            }
        }

        public async Task<bool> CambiarEstatusContratoAsync(string contratoId, string
       nuevoEstatus)
        {
            return false;
        }

    }
}
