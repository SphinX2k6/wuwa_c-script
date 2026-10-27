using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200295E RID: 10590
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.EVirtualKeyboardType")]
	public enum EVirtualKeyboardType
	{
		// Token: 0x040158AE RID: 88238
		Default,
		// Token: 0x040158AF RID: 88239
		Number,
		// Token: 0x040158B0 RID: 88240
		Web,
		// Token: 0x040158B1 RID: 88241
		Email,
		// Token: 0x040158B2 RID: 88242
		Password,
		// Token: 0x040158B3 RID: 88243
		AlphaNumeric,
		// Token: 0x040158B4 RID: 88244
		EVirtualKeyboardType_MAX
	}
}
