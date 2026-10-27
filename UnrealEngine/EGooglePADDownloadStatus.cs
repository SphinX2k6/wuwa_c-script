using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001453 RID: 5203
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GooglePAD.EGooglePADDownloadStatus")]
	public enum EGooglePADDownloadStatus : byte
	{
		// Token: 0x0400A2CC RID: 41676
		AssetPack_UNKNOWN,
		// Token: 0x0400A2CD RID: 41677
		AssetPack_DOWNLOAD_PENDING,
		// Token: 0x0400A2CE RID: 41678
		AssetPack_DOWNLOADING,
		// Token: 0x0400A2CF RID: 41679
		AssetPack_TRANSFERRING,
		// Token: 0x0400A2D0 RID: 41680
		AssetPack_DOWNLOAD_COMPLETED,
		// Token: 0x0400A2D1 RID: 41681
		AssetPack_DOWNLOAD_FAILED,
		// Token: 0x0400A2D2 RID: 41682
		AssetPack_DOWNLOAD_CANCELED,
		// Token: 0x0400A2D3 RID: 41683
		AssetPack_WAITING_FOR_WIFI,
		// Token: 0x0400A2D4 RID: 41684
		AssetPack_NOT_INSTALLED,
		// Token: 0x0400A2D5 RID: 41685
		AssetPack_INFO_PENDING,
		// Token: 0x0400A2D6 RID: 41686
		AssetPack_INFO_FAILED,
		// Token: 0x0400A2D7 RID: 41687
		AssetPack_REMOVAL_PENDING,
		// Token: 0x0400A2D8 RID: 41688
		AssetPack_REMOVAL_FAILED,
		// Token: 0x0400A2D9 RID: 41689
		AssetPack_MAX
	}
}
