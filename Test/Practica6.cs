using Siad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Test
{
    public class Practica6
    {
        private readonly NormaService _normaService;
        public Practica6() { 
            _normaService = new NormaService();
        }

        public async Task EjecutarAsync()
        {
            try
            {
                //Falta funcion de identificas normas cfe vs otras normas
                await ObtenerNormas();
                await RegistrarNormas();
                await ActualizarNormas();
                Console.WriteLine("Flujo completado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo Practica1: {ex.Message}");
            }
        }
        public async Task ObtenerNormas() {
            await _normaService.ObtenerNormasAsync();
        }

        public async Task RegistrarNormas() {
            await _normaService.RegistrarNormaAsync(new Models.DTOs.NormaDTO { 
                Id ="",
                Clave = "E0000-04",
                Nombre = "Conductores Dúplex con Aislamiento Termoplástico para Instalaciones hasta 600 V, para 60° C",
                Edicion = "Septiembre 2001",
                Estatus ="Vigente",
                EsCFE = true,
                FechaRegistro = "2025-09-23T18:50:13.717Z"
            });
        }

        public async Task ActualizarNormas()
        {
            await _normaService.ActualizarNormaAsync(new Models.DTOs.NormaDTO
            {
                Id = "68d49778d2127143130408b7",
                Clave = "E0000-05",
                Nombre = "Conductores Dúplex con Aislamiento Termoplástico para Instalaciones hasta 600 V, para 60° C",
                Edicion = "Septiembre 2001",
                Estatus = "Vigente",
                EsCFE = true,
                FechaRegistro = "2025-09-23T18:50:13.717Z"
            });
        }


    }
}
