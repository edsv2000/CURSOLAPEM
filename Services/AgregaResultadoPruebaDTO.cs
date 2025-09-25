using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Services
{
    public class AgregaResultadoPruebaDTO
    {
        public string IdPrueba { get; set; }
        public string IdValorReferencia { get; set; }
        public string FechaPrueba { get; set; }
        public string OperadorPrueba { get; set; }
        public string IdInstrumentoMedicion { get; set; }
        public string ValorMedido { get; set; }
        public string Resultado { get; set; }
        public string NumeroIntento { get; set; }
    }
}
