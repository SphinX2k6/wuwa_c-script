using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001457 RID: 5207
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GraphEditor.EGraphPanningMouseButton")]
	public enum EGraphPanningMouseButton : byte
	{
		// Token: 0x0400A303 RID: 41731
		Right,
		// Token: 0x0400A304 RID: 41732
		Middle,
		// Token: 0x0400A305 RID: 41733
		Both,
		// Token: 0x0400A306 RID: 41734
		EGraphPanningMouseButton_MAX
	}
}
