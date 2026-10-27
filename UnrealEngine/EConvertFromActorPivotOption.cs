using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200152D RID: 5421
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/InstanceTool.EConvertFromActorPivotOption")]
	public enum EConvertFromActorPivotOption : byte
	{
		// Token: 0x0400AA6F RID: 43631
		SelectionCenter,
		// Token: 0x0400AA70 RID: 43632
		LastSelectedActor,
		// Token: 0x0400AA71 RID: 43633
		WorldSpaceZero,
		// Token: 0x0400AA72 RID: 43634
		BoundsCenter,
		// Token: 0x0400AA73 RID: 43635
		MergedBoundsCenter,
		// Token: 0x0400AA74 RID: 43636
		MergedBottomCenter,
		// Token: 0x0400AA75 RID: 43637
		EConvertFromActorPivotOption_MAX
	}
}
