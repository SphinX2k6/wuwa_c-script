using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Utils
{
	// Token: 0x02002AEE RID: 10990
	[NullableContext(1)]
	[Nullable(0)]
	public class Parse
	{
		// Token: 0x0602845E RID: 164958 RVA: 0x003D4648 File Offset: 0x003D2848
		public static bool Value(string[] splitString, string match, ref byte value)
		{
			foreach (string text in splitString)
			{
				int num = text.IndexOf(match, StringComparison.OrdinalIgnoreCase);
				if (num >= 0 && byte.TryParse(text.AsSpan(num + match.Length), out value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602845F RID: 164959 RVA: 0x003D4690 File Offset: 0x003D2890
		public static bool Value(string[] splitString, string match, ref float value)
		{
			foreach (string text in splitString)
			{
				int num = text.IndexOf(match, StringComparison.OrdinalIgnoreCase);
				if (num >= 0 && float.TryParse(text.AsSpan(num + match.Length), out value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06028460 RID: 164960 RVA: 0x003D46D8 File Offset: 0x003D28D8
		public static bool Value(string[] splitString, string match, ref double value)
		{
			foreach (string text in splitString)
			{
				int num = text.IndexOf(match, StringComparison.OrdinalIgnoreCase);
				if (num >= 0 && double.TryParse(text.AsSpan(num + match.Length), out value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06028461 RID: 164961 RVA: 0x003D4720 File Offset: 0x003D2920
		public static bool ParseVector(string str, out float x, out float y, out float z)
		{
			x = (y = (z = 0f));
			string[] array = str.Split(',', StringSplitOptions.None);
			return array.Length >= 3 && (float.TryParse(array[0], out x) && float.TryParse(array[1], out y)) && float.TryParse(array[2], out z);
		}
	}
}
