using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A41 RID: 2625
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDecalOutputTarget")]
	public enum EDecalOutputTarget : byte
	{
		// Token: 0x04004649 RID: 17993
		SceneColor,
		// Token: 0x0400464A RID: 17994
		ScratchHalf,
		// Token: 0x0400464B RID: 17995
		ScratchQuarter,
		// Token: 0x0400464C RID: 17996
		ScratchEighth,
		// Token: 0x0400464D RID: 17997
		ScratchFull,
		// Token: 0x0400464E RID: 17998
		EDecalOutputTarget_MAX
	}
}
