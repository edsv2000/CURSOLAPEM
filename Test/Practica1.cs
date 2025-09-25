using Siad.Models.DTOs;
using Siad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Test
{
    public class Practica1
    {
        private readonly AuthServices _authServices;
        private readonly EstadoService _estadoService;

        public Practica1()
        {
            _authServices = new AuthServices();
            _estadoService = new EstadoService();
        }

        public async Task EjecutarAsync()
        {
            try
            {
                await LoginAsync();
                await ConfigurarEmpresaAsync();
                await EnviarEstadoAsync();
                Console.WriteLine("Flujo completado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo Practica1: {ex.Message}");
            }
        }

        private async Task LoginAsync()
        {
            var data = await _authServices.LoginAsync("e.svillegas@condumex.com.mx", "0LRPTY");
          
        }

        private async Task ConfigurarEmpresaAsync()
        {
            var data = await _authServices.ConfigurarEmpresaAsync();
           
        }

        private async Task EnviarEstadoAsync()
        {
            await _estadoService.EnviarEstadoSidAsync("EN_ESPERA");
            
        }
    }

}
