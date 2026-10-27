using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B8D RID: 2957
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETexturePowerOfTwoSetting")]
	public enum ETexturePowerOfTwoSetting
	{
		// Token: 0x0400515F RID: 20831
		None,
		// Token: 0x04005160 RID: 20832
		PadToPowerOfTwo,
		// Token: 0x04005161 RID: 20833
		PadToSquarePowerOfTwo,
		// Token: 0x04005162 RID: 20834
		PadToMutipleOfFour,
		// Token: 0x04005163 RID: 20835
		PadToMutipleOfEight,
		// Token: 0x04005164 RID: 20836
		ETexturePowerOfTwoSetting_MAX
	}
}
