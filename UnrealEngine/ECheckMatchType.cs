using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015EA RID: 5610
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroActorFolderCheck.ECheckMatchType")]
	public enum ECheckMatchType : byte
	{
		// Token: 0x0400AFF7 RID: 45047
		OneFolderEqual,
		// Token: 0x0400AFF8 RID: 45048
		OneFolderMatch,
		// Token: 0x0400AFF9 RID: 45049
		AllFolderPath,
		// Token: 0x0400AFFA RID: 45050
		ECheckMatchType_MAX
	}
}
