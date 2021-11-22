using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabajoPractico3;

namespace TestUnitarioAppFutbol
{
    [TestClass]
    public class testAppFutbol
    {
        /// <summary>
        /// Verifica que dos jugadores sean iguales
        /// </summary>
        [TestMethod]
        public void VerificarIgualdadDeJugadores()//aca hay que poner el nombre del metodo que vamos a probar
        {
            //arrange
            Mediocampista m1 = new Mediocampista("Juan", "Perez", 25, 105, 200, 15, 2);
            Mediocampista m2 = new Mediocampista("Juan", "Perez", 25, 105, 200, 15, 2);
            //Mediocampista m2 = new Mediocampista("Jose", "Lopez", 25, 120, 300, 20, 1);

            //act
            bool rta = m1 == m2;

            //assert
            Assert.IsTrue(rta);
        }
        /// <summary>
        /// Verifica que los jugadores se agreguen correctamente al equipo
        /// </summary>
        [TestMethod]
        public void AgregarJugador()
        {
            //arrage

            Equipo e1 = new Equipo(20, "Los Leones");

            Mediocampista m1 = new Mediocampista("Juan", "Perez", 25, 105, 200, 15, 2);
            Delantero d1 = new Delantero("Sergio", "Gonzales", 30, 10, 42, 50);

            //act
            bool rta = e1 + m1 && e1 + d1;
            //assert
            Assert.IsTrue(rta);
        }
        /// <summary>
        /// Verfica que el jugador se elimine correctamente del equipo
        /// </summary>
        [TestMethod]
        public void EliminarJugador()
        {
            //arrage
            Equipo e1 = new Equipo(20, "Los Leones");
            Mediocampista m1 = new Mediocampista("Juan", "Perez", 25, 105, 200, 15, 2);

            //act
            bool rta = e1 + m1;
            rta = e1 - m1;
        }
    }
}
