using Siad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Test
{
    public class Practica2
    {
       private readonly InstrumentoService _instrumentoService;

        public Practica2()
        {
         _instrumentoService = new InstrumentoService();
        }

        public async Task EjecutarAsync()
        {
            try
            {
                await ConsultarInstrumentos();
                await RegistrarInstrumento();
                await ActualizarInstrumentos();
                Console.WriteLine("Flujo completado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo Practica1: {ex.Message}");
            }
        }

        private async Task ConsultarInstrumentos()
        {
             await _instrumentoService.ObtenerInstrumentosAsync();

        }

        private async Task RegistrarInstrumento() {
            await _instrumentoService.RegistrarInstrumentoAsync(new Siad.Models.DTOs.InstrumentoDTO
            {
                Id = "",
                Nombre = "Termometro2",
                NumeroSerie = "238912347",
                FechaCalibracion = "2025-09-23T15:49:43.147Z",
                FechaVencimientoCalibracion = "2025-09-23T15:49:43.147Z",
                UrlArchivo = "https://www.google.com/",
                MD5 = "",
                Estatus = "ACTIVO",
                FechaRegistro = "2025-09-24T15:49:43.147Z"
            });
        }

        private async Task ActualizarInstrumentos() {

            await _instrumentoService.ActualizarInstrumentoAsync(new Siad.Models.DTOs.InstrumentoDTO
            {
                Id = "68d429bf7468b29c5e35b03e",
                Nombre = "Termometro56",
                NumeroSerie = "238912347",
                FechaCalibracion = "2025-09-23T15:49:43.147Z",
                FechaVencimientoCalibracion = "2025-09-23T15:49:43.147Z",
                UrlArchivo = "https://www.google.com/",
                MD5 = "",
                Estatus = "ACTIVO",
                FechaRegistro = "2025-09-24T15:49:43.147Z"
            });
        }


    }
}
