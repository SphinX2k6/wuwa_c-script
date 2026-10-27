using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A11 RID: 2577
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBlueprintNativizationFlag")]
	public enum EBlueprintNativizationFlag : byte
	{
		// Token: 0x04004502 RID: 17666
		Disabled,
		// Token: 0x04004503 RID: 17667
		Dependency,
		// Token: 0x04004504 RID: 17668
		ExplicitlyEnabled,
		// Token: 0x04004505 RID: 17669
		EBlueprintNativizationFlag_MAX
	}
}
