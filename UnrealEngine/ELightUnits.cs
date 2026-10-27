using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AA7 RID: 2727
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELightUnits")]
	public enum ELightUnits : byte
	{
		// Token: 0x04004945 RID: 18757
		Unitless,
		// Token: 0x04004946 RID: 18758
		Candelas,
		// Token: 0x04004947 RID: 18759
		Lumens,
		// Token: 0x04004948 RID: 18760
		ELightUnits_MAX
	}
}
