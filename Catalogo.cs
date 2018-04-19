using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasConArreglos
{
    class Catalogo
    {
        private string[] vec;
        private string Informacion;
        private int contador;

   

        public Catalogo()
        {
            Informacion = "";
            vec = new string[15];
            contador = 0;
        }

      /*  public bool validarAgregar(string placa)
        {
            for (int x = 0; x < contador; x++)
            {
                if (vec[x].Contains(placa))
                {
                    return true;
                }
                else
                    return false;
            }

            return false;
        }*/

        public void agregar(string nombre1, string año1, string placa1, string telefono1)
        {
            
            Informacion = " ";
            Informacion = nombre1 + " " + año1 + " " + placa1 + " " + telefono1 + " ";
            vec[contador] = Informacion;
            contador++;
        }

        public string listar()
        {
            string lista= "";
            for (int x = 0; x < contador; x++)
            {
               lista += vec[x] + Environment.NewLine;
              
            }
            return lista;
        }

        public void eliminar(string placa)
        {
            for (int x = 0; x < contador; x++)
            {
                if (vec[x].Contains(placa))
                {

                    while (x < contador)
                    {
                        vec[x] = vec[x + 1];
                        x++;
                    }                 
            
                }

            }
            contador--;
        }

        public void insertar(string nombre1, string año1, string placa1, string telefono1, string placa)
        {
            for (int x = 0; x < contador; x++)
            {
                if (vec[x].Contains(placa))
                {
                    Informacion = " ";
                    Informacion = nombre1 + " " + año1 + " " + placa1 + " " + telefono1 + " ";
                    vec[x] = Informacion;
                }

            }

        }
    }
}
