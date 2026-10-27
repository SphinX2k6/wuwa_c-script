using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009EE RID: 2542
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAnimInterpolationType")]
	public enum EAnimInterpolationType : byte
	{
		// Token: 0x04004439 RID: 17465
		Linear,
		// Token: 0x0400443A RID: 17466
		Step,
		// Token: 0x0400443B RID: 17467
		EAnimInterpolationType_MAX
	}
}
