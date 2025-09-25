using Siad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Test
{
    public class Practica3
    {
        private readonly PrototipoService _prototipoService;
        public Practica3() {

            _prototipoService = new PrototipoService();
        }

        public async Task EjecutarAsync()
        {
            try
            {
                await ConsultarPrototipos();
                await RegistrarPrototipo();
                await ActualizarPrototipo();
                Console.WriteLine("Flujo completado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo Practica1: {ex.Message}");
            }
        }

        public async Task ConsultarPrototipos() {

            await _prototipoService.ObtenerPrototiposAsync();
        }

        public async Task RegistrarPrototipo() {
            await _prototipoService.RegistrarPrototipoAsync(new Siad.Models.DTOs.PrototipoDTO
            {
                Id = "",
                Numero = "K3112-21-E/3249",
                FechaEmision = "2025-09-24T18:44:19.178Z",
                FechaVencimiento = "2025-09-24T18:44:19.178Z",
                UrlArchivo = "https://www.cfe.mx",
                MD5 = "",
                Estatus = "ACTIVO",
                FechaRegistro = "2025-09-24T18:44:19.178Z"
            });
        }

        public async Task ActualizarPrototipo() {
           await _prototipoService.ActualizarPrototipoAsync(new Siad.Models.DTOs.PrototipoDTO
            {
                Id = "68d42e567468b29c5e35b042",
                Numero = "K3112-21-E/3252",
                FechaEmision = "2025-09-24T18:44:19.178Z",
                FechaVencimiento = "2025-09-24T18:44:19.178Z",
                UrlArchivo = "https://www.cfe.mx",
                MD5 = "",
                Estatus = "ACTIVO",
                FechaRegistro = "2025-09-24T18:44:19.178Z"
            });
        }
    }
}
