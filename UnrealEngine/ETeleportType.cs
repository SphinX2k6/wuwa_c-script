using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B84 RID: 2948
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETeleportType")]
	public enum ETeleportType : byte
	{
		// Token: 0x0400511B RID: 20763
		None,
		// Token: 0x0400511C RID: 20764
		TeleportPhysics,
		// Token: 0x0400511D RID: 20765
		ResetPhysics,
		// Token: 0x0400511E RID: 20766
		ETeleportType_MAX
	}
}
