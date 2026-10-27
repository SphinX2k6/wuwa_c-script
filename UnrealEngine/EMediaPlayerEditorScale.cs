using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022AF RID: 8879
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MediaPlayerEditor.EMediaPlayerEditorScale")]
	public enum EMediaPlayerEditorScale : byte
	{
		// Token: 0x04012021 RID: 73761
		Fill,
		// Token: 0x04012022 RID: 73762
		Fit,
		// Token: 0x04012023 RID: 73763
		Original,
		// Token: 0x04012024 RID: 73764
		EMediaPlayerEditorScale_MAX
	}
}
