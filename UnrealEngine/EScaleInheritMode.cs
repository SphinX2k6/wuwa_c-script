using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B58 RID: 2904
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EScaleInheritMode")]
	public enum EScaleInheritMode
	{
		// Token: 0x04004FE6 RID: 20454
		XYZ,
		// Token: 0x04004FE7 RID: 20455
		XY,
		// Token: 0x04004FE8 RID: 20456
		YZ,
		// Token: 0x04004FE9 RID: 20457
		ZX,
		// Token: 0x04004FEA RID: 20458
		X,
		// Token: 0x04004FEB RID: 20459
		Y,
		// Token: 0x04004FEC RID: 20460
		Z,
		// Token: 0x04004FED RID: 20461
		Local,
		// Token: 0x04004FEE RID: 20462
		EScaleInheritMode_MAX
	}
}
