using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGS.ManipulacionEnCadena.UnitTest.AppxUnit
{
    public class ManipulatorTest
    {
        [Fact]
        public void ReverseString_ShouldReturnReveseString()
        {
            Manipulator manipulator = new Manipulator();

            var input = "Josue";
            var esperado = "eusoJ";

            var result = manipulator.ReverseString(input);

            Assert.Equal(esperado, result);

        }
        [Fact]
        public void RemoveSpaces_ShouldRemoveAllSpaces()
        {
            Manipulator manipulator = new Manipulator();

            var input = "J O S U E";
            var esperado = "JOSUE";

            var result = manipulator.RemoveSpaces(input);

            Assert.Equal(esperado, result);
        }


    }
}
