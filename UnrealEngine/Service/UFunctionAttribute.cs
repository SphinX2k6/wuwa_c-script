using System;
using UnrealEngine.Service.Flags;

namespace UnrealEngine.Service
{
	// Token: 0x020008B0 RID: 2224
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public class UFunctionAttribute : Attribute
	{
		// Token: 0x0600BE58 RID: 48728 RVA: 0x0012FEDD File Offset: 0x0012E0DD
		public UFunctionAttribute(EFunctionFlags flags = EFunctionFlags.FUNC_None)
		{
		}

		// Token: 0x040056D8 RID: 22232
		public EFunctionFlags Flags = flags;
	}
}
