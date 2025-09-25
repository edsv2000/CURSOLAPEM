using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Siad.Models.DTOs
{
    public class ContratoDTO
    {
        public string Tipo { get; set; }

        public string Id { get; set; }
        public string TipoContrato { get; set; }
        public string NoContrato { get; set; }
        public string Estatus { get; set; }

        public List<DetalleContratoDTO> DetalleContrato { get; set; } = new();

        public string UrlArchivo { get; set; }
        public string MD5 { get; set; }
        public string FechaEntregaCFE { get; set; }
    }
}
