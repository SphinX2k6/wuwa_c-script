using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001D1 RID: 465
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECameraShakeDurationType")]
	public enum ECameraShakeDurationType : byte
	{
		// Token: 0x04000B57 RID: 2903
		Fixed,
		// Token: 0x04000B58 RID: 2904
		Infinite,
		// Token: 0x04000B59 RID: 2905
		Custom,
		// Token: 0x04000B5A RID: 2906
		ECameraShakeDurationType_MAX
	}
}
