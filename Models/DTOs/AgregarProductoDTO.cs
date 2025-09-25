using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Models.DTOs
{
    public class AgregarProductoDTO
    {
        public string Id { get; set; }
        public string CodigoFabricante { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public string TipoFabricacion { get; set; }
        public string Unidad { get; set; }
        public string Norma { get; set; }
        public string Prototipo { get; set; }
        public string Estatus { get; set; }
        public string FechaRegistro { get; set; }
        public List<string> Pruebas { get; set; }

    }
}
