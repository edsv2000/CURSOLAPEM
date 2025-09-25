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
    public class ValorReferenciaService
    {
        public async Task ObtenerValoresReferenciaAsync()
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "ValorReferencia");
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

        public async Task<bool> RegistrarValorReferenciaAsync(ValorReferenciaDTO data)
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "ValorReferencia");
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

        public async Task<bool> ActualizarValorReferenciaAsync(ValorReferenciaDTO data)
        {

            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "ValorReferencia");
            ResponseDTO response = await request.Put(data);

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
