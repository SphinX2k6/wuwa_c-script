using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F57 RID: 8023
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Landscape.EGrassScaling")]
	public enum EGrassScaling : byte
	{
		// Token: 0x0401074C RID: 67404
		Uniform,
		// Token: 0x0401074D RID: 67405
		Free,
		// Token: 0x0401074E RID: 67406
		LockXY,
		// Token: 0x0401074F RID: 67407
		EGrassScaling_MAX
	}
}
