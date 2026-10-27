using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A7B RID: 2683
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EHasCustomNavigableGeometry")]
	public enum EHasCustomNavigableGeometry
	{
		// Token: 0x040047F7 RID: 18423
		No,
		// Token: 0x040047F8 RID: 18424
		Yes,
		// Token: 0x040047F9 RID: 18425
		EvenIfNotCollidable,
		// Token: 0x040047FA RID: 18426
		DontExport,
		// Token: 0x040047FB RID: 18427
		EHasCustomNavigableGeometry_MAX
	}
}
