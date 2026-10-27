using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A5A RID: 2650
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDrawDebugItemType")]
	public enum EDrawDebugItemType
	{
		// Token: 0x04004726 RID: 18214
		DirectionalArrow,
		// Token: 0x04004727 RID: 18215
		Sphere,
		// Token: 0x04004728 RID: 18216
		Line,
		// Token: 0x04004729 RID: 18217
		OnScreenMessage,
		// Token: 0x0400472A RID: 18218
		CoordinateSystem,
		// Token: 0x0400472B RID: 18219
		String,
		// Token: 0x0400472C RID: 18220
		EDrawDebugItemType_MAX
	}
}
