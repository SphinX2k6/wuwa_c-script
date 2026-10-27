using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200278A RID: 10122
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EDataCreationPreferences")]
	public enum EDataCreationPreferences : byte
	{
		// Token: 0x040149CA RID: 84426
		OnlyUseOriginalData,
		// Token: 0x040149CB RID: 84427
		PreferOriginalData,
		// Token: 0x040149CC RID: 84428
		PreferOptimizedResult,
		// Token: 0x040149CD RID: 84429
		EDataCreationPreferences_MAX
	}
}
