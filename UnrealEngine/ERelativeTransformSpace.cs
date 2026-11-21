using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001F3 RID: 499
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERelativeTransformSpace")]
	public enum ERelativeTransformSpace
	{
		// Token: 0x04000C6A RID: 3178
		RTS_World,
		// Token: 0x04000C6B RID: 3179
		RTS_Actor,
		// Token: 0x04000C6C RID: 3180
		RTS_Component,
		// Token: 0x04000C6D RID: 3181
		RTS_ParentBoneSpace,
		// Token: 0x04000C6E RID: 3182
		RTS_MAX
	}
}
