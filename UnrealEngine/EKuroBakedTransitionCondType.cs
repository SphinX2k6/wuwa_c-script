using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A8B RID: 2699
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroBakedTransitionCondType")]
	public enum EKuroBakedTransitionCondType : byte
	{
		// Token: 0x04004851 RID: 18513
		Bool,
		// Token: 0x04004852 RID: 18514
		Enum,
		// Token: 0x04004853 RID: 18515
		Group,
		// Token: 0x04004854 RID: 18516
		Always,
		// Token: 0x04004855 RID: 18517
		CurrentState,
		// Token: 0x04004856 RID: 18518
		Relevant,
		// Token: 0x04004857 RID: 18519
		EKuroBakedTransitionCondType_MAX
	}
}
