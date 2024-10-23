using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Variants;

namespace TestVariants
{
    public class TestDoubles
    {
        [Fact]
        public void Test()
        {
            var v = new ImplDouble(-3.14);
            Assert.Equal(-3.14, v.AsDouble());
            Assert.Equal(-3, v.AsInt());
            Assert.Equal("-3,14", v.AsString());
            Assert.True(v.AsBool());
            Assert.Throws<VariantException>(() => v.AsDateTime());
        }
    }
}
