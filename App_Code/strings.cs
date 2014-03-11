using System;

namespace DONEIN_NET.Site_Map
{
	public static class Strings
	{
		public static string Right(this string value, int length)
		{
			return value.Substring(value.Length - length);
		}

		public static string Left(this string value, int length)
		{
			return value.Substring(0, length);
		}
	}
}