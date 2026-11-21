using System;
using UnrealEngine.Service.Flags;

namespace UnrealEngine.Service
{
	// Token: 0x020008AF RID: 2223
	[AttributeUsage(AttributeTargets.Enum, Inherited = false)]
	public class UEnumAttribute : Attribute
	{
		// Token: 0x0600BE57 RID: 48727 RVA: 0x0012FECE File Offset: 0x0012E0CE
		public UEnumAttribute(EEnumFlags flags = EEnumFlags.None)
		{
		}

		// Token: 0x040056D7 RID: 22231
		private EEnumFlags Flags = flags;
	}
}
