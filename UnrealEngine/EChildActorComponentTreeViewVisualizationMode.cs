using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A27 RID: 2599
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EChildActorComponentTreeViewVisualizationMode")]
	public enum EChildActorComponentTreeViewVisualizationMode : byte
	{
		// Token: 0x0400457E RID: 17790
		UseDefault,
		// Token: 0x0400457F RID: 17791
		ComponentOnly,
		// Token: 0x04004580 RID: 17792
		ComponentWithChildActor,
		// Token: 0x04004581 RID: 17793
		ChildActorOnly,
		// Token: 0x04004582 RID: 17794
		EChildActorComponentTreeViewVisualizationMode_MAX
	}
}
