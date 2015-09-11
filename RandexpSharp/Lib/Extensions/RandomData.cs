using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RandexpSharp.Lib.Extensions
{
	public class RandomData
	{

		/** Return a random double in the range 0 to 1, inclusive, uniformly sampled from that range.
		* The mean of this distribution is 0.5.  The variance is 1/12. */
		public double NextUniform()
		{
			long l = ((long)(next(26)) << 27) + next(27);
			return l / (double)(1L << 53);
		}

		/** Return a random double in the range a to b, inclusive, uniformly sampled from that range.
		 * The mean of this distribution is (b-a)/2.  The variance is (b-a)^2/12 */
		public double NextUniform(double a, double b)
		{
			return a + (b - a) * nextUniform();
		}
	}
}
