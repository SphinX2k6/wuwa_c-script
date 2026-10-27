using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B51 RID: 2897
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERoundingMode")]
	public enum ERoundingMode
	{
		// Token: 0x04004FBC RID: 20412
		HalfToEven,
		// Token: 0x04004FBD RID: 20413
		HalfFromZero,
		// Token: 0x04004FBE RID: 20414
		HalfToZero,
		// Token: 0x04004FBF RID: 20415
		FromZero,
		// Token: 0x04004FC0 RID: 20416
		ToZero,
		// Token: 0x04004FC1 RID: 20417
		ToNegativeInfinity,
		// Token: 0x04004FC2 RID: 20418
		ToPositiveInfinity,
		// Token: 0x04004FC3 RID: 20419
		ERoundingMode_MAX
	}
}
