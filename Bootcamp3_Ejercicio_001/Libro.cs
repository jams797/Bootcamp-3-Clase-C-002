using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp3_Ejercicio_001
{
    class Libro
    {
        private string nombre;
        private string autor;
        private int anioPublicacion;

        public Libro(string nombre, string autor, int anioPublicacion)
        {
            this.nombre = nombre;
            this.autor = autor;
            this.anioPublicacion = anioPublicacion;
        }

        public string obtenerDescripcion()
        {
            return $"El libro '{nombre}' del autor '{autor}' se publico en el año {anioPublicacion}";
        }
    }
}
