using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaServicios.Colecciones.SimpleEnlazadas;
namespace uTestLibColecciones.SimpleEnlazados
{
    [TestClass]
    public class uTestColaSimpleEnlazada
    {
        [TestMethod]
        public void TestEncolar()
        {
            clsColaSimpleEnlazada<int> varCola = new clsColaSimpleEnlazada<int>();
            varCola.Encolar(3);
            varCola.Encolar(5);
            varCola.Encolar(3);
            varCola.Encolar(5);
            varCola.Encolar(3);
            varCola.Encolar(8);
            int[] varPrueba = { 3, 5, 3, 5, 3, 8 };

            int i = 0;
            foreach (var item in varCola.darVectorItem())
            {
                Assert.AreEqual(varPrueba[i], item);
                i++;
            }
        }
        [TestMethod]
        public void TestDesencolar()
        {
            int n = 0;
            clsColaSimpleEnlazada<int> varCola = new clsColaSimpleEnlazada<int>();
            varCola.Encolar(3);
            varCola.Encolar(5);
            varCola.Encolar(3);
            varCola.Encolar(5);
            varCola.Encolar(3);
            varCola.Encolar(8);
            varCola.Encolar(9);
            varCola.Desencolar(ref n);
            int[] varPrueba = { 5, 3, 5, 3, 8, 9 };
            int i = 0;
            foreach (var item in varCola.darVectorItem())
            {
                Assert.AreEqual(varPrueba[i], item);
                if (i == 5)
                {
                    break;
                }
                i++;
            }
        }
        [TestMethod]
        public void Revisar()
        {
            clsColaSimpleEnlazada<int> varCola = new clsColaSimpleEnlazada<int>();
            int n = 5;
            Assert.AreEqual(0, varCola.DarLongitud());
            Assert.AreEqual(true, varCola.Encolar(2));
            Assert.AreEqual(1, varCola.DarLongitud());
            Assert.AreEqual(true, varCola.Encolar(5));
            Assert.AreEqual(2, varCola.DarLongitud());
            Assert.AreEqual(true, varCola.Encolar(7));
            Assert.AreEqual(3, varCola.DarLongitud());
            Assert.AreEqual(true, varCola.Encolar(8));
            Assert.AreEqual(4, varCola.DarLongitud());
            Assert.AreEqual(0, varCola.DarItemActual());
            Assert.AreEqual(true, varCola.Revisar(ref n));
            Assert.AreEqual(2, n);
            Assert.AreEqual(true, varCola.Desencolar(ref n));
            Assert.AreEqual(2, n);
            Assert.AreEqual(true, varCola.Revisar(ref n));
            Assert.AreEqual(5, n);
            Assert.AreEqual(true, varCola.Desencolar(ref n));
            Assert.AreEqual(5, n);
            Assert.AreEqual(true, varCola.Revisar(ref n));
            Assert.AreEqual(7, n);
            Assert.AreEqual(true, varCola.Desencolar(ref n));
            Assert.AreEqual(7, n);
            Assert.AreEqual(true, varCola.Revisar(ref n));
            Assert.AreEqual(8, n);
            Assert.AreEqual(true, varCola.Desencolar(ref n));
            Assert.AreEqual(8, n);
            Assert.AreEqual(false, varCola.Revisar(ref n));
            Assert.AreEqual(0, n);
        }
        [TestMethod]
        public void TestContiene()
        {
            int n = 0;
            clsColaSimpleEnlazada<int> varCola = new clsColaSimpleEnlazada<int>();
            varCola.Encolar(3);
            varCola.Encolar(5);
            varCola.Encolar(3);
            varCola.Encolar(5);
            varCola.Encolar(3);
            varCola.Encolar(8);
            Assert.AreEqual(true, varCola.Contiene(3));
        }
        [TestMethod]
        public void OrdenamientoDePilaQuicSort()
        {
            clsColaSimpleEnlazada<int> varCola = new clsColaSimpleEnlazada<int>();
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            varCola.OrdenarQuickSort(false);

            Assert.AreEqual(true, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varCola.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaBurbujaSimple()
        {
            clsColaSimpleEnlazada<int> varCola = new clsColaSimpleEnlazada<int>();
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            Assert.AreEqual(16, varCola.DarLongitud());
            varCola.OrdenarBurbujaSimple(false);
            Assert.AreEqual(true, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varCola.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaBurbujaMejorado()
        {
            clsColaSimpleEnlazada<int> varCola = new clsColaSimpleEnlazada<int>();
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            Assert.AreEqual(16, varCola.DarLongitud());
            Assert.AreEqual(false, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varCola.darEstaOrdenadaDescendente());
            varCola.OrdenarBurbujaMejorado(false);
            Assert.AreEqual(true, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varCola.darEstaOrdenadaDescendente());
            varCola.OrdenarBurbujaMejorado(true);
            Assert.AreEqual(false, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varCola.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaInsercion()
        {
            clsColaSimpleEnlazada<int> varCola = new clsColaSimpleEnlazada<int>();
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            Assert.AreEqual(16, varCola.DarLongitud());
            Assert.AreEqual(false, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varCola.darEstaOrdenadaDescendente());
            varCola.OrdenarInsercion(false);
            Assert.AreEqual(true, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varCola.darEstaOrdenadaDescendente());
            varCola.OrdenarInsercion(true);
            Assert.AreEqual(false, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varCola.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaSeleccion()
        {
            clsColaSimpleEnlazada<int> varCola = new clsColaSimpleEnlazada<int>();
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            Assert.AreEqual(16, varCola.DarLongitud());
            Assert.AreEqual(false, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varCola.darEstaOrdenadaDescendente());
            varCola.OrdenarSeleccion(false);
            Assert.AreEqual(true, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varCola.darEstaOrdenadaDescendente());
            varCola.OrdenarSeleccion(true);
            Assert.AreEqual(false, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varCola.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaBurbujaBiDireccional()
        {
            clsColaSimpleEnlazada<int> varCola = new clsColaSimpleEnlazada<int>();
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            varCola.Encolar(2);
            varCola.Encolar(3);
            varCola.Encolar(4);
            varCola.Encolar(1);
            varCola.Encolar(2);
            varCola.Encolar(9);
            varCola.Encolar(11);
            varCola.Encolar(17);
            Assert.AreEqual(false, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varCola.darEstaOrdenadaDescendente());
            Assert.AreEqual(16, varCola.DarLongitud());
            varCola.ponerModoInteligente(true);
            varCola.OrdenarBurbujaBiDireccional(false);
            Assert.AreEqual(true, varCola.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varCola.darEstaOrdenadaDescendente());
        }
    }
}
