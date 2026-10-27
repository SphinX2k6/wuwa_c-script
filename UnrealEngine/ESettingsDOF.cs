using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B60 RID: 2912
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESettingsDOF")]
	public enum ESettingsDOF
	{
		// Token: 0x04005043 RID: 20547
		Full3D,
		// Token: 0x04005044 RID: 20548
		YZPlane,
		// Token: 0x04005045 RID: 20549
		XZPlane,
		// Token: 0x04005046 RID: 20550
		XYPlane,
		// Token: 0x04005047 RID: 20551
		ESettingsDOF_MAX
	}
}
