using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Utils
{
	// Token: 0x0200089A RID: 2202
	[NullableContext(1)]
	[Nullable(0)]
	public static class ExceptionUtils
	{
		// Token: 0x0600BE02 RID: 48642 RVA: 0x0012F4FB File Offset: 0x0012D6FB
		public static void RaiseException(string info)
		{
			throw new Exception(info);
		}

		// Token: 0x0600BE03 RID: 48643 RVA: 0x0012F503 File Offset: 0x0012D703
		public static string GetStackTrace()
		{
			return new StackTrace(1, true).ToString();
		}
	}
}
