using System;
using kaffe;
using KaffeNetCore.kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katte.test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Cortado _cortado;

        private readonly FlatWhite _flatWhite;

        private readonly Latte _latte;

        private readonly SortKaffe _sortKaffe;

        public UnitTest1()
        {
            _cortado = new Cortado();
            _flatWhite = new FlatWhite();
            _latte = new Latte();
            _sortKaffe = new SortKaffe(20);
        }

        #region SortKaffe
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Uppss du gav for meget rabat")]
        public void SortkaffeprisTest()
        {
            _sortKaffe.Pris();
        }
        #endregion

        #region Flatwhite
        [TestMethod]
        public void FlatwhitePris()
        {
            Assert.IsTrue(_flatWhite.Pris() == 45);
        }

        [TestMethod]
        public void FlatwhiteMIM�lk()
        {
            Assert.IsTrue(_flatWhite.MlM�lk() == 160);
        }

        [TestMethod]
        public void FlatwhiteStyrke()
        {
            Assert.IsTrue(_flatWhite.Styrke() == "Mild");
        }
        #endregion

        #region Latte

        [TestMethod]
        public void LattePris()
        {
            Assert.IsTrue(_latte.Pris() == 40);
        }

        [TestMethod]
        public void LatteMIM�lk()
        {
            Assert.IsTrue(_latte.MlM�lk() == 120);
        }

        #endregion

        #region Cortado

        [TestMethod]
        public void CortadoPris()
        {
            Assert.IsTrue(_cortado.Pris() == 25);
        }

        [TestMethod]
        public void CortadoMLM�lk()
        {
            Assert.IsTrue(_cortado.MlM�lk() == 25);
        }

        #endregion

        #region Kaffe

        

        #endregion
    }
}
