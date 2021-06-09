using System;
using System.Collections.Generic;
namespace ComplejidadTemporal
{
    public class ArbolGeneral<T>
    {
        //VARIABLES QUE TENDRA LA CLASE
        private T dato;
        private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();


        //CONSTRUCTOR CON PARAMETRO
        public ArbolGeneral(T dato)
        {
            this.dato = dato;
        }

        //METODO PARA OBTENER EL DATO DE LA RAIZ
        public T GetDatoRaiz()
        {
            return this.dato;
        }


        //METODO PARA OBTENER UN HIJO
        public List<ArbolGeneral<T>> GetHijos()
        {
            return hijos;
        }


        //METODO PARA AGREGAR UN HIJO
        public void AgregarHijo(ArbolGeneral<T> Hijo)
        {
            GetHijos().Add(Hijo);
        }

        //METODO PARA ELIMINAR UN HIJO
        public void EliminarHijo(ArbolGeneral<T> Hijo)
        {
            this.GetHijos().Remove(Hijo);

        }

        //METODO PARA SABER SI ES HOJA

        public bool EsHoja()
        {
            return this.GetHijos().Count == 0;
        }


        //METODO PARA SABER LA ALTURA
        public int altura()
        {
            return 0;
        }

        //METODO PARA SABER EL NIVEL
        public int nivel(T dato)
        {
            return 0;
        }
    }
}
