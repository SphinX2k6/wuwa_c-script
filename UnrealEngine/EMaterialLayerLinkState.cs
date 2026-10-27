using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AB7 RID: 2743
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialLayerLinkState")]
	public enum EMaterialLayerLinkState : byte
	{
		// Token: 0x040049A8 RID: 18856
		Uninitialized,
		// Token: 0x040049A9 RID: 18857
		LinkedToParent,
		// Token: 0x040049AA RID: 18858
		UnlinkedFromParent,
		// Token: 0x040049AB RID: 18859
		NotFromParent,
		// Token: 0x040049AC RID: 18860
		EMaterialLayerLinkState_MAX
	}
}
