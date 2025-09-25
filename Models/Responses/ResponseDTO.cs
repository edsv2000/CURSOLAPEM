using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Models.Responses
{
    public class ResponseDTO
    {
        public bool Success { get; set; }
        public int Code { get; set; }
        public string Data { get; set; }

    }
}
