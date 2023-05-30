using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaServicios.Colecciones.Vectoriales;
namespace uTestLibColecciones.Vectoriales
{
    [TestClass]
    public class uTestColaVectoriales
    {

        [TestMethod]
        public void TestEncolar()
        {
            clsColaVector<int> varPila = new clsColaVector<int>(6);
            varPila.Encolar(3);
            varPila.Encolar(5);
            varPila.Encolar(3);
            varPila.Encolar(5);
            varPila.Encolar(3);
            varPila.Encolar(8);
            int[] varPrueba = { 3, 5, 3, 5, 3, 8 };
            int i = 0;
            foreach (var item in varPila.DarVectorItems())
            {
                Assert.AreEqual(varPrueba[i], item);
                i++;
            }
        }
        [TestMethod]
        public void TestEncolarConColaLlena()
        {
            clsColaVector<int> varPila = new clsColaVector<int>(6);
            varPila.Encolar(3);
            varPila.Encolar(5);
            varPila.Encolar(3);
            varPila.Encolar(5);
            varPila.Encolar(3);
            varPila.Encolar(8);
            Assert.AreEqual(false, varPila.Encolar(7));
            int[] varPrueba = { 3, 5, 3, 5, 3, 8 };
            int i = 0;
            foreach (var item in varPila.DarVectorItems())
            {
                Assert.AreEqual(varPrueba[i], item);
                i++;
            }
        }
        [TestMethod]
        public void TestDesencolar()
        {
            int n = 0;
            clsColaVector<int> varPila = new clsColaVector<int>(7);
            varPila.Encolar(3);
            varPila.Encolar(5);
            varPila.Encolar(3);
            varPila.Encolar(5);
            varPila.Encolar(3);
            varPila.Encolar(8);
            varPila.Encolar(9);
            varPila.Desencolar(ref n);
            int[] varPrueba = { 5, 3, 5, 3, 8, 9 };
            int i = 0;
            foreach (var item in varPila.DarVectorItems())
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
        public void TestDesencolarConColaVacia()
        {
            int n = 0;
            clsColaVector<int> varPila = new clsColaVector<int>();
            Assert.AreEqual(false, varPila.Desencolar(ref n));

        }       
        [TestMethod]
        public void Revisar()
        {
            clsColaVector<int> varCola = new clsColaVector<int>();
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
            clsColaVector<int> varPila = new clsColaVector<int>();
            varPila.Encolar(3);
            varPila.Encolar(5);
            varPila.Encolar(3);
            varPila.Encolar(5);
            varPila.Encolar(3);
            varPila.Encolar(8);
            Assert.AreEqual(true, varPila.Contiene(3));
        }
        [TestMethod]
        public void OrdenamientoDePilaQuicSort()
        {
            clsColaVector<int> varCola = new clsColaVector<int>();
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
            clsColaVector<int> varCola = new clsColaVector<int>();
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
            clsColaVector<int> varCola = new clsColaVector<int>();
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
            clsColaVector<int> varCola = new clsColaVector<int>();
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
            clsColaVector<int> varCola = new clsColaVector<int>();
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
            clsColaVector<int> varCola = new clsColaVector<int>();
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
