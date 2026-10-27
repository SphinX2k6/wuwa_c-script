using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200032C RID: 812
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.ESnapshotSourceMode")]
	public enum ESnapshotSourceMode : byte
	{
		// Token: 0x04001363 RID: 4963
		NamedSnapshot,
		// Token: 0x04001364 RID: 4964
		SnapshotPin,
		// Token: 0x04001365 RID: 4965
		ESnapshotSourceMode_MAX
	}
}
