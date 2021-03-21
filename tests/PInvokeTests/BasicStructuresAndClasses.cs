using System;
using System.Runtime.InteropServices;
using Xunit;
using PInvokeCheckApi;

namespace StructuresAndClasses
{

    public class BasicStructuresAndClasses
    {
        [Fact]
        static void PInvokeUsingStructuresTest()
        {
            Struct4Byte s1 = new Struct4Byte();
            Struct12Byte s2 = new Struct12Byte();

            Assert.Equal(0, s1.x1);
            Assert.Equal(0, s2.x1);
            Assert.Equal(0, s2.x2);
            Assert.Equal(0, s2.x3);

            PInvokeCheckUsingStructures.Function4Byte(ref s1, 3);
            PInvokeCheckUsingStructures.Function12Byte(ref s2, 3);

            Assert.Equal(4, s1.x1); //1 + 3
            Assert.Equal(4, s2.x1); //1 + 3
            Assert.Equal(5, s2.x2); //2 + 3
            Assert.Equal(6, s2.x3); //3 + 3
        }

        [Fact]
        static void PInvokeUsingClassesTest()
        {
            Class4Byte c1 = new Class4Byte();
            Class12Byte c2 = new Class12Byte();

            Assert.Equal(0, c1.x1);
            Assert.Equal(0, c2.x1);
            Assert.Equal(0, c2.x2);
            Assert.Equal(0, c2.x3);

            PInvokeCheckUsingClasses.Function4Byte(c1, 3);
            PInvokeCheckUsingClasses.Function12Byte(c2, 3);

            Assert.Equal(4, c1.x1); //1 + 3
            Assert.Equal(4, c2.x1); //1 + 3
            Assert.Equal(5, c2.x2); //2 + 3
            Assert.Equal(6, c2.x3); //3 + 3

        }

    }
}
