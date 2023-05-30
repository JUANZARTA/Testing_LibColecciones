using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaServicios.Colecciones.Vectoriales;
namespace uTestLibColecciones.Vectoriales
{
    [TestClass]
    public class uTestPilaVectoriales
    {
        [TestMethod]
        public void Apilar()
        {
            clsPilaVector<int> varPila = new clsPilaVector<int>();
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
        public void ApilarConPilaLlena()
        {
            clsPilaVector<int> varPila = new clsPilaVector<int>(2);
            Assert.AreEqual(0, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(2));
            Assert.AreEqual(1, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(5));
            Assert.AreEqual(2, varPila.DarLongitud());
            Assert.AreEqual(false, varPila.Apilar(7));
            Assert.AreEqual(2, varPila.DarLongitud());
            Assert.AreEqual(false, varPila.Apilar(8));
            Assert.AreEqual(2, varPila.DarLongitud());
        }
        [TestMethod]
        public void ApilarConPilaLlenaConFactorDeCrecimiento()
        {
            clsPilaVector<int> varPila = new clsPilaVector<int>(2,1);
            Assert.AreEqual(0, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(2));
            Assert.AreEqual(1, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(5));
            Assert.AreEqual(2, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(7));
            Assert.AreEqual(3, varPila.DarLongitud());
            Assert.AreEqual(true, varPila.Apilar(8));
            Assert.AreEqual(4, varPila.DarLongitud());
        }
        [TestMethod]
        public void DesApilar()
        {
            int n = 0;
            clsPilaVector<int> varPila = new clsPilaVector<int>();
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
            clsPilaVector<int> varPila = new clsPilaVector<int>();
            Assert.AreEqual(0, varPila.DarLongitud());
            Assert.AreEqual(false, varPila.Desapilar(ref n));
            Assert.AreEqual(0, n);
            Assert.AreEqual(0, varPila.DarLongitud());
        }
        [TestMethod]
        public void Revisar()
        {
            clsPilaVector<int> varPila = new clsPilaVector<int>();
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
            Assert.AreEqual(8,n);
            Assert.AreEqual(true,varPila.Desapilar(ref n));
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
            clsPilaVector<int> varPila = new clsPilaVector<int>();
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
        }
        [TestMethod]
        public void OrdenamientoDePilaBurbujaSimple()
        {
            clsPilaVector<int> varPila = new clsPilaVector<int>();
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
            Assert.AreEqual(16,varPila.DarLongitud());
            varPila.OrdenarBurbujaSimple(false);
            Assert.AreEqual(true, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaBurbujaMejorado()
        {
            clsPilaVector<int> varPila = new clsPilaVector<int>();
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
            Assert.AreEqual(true, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
            varPila.OrdenarBurbujaMejorado(true);
            Assert.AreEqual(false, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(true, varPila.darEstaOrdenadaDescendente());
        }
        [TestMethod]
        public void OrdenamientoDePilaInsercion()
        {
            clsPilaVector<int> varPila = new clsPilaVector<int>();
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
            clsPilaVector<int> varPila = new clsPilaVector<int>();
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
            clsPilaVector<int> varPila = new clsPilaVector<int>();
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
            Assert.AreEqual(false,varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
            Assert.AreEqual(16, varPila.DarLongitud());
            varPila.ponerModoInteligente(true);
            varPila.OrdenarBurbujaBiDireccional(false);
            Assert.AreEqual(true, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
        }


        [TestMethod]
        public void OrdenamientoDePilaBurbujaSimpleConPersona()
        {
            clsPilaVector<clsPersona> varPila = new clsPilaVector<clsPersona>();
            clsPersona varObj1 = new clsPersona(10);
            clsPersona varObj2 = new clsPersona(15);
            clsPersona varObj3 = new clsPersona(5);
            varPila.Apilar(varObj1);
            varPila.Apilar(varObj2);
            varPila.Apilar(varObj3);
            varPila.Apilar(varObj1);
            varPila.Apilar(varObj2);
            varPila.Apilar(varObj3);
            varPila.Apilar(varObj1);
            varPila.Apilar(varObj2);
            varPila.Apilar(varObj3);
            varPila.Apilar(varObj1);
            varPila.Apilar(varObj2);
            varPila.Apilar(varObj3);
            varPila.Apilar(varObj3);
            varPila.Apilar(varObj1);
            varPila.Apilar(varObj2);
            varPila.Apilar(varObj3);
            Assert.AreEqual(16, varPila.DarLongitud());
            varPila.OrdenarBurbujaSimple(false);
            Assert.AreEqual(true, varPila.darEstaOrdenadaAscendente());
            Assert.AreEqual(false, varPila.darEstaOrdenadaDescendente());
        }
    }

    public class clsPersona:IComparable
    {
        private int atrCedula;
        public clsPersona()
        {
            atrCedula = 0;
        }
        public clsPersona(int prmOID)
        {
            atrCedula = prmOID;
        }
        public int CompareTo(object prmObject)
        {
            if (atrCedula < ((clsPersona)prmObject).atrCedula) return -1;
            if (atrCedula > ((clsPersona)prmObject).atrCedula) return 1;
            return 0;
        }

    }
}
