using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A7F RID: 2687
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EHLODBuildType")]
	public enum EHLODBuildType : byte
	{
		// Token: 0x0400480D RID: 18445
		Default,
		// Token: 0x0400480E RID: 18446
		UE,
		// Token: 0x0400480F RID: 18447
		Simplygon,
		// Token: 0x04004810 RID: 18448
		EHLODBuildType_MAX
	}
}
