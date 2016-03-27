#if SILVERLIGHT
namespace System.Diagnostics
{
	internal static class Trace
	{
		public static void WriteLine(string s)
		{
			Debug.WriteLine(s);
		}
	}
}
#endif
