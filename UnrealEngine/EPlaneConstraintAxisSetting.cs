using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B1B RID: 2843
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPlaneConstraintAxisSetting")]
	public enum EPlaneConstraintAxisSetting : byte
	{
		// Token: 0x04004DD8 RID: 19928
		Custom,
		// Token: 0x04004DD9 RID: 19929
		X,
		// Token: 0x04004DDA RID: 19930
		Y,
		// Token: 0x04004DDB RID: 19931
		Z,
		// Token: 0x04004DDC RID: 19932
		UseGlobalPhysicsSetting,
		// Token: 0x04004DDD RID: 19933
		EPlaneConstraintAxisSetting_MAX
	}
}
