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
                Nombre = "a",
                Apellido = "Villa",
                Telefono = 19022022,
                Descripcion = "Ocupan"
            },

               new ClientesModel
            {
                Nombre = "Pancho",
                Apellido = "Villa",
                Telefono = 19022022,
                Descripcion = "Ocupan"
            },

               new ClientesModel
            {
                Nombre = "Pancho",
                Apellido = "Villa",
                Telefono = 19022022,
                Descripcion = "Ocupan"
            },

               new ClientesModel
            {
                Nombre = "Pancho",
                Apellido = "Villa",
                Telefono = 19022022,
                Descripcion = "Ocupan"
            }
        };
    }
}
