using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Utils
{
	// Token: 0x0200089D RID: 2205
	[NullableContext(1)]
	[Nullable(0)]
	public class Parse
	{
		// Token: 0x0600BE13 RID: 48659 RVA: 0x0012F958 File Offset: 0x0012DB58
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

		// Token: 0x0600BE14 RID: 48660 RVA: 0x0012F9A0 File Offset: 0x0012DBA0
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

		// Token: 0x0600BE15 RID: 48661 RVA: 0x0012F9E8 File Offset: 0x0012DBE8
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

		// Token: 0x0600BE16 RID: 48662 RVA: 0x0012FA30 File Offset: 0x0012DC30
		public static bool ParseVector(string str, out float x, out float y, out float z)
		{
			x = (y = (z = 0f));
			string[] array = str.Split(',', StringSplitOptions.None);
			return array.Length >= 3 && (float.TryParse(array[0], out x) && float.TryParse(array[1], out y)) && float.TryParse(array[2], out z);
		}
	}
}
