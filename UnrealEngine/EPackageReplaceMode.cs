using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001512 RID: 5394
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngine.EPackageReplaceMode")]
	public enum EPackageReplaceMode : sbyte
	{
		// Token: 0x0400A9A9 RID: 43433
		CreateNewAssets,
		// Token: 0x0400A9AA RID: 43434
		ReplaceExistingAssets,
		// Token: 0x0400A9AB RID: 43435
		EPackageReplaceMode_MAX
	}
}
