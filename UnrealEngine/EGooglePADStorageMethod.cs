using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001455 RID: 5205
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GooglePAD.EGooglePADStorageMethod")]
	public enum EGooglePADStorageMethod : byte
	{
		// Token: 0x0400A2EB RID: 41707
		AssetPack_STORAGE_FILES,
		// Token: 0x0400A2EC RID: 41708
		AssetPack_STORAGE_APK,
		// Token: 0x0400A2ED RID: 41709
		AssetPack_STORAGE_UNKNOWN,
		// Token: 0x0400A2EE RID: 41710
		AssetPack_STORAGE_NOT_INSTALLED,
		// Token: 0x0400A2EF RID: 41711
		AssetPack_STORAGE_MAX
	}
}
