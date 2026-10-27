using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AA4 RID: 2724
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELightmapType")]
	public enum ELightmapType : byte
	{
		// Token: 0x04004934 RID: 18740
		Default,
		// Token: 0x04004935 RID: 18741
		ForceSurface,
		// Token: 0x04004936 RID: 18742
		ForceVolumetric,
		// Token: 0x04004937 RID: 18743
		ELightmapType_MAX
	}
}
