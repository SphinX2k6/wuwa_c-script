using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CE2 RID: 7394
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ShapeMaterial_BuffTarget")]
	public enum EKSC_ShapeMaterial_BuffTarget : byte
	{
		// Token: 0x0400F6E2 RID: 63202
		CurrentPlayer,
		// Token: 0x0400F6E3 RID: 63203
		TeamPlayer,
		// Token: 0x0400F6E4 RID: 63204
		EKSC_ShapeMaterial_MAX
	}
}
