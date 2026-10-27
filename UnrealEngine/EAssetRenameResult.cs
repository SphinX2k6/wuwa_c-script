using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000362 RID: 866
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AssetTools.EAssetRenameResult")]
	public enum EAssetRenameResult : byte
	{
		// Token: 0x040014DF RID: 5343
		Failure,
		// Token: 0x040014E0 RID: 5344
		Success,
		// Token: 0x040014E1 RID: 5345
		Pending,
		// Token: 0x040014E2 RID: 5346
		EAssetRenameResult_MAX
	}
}
