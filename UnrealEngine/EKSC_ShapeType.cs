using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CE6 RID: 7398
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ShapeType")]
	public enum EKSC_ShapeType : byte
	{
		// Token: 0x0400F6F7 RID: 63223
		Sphere,
		// Token: 0x0400F6F8 RID: 63224
		Box,
		// Token: 0x0400F6F9 RID: 63225
		EKSC_MAX
	}
}
