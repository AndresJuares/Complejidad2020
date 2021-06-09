using System;
using System.Collections.Generic;

namespace ComplejidadTemporal
{
    public class Cola<T>
    {
        //VARIABLES QUE TENDRA LA CLASE COLA
        private List<T> datos = new List<T>();


        //CONSTRUCTOR DE LA CLASE
        public Cola()
        {
        }

        //METODO PARA ENCOLAR
        public void encolar(T elem)
        {
            this.datos.Add(elem);
        }


        //METODO PARA DESENCOLAR
        public T desencolar()
        {
            T temp = this.datos[0];
            this.datos.RemoveAt(0);
            return temp;
        }

        //METODO PARA SABER EL TOPE
        public T tope()
        {
            return this.datos[this.datos.Count - 1];
        }

        //METODO PARA SABER SI LA COLA ESTA VACIA
        public bool EsVacia()
        {
            return this.datos.Count == 0;
        }
    }
}
