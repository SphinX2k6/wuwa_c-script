using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A60 RID: 2656
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EEmitterDynamicParameterValue")]
	public enum EEmitterDynamicParameterValue
	{
		// Token: 0x04004753 RID: 18259
		EDPV_UserSet,
		// Token: 0x04004754 RID: 18260
		EDPV_AutoSet,
		// Token: 0x04004755 RID: 18261
		EDPV_VelocityX,
		// Token: 0x04004756 RID: 18262
		EDPV_VelocityY,
		// Token: 0x04004757 RID: 18263
		EDPV_VelocityZ,
		// Token: 0x04004758 RID: 18264
		EDPV_VelocityMag,
		// Token: 0x04004759 RID: 18265
		EDPV_MAX
	}
}
