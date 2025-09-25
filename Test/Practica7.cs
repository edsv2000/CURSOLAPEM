using Siad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Test
{
    public class Practica7
    {
        private readonly PruebaService _pruebaService;
        public Practica7() {
            _pruebaService = new PruebaService();   
        }

        public async Task EjecutarAsync()
        {
            try
            {
                await ObtenerPruebas();
                await RegistrarPrueba();
                await ActualizarPrueba();
                Console.WriteLine("Flujo completado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo Practica1: {ex.Message}");
            }
        }

        public async Task ObtenerPruebas() {
            await _pruebaService.ObtenerPruebasAsync();
        }

        public async Task RegistrarPrueba() {
            await _pruebaService.RegistrarPruebaAsync(new Siad.Models.DTOs.PruebaDTO
            {
                Id = "",
                Nombre = "Resistencia electrica del conductor 3",
                Estatus = "ACTIVA",
                TipoPrueba = "ACEPTACION",
                TipoResultado = "VALOR_REFERENCIA",
                FechaRegistro = "2025-09-24T19:00:34.414Z"
            });
        }

        public async Task ActualizarPrueba() {

            await _pruebaService.ActualizarPruebaAsync(new Siad.Models.DTOs.PruebaDTO
            {
                Id = "68d4443a7468b29c5e35b0ac",
                Nombre = "Resistencia electrica del conductor 4",
                Estatus = "ACTIVA",
                TipoPrueba = "ACEPTACION",
                TipoResultado = "VALOR_REFERENCIA",
                FechaRegistro = "2025-09-24T19:00:34.414Z"
            });
        }
    }
}
