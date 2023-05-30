using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaServicios.Colecciones.SimpleEnlazadas;
namespace uTestLibColecciones.SimpleEnlazados
{
    [TestClass]
    public class uTestListaSimpleEnlazada
    {
        [TestMethod]
        public void Agregar()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(2));
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(5));
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(7));
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(8));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(0, varLista.DarItemActual());
            Assert.AreEqual(true, varLista.Contiene(n));
            n = -1;
            Assert.AreEqual(false, varLista.Contiene(n));
        }
        [TestMethod]
        public void Insertar()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Insertar(0, 2));
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Insertar(1, 5));
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Insertar(2, 7));
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Insertar(3, 8));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(0, varLista.DarItemActual());
            Assert.AreEqual(true, varLista.Contiene(n));
            n = -1;
            Assert.AreEqual(false, varLista.Contiene(n));
        }
        [TestMethod]
        public void Modificar()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(2));
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(5));
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(7));
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(8));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(0, varLista.DarItemActual());
            Assert.AreEqual(true, varLista.Contiene(n));
            n = -1;
            Assert.AreEqual(false, varLista.Contiene(n));

            Assert.AreEqual(true, varLista.Modificar(0, 6));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(0, ref n));
            Assert.AreEqual(6, n);

            Assert.AreEqual(true, varLista.Modificar(1, 777));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(1, ref n));
            Assert.AreEqual(777, n);

            Assert.AreEqual(true, varLista.Modificar(2, 888));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(2, ref n));
            Assert.AreEqual(888, n);

            Assert.AreEqual(true, varLista.Modificar(3, 999));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(3, ref n));
            Assert.AreEqual(999, n);

            Assert.AreEqual(false, varLista.Modificar(4, 6));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(false, varLista.Recuperar(4, ref n));
            Assert.AreEqual(0, n);
        }
        [TestMethod]
        public void Intercambiar()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(2));
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(5));
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(7));
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(8));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(0, varLista.DarItemActual());
            Assert.AreEqual(true, varLista.Contiene(n));
            n = -1;
            Assert.AreEqual(false, varLista.Contiene(n));

            Assert.AreEqual(true, varLista.Intercambiar(0, 3));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(0, ref n));
            Assert.AreEqual(8, n);
            Assert.AreEqual(true, varLista.Recuperar(3, ref n));
            Assert.AreEqual(2, n);

            Assert.AreEqual(true, varLista.Intercambiar(1, 2));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(1, ref n));
            Assert.AreEqual(7, n);
            Assert.AreEqual(true, varLista.Recuperar(2, ref n));
            Assert.AreEqual(5, n);

            Assert.AreEqual(false, varLista.Intercambiar(0, 5));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(0, ref n));
            Assert.AreEqual(8, n);
            Assert.AreEqual(false, varLista.Recuperar(5, ref n));
            Assert.AreEqual(0, n);
        }
        [TestMethod]
        public void Recuperar()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(2));
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(5));
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(7));
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(8));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(0, varLista.DarItemActual());
            Assert.AreEqual(true, varLista.Contiene(n));
            n = -1;
            Assert.AreEqual(false, varLista.Contiene(n));
            int[] vecN = { 2, 5, 7, 8 };
            for (int i = 0; i < varLista.darLongitud(); i++)
            {
                Assert.AreEqual(true, varLista.Recuperar(i, ref n));
                Assert.AreEqual(vecN[i], n);
            }
            Assert.AreEqual(false, varLista.Recuperar(12, ref n));
            Assert.AreEqual(0, n);
        }
        [TestMethod]
        public void Remover()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(2));
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(5));
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(7));
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(8));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(0, varLista.DarItemActual());
            Assert.AreEqual(true, varLista.Contiene(n));
            n = -1;
            Assert.AreEqual(false, varLista.Contiene(n));

            Assert.AreEqual(true, varLista.Remover(0, ref n));
            Assert.AreEqual(2, n);
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(0, ref n));
            Assert.AreEqual(5, n);

            Assert.AreEqual(true, varLista.Remover(0, ref n));
            Assert.AreEqual(5, n);
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(0, ref n));
            Assert.AreEqual(7, n);

            Assert.AreEqual(true, varLista.Remover(0, ref n));
            Assert.AreEqual(7, n);
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(0, ref n));
            Assert.AreEqual(8, n);

            Assert.AreEqual(true, varLista.Remover(0, ref n));
            Assert.AreEqual(8, n);
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(false, varLista.Recuperar(0, ref n));
            Assert.AreEqual(0, n);

            Assert.AreEqual(false, varLista.Remover(0, ref n));
            Assert.AreEqual(0, n);
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(false, varLista.Recuperar(0, ref n));
            Assert.AreEqual(0, n);
        }
        [TestMethod]
        public void RemoverEste()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(2));
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(5));
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(7));
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(8));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(0, varLista.DarItemActual());
            Assert.AreEqual(true, varLista.Contiene(n));
            n = -1;
            Assert.AreEqual(false, varLista.Contiene(n));

            n = 2;
            Assert.AreEqual(true, varLista.RemoverEste(ref n));
            Assert.AreEqual(2, n);
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(0, ref n));
            Assert.AreEqual(5, n);

            n = 5;
            Assert.AreEqual(true, varLista.RemoverEste(ref n));
            Assert.AreEqual(5, n);
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(0, ref n));
            Assert.AreEqual(7, n);

            n = 7;
            Assert.AreEqual(true, varLista.RemoverEste(ref n));
            Assert.AreEqual(7, n);
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Recuperar(0, ref n));
            Assert.AreEqual(8, n);

            n = 8;
            Assert.AreEqual(true, varLista.RemoverEste(ref n));
            Assert.AreEqual(8, n);
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(false, varLista.Recuperar(0, ref n));
            Assert.AreEqual(0, n);

            n = 8;
            Assert.AreEqual(false, varLista.RemoverEste(ref n));
            Assert.AreEqual(0, n);
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(false, varLista.Recuperar(0, ref n));
            Assert.AreEqual(0, n);
        }
        [TestMethod]
        public void Encontrar()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(2));
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(5));
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(7));
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(8));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(0, varLista.DarItemActual());
            Assert.AreEqual(true, varLista.Contiene(n));
            n = -1;
            Assert.AreEqual(false, varLista.Contiene(n));

            Assert.AreEqual(true, varLista.Encontrar(5, ref n));
            Assert.AreEqual(1, n);
            Assert.AreEqual(false, varLista.Encontrar(10, ref n));
            Assert.AreEqual(-1, n);
        }
        [TestMethod]
        public void Reversar()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(2));
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(5));
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(7));
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(8));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(0, varLista.DarItemActual());
            Assert.AreEqual(true, varLista.Contiene(n));
            n = -1;
            Assert.AreEqual(false, varLista.Contiene(n));
            Assert.AreEqual(true, varLista.Reversar());
            Assert.AreEqual(true, varLista.Recuperar(0, ref n));
            Assert.AreEqual(8, n);
        }     
        [TestMethod]
        public void OrdenamientoDePilaQuicSort()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            varLista.OrdenarQuickSort(false);
            Assert.AreEqual(16, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varLista.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaBurbujaSimple()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            Assert.AreEqual(16, varLista.DarLongitud());
            varLista.OrdenarBurbujaSimple(false);
            Assert.AreEqual(true, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varLista.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaBurbujaMejorado()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            Assert.AreEqual(16, varLista.DarLongitud());
            Assert.AreEqual(false, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varLista.darEstaOrdenadaDescendente());
            varLista.OrdenarBurbujaMejorado(false);
            Assert.AreEqual(true, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varLista.darEstaOrdenadaDescendente());
            varLista.OrdenarBurbujaMejorado(true);
            Assert.AreEqual(false, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varLista.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaInsercion()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            Assert.AreEqual(16, varLista.DarLongitud());
            Assert.AreEqual(false, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varLista.darEstaOrdenadaDescendente());
            varLista.OrdenarInsercion(false);
            Assert.AreEqual(true, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varLista.darEstaOrdenadaDescendente());
            varLista.OrdenarInsercion(true);
            Assert.AreEqual(false, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varLista.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaSeleccion()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            Assert.AreEqual(16, varLista.DarLongitud());
            Assert.AreEqual(false, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varLista.darEstaOrdenadaDescendente());
            varLista.OrdenarSeleccion(false);
            Assert.AreEqual(true, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varLista.darEstaOrdenadaDescendente());
            varLista.OrdenarSeleccion(true);
            Assert.AreEqual(false, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varLista.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaBurbujaBiDireccional()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            varLista.Agregar(2);
            varLista.Agregar(3);
            varLista.Agregar(4);
            varLista.Agregar(1);
            varLista.Agregar(2);
            varLista.Agregar(9);
            varLista.Agregar(11);
            varLista.Agregar(17);
            Assert.AreEqual(false, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varLista.darEstaOrdenadaDescendente());
            Assert.AreEqual(16, varLista.DarLongitud());
            varLista.ponerModoInteligente(true);
            varLista.OrdenarBurbujaBiDireccional(false);
            Assert.AreEqual(true, varLista.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varLista.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void Reversar2()
        {
            clsListaSimpleEnlazada<int> varLista = new clsListaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(2));
            Assert.AreEqual(1, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(5));
            Assert.AreEqual(2, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(7));
            Assert.AreEqual(3, varLista.DarLongitud());
            Assert.AreEqual(true, varLista.Agregar(8));
            Assert.AreEqual(4, varLista.DarLongitud());
            Assert.AreEqual(0, varLista.DarItemActual());
            Assert.AreEqual(true, varLista.Contiene(n));
            n = -1;
            Assert.AreEqual(false, varLista.Contiene(n));
            Assert.AreEqual(true, varLista.Reversar());
            Assert.AreEqual(true, varLista.Recuperar(0, ref n));
            Assert.AreEqual(8, n);
        }
    }
}
