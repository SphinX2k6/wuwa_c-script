using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A9E RID: 2718
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELevelInstanceFlags")]
	public enum ELevelInstanceFlags : byte
	{
		// Token: 0x0400490D RID: 18701
		None,
		// Token: 0x0400490E RID: 18702
		IsInEditHierarchy,
		// Token: 0x0400490F RID: 18703
		HasPropertyOverrides,
		// Token: 0x04004910 RID: 18704
		HasEditablePropertyOverrides = 4,
		// Token: 0x04004911 RID: 18705
		ELevelInstanceFlags_MAX
	}
}
