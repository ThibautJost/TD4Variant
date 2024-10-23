using System;
using System.Diagnostics;

namespace Variants
{
    /// <summary>
    /// Boolean implementation of variant
    /// </summary>
    public class ImplBool : IVariant
    {
        private bool value;

        /// <summary>
        /// Initialize the variant with a boolean value
        /// </summary>
        /// <param name="value">The boolean value to store</param>
        public ImplBool(bool value)
        {
            this.value = value;
        }

        /// <summary>
        /// Initialize the variant with a string value and parse it to boolean
        /// </summary>
        /// <param name="value">The string value to parse and store</param>
        public ImplBool(string value)
        {
            if (!bool.TryParse(value, out this.value))
            {
                // Handle cases like "0" or "1" if needed
                if (value == "0")
                {
                    this.value = false;
                }
                else if (value == "1")
                {
                    this.value = true;
                }
                else
                {
                    throw new VariantException();
                }
            }
        }

        public bool AsBool()
        {
            return value;
        }

        public DateTime AsDateTime()
        {
            throw new VariantException();
        }

        public double AsDouble()
        {
            return value ? 1.0 : 0.0;
        }

        public int AsInt()
        {
            return value ? 1 : 0;
        }

        public string AsString()
        {
            return value.ToString();
        }

        public IVariant Clone()
        {
            return new ImplBool(value);
        }

        public bool Equals(IVariant other)
        {
            Debug.Assert(other != null);
            try
            {
                return value == other.AsBool();
            }
            catch
            {
                return false;
            }
        }
    }
}
