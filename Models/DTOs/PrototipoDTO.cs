using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Models.DTOs
{
    public class PrototipoDTO
    {
        public string Id { get; set; }
        public string Numero { get; set; }
        public string FechaEmision { get; set; }
        public string FechaVencimiento { get; set; }
        public string UrlArchivo { get; set; }
        public string MD5 { get; set; }
        public string Estatus { get; set; }
        public string FechaRegistro { get; set; }
    }
}
