using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A71 RID: 6769
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroCharBodySpecifiedType")]
	public enum EKuroCharBodySpecifiedType : byte
	{
		// Token: 0x0400D8F2 RID: 55538
		All,
		// Token: 0x0400D8F3 RID: 55539
		Body,
		// Token: 0x0400D8F4 RID: 55540
		Weapon,
		// Token: 0x0400D8F5 RID: 55541
		Hulu,
		// Token: 0x0400D8F6 RID: 55542
		WeaponAndHulu,
		// Token: 0x0400D8F7 RID: 55543
		Other,
		// Token: 0x0400D8F8 RID: 55544
		ExtraBody,
		// Token: 0x0400D8F9 RID: 55545
		External,
		// Token: 0x0400D8FA RID: 55546
		ECharacterBodySpecifiedType_Max,
		// Token: 0x0400D8FB RID: 55547
		EKuroCharBodySpecifiedType_MAX
	}
}
