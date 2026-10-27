using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001400 RID: 5120
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GDKPlatformEditor.EGDKIntelligentInstallChunkType")]
	public enum EGDKIntelligentInstallChunkType : byte
	{
		// Token: 0x04009FC5 RID: 40901
		Initial,
		// Token: 0x04009FC6 RID: 40902
		Language,
		// Token: 0x04009FC7 RID: 40903
		Device,
		// Token: 0x04009FC8 RID: 40904
		OnDemand,
		// Token: 0x04009FC9 RID: 40905
		EGDKIntelligentInstallChunkType_MAX
	}
}
