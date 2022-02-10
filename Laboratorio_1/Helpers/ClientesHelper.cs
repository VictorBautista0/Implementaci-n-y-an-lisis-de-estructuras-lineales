using Laboratorio_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Helpers
{
    public class ClientesHelper
    {
        private static ClientesHelper _instancia = null;

        public static ClientesHelper Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ClientesHelper();
                }
                return _instancia;
            }
        }

        public List<ClientesModel> Lista = new List<ClientesModel>
        {
            new ClientesModel
            {
                Nombre = "Pancho",
                Apellido = "Villa",
                Telefono = 19022022,
                Descripcion = "Ocupante en VR"
            },

               new ClientesModel
            {
                Nombre = "Ramon",
                Apellido = "Tomogan",
                Telefono = 22022090,
                Descripcion = "Maestro de Karate en Curitua"
            },

               new ClientesModel
            {
                Nombre = "David",
                Apellido = "Sevilla",
                Telefono = 58904734,
                Descripcion = "Locutor de RadioFuna"
            },

               new ClientesModel
            {
                Nombre = "Imantado",
                Apellido = "Garatea",
                Telefono = 28550208,
                Descripcion = "Streamer IRL en Buich"
            },

               new ClientesModel
            {
                Nombre = "Arnaoldo",
                Apellido = "Cifuentes",
                Telefono = 63286545,
                Descripcion = "Chef de Pizzas"
            }
        };
    }
}
