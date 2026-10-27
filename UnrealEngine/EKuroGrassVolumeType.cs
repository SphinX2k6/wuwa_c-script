using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A44 RID: 6724
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.EKuroGrassVolumeType")]
	public enum EKuroGrassVolumeType : byte
	{
		// Token: 0x0400D734 RID: 55092
		Box,
		// Token: 0x0400D735 RID: 55093
		Sphere,
		// Token: 0x0400D736 RID: 55094
		EKuroGrassVolumeType_MAX
	}
}
