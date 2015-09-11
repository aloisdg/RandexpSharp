using System;

namespace RandexpSharp.Lib.Extensions
{
	public class NumberRange : Range, IEquatable<NumberRange>
	{
		public Double Min { get; private set; }
		public Double Max { get; private set; }

		public NumberRange(Double num)
		{
			SetLimit(num, num);
		}

		public NumberRange(Double num1, Double num2)
		{
			if (num1 <= num2) SetLimit(num1, num2);
			else SetLimit(num2, num1);
		}

		private void SetLimit(double num1, double num2)
		{
			Min = num1;
			Max = num2;
		}

		//public bool ContainsNumber(Double number)
		//{
		//	var compareMin = Min.CompareTo(number);
		//	var compareMax = Max.CompareTo(number);
		//	return compareMin <= 0 && compareMax >= 0;
		//}

		public bool Equals(NumberRange other)
		{
			return Min.Equals(other.Min) && Max.Equals(other.Max);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((NumberRange)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Max.GetHashCode() * 397) ^ Min.GetHashCode();
			}
		}

		public static bool operator ==(NumberRange left, NumberRange right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(NumberRange left, NumberRange right)
		{
			return !Equals(left, right);
		}

		public override double GetMinimumNumber()
		{
			return Min;
		}

		public override double GetMaximumNumber()
		{
			return Max;
		}
	}
}
