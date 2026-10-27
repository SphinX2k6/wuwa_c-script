using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B40 RID: 2880
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EReflectionSourceType")]
	public enum EReflectionSourceType : byte
	{
		// Token: 0x04004F5B RID: 20315
		CapturedScene,
		// Token: 0x04004F5C RID: 20316
		SpecifiedCubemap,
		// Token: 0x04004F5D RID: 20317
		EReflectionSourceType_MAX
	}
}
