using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002E3 RID: 739
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ECharMoveStateType")]
	public enum ECharMoveStateType : byte
	{
		// Token: 0x0400200A RID: 8202
		Other,
		// Token: 0x0400200B RID: 8203
		Stand,
		// Token: 0x0400200C RID: 8204
		Walk,
		// Token: 0x0400200D RID: 8205
		WalkStop,
		// Token: 0x0400200E RID: 8206
		Run,
		// Token: 0x0400200F RID: 8207
		RunStop,
		// Token: 0x04002010 RID: 8208
		Sprint,
		// Token: 0x04002011 RID: 8209
		SprintStop,
		// Token: 0x04002012 RID: 8210
		Dodge,
		// Token: 0x04002013 RID: 8211
		LandRoll,
		// Token: 0x04002014 RID: 8212
		KnockDown,
		// Token: 0x04002015 RID: 8213
		Parry,
		// Token: 0x04002016 RID: 8214
		SoftKnock,
		// Token: 0x04002017 RID: 8215
		HeavyKnock,
		// Token: 0x04002018 RID: 8216
		NormalClimb,
		// Token: 0x04002019 RID: 8217
		FastClimb,
		// Token: 0x0400201A RID: 8218
		Glide,
		// Token: 0x0400201B RID: 8219
		KnockUp,
		// Token: 0x0400201C RID: 8220
		FastSwim,
		// Token: 0x0400201D RID: 8221
		NormalSwim,
		// Token: 0x0400201E RID: 8222
		Swing,
		// Token: 0x0400201F RID: 8223
		Captured,
		// Token: 0x04002020 RID: 8224
		Slide,
		// Token: 0x04002021 RID: 8225
		Flying,
		// Token: 0x04002022 RID: 8226
		EnterClimb,
		// Token: 0x04002023 RID: 8227
		ExitClimb,
		// Token: 0x04002024 RID: 8228
		NormalSki,
		// Token: 0x04002025 RID: 8229
		StandUp,
		// Token: 0x04002026 RID: 8230
		Soar,
		// Token: 0x04002027 RID: 8231
		Roll,
		// Token: 0x04002028 RID: 8232
		Kite,
		// Token: 0x04002029 RID: 8233
		Gongduola,
		// Token: 0x0400202A RID: 8234
		NpcVehicle,
		// Token: 0x0400202B RID: 8235
		WalkOnAir,
		// Token: 0x0400202C RID: 8236
		BreakWeakness,
		// Token: 0x0400202D RID: 8237
		Floating,
		// Token: 0x0400202E RID: 8238
		Rise,
		// Token: 0x0400202F RID: 8239
		Drop,
		// Token: 0x04002030 RID: 8240
		FloatingGround,
		// Token: 0x04002031 RID: 8241
		MechHover,
		// Token: 0x04002032 RID: 8242
		MechJetFlight,
		// Token: 0x04002033 RID: 8243
		Diving,
		// Token: 0x04002034 RID: 8244
		FlowerFlying,
		// Token: 0x04002035 RID: 8245
		ECharMoveStateType_MAX
	}
}
