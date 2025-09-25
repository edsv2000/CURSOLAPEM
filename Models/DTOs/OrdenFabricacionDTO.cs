using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Models.DTOs
{
    public class OrdenFabricacionDTO
    {
        public string Id { get; set; }

        public string ClaveOrdenFabricacion { get; set; }

        public string LoteFabricacion { get; set; }

        public string IdProducto { get; set; }

        public List<DetalleFabricacionDTO> DetalleFabricacion { get; set; } = new();

    }
}
