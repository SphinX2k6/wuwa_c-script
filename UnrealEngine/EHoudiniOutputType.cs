using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200148E RID: 5262
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniOutputType")]
	public enum EHoudiniOutputType : byte
	{
		// Token: 0x0400A49E RID: 42142
		Invalid,
		// Token: 0x0400A49F RID: 42143
		Mesh,
		// Token: 0x0400A4A0 RID: 42144
		Instancer,
		// Token: 0x0400A4A1 RID: 42145
		Landscape,
		// Token: 0x0400A4A2 RID: 42146
		Curve,
		// Token: 0x0400A4A3 RID: 42147
		Skeletal,
		// Token: 0x0400A4A4 RID: 42148
		GeometryCollection,
		// Token: 0x0400A4A5 RID: 42149
		EHoudiniOutputType_MAX
	}
}
