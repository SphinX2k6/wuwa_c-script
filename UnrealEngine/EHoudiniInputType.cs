using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001489 RID: 5257
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniInputType")]
	public enum EHoudiniInputType : byte
	{
		// Token: 0x0400A47B RID: 42107
		Invalid,
		// Token: 0x0400A47C RID: 42108
		Geometry,
		// Token: 0x0400A47D RID: 42109
		Curve,
		// Token: 0x0400A47E RID: 42110
		Asset,
		// Token: 0x0400A47F RID: 42111
		Landscape,
		// Token: 0x0400A480 RID: 42112
		World,
		// Token: 0x0400A481 RID: 42113
		Skeletal,
		// Token: 0x0400A482 RID: 42114
		GeometryCollection,
		// Token: 0x0400A483 RID: 42115
		EHoudiniInputType_MAX
	}
}
