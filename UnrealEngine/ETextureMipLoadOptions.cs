using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B8B RID: 2955
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETextureMipLoadOptions")]
	public enum ETextureMipLoadOptions : byte
	{
		// Token: 0x04005154 RID: 20820
		Default,
		// Token: 0x04005155 RID: 20821
		AllMips,
		// Token: 0x04005156 RID: 20822
		OnlyFirstMip,
		// Token: 0x04005157 RID: 20823
		ETextureMipLoadOptions_MAX
	}
}
