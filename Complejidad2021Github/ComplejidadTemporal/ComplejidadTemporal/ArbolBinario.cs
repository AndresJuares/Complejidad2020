using System;
using System.Collections.Generic;
namespace ComplejidadTemporal
{
    public class ArbolBinario<T>
    {

        //VARIABLES QUE TENDRA LA CLASE ARBOLBINARIO
        private T dato;
        private ArbolBinario<T> Hijoizquierdo;
        private ArbolBinario<T> Hijoderecho;


        //CONSTRUCTOR VACIO
        public ArbolBinario()
        {
        }

        //CONSTRUCTOR CON PARAMETRO
        public ArbolBinario(T dato) {
            this.dato = dato;
        }

        //METODO PARA OBTENER EL DATO DE LA RAIZ
        public T GetDatoRaiz(){
            return this.dato;
        }

        //METODO PARA AGREGAR EL HIJO IZQUIERDO
        public void agregarHijoIzq(ArbolBinario<T> Hijoizq){
            this.Hijoizquierdo = Hijoizq;
        }

        //METODO PARA AGREGAR EL HIJO DERECHO
        public void agregarHijoDer(ArbolBinario<T> HijoDer){
            this.Hijoderecho = HijoDer;
        }

        //METODO PARA ELIMINAR EL HIJO IZQUIERDO
        public void eliminarHijoIzq(){
            this.Hijoizquierdo = null;
        }

        //METODO PARA ELIMINAR EL HIJO DERECHO
        public void eliminarHijoDer(){
            this.Hijoderecho = null;
        }

        //METODO PARA SABER SI ES HOJA
        public bool EsHoja() {
            return this.Hijoizquierdo == null && this.Hijoderecho == null;
        }

        //METODO PARA RECORRIDO EN INORDEN
        public void Inorden() {
            
        }

        //METODO PARA RECORRIDO EN POSTORDEN
        public void PostOrden() { 
        
        }

        //METODO PARA RECORRIDO EN PREORDEN
        public void Preorden() { 
        
        }


        //METODO PARA RECORRIDO POR NIVELES

        //METODO PARA CONTAR HOJAS 
        public int ContarHojas() {
            return 0;
        }
        //METODO PARA RECORRER ENTRE NIVELES
        public void RecorridoEntreNiveles(){
        
        }
    }
}
