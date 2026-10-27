using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000503 RID: 1283
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ETransformSpaceMode")]
	public enum ETransformSpaceMode : byte
	{
		// Token: 0x040020B4 RID: 8372
		LocalSpace,
		// Token: 0x040020B5 RID: 8373
		GlobalSpace,
		// Token: 0x040020B6 RID: 8374
		BaseSpace,
		// Token: 0x040020B7 RID: 8375
		BaseJoint,
		// Token: 0x040020B8 RID: 8376
		Max,
		// Token: 0x040020B9 RID: 8377
		ETransformSpaceMode_MAX
	}
}
