using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A3D RID: 2621
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDataLayerRuntimeState")]
	public enum EDataLayerRuntimeState : byte
	{
		// Token: 0x0400461E RID: 17950
		Unloaded,
		// Token: 0x0400461F RID: 17951
		Loaded,
		// Token: 0x04004620 RID: 17952
		Activated,
		// Token: 0x04004621 RID: 17953
		EDataLayerRuntimeState_MAX
	}
}
