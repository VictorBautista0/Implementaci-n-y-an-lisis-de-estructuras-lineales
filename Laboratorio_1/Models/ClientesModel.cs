using Laboratorio_1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Models
{
    public class ClientesModel
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Telefono { get; set; }

        public string Descripcion { get; set; }

        public static void Guardar(ClientesModel NuevoCliente)
        {
            ClientesHelper.Instancia.Lista.Add(NuevoCliente);
        }

        public static void NombreAscendente()
        {
            for (int i = 0; i < ClientesHelper.Instancia.Lista.Count; i++)
            {
                for (int j = 0; j < ClientesHelper.Instancia.Lista.Count - 1 - i; j++)
                {
                    int n = ClientesHelper.Instancia.Lista[j].Nombre.CompareTo(ClientesHelper.Instancia.Lista[j + 1].Nombre);
                    if (n > 0)
                    {
                        var auxiliar = ClientesHelper.Instancia.Lista[j + 1];
                        ClientesHelper.Instancia.Lista[j + 1] = ClientesHelper.Instancia.Lista[j];
                        ClientesHelper.Instancia.Lista[j] = auxiliar;
                    }
                }
            }
        }

        public static void ApellidoAscendente()
        {
            for (int i = 0; i < ClientesHelper.Instancia.Lista.Count; i++)
            {
                for (int j = 0; j < ClientesHelper.Instancia.Lista.Count - 1 - i; j++)
                {
                    int n = ClientesHelper.Instancia.Lista[j].Apellido.CompareTo(ClientesHelper.Instancia.Lista[j + 1].Apellido);
                    if (n > 0)
                    {
                        var auxiliar = ClientesHelper.Instancia.Lista[j + 1];
                        ClientesHelper.Instancia.Lista[j + 1] = ClientesHelper.Instancia.Lista[j];
                        ClientesHelper.Instancia.Lista[j] = auxiliar;
                    }
                }
            }
        }
    }
}
