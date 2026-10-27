using System;
using UnrealEngine.Service.Flags;

namespace UnrealEngine.Service
{
	// Token: 0x02002B04 RID: 11012
	[AttributeUsage(AttributeTargets.Property, Inherited = false)]
	public class UPropertyAttribute : Attribute
	{
		// Token: 0x060284A2 RID: 165026 RVA: 0x003D4BCB File Offset: 0x003D2DCB
		public UPropertyAttribute(EPropertyFlags flags = EPropertyFlags.CPF_None)
		{
		}

		// Token: 0x040162C7 RID: 90823
		public EPropertyFlags Flags = flags;
	}
}
