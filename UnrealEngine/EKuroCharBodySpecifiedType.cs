using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A7 RID: 1191
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroCharBodySpecifiedType")]
	public enum EKuroCharBodySpecifiedType : byte
	{
		// Token: 0x04002F91 RID: 12177
		All,
		// Token: 0x04002F92 RID: 12178
		Body,
		// Token: 0x04002F93 RID: 12179
		Weapon,
		// Token: 0x04002F94 RID: 12180
		Hulu,
		// Token: 0x04002F95 RID: 12181
		WeaponAndHulu,
		// Token: 0x04002F96 RID: 12182
		Other,
		// Token: 0x04002F97 RID: 12183
		ExtraBody,
		// Token: 0x04002F98 RID: 12184
		External,
		// Token: 0x04002F99 RID: 12185
		ECharacterBodySpecifiedType_Max,
		// Token: 0x04002F9A RID: 12186
		EKuroCharBodySpecifiedType_MAX
	}
}
