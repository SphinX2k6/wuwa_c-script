using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200045C RID: 1116
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.ECollisionTypeEnum")]
	public enum ECollisionTypeEnum : byte
	{
		// Token: 0x04001BD2 RID: 7122
		Chaos_Volumetric,
		// Token: 0x04001BD3 RID: 7123
		Chaos_Surface_Volumetric,
		// Token: 0x04001BD4 RID: 7124
		Chaos_Max,
		// Token: 0x04001BD5 RID: 7125
		Chaos_MAX
	}
}
