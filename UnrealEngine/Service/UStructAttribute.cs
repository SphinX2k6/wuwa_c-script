using System;
using UnrealEngine.Service.Flags;

namespace UnrealEngine.Service
{
	// Token: 0x02002B05 RID: 11013
	[AttributeUsage(AttributeTargets.Struct, Inherited = false)]
	public class UStructAttribute : Attribute
	{
		// Token: 0x060284A3 RID: 165027 RVA: 0x003D4BDA File Offset: 0x003D2DDA
		public UStructAttribute(EStructFlags flags = EStructFlags.STRUCT_NoFlags)
		{
		}

		// Token: 0x040162C8 RID: 90824
		public EStructFlags Flags = flags;
	}
}
