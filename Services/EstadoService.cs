using Siad.Models.DTOs;
using Siad.Models.Responses;
using SiadApiClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Services
{
    public class EstadoService
    {
        public async Task EnviarEstadoSidAsync(string estado) {

            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "EstadoSID");

            EstadoServicioDTO EstadoServicio = new EstadoServicioDTO
            {
               estado = estado
            };

            ResponseDTO response = await request.Post(EstadoServicio);

            if (response.Success)
            {
                Console.WriteLine("Se reporto correctamente al SID");
            }
            else {
                Console.WriteLine(response.Data);
            }
         
        }
    }
}
