using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A1C RID: 2588
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBoneTranslationRetargetingMode")]
	public enum EBoneTranslationRetargetingMode
	{
		// Token: 0x04004541 RID: 17729
		Animation,
		// Token: 0x04004542 RID: 17730
		Skeleton,
		// Token: 0x04004543 RID: 17731
		AnimationScaled,
		// Token: 0x04004544 RID: 17732
		AnimationRelative,
		// Token: 0x04004545 RID: 17733
		OrientAndScale,
		// Token: 0x04004546 RID: 17734
		EBoneTranslationRetargetingMode_MAX
	}
}
