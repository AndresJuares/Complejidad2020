using System;

namespace ComplejidadTemporal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArbolBinario<int> arbolBinarioA = new ArbolBinario<int>(1);

            ArbolBinario<int> hijoIzquierdo = new ArbolBinario<int>(2);
            hijoIzquierdo.agregarHijoIzq(new ArbolBinario<int>(3));
            hijoIzquierdo.agregarHijoDer(new ArbolBinario<int>(4));

            ArbolBinario<int> hijoDerecho = new ArbolBinario<int>(5);
            hijoDerecho.agregarHijoIzq(new ArbolBinario<int>(6));
            hijoDerecho.agregarHijoDer(new ArbolBinario<int>(7));

            arbolBinarioA.agregarHijoIzq(hijoIzquierdo);
            arbolBinarioA.agregarHijoDer(hijoDerecho);

            arbolBinarioA.Preorden();
            arbolBinarioA.Inorden();
            arbolBinarioA.PostOrden();
            arbolBinarioA.RecorridoEntreNiveles();
            Console.WriteLine("Hola Mundo");
        }
    }
}
