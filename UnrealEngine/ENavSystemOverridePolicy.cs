using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002472 RID: 9330
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/NavigationSystem.ENavSystemOverridePolicy")]
	public enum ENavSystemOverridePolicy : byte
	{
		// Token: 0x04012A49 RID: 76361
		Override,
		// Token: 0x04012A4A RID: 76362
		Append,
		// Token: 0x04012A4B RID: 76363
		Skip,
		// Token: 0x04012A4C RID: 76364
		ENavSystemOverridePolicy_MAX
	}
}
