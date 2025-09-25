using Siad.Models.DTOs;
using Siad.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Examples
{
    public class EscenarioPrueba
    {
        private readonly InstrumentoService _instrumentoService;
        private readonly PrototipoService _prototipoService;
        private readonly NormaService _normaService;
        private readonly PruebaService _pruebaService;
        private readonly ProductoService _productoService;
        private readonly ValorReferenciaService _valorReferenciaService;
        private readonly ContratoService _contratoService;
        private readonly OrdenFabricacionService _ordenFabricacionService;
        private readonly ExpedienteService _expedienteService;
        private readonly PruebasEjecucionService _pruebasEjecucionService;
        public EscenarioPrueba() { 
            _instrumentoService = new InstrumentoService();
            _prototipoService = new PrototipoService();
            _normaService = new NormaService();
            _pruebaService = new PruebaService();
            _productoService = new ProductoService();
            _valorReferenciaService = new ValorReferenciaService();
            _contratoService = new ContratoService();
            _ordenFabricacionService = new OrdenFabricacionService();
            _expedienteService = new ExpedienteService();
            _pruebasEjecucionService = new PruebasEjecucionService();

        }

        public async Task EjecutarAsync()
        {
            try
            {
                Console.WriteLine("PASO 1. Crear instrumento ---------------------------------------------------------------------\n");
                await CrearInstrumento(); //Retorna estatus 200 Ok
                await _instrumentoService.ObtenerInstrumentosAsync();
                Console.WriteLine("\n\nPASO 2. Crear prototipo ---------------------------------------------------------------------\n");
                await CrearPrototipo(); //Retorna estatus 200 ok
                await _prototipoService.ObtenerPrototiposAsync();
                Console.WriteLine("\n\nPASO 3. Crear Norma ---------------------------------------------------------------------\n");
                await RegistrarNorma(); //Retorna estatus 200 ok 
                await _normaService.ObtenerNormasAsync();
                Console.WriteLine("\n\nPASO 4. Crear Prueba---------------------------------------------------------------------\n");
                string id_prueba = await CrearPrueba(); //Retorna id de prueba. El nombre de la prueba debe ser diferente
                Console.WriteLine("\n\nPASO 5. Crear Producto---------------------------------------------------------------------\n");
                string id_producto = await CrearProducto(id_prueba); //retorna id de producto. Requiere id norma, prototipo y prueba
                Console.WriteLine("\n\nPASO 6. Crear Valor de referencia---------------------------------------------------------------------\n");
                await CrearValorReferencia(id_producto, id_prueba); //retorna estatus 200ok 
                await _valorReferenciaService.ObtenerValoresReferenciaAsync();
                Console.WriteLine("\n\nPASO 7. Crear contrato---------------------------------------------------------------------\n");
                string id_contrato = await CrearContrato(); //retorna id contrato
                Console.WriteLine("\n\nPASO 8. Orden Fabricación---------------------------------------------------------------------\n");
                await CrearOrdenFabricacion(id_producto, id_contrato); // La orden de fabricacion debe ser diferente
                Console.WriteLine("\n\nPASO 9. Expediente Pruebas---------------------------------------------------------------------\n");
                await CrearExpedientePruebas(); // El expediente de prueba debe ser diferente. Definir bien la cantidad de muestras de acuerdo a las muestras registradas
                Console.WriteLine("\n\nPASO 10. Agregar resultado---------------------------------------------------------------------\n");
                await AgregarResultadoPrueba(id_prueba);
                Console.WriteLine("\n\nPASO 11. Terminar expediente---------------------------------------------------------------------\n");
                await TerminarExpediente();
                Console.WriteLine("Flujo completado correctamente.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo: {ex.Message}");
            }
        }

        public async Task CrearInstrumento() {
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

        public async Task CrearPrototipo() {
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

        public async Task RegistrarNorma() {

            await _normaService.RegistrarNormaAsync(new Models.DTOs.NormaDTO
            {
                Id = "",
                Clave = "E0000-04",
                Nombre = "Conductores Dúplex con Aislamiento Termoplástico para Instalaciones hasta 600 V, para 60° C",
                Edicion = "Septiembre 2001",
                Estatus = "Vigente",
                EsCFE = true,
                FechaRegistro = "2025-09-23T18:50:13.717Z"
            });

        }

        public async Task<string> CrearPrueba() {

            string data = await _pruebaService.RegistrarPruebaAsync(new Siad.Models.DTOs.PruebaDTO
            {
                Id = "",
                Nombre = "Resistencia electrica del conductor 681",
                Estatus = "ACTIVA",
                TipoPrueba = "ACEPTACION",
                TipoResultado = "VALOR_REFERENCIA",
                FechaRegistro = "2025-09-24T19:00:34.414Z"
            });

            return data;
        }

        public async Task<string> CrearProducto(string prueba) {

            Console.Write("Ingresa el ID de la Norma: ");
            string normaId = Console.ReadLine();

            Console.Write("Ingresa el ID del Prototipo: ");
            string prototipoId = Console.ReadLine();

            string data = await _productoService.RegistrarProductoAsync(new Siad.Models.DTOs.AgregarProductoDTO
            {
                Id = "",
                CodigoFabricante = "CFC900",
                Descripcion = "Alambre TWDZ",
                DescripcionCorta = "ACSR 3/0",
                TipoFabricacion = "LOTE",
                Unidad = "kg",
                Norma = normaId,
                Prototipo = prototipoId,
                Estatus = "ACTIVO",
                FechaRegistro = "2025-09-24T19:04:09.460Z",
                Pruebas = [prueba]

            });

            return data;
        }

        public async Task CrearValorReferencia(string id_producto, string id_prueba) {

            await _valorReferenciaService.RegistrarValorReferenciaAsync(new Siad.Models.DTOs.ValorReferenciaDTO
            {
                Id = "",
                IdProducto = id_producto,
                IdPrueba = id_prueba,
                Valor = "10",
                Valor2 = "0",
                Unidad = "ohm/km",
                Comparacion = "VALOR_MINIMO",
                FechaRegistro = "2025-09-24T19:11:43.292Z"

            });
        }

        public async Task<string> CrearContrato() {
           string data =  await _contratoService.RegistrarContratoAsync(new Siad.Models.DTOs.ContratoDTO
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

            return data;
        }

        public async Task CrearOrdenFabricacion(string producto, string contrato) {
            await _ordenFabricacionService.CrearOrdenFabricacionAsync(new OrdenFabricacionDTO
            {
                Id = "",
                ClaveOrdenFabricacion = "OF2056",
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

        public async Task CrearExpedientePruebas() {

            Console.Write("Ingresa el orden de fabricacion: ");
            string ordenId = Console.ReadLine();

            await _expedienteService.CrearExpedienteAsync(new ExpedienteInspeccionDTO
            {
                Id = "",
                ClaveExpediente = "EXP-2025_91",
                OrdenFabricacion = ordenId,
                CantidadMuestras = "1",
                MaximoRechazos = "0",
                Muestras = ["tramo1"]
            });
        }

        public async Task AgregarResultadoPrueba(string id_prueba) {
            Console.Write("Ingresa expediente: ");
            string expediente = Console.ReadLine();
            Console.Write("Ingresa muestra: ");
            string muestra = Console.ReadLine();

            Console.Write("Ingresa id de valor de referencia: ");
            string id_referencia = Console.ReadLine();
            Console.Write("Ingresa id de instrumento de medicion: ");
            string id_instrumento = Console.ReadLine();
            await _pruebasEjecucionService.AgregarResultadoPruebaAsync(expediente,muestra,new AgregaResultadoPruebaDTO { 
                IdPrueba=id_prueba,
                IdValorReferencia = id_referencia,
                FechaPrueba = "2025-09-24T15:37:27.835Z",
                OperadorPrueba = "Eder Salvador",
                IdInstrumentoMedicion = id_instrumento,
                ValorMedido = "10.1",
                Resultado = "Satisfactorio",
                NumeroIntento = "1"

            });
        }

        public async Task TerminarExpediente() {
            Console.Write("Ingresa expediente: ");
            string expediente = Console.ReadLine();
            await _pruebasEjecucionService.TerminarPruebasExpedienteAsync(expediente);
        }
    }
}
