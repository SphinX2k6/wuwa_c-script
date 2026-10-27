using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200291F RID: 10527
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TLBSBase.ELightLeakFixMode")]
	public enum ELightLeakFixMode
	{
		// Token: 0x0401568C RID: 87692
		LightLeakFixMode_Off,
		// Token: 0x0401568D RID: 87693
		LightLeakFixMode_Loose,
		// Token: 0x0401568E RID: 87694
		LightLeakFixMode_Strict,
		// Token: 0x0401568F RID: 87695
		LightLeakFixMode_MAX
	}
}
