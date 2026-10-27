using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001490 RID: 5264
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniPartType")]
	public enum EHoudiniPartType : byte
	{
		// Token: 0x0400A4C0 RID: 42176
		Invalid,
		// Token: 0x0400A4C1 RID: 42177
		Mesh,
		// Token: 0x0400A4C2 RID: 42178
		Instancer,
		// Token: 0x0400A4C3 RID: 42179
		Curve,
		// Token: 0x0400A4C4 RID: 42180
		Volume,
		// Token: 0x0400A4C5 RID: 42181
		EHoudiniPartType_MAX
	}
}
