using Siad.Models.DTOs;
using Siad.Models.Responses;
using SiadApiClient.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Services
{
    public class PruebasEjecucionService
    {

        public async Task<bool> AgregarResultadoPruebaAsync(string expediente, string muestra, AgregaResultadoPruebaDTO resultado)
        {
            // Implementar llamada a PUT /F3_Pruebas/AgregaResultadoPrueba

            ApiClient request = new ApiClient("F3_Pruebas", $"AgregaResultadoPrueba?expediente={expediente}&muestra={muestra}");
            ResponseDTO response = await request.Put(resultado);

            if (response.Success)
            {
                Console.WriteLine("Se agrego resultado de prueba. " + response.Data);
                return true;
            }
            else
            {
                Console.WriteLine("No se agrego el resultado correctamente. ERROR:" + response.Data);
                return false;
            }
        }

        public async Task ObtenerPruebasNoSatisfactoriasAsync(string expediente)
        {
            // Implementar llamada a GET /F3_Pruebas/PruebasNoSatisfactorias/{Expediente}
            ApiClient request = new ApiClient("F3_Pruebas", $"PruebasNoSatisfactorias/{expediente}");
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
        public async Task ValidarExpedienteAsync(string expediente)
        {
            // Implementar llamada a GET /F3_Pruebas/ValidacionExpediente/{Expediente}
            ApiClient request = new ApiClient("F3_Pruebas", $"ValidacionExpediente/{expediente}");
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
        public async Task<bool> TerminarPruebasExpedienteAsync(string expediente)
        {
            // Implementar llamada a PUT /F3_Pruebas/TerminarPruebasExpediente/{Expediente}


            ApiClient request = new ApiClient("F3_Pruebas", $"TerminarPruebasExpediente/{expediente}");
            ResponseDTO response = await request.Put(expediente);

            if (response.Success)
            {
                Console.WriteLine("Se termino correctamente. " + response.Data);
                return true;
            }
            else
            {
                Console.WriteLine("ERROR:" + response.Data);
                return false;
            }
        }

         public async Task<bool> CrearAvisoPruebaAsync(string expediente)
        {
            // Implementar llamada a PUT /F4_Liberacion/CrearAvisoPrueba/{Expediente}

            ApiClient request = new ApiClient("F4_Liberacion", $"CrearAvisoPrueba/{expediente}");
            ResponseDTO response = await request.Put(expediente);

            if (response.Success)
            {
                Console.WriteLine(response.Data);
                return true;
            }
            else
            {
                Console.WriteLine("ERROR:" + response.Data);
                return false;
            }

        }

        public async Task ConsultarAvisosAsync(string expediente)
        {
            // Implementar llamada a GET /F4_Liberacion/ConsultaAvisos/{Expediente}
            ApiClient request = new ApiClient("F4_Liberacion", $"ConsultaAvisos/{expediente}");
            ResponseDTO response = await request.Get();

            if (response.Success)
            {

                Console.WriteLine(response.Data);
              
            }
            else
            {
                Console.WriteLine("ERROR:" + response.Data);
              
            }

        }

       /* public async Task<bool> CerrarExpedienteAsync(string expediente, string resultado)
        {
            // Implementar llamada a PUT /F4_Liberacion/CierreExpedientePruebas/{Expediente}/{ ResultadoExpediente}
         }*/
    }
}
