using Siad.Models.DTOs;
using Siad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Examples
{
    public class EscenarioExamen
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

        public EscenarioExamen() {

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
                Console.WriteLine("Crear instrumento ---------------------------------------------------------------------\n");
                //await CrearInstrumento("Multimetro digital de alta precisión","78451203"); //Retorna estatus 200 Ok 
                //await CrearInstrumento("Megóhmetro de5kV", "PLM445621"); //Retorna estatus 200 Ok 
                await _instrumentoService.ObtenerInstrumentosAsync();
                Console.WriteLine("\n\nCrear prototipo ---------------------------------------------------------------------\n");
                //await CrearPrototipo("k415B-32-f/5120"); //Retorna estatus 200 ok
                await _prototipoService.ObtenerPrototiposAsync();
                Console.WriteLine("\n\nCrear Norma ---------------------------------------------------------------------\n");
                //await RegistrarNorma("E0000-45","Edicion 2023"); //Retorna estatus 200 ok 
                await _normaService.ObtenerNormasAsync();
                Console.WriteLine("\n\nCrear Prueba---------------------------------------------------------------------\n");
                //string id_prueba_1 = await CrearPrueba("Resistencia de aislamiento a 500V DC"); //Retorna id de prueba. El nombre de la prueba debe ser diferente
                //string id_prueba_2 = await CrearPrueba("Diametro nominal del conductor");
                //string id_prueba_3 = await CrearPrueba("Estanqueidad del aislamiento");
                await _pruebaService.ObtenerPruebasAsync();
                Console.WriteLine("\n\nCrear Producto---------------------------------------------------------------------\n");
                //string id_producto = await CrearProducto(id_prueba_1, id_prueba_2, id_prueba_3,"CFE2009","CABLE DE ALUMINIO AAAC 4/0 AWG","CABLE SA-AAC (477)-XLP15"); //retorna id de producto. Requiere id norma, prototipo y prueba
                await _productoService.ObtenerProductosAsync();
                Console.WriteLine("\n\nCrear Valor de referencia---------------------------------------------------------------------\n");
                //await CrearValorReferencia(id_producto, id_prueba_1,"100","0", "ohm/km","VALOR_MINIMO"); //retorna estatus 200ok 
                //await CrearValorReferencia(id_producto, id_prueba_2, "12.5", "13.5", "mm", "RANGO");
                //await CrearValorReferencia(id_producto, id_prueba_3, "0.0", "0.0", "kg", "NO_COMPARAR");
                await _valorReferenciaService.ObtenerValoresReferenciaAsync();
                Console.WriteLine("\n\nCrear contrato---------------------------------------------------------------------\n");
                /*var lista = new List<DetalleContratoDTO>
                    {
                        new DetalleContratoDTO
                        {
                            PartidaContrato = "725",
                            DescripcionAviso = "CABLE DE ALUMINIO AAAC 4/0 AWG",
                            AreaDestinoCFE = "CFE",
                            Cantidad = "550",
                            Unidad = "kg",
                            ImporteTotal = "185750"
                        },
                        new DetalleContratoDTO
                        {
                            PartidaContrato = "812",
                            DescripcionAviso = "CABLE DE ALUMINIO AAAC 4/0 AWG",
                            AreaDestinoCFE = "CFE",
                            Cantidad = "920",
                            Unidad = "kg",
                            ImporteTotal = "315420"
                        }
                    };

                */
                //string id_contrato_cfe = await CrearContrato("ContratoCFE","9200037819", lista); //retorna id contrato

                var listaparticulas = new List<DetalleContratoDTO>
                    {
                        new DetalleContratoDTO
                        {
                            PartidaContrato = "1",
                            DescripcionAviso = "CABLE DE ALUMINIO AAAC 4/0 AWG",
                            AreaDestinoCFE = "CFE",
                            Cantidad = "1500",
                            Unidad = "kg",
                            ImporteTotal = "185750"
                        }
                       
                    };
               // string id_contrato_particular = await CrearContrato("ContratoParticular", "92000234519", listaparticulas); //retorna id contrato
                Console.WriteLine("\n\nPASO 8. Orden Fabricación---------------------------------------------------------------------\n");
                
               /* var lista_orden = new List<DetalleFabricacionDTO>
                    {
                       new DetalleFabricacionDTO {
                            ContratoId = id_contrato_cfe,
                            TipoContrato = "ContratoCFE",
                            PartidaContratoId ="725",
                            DescripcionPartida = "CABLE DE ALUMINIO AAAC 4/0 AWG",
                            Unidad = "kg",
                            CantidadOriginalContrato = "550",
                            CantidadAFabricar = "550"
                        },
                        new DetalleFabricacionDTO {
                            ContratoId = id_contrato_cfe,
                            TipoContrato = "ContratoCFE",
                            PartidaContratoId ="812",
                            DescripcionPartida = "CABLE DE ALUMINIO AAAC 4/0 AWG",
                            Unidad = "kg",
                            CantidadOriginalContrato = "920",
                            CantidadAFabricar = "920"
                        },
                          new DetalleFabricacionDTO {
                            ContratoId = id_contrato_particular,
                            TipoContrato = "ContratoParticular",
                            PartidaContratoId ="1",
                            DescripcionPartida = "CABLE DE ALUMINIO AAAC 4/0 AWG",
                            Unidad = "kg",
                            CantidadOriginalContrato = "1500",
                            CantidadAFabricar = "1500"
                          }

                    };
               */
                //await CrearOrdenFabricacion(id_producto, "OF-2025-CFE-9125","AD0071845",lista_orden); // La orden de fabricacion debe ser diferente
                Console.WriteLine("\n\nExpediente Pruebas---------------------------------------------------------------------\n");
                //await CrearExpedientePruebas("FGW-2025-00245","4","1", ["M-00245-01","M-00245-02", "M-00245-03", "M-00245-04"]); // El expediente de prueba debe ser diferente. Definir bien la cantidad de muestras de acuerdo a las muestras registradas
                var expediete_clave = "FGW-2025-00245";
                Console.WriteLine("\n\nAgregar resultado---------------------------------------------------------------------\n");
                //await AgregarResultadoPrueba(id_prueba_1,"150","1", "M-00245-01", expediete_clave, "Satisfactorio");
                //await AgregarResultadoPrueba(id_prueba_2, "12.8", "1", "M-00245-01", expediete_clave, "Satisfactorio");
                /* await AgregarResultadoPrueba(id_prueba_3, "CUMPLE", "1", "M-00245-01", expediete_clave, "Satisfactorio");

                 await AgregarResultadoPrueba(id_prueba_1, "95", "1", "M-00245-02", expediete_clave, "No Satisfactorio");
                 await AgregarResultadoPrueba(id_prueba_1, "110", "2", "M-00245-02", expediete_clave, "Satisfactorio");
                 await AgregarResultadoPrueba(id_prueba_2, "13.2", "1", "M-00245-02", expediete_clave, "Satisfactorio");
                 await AgregarResultadoPrueba(id_prueba_3, "CUMPLE", "1", "M-00245-02", expediete_clave, "Satisfactorio");

                 await AgregarResultadoPrueba(id_prueba_1, "120", "1", "M-00245-03", expediete_clave, "Satisfactorio");
                 await AgregarResultadoPrueba(id_prueba_2, "12.6", "1", "M-00245-03",    expediete_clave, "Satisfactorio");
                 await AgregarResultadoPrueba(id_prueba_3, "CUMPLE", "1", "M-00245-03", expediete_clave, "Satisfactorio");

                 await AgregarResultadoPrueba(id_prueba_1, "105", "1", "M-00245-04", expediete_clave, "Satisfactorio");
                 await AgregarResultadoPrueba(id_prueba_2, "13.9", "1", "M-00245-04", expediete_clave, "No Satisfactorio");
                 await AgregarResultadoPrueba(id_prueba_2, "13.1", "2", "M-00245-04", expediete_clave, "Satisfactorio");
                 await AgregarResultadoPrueba(id_prueba_3, "CUMPLE", "1", "M-00245-04", expediete_clave, "Satisfactorio");
 */
                await AgregarResultadoPrueba("68d58bc94c372ecdc9906259", "CUMPLE", "1", "M-00245-01", expediete_clave, "Satisfactorio");
                await AgregarResultadoPrueba("68d58bc94c372ecdc9906259", "CUMPLE", "1", "M-00245-02", expediete_clave, "Satisfactorio");
                await AgregarResultadoPrueba("68d58bc94c372ecdc9906259", "CUMPLE", "1", "M-00245-03", expediete_clave, "Satisfactorio");
                await AgregarResultadoPrueba("68d58bc94c372ecdc9906259", "CUMPLE", "1", "M-00245-04", expediete_clave, "Satisfactorio");

                Console.WriteLine("\n\nTerminar expediente---------------------------------------------------------------------\n");
                await TerminarExpediente("FGW-2025-00245");

                Console.WriteLine("\n\nGenerar avisos de prueba---------------------------------------------------------------------\n");
                await GenerarAviso("FGW-2025-00245");

                Console.WriteLine("Flujo completado correctamente.");



                

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo: {ex.Message}");
            }

        }
        public async Task CrearInstrumento(string nombre, string noserie)
        {
            await _instrumentoService.RegistrarInstrumentoAsync(new Siad.Models.DTOs.InstrumentoDTO
            {
                Id = "",
                Nombre = nombre,
                NumeroSerie = noserie,
                FechaCalibracion = "2025-09-25T15:49:43.147Z",
                FechaVencimientoCalibracion = "2025-09-25T15:49:43.147Z",
                UrlArchivo = "https://www.google.com/",
                MD5 = "",
                Estatus = "ACTIVO",
                FechaRegistro = "2025-09-25T15:49:43.147Z"
            });

        }

        public async Task CrearPrototipo(string prototipo)
        {
            await _prototipoService.RegistrarPrototipoAsync(new Siad.Models.DTOs.PrototipoDTO
            {
                Id = "",
                Numero = prototipo,
                FechaEmision = "2025-09-24T18:44:19.178Z",
                FechaVencimiento = "2025-09-24T18:44:19.178Z",
                UrlArchivo = "https://www.cfe.mx",
                MD5 = "",
                Estatus = "ACTIVO",
                FechaRegistro = "2025-09-25T18:44:19.178Z"
            });

        }

        public async Task RegistrarNorma(string clave, string edicion)
        {

            await _normaService.RegistrarNormaAsync(new Models.DTOs.NormaDTO
            {
                Id = "",
                Clave = clave,
                Nombre = "Conductores Dúplex con Aislamiento Termoplástico para Instalaciones hasta 600 V, para 60° C",
                Edicion = edicion,
                Estatus = "Vigente",
                EsCFE = true,
                FechaRegistro = "2025-09-25T18:50:13.717Z"
            });

        }

        public async Task<string> CrearPrueba(string nombre)
        {

            string data = await _pruebaService.RegistrarPruebaAsync(new Siad.Models.DTOs.PruebaDTO
            {
                Id = "",
                Nombre = nombre,
                Estatus = "ACTIVA",
                TipoPrueba = "ACEPTACION",
                TipoResultado = "VALOR_REFERENCIA",
                FechaRegistro = "2025-09-25T19:00:34.414Z"
            });

            return data;
        }

        public async Task<string> CrearProducto(string prueba1, string prueba2, string prueba3, string codigofabricante, string descripcion, string descripcioncorta)
        {

            Console.Write("Ingresa el ID de la Norma: ");
            string normaId = Console.ReadLine();

            Console.Write("Ingresa el ID del Prototipo: ");
            string prototipoId = Console.ReadLine();

            string data = await _productoService.RegistrarProductoAsync(new Siad.Models.DTOs.AgregarProductoDTO
            {
                Id = "",
                CodigoFabricante = codigofabricante,
                Descripcion = descripcion,
                DescripcionCorta = descripcioncorta,
                TipoFabricacion = "LOTE",
                Unidad = "kg",
                Norma = normaId,
                Prototipo = prototipoId,
                Estatus = "ACTIVO",
                FechaRegistro = "2025-09-25T19:04:09.460Z",
                Pruebas = [prueba1, prueba2, prueba3]

            });

            return data;
        }

        public async Task CrearValorReferencia(string id_producto, string id_prueba, string valor, string valor2, string unidad,string comparacion)
        {

            await _valorReferenciaService.RegistrarValorReferenciaAsync(new Siad.Models.DTOs.ValorReferenciaDTO
            {
                Id = "",
                IdProducto = id_producto,
                IdPrueba = id_prueba,
                Valor = valor,
                Valor2 = valor2,
                Unidad = unidad, // ohm/km
                Comparacion = comparacion,
                FechaRegistro = "2025-09-25T19:11:43.292Z"

            });
        }

        public async Task<string> CrearContrato(string tipo, string nocontrato,List<DetalleContratoDTO> listadetalle)
        {
            string data = await _contratoService.RegistrarContratoAsync(new Siad.Models.DTOs.ContratoDTO
            {
                Tipo = tipo,
                Id = "",
                TipoContrato = tipo,
                NoContrato = "152231129",
                Estatus = "ACTIVO",
                DetalleContrato = listadetalle,
                UrlArchivo = "https://www.cfe.mx",
                MD5 = "",
                FechaEntregaCFE = "2025-09-25T17:25:06.51Z"
            });

            return data;
        }

        public async Task CrearOrdenFabricacion(string producto, string claveorden,string lote, List<DetalleFabricacionDTO> lista)
        {
            await _ordenFabricacionService.CrearOrdenFabricacionAsync(new OrdenFabricacionDTO
            {
                Id = "",
                ClaveOrdenFabricacion =  claveorden,
                LoteFabricacion = lote,
                IdProducto = producto,
                DetalleFabricacion = lista

            });
        }

        public async Task CrearExpedientePruebas(string expediente,string cantidadmuestra, string maximorechazo, List<string> lista)
        {

            Console.Write("Ingresa el orden de fabricacion: ");
            string ordenId = Console.ReadLine();

            await _expedienteService.CrearExpedienteAsync(new ExpedienteInspeccionDTO
            {
                Id = "",
                ClaveExpediente = expediente,
                OrdenFabricacion = ordenId,
                CantidadMuestras = cantidadmuestra,
                MaximoRechazos = maximorechazo,
                Muestras = lista
            });
        }

        public async Task AgregarResultadoPrueba(string id_prueba, string valor, string intento, string muestra, string expediente, string resultado)
        {
 
            Console.Write($"Ingresa id de valor de referencia - {id_prueba} : ");
            string id_referencia = Console.ReadLine();
            Console.Write("Ingresa id de instrumento de medicion: ");
            string id_instrumento = Console.ReadLine();
            await _pruebasEjecucionService.AgregarResultadoPruebaAsync(expediente, muestra, new AgregaResultadoPruebaDTO
            {
                IdPrueba = id_prueba,
                IdValorReferencia = id_referencia,
                FechaPrueba = "2025-09-25T15:37:27.835Z",
                OperadorPrueba = "Eder Salvador",
                IdInstrumentoMedicion = id_instrumento,
                ValorMedido = valor,
                Resultado = resultado,
                NumeroIntento = intento

            });
        }

        public async Task TerminarExpediente(string expediente)
        {
            await _pruebasEjecucionService.TerminarPruebasExpedienteAsync(expediente);
        }

        public async Task GenerarAviso(string expediente)
        {
            await _pruebasEjecucionService.CrearAvisoPruebaAsync(expediente);
        }

    }
    }
