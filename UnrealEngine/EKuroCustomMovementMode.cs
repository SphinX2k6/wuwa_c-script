using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000468 RID: 1128
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMovement.EKuroCustomMovementMode")]
	public enum EKuroCustomMovementMode : byte
	{
		// Token: 0x04002DDE RID: 11742
		Climb,
		// Token: 0x04002DDF RID: 11743
		Swim,
		// Token: 0x04002DE0 RID: 11744
		Glide,
		// Token: 0x04002DE1 RID: 11745
		Pendulum,
		// Token: 0x04002DE2 RID: 11746
		Slide,
		// Token: 0x04002DE3 RID: 11747
		UpToWalkOnWater,
		// Token: 0x04002DE4 RID: 11748
		Leisure,
		// Token: 0x04002DE5 RID: 11749
		Soar,
		// Token: 0x04002DE6 RID: 11750
		Ski,
		// Token: 0x04002DE7 RID: 11751
		Roll,
		// Token: 0x04002DE8 RID: 11752
		Kite,
		// Token: 0x04002DE9 RID: 11753
		Ride,
		// Token: 0x04002DEA RID: 11754
		RailSlide,
		// Token: 0x04002DEB RID: 11755
		SplineClimb,
		// Token: 0x04002DEC RID: 11756
		Swing,
		// Token: 0x04002DED RID: 11757
		Floating,
		// Token: 0x04002DEE RID: 11758
		MechHover,
		// Token: 0x04002DEF RID: 11759
		MechJetFlight,
		// Token: 0x04002DF0 RID: 11760
		Diving,
		// Token: 0x04002DF1 RID: 11761
		FlowerFlying,
		// Token: 0x04002DF2 RID: 11762
		EKuroCustomMovementMode_MAX
	}
}
