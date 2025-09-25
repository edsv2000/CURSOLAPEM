using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Models.DTOs
{
    public class InstrumentoDTO
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string NumeroSerie { get; set; }
        public string FechaCalibracion { get; set; }
        public string FechaVencimientoCalibracion { get; set; }
        public string UrlArchivo { get; set; }
        public string MD5 { get; set; }
        public string Estatus { get; set; }
        public string FechaRegistro { get; set; }
    }
}
