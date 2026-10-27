using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001498 RID: 5272
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniStaticMeshMethod")]
	public enum EHoudiniStaticMeshMethod : byte
	{
		// Token: 0x0400A4F1 RID: 42225
		RawMesh,
		// Token: 0x0400A4F2 RID: 42226
		FMeshDescription,
		// Token: 0x0400A4F3 RID: 42227
		UHoudiniStaticMesh,
		// Token: 0x0400A4F4 RID: 42228
		EHoudiniStaticMeshMethod_MAX
	}
}
