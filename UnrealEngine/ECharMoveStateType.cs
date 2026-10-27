using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001634 RID: 5684
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ECharMoveStateType")]
	public enum ECharMoveStateType : byte
	{
		// Token: 0x0400B2DD RID: 45789
		Other,
		// Token: 0x0400B2DE RID: 45790
		Stand,
		// Token: 0x0400B2DF RID: 45791
		Walk,
		// Token: 0x0400B2E0 RID: 45792
		WalkStop,
		// Token: 0x0400B2E1 RID: 45793
		Run,
		// Token: 0x0400B2E2 RID: 45794
		RunStop,
		// Token: 0x0400B2E3 RID: 45795
		Sprint,
		// Token: 0x0400B2E4 RID: 45796
		SprintStop,
		// Token: 0x0400B2E5 RID: 45797
		Dodge,
		// Token: 0x0400B2E6 RID: 45798
		LandRoll,
		// Token: 0x0400B2E7 RID: 45799
		KnockDown,
		// Token: 0x0400B2E8 RID: 45800
		Parry,
		// Token: 0x0400B2E9 RID: 45801
		SoftKnock,
		// Token: 0x0400B2EA RID: 45802
		HeavyKnock,
		// Token: 0x0400B2EB RID: 45803
		NormalClimb,
		// Token: 0x0400B2EC RID: 45804
		FastClimb,
		// Token: 0x0400B2ED RID: 45805
		Glide,
		// Token: 0x0400B2EE RID: 45806
		KnockUp,
		// Token: 0x0400B2EF RID: 45807
		FastSwim,
		// Token: 0x0400B2F0 RID: 45808
		NormalSwim,
		// Token: 0x0400B2F1 RID: 45809
		Swing,
		// Token: 0x0400B2F2 RID: 45810
		Captured,
		// Token: 0x0400B2F3 RID: 45811
		Slide,
		// Token: 0x0400B2F4 RID: 45812
		Flying,
		// Token: 0x0400B2F5 RID: 45813
		EnterClimb,
		// Token: 0x0400B2F6 RID: 45814
		ExitClimb,
		// Token: 0x0400B2F7 RID: 45815
		NormalSki,
		// Token: 0x0400B2F8 RID: 45816
		StandUp,
		// Token: 0x0400B2F9 RID: 45817
		Soar,
		// Token: 0x0400B2FA RID: 45818
		Roll,
		// Token: 0x0400B2FB RID: 45819
		Kite,
		// Token: 0x0400B2FC RID: 45820
		Gongduola,
		// Token: 0x0400B2FD RID: 45821
		NpcVehicle,
		// Token: 0x0400B2FE RID: 45822
		ECharMoveStateType_MAX
	}
}
