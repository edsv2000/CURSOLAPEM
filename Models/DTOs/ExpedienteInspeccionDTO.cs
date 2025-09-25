using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Models.DTOs
{
    public class ExpedienteInspeccionDTO
    {
        public string Id { get; set; }

        public string ClaveExpediente { get; set; }

        public string OrdenFabricacion { get; set; }

        public string CantidadMuestras { get; set; }

        public string MaximoRechazos { get; set; }

        public List<string> Muestras { get; set; }
    }

}
