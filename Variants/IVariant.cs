namespace Variants
{
    public interface IVariant
    {
        /// <summary>
        /// Give variant on string value
        /// </summary>
        /// <returns>string value of the variant</returns>
        /// <exception cref="VariantException">If value cannot be converted</exception>
        string AsString();

        /// <summary>
        /// Give variant on boolean value
        /// </summary>
        /// <returns>boolean value of the variant</returns>
        /// <exception cref="VariantException">If value cannot be converted</exception>
        bool AsBool();

        /// <summary>
        /// Give variant as integer value
        /// </summary>
        /// <returns>integer value of the variant</returns>
        /// <exception cref="VariantException">If value cannot be converted</exception>
        int AsInt();

        /// <summary>
        /// Give variant as double value
        /// </summary>
        /// <returns>double value of the variant</returns>
        /// <exception cref="VariantException">If value cannot be converted</exception>
        double AsDouble();

        /// <summary>
        /// Give variant as datetime value
        /// </summary>
        /// <returns>datetime value of the variant</returns>
        /// <exception cref="VariantException">If value cannot be converted</exception>
        DateTime AsDateTime();
 
       /// <summary>
        /// Clone the variant
        /// </summary>
        /// <returns>another variant object, with same value, same type</returns>
        IVariant Clone();

        /// <summary>
        /// Compares 2 variants
        /// </summary>
        /// <param name="other">the other variant</param>
        /// <returns>true if variants have same value inside (regardless of type)</returns>
        /// <pre>other may not be null</pre>        
        bool Equals(IVariant other);
    }
}