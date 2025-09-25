using Siad.Models.DTOs;
using Siad.Models.Responses;
using SiadApiClient.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Siad.Services
{
    public class ExpedienteService
    {
        public async Task ObtenerExpedientesAsync(int pageNumber = 1, int pageSize = 20)
        {
         
            ApiClient request = new ApiClient("F2_PreparacionFabricacion", $"ExpedientePruebas?pageNumber={pageNumber}&pageSize={pageSize}");
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

        public async Task ObtenerExpedientePorIdAsync(string expedienteId)
        {
            // Implementar llamada a GET /F2_PreparacionFabricacion/ExpedientePruebas/{ id}
            ApiClient request = new ApiClient("F2_PreparacionFabricacion", $"ExpedientePruebas/{expedienteId}");
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

        public async Task<bool> CrearExpedienteAsync(ExpedienteInspeccionDTO expediente)
        {
            // Implementar llamada a POST /F2_PreparacionFabricacion/ExpedientePruebas

            ApiClient request = new ApiClient("F2_PreparacionFabricacion", "ExpedientePruebas");
            ResponseDTO response = await request.Post(expediente);

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

        public async Task<bool> ActualizarExpedienteAsync(ExpedienteInspeccionDTO expediente)
        {
            // Implementar llamada a PUT /F2_PreparacionFabricacion/ExpedientePruebas
            ApiClient request = new ApiClient("F2_PreparacionFabricacion", "ExpedientePruebas");
            ResponseDTO response = await request.Put(expediente);

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

        public async Task<bool> AgregarMuestraAsync(string expedienteClave, string muestra)
        {
            // Implementar llamada a PUT /F2_PreparacionFabricacion/AgregaMuestraExpediente /{ Expediente}
            ApiClient request = new ApiClient("F2_PreparacionFabricacion", $"AgregaMuestraExpediente/{expedienteClave}");
            ResponseDTO response = await request.Put(muestra);

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

        public async Task<bool> QuitarMuestraAsync(string expedienteClave, string muestra)
        {
            // Implementar llamada a PUT /F2_PreparacionFabricacion/QuitarMuestraExpediente /{ Expediente}/{ muestra}
       
            ApiClient request = new ApiClient("F2_PreparacionFabricacion", $"QuitarMuestraExpediente/{expedienteClave}/{muestra}");
            ResponseDTO response = await request.Put(muestra);

            if (response.Success)
            {
                Console.WriteLine("Se quito correctamente. " + response.Data);
                return true;
            }
            else
            {
                Console.WriteLine("No se quito la muestra correctamente. ERROR:" + response.Data);
                return false;
            }
        }
    }
    }
