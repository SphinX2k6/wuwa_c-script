using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B43 RID: 2883
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERelativeTransformSpace")]
	public enum ERelativeTransformSpace
	{
		// Token: 0x04004F67 RID: 20327
		RTS_World,
		// Token: 0x04004F68 RID: 20328
		RTS_Actor,
		// Token: 0x04004F69 RID: 20329
		RTS_Component,
		// Token: 0x04004F6A RID: 20330
		RTS_ParentBoneSpace,
		// Token: 0x04004F6B RID: 20331
		RTS_MAX
	}
}
