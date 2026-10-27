using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A1B RID: 10779
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFBXImportType")]
	public enum EFBXImportType
	{
		// Token: 0x04015DE6 RID: 89574
		FBXIT_StaticMesh,
		// Token: 0x04015DE7 RID: 89575
		FBXIT_SkeletalMesh,
		// Token: 0x04015DE8 RID: 89576
		FBXIT_Animation,
		// Token: 0x04015DE9 RID: 89577
		FBXIT_MAX
	}
}
