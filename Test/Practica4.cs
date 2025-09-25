using Siad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Test
{
    
    public class Practica4
    {

        private readonly ValorReferenciaService _valorReferenciaService;
        public Practica4() { 
            _valorReferenciaService = new ValorReferenciaService();
        
        }

        public async Task EjecutarAsync()
        {
            try
            {
                await ObtenerValoresReferencia();
                await RegistrarValoresReferencia();
                await ActualizarValorReferenica();
                Console.WriteLine("Flujo completado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo Practica1: {ex.Message}");
            }
        }

        public async Task ObtenerValoresReferencia() {

           
            await _valorReferenciaService.ObtenerValoresReferenciaAsync();
            
        }

        public async Task RegistrarValoresReferencia()
        {


            await _valorReferenciaService.RegistrarValorReferenciaAsync(new Siad.Models.DTOs.ValorReferenciaDTO
            {
                Id = "",
                IdProducto = "68d2f021ce3b00aacea97212",
                IdPrueba = "68d2eea6ce3b00aacea97200",
                Valor = "10",
                Valor2 = "0",
                Unidad = "ohm/km",
                Comparacion = "VALOR_MINIMO",
                FechaRegistro = "2025-09-24T19:11:43.292Z"

            });

        }

        public async Task ActualizarValorReferenica() {

            await _valorReferenciaService.ActualizarValorReferenciaAsync(new Siad.Models.DTOs.ValorReferenciaDTO
            {
                Id = "68d2f1a1ce3b00aacea9721f",
                IdProducto = "68d2f021ce3b00aacea97212",
                IdPrueba = "68d2eea6ce3b00aacea97200",
                Valor = "9",
                Valor2 = "0",
                Unidad = "ohm/km",
                Comparacion = "VALOR_MINIMO",
                FechaRegistro = "2025-09-24T19:11:43.292Z"

            });
        }

    }
    }
