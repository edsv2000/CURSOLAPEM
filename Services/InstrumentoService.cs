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
    public class InstrumentoService
    {
        public async Task ObtenerInstrumentosAsync() {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Instrumento");

    
            ResponseDTO response = await request.Get();

          
            Console.WriteLine(response.Data);
           
        }

        public async Task<bool> RegistrarInstrumentoAsync(InstrumentoDTO data) {

            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Instrumento");
            ResponseDTO response = await request.Post(data);

            if (response.Success)
            {
                Console.WriteLine("Se registro correctamente. "+response.Data);
                return true;
            }
            else
            {
                Console.WriteLine("No se realizo el registro correctamere. ERROR:"+response.Data);
                return false;
            }
            
        }

        public async Task<bool> ActualizarInstrumentoAsync(InstrumentoDTO data)
        {

            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Instrumento");
            ResponseDTO response = await request.Put(data);

            if (response.Success)
            {
                Console.WriteLine("Se actualizo correctamente. " + response.Data);
                return true;
            }
            else
            {
                Console.WriteLine("No se realizo la actualización correctamere. ERROR:" + response.Data);
                return false;
            }

        }
    }
}
