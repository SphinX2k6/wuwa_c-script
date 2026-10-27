using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004F8 RID: 1272
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERigControlType")]
	public enum ERigControlType : byte
	{
		// Token: 0x0400206E RID: 8302
		Bool,
		// Token: 0x0400206F RID: 8303
		Float,
		// Token: 0x04002070 RID: 8304
		Integer,
		// Token: 0x04002071 RID: 8305
		Vector2D,
		// Token: 0x04002072 RID: 8306
		Position,
		// Token: 0x04002073 RID: 8307
		Scale,
		// Token: 0x04002074 RID: 8308
		Rotator,
		// Token: 0x04002075 RID: 8309
		Transform,
		// Token: 0x04002076 RID: 8310
		TransformNoScale,
		// Token: 0x04002077 RID: 8311
		EulerTransform,
		// Token: 0x04002078 RID: 8312
		ERigControlType_MAX
	}
}
