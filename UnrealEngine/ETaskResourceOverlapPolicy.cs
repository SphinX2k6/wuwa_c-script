using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020013EE RID: 5102
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayTasks.ETaskResourceOverlapPolicy")]
	public enum ETaskResourceOverlapPolicy : byte
	{
		// Token: 0x04009F62 RID: 40802
		StartOnTop,
		// Token: 0x04009F63 RID: 40803
		StartAtEnd,
		// Token: 0x04009F64 RID: 40804
		ETaskResourceOverlapPolicy_MAX
	}
}
