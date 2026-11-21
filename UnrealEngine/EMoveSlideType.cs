using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200046A RID: 1130
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMovement.EMoveSlideType")]
	public enum EMoveSlideType : byte
	{
		// Token: 0x04002DF9 RID: 11769
		Free,
		// Token: 0x04002DFA RID: 11770
		Planar,
		// Token: 0x04002DFB RID: 11771
		RemovePositive,
		// Token: 0x04002DFC RID: 11772
		NoSlide,
		// Token: 0x04002DFD RID: 11773
		EMoveSlideType_MAX
	}
}
