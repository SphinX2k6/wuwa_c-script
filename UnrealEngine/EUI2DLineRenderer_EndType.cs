using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000658 RID: 1624
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUI2DLineRenderer_EndType")]
	public enum EUI2DLineRenderer_EndType : byte
	{
		// Token: 0x04003E14 RID: 15892
		None,
		// Token: 0x04003E15 RID: 15893
		Cap,
		// Token: 0x04003E16 RID: 15894
		ConnectStartAndEnd,
		// Token: 0x04003E17 RID: 15895
		EUI2DLineRenderer_MAX
	}
}
