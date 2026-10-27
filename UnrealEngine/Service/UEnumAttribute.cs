using System;
using UnrealEngine.Service.Flags;

namespace UnrealEngine.Service
{
	// Token: 0x02002AFF RID: 11007
	[AttributeUsage(AttributeTargets.Enum, Inherited = false)]
	public class UEnumAttribute : Attribute
	{
		// Token: 0x0602849D RID: 165021 RVA: 0x003D4B72 File Offset: 0x003D2D72
		public UEnumAttribute(EEnumFlags flags = EEnumFlags.None)
		{
		}

		// Token: 0x040162BF RID: 90815
		private EEnumFlags Flags = flags;
	}
}
