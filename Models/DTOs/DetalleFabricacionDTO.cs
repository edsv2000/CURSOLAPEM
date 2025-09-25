using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Models.DTOs
{
    public class DetalleFabricacionDTO
    {
        public string ContratoId { get; set; }

        public string TipoContrato { get; set; }

        public string PartidaContratoId { get; set; }

        public string DescripcionPartida { get; set; }

        public string Unidad { get; set; }

        public string CantidadOriginalContrato { get; set; }

        public string CantidadAFabricar { get; set; }

    }
}
