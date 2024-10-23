using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variants
{
    /// <summary>
    /// Main class, carries variant values
    /// </summary>
    public class Variant : IVariant
    {
        private IVariant impl;

        public bool AsBool()
        {
            return impl.AsBool();
        }

        public DateTime AsDateTime()
        {
            return impl.AsDateTime();
        }

        public double AsDouble()
        {
            return impl.AsDouble();
        }

        public int AsInt()
        {
            return impl.AsInt();
        }

        public string AsString()
        {
            return impl.AsString();
        }

        public IVariant Clone()
        {
            return impl.Clone();
        }

        public bool Equals(IVariant other)
        {
            return impl.Equals(other);
        }

        public override string ToString()
        {
            return AsString();
        }


    }
}
