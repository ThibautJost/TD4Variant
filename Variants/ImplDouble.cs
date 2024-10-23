using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Variants
{
    /// <summary>
    /// String intern implementation of variant
    /// </summary>
    public class ImplDouble : IVariant
    {
        private double value;
        /// <summary>
        /// Init the variant with a string value
        /// </summary>
        /// <param name="value">the string value to store   </param>
        public ImplDouble(double  value)
        {
            this.value = value;               
        }

        public bool AsBool()
        {
            return (value != 0);
        }

        public DateTime AsDateTime()
        {
            throw new VariantException();
        }

        public double AsDouble()
        {
            return value;
        }

        public int AsInt()
        {
            int test = 0;
            try
            {
                test = Convert.ToInt32(value);
            }
            catch
            {
                throw new VariantException();
            }
            return test;
        }

        public string AsString()
        {
            return Convert.ToString(value, CultureInfo.InvariantCulture);
        }

        public IVariant Clone()
        {
            return new ImplDouble(value);
        }

        public bool Equals(IVariant other)
        {
            Debug.Assert(other != null);
            bool ret = false;
            try
            {
                ret = value == other.AsDouble();
            }
            catch
            {
                // ignored
            }

            return ret;
        }
    }
}
