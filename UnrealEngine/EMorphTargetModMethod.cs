using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ADB RID: 2779
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMorphTargetModMethod")]
	public enum EMorphTargetModMethod : byte
	{
		// Token: 0x04004AFB RID: 19195
		Unspecific,
		// Token: 0x04004AFC RID: 19196
		LeftRightView,
		// Token: 0x04004AFD RID: 19197
		PitchAngleView,
		// Token: 0x04004AFE RID: 19198
		DistanceBasedView,
		// Token: 0x04004AFF RID: 19199
		EMorphTargetModMethod_MAX
	}
}
