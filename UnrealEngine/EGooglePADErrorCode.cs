using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001454 RID: 5204
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GooglePAD.EGooglePADErrorCode")]
	public enum EGooglePADErrorCode : byte
	{
		// Token: 0x0400A2DB RID: 41691
		AssetPack_NO_ERROR,
		// Token: 0x0400A2DC RID: 41692
		AssetPack_APP_UNAVAILABLE,
		// Token: 0x0400A2DD RID: 41693
		AssetPack_UNAVAILABLE,
		// Token: 0x0400A2DE RID: 41694
		AssetPack_INVALID_REQUEST,
		// Token: 0x0400A2DF RID: 41695
		AssetPack_DOWNLOAD_NOT_FOUND,
		// Token: 0x0400A2E0 RID: 41696
		AssetPack_API_NOT_AVAILABLE,
		// Token: 0x0400A2E1 RID: 41697
		AssetPack_NETWORK_ERROR,
		// Token: 0x0400A2E2 RID: 41698
		AssetPack_ACCESS_DENIED,
		// Token: 0x0400A2E3 RID: 41699
		AssetPack_INSUFFICIENT_STORAGE,
		// Token: 0x0400A2E4 RID: 41700
		AssetPack_PLAY_STORE_NOT_FOUND,
		// Token: 0x0400A2E5 RID: 41701
		AssetPack_NETWORK_UNRESTRICTED,
		// Token: 0x0400A2E6 RID: 41702
		AssetPack_INTERNAL_ERROR,
		// Token: 0x0400A2E7 RID: 41703
		AssetPack_INITIALIZATION_NEEDED,
		// Token: 0x0400A2E8 RID: 41704
		AssetPack_INITIALIZATION_FAILED,
		// Token: 0x0400A2E9 RID: 41705
		AssetPack_MAX
	}
}
