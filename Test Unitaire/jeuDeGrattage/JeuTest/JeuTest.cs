using jeuDeGrattage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JeuTest
{
    
    
    /// <summary>
    ///Classe de test pour JeuTest, destinée à contenir tous
    ///les tests unitaires JeuTest
    ///</summary>
    [TestClass()]
    public class JeuTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur Jeu
        ///</summary>
        [TestMethod()]
        public void JeuConstructorTest()
        {
            Jeu target = new Jeu();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Gagne
        ///</summary>
        [TestMethod()]
        public void GagneTest()
        {
            Jeu target = new Jeu(); // TODO: initialisez à une valeur appropriée
            int expected = 0; // TODO: initialisez à une valeur appropriée
            int actual;
            actual = target.Gagne();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            Jeu target = new Jeu(); // TODO: initialisez à une valeur appropriée
            string expected = string.Empty; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
