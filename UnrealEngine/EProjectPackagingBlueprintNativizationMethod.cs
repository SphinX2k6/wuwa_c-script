using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A37 RID: 10807
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EProjectPackagingBlueprintNativizationMethod")]
	public enum EProjectPackagingBlueprintNativizationMethod : byte
	{
		// Token: 0x04015E89 RID: 89737
		Disabled,
		// Token: 0x04015E8A RID: 89738
		Inclusive,
		// Token: 0x04015E8B RID: 89739
		Exclusive,
		// Token: 0x04015E8C RID: 89740
		EProjectPackagingBlueprintNativizationMethod_MAX
	}
}
