using Siad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siad.Test
{
    public class Practica5
    {
        private readonly ProductoService _productoService;
        public Practica5() {
            _productoService = new ProductoService();
        }

        public async Task EjecutarAsync()
        {
            try
            {
                //Falta revisar asociacion de productos
                await ProductosRegistrados();
                await RegistrarProducto();
                await ActualizarProducto();
                Console.WriteLine("Flujo completado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en flujo Practica1: {ex.Message}");
            }
        }

        public async Task ProductosRegistrados()
        {


            await _productoService.ObtenerProductosAsync();

        }

        public async Task RegistrarProducto() {
            await _productoService.RegistrarProductoAsync(new Siad.Models.DTOs.AgregarProductoDTO
            {
                Id = "",
                CodigoFabricante = "CFC900",
                Descripcion = "Alambre TWDZ",
                DescripcionCorta = "ACSR 3/0",
                TipoFabricacion = "LOTE",
                Unidad = "kg",
                Norma = "68d2ec44ce3b00aacea971f1",
                Prototipo = "68d2eaf7ce3b00aacea971e6",
                Estatus = "ACTIVO",
                FechaRegistro = "2025-09-24T19:04:09.460Z",
                Pruebas = ["68d2eea6ce3b00aacea97200"]

            });
        }

        public async Task ActualizarProducto() {

            await _productoService.ActualizarProductoAsync(new Siad.Models.DTOs.AgregarProductoDTO
            {
                Id = "68d435897468b29c5e35b05a",
                CodigoFabricante = "CFC900",
                Descripcion = "Alambre TWDZ34",
                DescripcionCorta = "ACSR 3/0",
                TipoFabricacion = "LOTE",
                Unidad = "kg",
                Norma = "68d2ec44ce3b00aacea971f1",
                Prototipo = "68d2eaf7ce3b00aacea971e6",
                Estatus = "ACTIVO",
                FechaRegistro = "2025-09-24T19:04:09.460Z",
                Pruebas = ["68d2eea6ce3b00aacea97200"]

            });
        }

    }
}
