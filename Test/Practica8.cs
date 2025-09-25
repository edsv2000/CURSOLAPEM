using Siad.Models.DTOs;
using Siad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Test
{
    public class Practica8
    {
        private readonly ContratoService _contratoService;
        public Practica8() {
            _contratoService = new ContratoService();
        }
        public async Task EjecutarAsync()
        {
            try
            {
                //Falta metodo Gestionar estado de contratos
                await ObtenerContratos();
                await RegistrarContrato();
                await ActualizarContrato();
                Console.WriteLine("Flujo completado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo Practica1: {ex.Message}");
            }
        }

        public async Task ObtenerContratos() {

            await _contratoService.ObtenerContratosAsync(1, 1);
        }

        public async Task RegistrarContrato() {
            await _contratoService.RegistrarContratoAsync(new Siad.Models.DTOs.ContratoDTO
            {
                Tipo = "ContratoCFE",
                Id = "",
                TipoContrato = "ContratoCFE",
                NoContrato = "152231129",
                Estatus = "ACTIVO",
                DetalleContrato = [new DetalleContratoDTO {
        PartidaContrato ="1",
        DescripcionAviso= "Conductores Dúplex con Aislamiento Termoplástico para Instalaciones hasta 600 V, para 60° C",
        AreaDestinoCFE = "CFE",
        Cantidad="100000",
        Unidad ="kg",
        ImporteTotal="100000"
    },new DetalleContratoDTO {
        PartidaContrato ="2",
        DescripcionAviso= "Conductores Dúplex con Aislamiento Termoplástico para Instalaciones hasta 600 V, para 60° C",
        AreaDestinoCFE = "CFE",
        Cantidad="100000",
        Unidad ="kg",
        ImporteTotal="100000"
    },new DetalleContratoDTO {
        PartidaContrato ="3",
        DescripcionAviso= "Conductores Dúplex con Aislamiento Termoplástico para Instalaciones hasta 600 V, para 60° C",
        AreaDestinoCFE = "CFE",
        Cantidad="100000",
        Unidad ="kg",
        ImporteTotal="100000"
    },new DetalleContratoDTO {
        PartidaContrato ="4",
        DescripcionAviso= "Conductores Dúplex con Aislamiento Termoplástico para Instalaciones hasta 600 V, para 60° C",
        AreaDestinoCFE = "CFE",
        Cantidad="100000",
        Unidad ="kg",
        ImporteTotal="100000"
    }],
                UrlArchivo = "https://www.cfe.mx",
                MD5 = "",
                FechaEntregaCFE = "2025-07-18T17:25:06.51Z"
            });
        }
    


    public async Task ActualizarContrato() {
            await _contratoService.ActualizarContratoAsync(new Siad.Models.DTOs.ContratoDTO
            {
                Tipo = "ContratoCFE",
                Id = "68d44d587468b29c5e35b0d1",
                TipoContrato = "ContratoCFE",
                NoContrato = "152231129",
                Estatus = "ACTIVO",
                DetalleContrato = [new DetalleContratoDTO {
        PartidaContrato ="1",
        DescripcionAviso= "Conductores Dúplex con Aislamiento Termoplástico para Instalaciones hasta 600 V, para 60° C",
        AreaDestinoCFE = "CFE",
        Cantidad="100000",
        Unidad ="kg",
        ImporteTotal="100000"
    }],
                UrlArchivo = "https://www.cfe.mx",
                MD5 = "",
                FechaEntregaCFE = "2025-07-18T17:25:06.51Z"
            });
        }
    } }
