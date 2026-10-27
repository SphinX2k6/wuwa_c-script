using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A62 RID: 2658
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EEmitterRenderMode")]
	public enum EEmitterRenderMode
	{
		// Token: 0x04004760 RID: 18272
		ERM_Normal,
		// Token: 0x04004761 RID: 18273
		ERM_Point,
		// Token: 0x04004762 RID: 18274
		ERM_Cross,
		// Token: 0x04004763 RID: 18275
		ERM_LightsOnly,
		// Token: 0x04004764 RID: 18276
		ERM_None,
		// Token: 0x04004765 RID: 18277
		ERM_MAX
	}
}
