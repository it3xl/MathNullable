using System;

namespace MathNullableProject
{
	/// <summary>
	/// it3xl.ru: Mathematics for the Nullable.
	/// </summary>
	public static class MathNullable
	{
		/// <summary>
		/// Works like the <see cref="Math.Min(Decimal,Decimal)"/>, but:
		/// 1. if a argument is null it will return other argument.
		/// 2. if bouth arguments is null then it will return the null.
		/// </summary>
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <returns></returns>
		public static Decimal? MinIgnoreNull(Decimal? arg1, Decimal? arg2)
		{
			if (arg1 == null)
			{
				return arg2;
			}
			if (arg2 == null)
			{
				return arg1;
			}

			return Math.Min(arg1.Value, arg2.Value);
		}

		/// <summary>
		/// Works like the <see cref="Math.Max(Decimal,Decimal)"/>, but:
		/// 1. if a argument is null it will return other argument.
		/// 2. if bouth arguments is null then it will return the null.
		/// </summary>
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <returns></returns>
		public static Decimal? MaxIgnoreNull(Decimal? arg1, Decimal? arg2)
		{
			if (arg1 == null)
			{
				return arg2;
			}
			if (arg2 == null)
			{
				return arg1;
			}

			return Math.Max(arg1.Value, arg2.Value);
		}


		/// <summary>
		/// Works like the <see cref="Math.Min(Double,Double)"/>, but:
		/// 1. if a argument is null it will return other argument.
		/// 2. if bouth arguments is null then it will return the null.
		/// </summary>
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <returns></returns>
		public static Double? MinIgnoreNull(Double? arg1, Double? arg2)
		{
			if (arg1 == null)
			{
				return arg2;
			}
			if (arg2 == null)
			{
				return arg1;
			}

			return Math.Min(arg1.Value, arg2.Value);
		}

		/// <summary>
		/// Works like the <see cref="Math.Max(Double,Double)"/>, but:
		/// 1. if a argument is null it will return other argument.
		/// 2. if bouth arguments is null then it will return the null.
		/// </summary>
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <returns></returns>
		public static Double? MaxIgnoreNull(Double? arg1, Double? arg2)
		{
			if (arg1 == null)
			{
				return arg2;
			}
			if (arg2 == null)
			{
				return arg1;
			}

			return Math.Max(arg1.Value, arg2.Value);
		}

		/// <summary>
		/// Will return the true, if the parameter is the null or 0.
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		public static Boolean IsNilOrNull(this Double? val)
		{
			if (val == null)
			{
				return true;
			}

			// ReSharper disable CompareOfFloatsByEqualityOperator
			return val.Value == 0;
			// ReSharper restore CompareOfFloatsByEqualityOperator
		}

		/// <summary>
		/// Will return the true, if the parameter is the null or 0.
		/// </summary>
		/// <param name="val"></param>
		/// <returns></returns>
		public static Boolean IsNilOrNull(this Decimal? val)
		{
			if (val == null)
			{
				return true;
			}

			return val.Value == 0;
		}

	}
}
