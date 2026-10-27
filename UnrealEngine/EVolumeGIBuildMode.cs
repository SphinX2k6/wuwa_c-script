using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A57 RID: 10839
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/VolumeGIEditor.EVolumeGIBuildMode")]
	public enum EVolumeGIBuildMode : byte
	{
		// Token: 0x04015F43 RID: 89923
		QuickBuild,
		// Token: 0x04015F44 RID: 89924
		FullBuild,
		// Token: 0x04015F45 RID: 89925
		EVolumeGIBuildMode_MAX
	}
}
