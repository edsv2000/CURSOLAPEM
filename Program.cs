using Siad.Examples;
using Siad.Models.DTOs;
using Siad.Services;
using Siad.Test;
using System.Runtime.InteropServices;

//AuthServices authServices =  new AuthServices();
//var data = await authServices.ConfigurarEmpresaAsync();


//EstadoService estado = new EstadoService();
//await estado.EnviarEstadoSidAsync("EN_ESPERA");



//InstrumentoService instrumentoService = new InstrumentoService();
//await instrumentoService.ObtenerInstrumentosAsync();

/*var data = await instrumentoService.RegistrarInstrumentoAsync(new Siad.Models.DTOs.InstrumentoDTO
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
});*/

/*var data = await instrumentoService.ActualizarInstrumentoAsync(new Siad.Models.DTOs.InstrumentoDTO
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
});*/

//PrototipoService protoripoService = new PrototipoService();
//await protoripoService.ObtenerPrototiposAsync();

/*var data = await protoripoService.RegistrarPrototipoAsync(new Siad.Models.DTOs.PrototipoDTO { 
    Id ="",
    Numero = "K3112-21-E/3249",
    FechaEmision = "2025-09-24T18:44:19.178Z",
    FechaVencimiento = "2025-09-24T18:44:19.178Z",
    UrlArchivo = "https://www.cfe.mx",
    MD5 = "",
    Estatus = "ACTIVO",
    FechaRegistro = "2025-09-24T18:44:19.178Z"
});*/

/*var data = await protoripoService.ActualizarPrototipoAsync(new Siad.Models.DTOs.PrototipoDTO
{
    Id = "68d42e567468b29c5e35b042",
    Numero = "K3112-21-E/3252",
    FechaEmision = "2025-09-24T18:44:19.178Z",
    FechaVencimiento = "2025-09-24T18:44:19.178Z",
    UrlArchivo = "https://www.cfe.mx",
    MD5 = "",
    Estatus = "ACTIVO",
    FechaRegistro = "2025-09-24T18:44:19.178Z"
}); */

//ValorReferenciaService valorReferenciaService = new ValorReferenciaService();
//await valorReferenciaService.ObtenerValoresReferenciaAsync();

/*Aqui falta probar su funcionamiento requiero producto y id de prueba
 * var data = await valorReferenciaService.RegistrarValorReferenciaAsync(new Siad.Models.DTOs.ValorReferenciaDTO { 
    Id = "",
    IdProducto = "68d2f021ce3b00aacea97212",
    IdPrueba = "68d2eea6ce3b00aacea97200",
    Valor = "10",
    Valor2 = "0",
    Unidad = "ohm/km",
    Comparacion = "VALOR_MINIMO",
    FechaRegistro = "2025-09-24T19:11:43.292Z"

});*/


/*var data = await valorReferenciaService.ActualizarValorReferenciaAsync(new Siad.Models.DTOs.ValorReferenciaDTO
{
    Id = "68d2f1a1ce3b00aacea9721f",
    IdProducto = "68d2f021ce3b00aacea97212",
    IdPrueba = "68d2eea6ce3b00aacea97200",
    Valor = "9",
    Valor2 = "0",
    Unidad = "ohm/km",
    Comparacion = "VALOR_MINIMO",
    FechaRegistro = "2025-09-24T19:11:43.292Z"

});*/

ProductoService productoService = new ProductoService();
//await productoService.ObtenerProductosAsync();

/*var data = await productoService.RegistrarProductoAsync(new Siad.Models.DTOs.AgregarProductoDTO
{
    Id = "",
    CodigoFabricante = "CFC900",
    Descripcion = "Alambre TWDZ",
    DescripcionCorta = "ACSR 3/0",
    TipoFabricacion = "LOTE",
    Unidad = "kg",
    Norma = "68d2ec44ce3b00aacea971f1",
    Prototipo = "68d2eaf7ce3b00aacea971e6",
    Estatus = "ACTIVO",
    FechaRegistro = "2025-09-24T19:04:09.460Z",
    Pruebas = ["68d2eea6ce3b00aacea97200"]

});*/

/*var data = await productoService.ActualizarProductoAsync(new Siad.Models.DTOs.AgregarProductoDTO
{
    Id = "68d435897468b29c5e35b05a",
    CodigoFabricante = "CFC900",
    Descripcion = "Alambre TWDZ34",
    DescripcionCorta = "ACSR 3/0",
    TipoFabricacion = "LOTE",
    Unidad = "kg",
    Norma = "68d2ec44ce3b00aacea971f1",
    Prototipo = "68d2eaf7ce3b00aacea971e6",
    Estatus = "ACTIVO",
    FechaRegistro = "2025-09-24T19:04:09.460Z",
    Pruebas = ["68d2eea6ce3b00aacea97200"]

});*/

/*
 * Revisar funcionamiento
 * var data = await productoService.AsociarPruebasAProductoAsync("68d435897468b29c5e35b05a", ["68d2eea6ce3b00aacea97200", "68d4372c7468b29c5e35b069"]);*/

/*NormaService normaService = new NormaService();
await normaService.ObtenerNormasAsync();*/

//PruebaService pruebaService = new PruebaService();
//await pruebaService.ObtenerPruebasAsync();

/*await pruebaService.RegistrarPruebaAsync(new Siad.Models.DTOs.PruebaDTO {
    Id="",
    Nombre= "Resistencia electrica del conductor 3",
    Estatus = "ACTIVA",
    TipoPrueba = "ACEPTACION",
    TipoResultado = "VALOR_REFERENCIA",
    FechaRegistro = "2025-09-24T19:00:34.414Z"
});*/


/*await pruebaService.ActualizarPruebaAsync(new Siad.Models.DTOs.PruebaDTO
{
    Id = "68d4443a7468b29c5e35b0ac",
    Nombre = "Resistencia electrica del conductor 4",
    Estatus = "ACTIVA",
    TipoPrueba = "ACEPTACION",
    TipoResultado = "VALOR_REFERENCIA",
    FechaRegistro = "2025-09-24T19:00:34.414Z"
});*/

//ContratoService contratoService = new ContratoService();
//await contratoService.ObtenerContratosAsync(1,1);

/*var data = await contratoService.RegistrarContratoAsync(new Siad.Models.DTOs.ContratoDTO
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
    MD5 ="",
    FechaEntregaCFE = "2025-07-18T17:25:06.51Z"
});

*/

/*var data = await contratoService.ActualizarContratoAsync(new Siad.Models.DTOs.ContratoDTO
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
*/

//OrdenFabricacionService ordenFabricacionService = new OrdenFabricacionService();
//await ordenFabricacionService.ObtenerOrdenFabricacionAsync("68d30349ce3b00aacea97254");
/*var data = await ordenFabricacionService.CrearOrdenFabricacionAsync(new OrdenFabricacionDTO { 
    Id="",
    ClaveOrdenFabricacion="OF2027",
    LoteFabricacion="LT2026",
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

});*/

/*var data = await ordenFabricacionService.ActualizarOrdenFabricacionAsync(new OrdenFabricacionDTO
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

});*/

//ExpedienteService expedienteService = new ExpedienteService();
//await expedienteService.ObtenerExpedientesAsync();

//await expedienteService.ObtenerExpedientePorIdAsync("EXP-2025");

/*var data = await expedienteService.CrearExpedienteAsync(new ExpedienteInspeccionDTO { 
    Id = "",
    ClaveExpediente = "EXP-2025_2",
    OrdenFabricacion = "68d30349ce3b00aacea97254",
    CantidadMuestras ="5",
    MaximoRechazos= "0",
    Muestras = ["tramo1", "tramo2", "tramo3"]
});*/

/*var data = await expedienteService.ActualizarExpedienteAsync(new ExpedienteInspeccionDTO
{
    Id = "68d459767468b29c5e35b153",
    ClaveExpediente = "EXP-2025_23",
    OrdenFabricacion = "68d30349ce3b00aacea97254",
    CantidadMuestras = "5",
    MaximoRechazos = "0",
    Muestras = ["tramo1", "tramo2", "tramo3"]
});*/

//var data = await expedienteService.AgregarMuestraAsync("EXP-2025_23","tramo4");

//var data = await expedienteService.QuitarMuestraAsync("EXP-2025_23", "tramo4");




/*Practica6 main = new Practica6();
await main.EjecutarAsync();
*/

EscenarioExamen escenarioExamen = new EscenarioExamen();
await escenarioExamen.EjecutarAsync();

