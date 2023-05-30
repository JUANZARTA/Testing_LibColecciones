using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaServicios.Colecciones.SimpleEnlazadas;
namespace uTestLibColecciones.SimpleEnlazados
{
    [TestClass]
    public class uTestPilaSimpleEnlazada
    {
        [TestMethod]
        public void Apilar()
        {
            clsPilaSimpleEnlazada<int> varPila = new clsPilaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(2));
            Assert.AreEqual(1, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(5));
            Assert.AreEqual(2, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(7));
            Assert.AreEqual(3, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(8));
            Assert.AreEqual(4, varPila.DarLongitud());
            Assert.AreEqual(0, varPila.DarItemActual());
            Assert.AreEqual(true, varPila.Revisar(ref n));
            n = -1;
            Assert.AreEqual(true, varPila.Revisar(ref n));
        }     
        [TestMethod]
        public void DesApilar()
        {
            int n = 0;
            clsPilaSimpleEnlazada<int> varPila = new clsPilaSimpleEnlazada<int>();
            Assert.AreEqual(0, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(2));
            Assert.AreEqual(1, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(5));
            Assert.AreEqual(2, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(7));
            Assert.AreEqual(3, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(8));
            Assert.AreEqual(4, varPila.DarLongitud());
            Assert.AreEqual(0, varPila.DarItemActual());

            Assert.AreEqual(true, varPila.Desapilar(ref n));
            Assert.AreEqual(8, n);
            Assert.AreEqual(3, varPila.darLongitud());
            Assert.AreEqual(true, varPila.Desapilar(ref n));
            Assert.AreEqual(7, n);
            Assert.AreEqual(2, varPila.darLongitud());
            Assert.AreEqual(true, varPila.Desapilar(ref n));
            Assert.AreEqual(5, n);
            Assert.AreEqual(1, varPila.darLongitud());
            Assert.AreEqual(true, varPila.Desapilar(ref n));
            Assert.AreEqual(2, n);
            Assert.AreEqual(0, varPila.darLongitud());
        }
        [TestMethod]
        public void DesApilarConPilaVacia()
        {
            int n = 0;
            clsPilaSimpleEnlazada<int> varPila = new clsPilaSimpleEnlazada<int>();
            Assert.AreEqual(0, varPila.DarLongitud());
            Assert.AreEqual(false, varPila.Desapilar(ref n));
            Assert.AreEqual(0, n);
            Assert.AreEqual(0, varPila.DarLongitud());
        }
        [TestMethod]
        public void Revisar()
        {
            clsPilaSimpleEnlazada<int> varPila = new clsPilaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(2));
            Assert.AreEqual(1, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(5));
            Assert.AreEqual(2, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(7));
            Assert.AreEqual(3, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(8));
            Assert.AreEqual(4, varPila.DarLongitud());
            Assert.AreEqual(0, varPila.DarItemActual());
            Assert.AreEqual(true, varPila.Revisar(ref n));
            Assert.AreEqual(8, n);
            Assert.AreEqual(true, varPila.Desapilar(ref n));
            Assert.AreEqual(8, n);
            Assert.AreEqual(true, varPila.Revisar(ref n));
            Assert.AreEqual(7, n);
            Assert.AreEqual(true, varPila.Desapilar(ref n));
            Assert.AreEqual(7, n);
            Assert.AreEqual(true, varPila.Revisar(ref n));
            Assert.AreEqual(5, n);
            Assert.AreEqual(true, varPila.Desapilar(ref n));
            Assert.AreEqual(5, n);
            Assert.AreEqual(true, varPila.Revisar(ref n));
            Assert.AreEqual(2, n);
            Assert.AreEqual(true, varPila.Desapilar(ref n));
            Assert.AreEqual(2, n);
            Assert.AreEqual(false, varPila.Revisar(ref n));
            Assert.AreEqual(0, n);
        }
        [TestMethod]
        public void OrdenamientoDePilaQuicSort()
        {
            clsPilaSimpleEnlazada<int> varPila = new clsPilaSimpleEnlazada<int>();
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            varPila.OrdenarQuickSort(false);

            Assert.AreEqual(true, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
            varPila.OrdenarQuickSort(true);

            Assert.AreEqual(false, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varPila.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaBurbujaSimple()
        {
            clsPilaSimpleEnlazada<int> varPila = new clsPilaSimpleEnlazada<int>();
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            Assert.AreEqual(16, varPila.DarLongitud());
            varPila.OrdenarBurbujaSimple(false);
            int[] vec = varPila.darVectorItem();
            Assert.AreEqual(true, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
            varPila.OrdenarBurbujaSimple(true);
            int[] vec2 = varPila.darVectorItem();
            int n = 0;
        }
        [TestMethod]
        public void OrdenamientoDePilaBurbujaMejorado()
        {
            clsPilaSimpleEnlazada<int> varPila = new clsPilaSimpleEnlazada<int>();
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            Assert.AreEqual(16, varPila.DarLongitud());
            Assert.AreEqual(false, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
            varPila.OrdenarBurbujaMejorado(false);
            int[] vec = varPila.darVectorItem();
            Assert.AreEqual(true, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
            varPila.OrdenarBurbujaMejorado(true);
            Assert.AreEqual(false, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varPila.darEstaOrdenadaDescendente());
            varPila.OrdenarBurbujaMejorado(true);
            int[] vec2 = varPila.darVectorItem();
            int n = 0;
        }
        [TestMethod]
        public void OrdenamientoDePilaInsercion()
        {
            clsPilaSimpleEnlazada<int> varPila = new clsPilaSimpleEnlazada<int>();
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            Assert.AreEqual(16, varPila.DarLongitud());
            Assert.AreEqual(false, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
            varPila.OrdenarInsercion(false);
            Assert.AreEqual(true, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
            varPila.OrdenarInsercion(true);
            Assert.AreEqual(false, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varPila.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaSeleccion()
        {
            clsPilaSimpleEnlazada<int> varPila = new clsPilaSimpleEnlazada<int>();
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            Assert.AreEqual(16, varPila.DarLongitud());
            Assert.AreEqual(false, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
            varPila.OrdenarSeleccion(false);
            Assert.AreEqual(true, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
            varPila.OrdenarSeleccion(true);
            Assert.AreEqual(false, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varPila.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaBurbujaBiDireccional()
        {
            clsPilaSimpleEnlazada<int> varPila = new clsPilaSimpleEnlazada<int>();
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            varPila.Apilar(2);
            varPila.Apilar(3);
            varPila.Apilar(4);
            varPila.Apilar(1);
            varPila.Apilar(2);
            varPila.Apilar(9);
            varPila.Apilar(11);
            varPila.Apilar(17);
            Assert.AreEqual(false, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
            Assert.AreEqual(16, varPila.DarLongitud());
            varPila.ponerModoInteligente(true);
            varPila.OrdenarBurbujaBiDireccional(false);
            Assert.AreEqual(true, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
        }
    }
}
