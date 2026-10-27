using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Utils
{
	// Token: 0x02002AEB RID: 10987
	[NullableContext(1)]
	[Nullable(0)]
	public static class ExceptionUtils
	{
		// Token: 0x0602844D RID: 164941 RVA: 0x003D41EB File Offset: 0x003D23EB
		public static void RaiseException(string info)
		{
			throw new Exception(info);
		}

		// Token: 0x0602844E RID: 164942 RVA: 0x003D41F3 File Offset: 0x003D23F3
		public static string GetStackTrace()
		{
			return new StackTrace(1, true).ToString();
		}
	}
}
