using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A17 RID: 10775
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFBXAnimationLengthImportType")]
	public enum EFBXAnimationLengthImportType
	{
		// Token: 0x04015DB9 RID: 89529
		FBXALIT_ExportedTime,
		// Token: 0x04015DBA RID: 89530
		FBXALIT_AnimatedKey,
		// Token: 0x04015DBB RID: 89531
		FBXALIT_SetRange,
		// Token: 0x04015DBC RID: 89532
		FBXALIT_MAX
	}
}
