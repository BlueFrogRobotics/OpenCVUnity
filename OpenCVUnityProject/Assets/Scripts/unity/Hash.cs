using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCVUnity
{
    internal static class Hash
    {
        /// <summary>
        /// URs the shift.
        /// </summary>
        /// <returns>The shift.</returns>
        /// <param name="iNumber">Number.</param>
        /// <param name="iBits">Bits.</param>
        internal static int URShift(int iNumber, int iBits)
        {
            if (iNumber >= 0)
                return iNumber >> iBits;
            else
                return (iNumber >> iBits) + (2 << ~iBits);

        }

        /// <summary>
        /// URs the shift.
        /// </summary>
        /// <returns>The shift.</returns>
        /// <param name="iNumber">Number.</param>
        /// <param name="iBits">Bits.</param>
        internal static long URShift(long iNumber, int iBits)
        {
            if (iNumber >= 0)
                return iNumber >> iBits;
            else
                return (iNumber >> iBits) + (2 << ~iBits);
        }

        /// <summary>
        /// Determines if hash contents the specified enumerable.
        /// </summary>
        /// <returns><c>true</c> if hash contents the specified enumerable; otherwise, <c>false</c>.</returns>
        /// <param name="iEnumerable">Enumerable.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        internal static int HashContents<T>(this IEnumerable<T> iEnumerable)
        {
            int oHash = 0x218A9B2C;
            foreach (T lItem in iEnumerable) {
                int lThisHash = lItem.GetHashCode();
                oHash = lThisHash ^ ((oHash << 5) + oHash);
            }
            return oHash;
        }
    }
}
