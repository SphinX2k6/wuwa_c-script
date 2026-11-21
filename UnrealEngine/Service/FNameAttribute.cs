using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Service
{
	// Token: 0x020008A6 RID: 2214
	[NullableContext(1)]
	[Nullable(0)]
	[Conditional("COMPILE_TIME_ONLY")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
	public class FNameAttribute : Attribute
	{
		// Token: 0x0600BE3E RID: 48702 RVA: 0x0012FD10 File Offset: 0x0012DF10
		public FNameAttribute(params string[] inNames)
		{
		}

		// Token: 0x0600BE3F RID: 48703 RVA: 0x0012FD18 File Offset: 0x0012DF18
		public FNameAttribute(FNameType type, params string[] inNames)
		{
		}
	}
}
