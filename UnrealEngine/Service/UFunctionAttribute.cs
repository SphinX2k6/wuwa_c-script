using System;
using UnrealEngine.Service.Flags;

namespace UnrealEngine.Service
{
	// Token: 0x02002B00 RID: 11008
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public class UFunctionAttribute : Attribute
	{
		// Token: 0x0602849E RID: 165022 RVA: 0x003D4B81 File Offset: 0x003D2D81
		public UFunctionAttribute(EFunctionFlags flags = EFunctionFlags.FUNC_None)
		{
		}

		// Token: 0x040162C0 RID: 90816
		public EFunctionFlags Flags = flags;
	}
}
