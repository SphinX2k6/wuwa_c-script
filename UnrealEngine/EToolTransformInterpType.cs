using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000778 RID: 1912
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CurveEditorTools.EToolTransformInterpType")]
	public enum EToolTransformInterpType : byte
	{
		// Token: 0x04003013 RID: 12307
		Linear,
		// Token: 0x04003014 RID: 12308
		Sinusoidal,
		// Token: 0x04003015 RID: 12309
		Cubic,
		// Token: 0x04003016 RID: 12310
		CircularIn,
		// Token: 0x04003017 RID: 12311
		CircularOut,
		// Token: 0x04003018 RID: 12312
		ExpIn,
		// Token: 0x04003019 RID: 12313
		ExpOut,
		// Token: 0x0400301A RID: 12314
		EToolTransformInterpType_MAX
	}
}
