using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x02002AF6 RID: 10998
	[NullableContext(1)]
	[Nullable(0)]
	[Conditional("COMPILE_TIME_ONLY")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
	public class FNameAttribute : Attribute
	{
		// Token: 0x06028484 RID: 164996 RVA: 0x003D49B4 File Offset: 0x003D2BB4
		public FNameAttribute(params string[] inNames)
		{
		}

		// Token: 0x06028485 RID: 164997 RVA: 0x003D49BC File Offset: 0x003D2BBC
		public FNameAttribute(FNameType type, params string[] inNames)
		{
		}
	}
}
