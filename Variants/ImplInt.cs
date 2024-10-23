using System;
using System.Diagnostics;

namespace Variants
{
    /// <summary>
    /// Integer implementation of variant
    /// </summary>
    public class ImplInt : IVariant
    {
        private int value;

        /// <summary>
        /// Init the variant with an integer value
        /// </summary>
        /// <param name="value">the integer value to store</param>
        public ImplInt(int value)
        {
            this.value = value;
        }

        /// <summary>
        /// Give variant on string value
        /// </summary>
        /// <returns></returns>
        public string AsString()
        {
            return value.ToString();
        }

        public bool AsBool()
        {
            return value != 0;
        }

        public int AsInt()
        {
            return value;
        }

        public double AsDouble()
        {
            return Convert.ToDouble(value);
        }

        public DateTime AsDateTime()
        {
            try
            {
                // Assuming the integer represents ticks
                return new DateTime(value);
            }
            catch
            {
                throw new VariantException();
            }
        }

        public IVariant Clone()
        {
            return new ImplInt(value);
        }

        public bool Equals(IVariant other)
        {
            Debug.Assert(other != null);
            try
            {
                return value == other.AsInt();
            }
            catch
            {
                return false;
            }
        }
    }
}