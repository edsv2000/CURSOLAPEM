using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Models.DTOs
{
    public class DetalleContratoDTO
    {
        public string PartidaContrato { get; set; }

        public string DescripcionAviso { get; set; }

        public string AreaDestinoCFE { get; set; }

        public string Cantidad { get; set; }

        public string Unidad { get; set; }

        public string ImporteTotal { get; set; }
    }
}
