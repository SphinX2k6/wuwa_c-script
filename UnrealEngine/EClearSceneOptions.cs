using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A29 RID: 2601
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EClearSceneOptions")]
	public enum EClearSceneOptions
	{
		// Token: 0x04004589 RID: 17801
		NoClear,
		// Token: 0x0400458A RID: 17802
		HardwareClear,
		// Token: 0x0400458B RID: 17803
		QuadAtMaxZ,
		// Token: 0x0400458C RID: 17804
		EClearSceneOptions_MAX
	}
}
