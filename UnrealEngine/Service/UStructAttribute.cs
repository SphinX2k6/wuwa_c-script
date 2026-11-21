using System;
using UnrealEngine.Service.Flags;

namespace UnrealEngine.Service
{
	// Token: 0x020008B5 RID: 2229
	[AttributeUsage(AttributeTargets.Struct, Inherited = false)]
	public class UStructAttribute : Attribute
	{
		// Token: 0x0600BE5D RID: 48733 RVA: 0x0012FF36 File Offset: 0x0012E136
		public UStructAttribute(EStructFlags flags = EStructFlags.STRUCT_NoFlags)
		{
		}

		// Token: 0x040056E0 RID: 22240
		public EStructFlags Flags = flags;
	}
}
