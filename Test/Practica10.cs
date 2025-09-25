using Siad.Models.DTOs;
using Siad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Test
{
    public class Practica10
    {
        private readonly ExpedienteService _expedienteService;
        public Practica10() { 
            _expedienteService = new ExpedienteService();
        }

        public async Task EjecutarAsync()
        {
            try
            {
                await ObtenerExpedientes();
                await ObtenerExpedientePorID();
                await CrearExpediente();
                await ActualizarExpediente();
                await AgregarMuestra();
                await QuitarMuestra();
                Console.WriteLine("Flujo completado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo Practica1: {ex.Message}");
            }
        }

        public async Task ObtenerExpedientes() {

            await _expedienteService.ObtenerExpedientesAsync();
        }

        public async Task ObtenerExpedientePorID() {
            await _expedienteService.ObtenerExpedientePorIdAsync("EXP-2025");
        }

        public async Task CrearExpediente() {
            await _expedienteService.CrearExpedienteAsync(new ExpedienteInspeccionDTO
            {
                Id = "",
                ClaveExpediente = "EXP-2025_2",
                OrdenFabricacion = "68d30349ce3b00aacea97254",
                CantidadMuestras = "5",
                MaximoRechazos = "0",
                Muestras = ["tramo1", "tramo2", "tramo3"]
            });
        }

        public async Task ActualizarExpediente() {
            await _expedienteService.ActualizarExpedienteAsync(new ExpedienteInspeccionDTO
            {
                Id = "68d459767468b29c5e35b153",
                ClaveExpediente = "EXP-2025_23",
                OrdenFabricacion = "68d30349ce3b00aacea97254",
                CantidadMuestras = "5",
                MaximoRechazos = "0",
                Muestras = ["tramo1", "tramo2", "tramo3"]
            });
        
        }

        public async Task AgregarMuestra() {
            await _expedienteService.AgregarMuestraAsync("EXP-2025_23", "tramo4");
        }

        public async Task QuitarMuestra()
        {
            await _expedienteService.QuitarMuestraAsync("EXP-2025_23", "tramo4");
        }

    }
}
