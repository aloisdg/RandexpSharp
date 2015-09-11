using System;

namespace RandexpSharp.Lib.Extensions
{
	// Move from Double To generics T
	public abstract class Range
	{
		public abstract double GetMinimumNumber();
		public abstract double GetMaximumNumber();

		public bool ContainsNumber(double number) //where T : IComparable<T>
		{
			return number.CompareTo(GetMinimumNumber()) >= 0
				&& number.CompareTo(GetMaximumNumber()) <= 0;
		}

		public bool ContainsRange(Range range) //where T : IComparable<T>
		{
			return range != null && (ContainsNumber(range.GetMinimumNumber())
						 && ContainsNumber(range.GetMaximumNumber()));
		}

		public bool OverlapsRange(Range range) //where T : IComparable<T>
		{
			return range != null && (range.ContainsNumber(GetMinimumNumber())
						   || range.ContainsNumber(GetMaximumNumber())
						   || ContainsNumber(range.GetMinimumNumber()));
		}
	}
}