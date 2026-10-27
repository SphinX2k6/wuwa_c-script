using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FFE RID: 8190
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUI2DLineRenderer_EndType")]
	public enum EUI2DLineRenderer_EndType : byte
	{
		// Token: 0x04010C4E RID: 68686
		None,
		// Token: 0x04010C4F RID: 68687
		Cap,
		// Token: 0x04010C50 RID: 68688
		ConnectStartAndEnd,
		// Token: 0x04010C51 RID: 68689
		EUI2DLineRenderer_MAX
	}
}
