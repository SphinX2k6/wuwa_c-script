using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000500 RID: 1280
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERigUnitDebugTransformMode")]
	public enum ERigUnitDebugTransformMode : byte
	{
		// Token: 0x040020A4 RID: 8356
		Point,
		// Token: 0x040020A5 RID: 8357
		Axes,
		// Token: 0x040020A6 RID: 8358
		Box,
		// Token: 0x040020A7 RID: 8359
		Max,
		// Token: 0x040020A8 RID: 8360
		ERigUnitDebugTransformMode_MAX
	}
}
