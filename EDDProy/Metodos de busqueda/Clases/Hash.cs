using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EDDemo.Estructuras_Lineales.Clases; // Importar la clase ListaSimple
namespace HashNamespace
{
    public class Hash
    {
        private const int TAMANIO = 100; // Tamaño fijo de la tabla hash
        private int[] claves;           // Almacena las claves generadas
        private string[] valores;       // Almacena los productos
        private ListaSimple[] tabla; // Usar ListaSimple para resolver colisiones
        public Hash()
        {
            tabla = new ListaSimple[TAMANIO];
            for (int i = 0; i < TAMANIO; i++)
            {
                tabla[i] = new ListaSimple(); // Inicializar cada índice con una lista simple
            }
        }

        // Función hash simple (modular)
        private int FuncionHash(int clave)
        {
            return clave % TAMANIO;
        }

        // Función hash polinomial para cadenas
        public static int FuncionHashPolinomial(string clave, int tamanioTabla)
        {
            const int basePolinomial = 31;
            int hash = 0;
            for (int i = 0; i < clave.Length; i++)
            {
                hash = (hash * basePolinomial + clave[i]) % tamanioTabla;
            }
            return Math.Abs(hash);
        }

        // Insertar clave y valor
        public void Insertar(int clave, string valor)
        {
            int indice = FuncionHash(clave);
            tabla[indice].InsertarFinal(valor); // Insertar el valor al final de la lista en caso de colisión
        }

        // Buscar valores por su clave
        public string Buscar(int clave)
        {
            int indice = FuncionHash(clave);
            var resultado = tabla[indice].ToString(); // Devolver todos los elementos de la lista como cadena
            return resultado != " -> null" ? resultado : null; // Verificar si la lista contiene elementos
        }

        // Guardar claves y valores en un archivo
        public void GuardarEnArchivo(string ruta)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                for (int i = 0; i < TAMANIO; i++)
                {
                    if (claves[i] != -1)
                    {
                        sw.WriteLine($"{claves[i]},{valores[i]}");
                    }
                }
            }
        }
        // Vaciar toda la tabla hash
        public void VaciarTabla()
        {
            for (int i = 0; i < TAMANIO; i++)
            {
                tabla[i].VaciarHash(); // Vaciar cada lista simple
            }
        }
        // Cargar claves y valores desde un archivo
        public void CargarDesdeArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length == 2)
                    {
                        int clave = int.Parse(partes[0]);
                        string valor = partes[1];
                        Insertar(clave, valor);
                    }
                }
            }
        }
    }
}
