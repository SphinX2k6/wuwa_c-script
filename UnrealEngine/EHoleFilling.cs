using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002790 RID: 10128
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EHoleFilling")]
	public enum EHoleFilling : byte
	{
		// Token: 0x040149F7 RID: 84471
		Disabled,
		// Token: 0x040149F8 RID: 84472
		Low,
		// Token: 0x040149F9 RID: 84473
		Medium,
		// Token: 0x040149FA RID: 84474
		High,
		// Token: 0x040149FB RID: 84475
		EHoleFilling_MAX
	}
}
