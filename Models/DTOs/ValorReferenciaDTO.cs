using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Models.DTOs
{
    public class ValorReferenciaDTO
    {
        public string Id { get; set; }
        public string IdProducto { get; set; }
        public string IdPrueba { get; set; }
        public string Valor { get; set; }
        public string Valor2 { get; set; }
        public string Unidad { get; set; }
        public string Comparacion { get; set; }
        public string FechaRegistro { get; set; }
    }
}
