using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009E4 RID: 2532
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAdditiveBasePoseType")]
	public enum EAdditiveBasePoseType
	{
		// Token: 0x040043F7 RID: 17399
		ABPT_None,
		// Token: 0x040043F8 RID: 17400
		ABPT_RefPose,
		// Token: 0x040043F9 RID: 17401
		ABPT_AnimScaled,
		// Token: 0x040043FA RID: 17402
		ABPT_AnimFrame,
		// Token: 0x040043FB RID: 17403
		ABPT_MAX
	}
}
