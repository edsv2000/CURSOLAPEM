using Siad.Models.DTOs;
using Siad.Models.Responses;
using SiadApiClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Siad.Services
{
    public class ProductoService
    {

        public async Task<string> ObtenerProductosAsync()
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Producto");
            ResponseDTO response = await request.Get();

            if (response.Success)
            {
                return response.Data;


            }
            else
            {
                return "ERROR: " + response.Data;
            }

        }

        public async Task<string> RegistrarProductoAsync(AgregarProductoDTO data)
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Producto");
            ResponseDTO response = await request.Post(data);

            if (response.Success)
            {
                Console.WriteLine("Se registro correctamente. " + response.Data);
               
            }
            else
            {
                Console.WriteLine("No se realizo el registro correctamere. ERROR:" + response.Data);
              
            }

            return response.Data;
        }

        public async Task<bool> ActualizarProductoAsync(AgregarProductoDTO data)
        {
            ApiClient request = new ApiClient("F1_ConfiguracionInicial", "Producto");
            ResponseDTO response = await request.Put(data);

            if (response.Success)
            {
                Console.WriteLine("Se actualizo correctamente. " + response.Data);
                return true;
            }
            else
            {
                Console.WriteLine("No se actualizo el registro correctamere. ERROR:" + response.Data);
                return false;
            }
        }

        public async Task<bool> AsociarPruebasAProductoAsync(string productoId, List<string> pruebasIds)
        {
            try
            {
                string data = await this.ObtenerProductosAsync();


                if (string.IsNullOrWhiteSpace(data))
                {
                    Console.WriteLine("No se obtuvo información de productos.");
                    return false;
                }

                var productos = JsonSerializer.Deserialize<List<AgregarProductoDTO>>(data, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });




                if (productos == null || !productos.Any())
                {
                    Console.WriteLine("La lista de productos está vacía o no se pudo deserializar.");
                    return false;
                }

                var producto = productos.FirstOrDefault(p => p.Id == productoId);
                if (producto == null)
                {
                    Console.WriteLine($"No se encontró el producto con ID: {productoId}");
                    return false;
                }

                // Aquí sí se asocian las pruebas
                producto.Pruebas = pruebasIds; // Asegúrate de que esta propiedad exista en AgregarProductoDTO

                bool isUpdate = await this.ActualizarProductoAsync(producto);

                Console.WriteLine(isUpdate
                    ? $"Se asociaron las pruebas al producto {productoId}"
                    : $"No se pudo actualizar el producto {productoId}");

                return isUpdate;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al asociar pruebas: {ex.Message}");
                return false;
            }
        }


    }
}
