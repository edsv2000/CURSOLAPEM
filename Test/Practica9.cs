using Siad.Models.DTOs;
using Siad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Test
{
    public class Practica9
    {
        private readonly OrdenFabricacionService _ordenFabricacionService;
        public Practica9() { 
            _ordenFabricacionService = new OrdenFabricacionService();
        }

        public async Task EjecutarAsync()
        {
            try
            {
                //Falta Verificar detalles
                await CrearOrdenFabricacion();
                await ActualizarOrdenFabricacion();
                await ConsultarOrden();
                Console.WriteLine("Flujo completado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo Practica1: {ex.Message}");
            }
        }

        public async Task CrearOrdenFabricacion() {

            await _ordenFabricacionService.CrearOrdenFabricacionAsync(new OrdenFabricacionDTO
            {
                Id = "",
                ClaveOrdenFabricacion = "OF2027",
                LoteFabricacion = "LT2026",
                IdProducto = "68d2f021ce3b00aacea97212",
                DetalleFabricacion = [new DetalleFabricacionDTO {
                    ContratoId = "68d30110ce3b00aacea97236",
                    TipoContrato = "ContratoCFE",
                    PartidaContratoId ="1",
                    DescripcionPartida = "Conductores Dúplex con Aislamiento Termoplástico para Instalaciones hasta 600 V, para 60° C",
                    Unidad = "kg",
                    CantidadOriginalContrato = "10000",
                    CantidadAFabricar = "5000"
                }]

            });
        }

        public async Task ActualizarOrdenFabricacion() {
            await _ordenFabricacionService.ActualizarOrdenFabricacionAsync(new OrdenFabricacionDTO
            {
                Id = "68d45ccb7468b29c5e35b162",
                ClaveOrdenFabricacion = "OF2028",
                LoteFabricacion = "LT2026",
                IdProducto = "68d2f021ce3b00aacea97212",
                DetalleFabricacion = [new DetalleFabricacionDTO {
                    ContratoId = "68d30110ce3b00aacea97236",
                    TipoContrato = "ContratoCFE",
                    PartidaContratoId ="1",
                    DescripcionPartida = "Conductores Dúplex con Aislamiento Termoplástico para Instalaciones hasta 600 V, para 60° C",
                    Unidad = "kg",
                    CantidadOriginalContrato = "10000",
                    CantidadAFabricar = "5000"
                }]

            });
        }

        public async Task ConsultarOrden() {
            await _ordenFabricacionService.ObtenerOrdenFabricacionAsync("68d30349ce3b00aacea97254");
        }
    }
}
