using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009F1 RID: 2545
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAnimSyncGroupScope")]
	public enum EAnimSyncGroupScope : byte
	{
		// Token: 0x04004446 RID: 17478
		Local,
		// Token: 0x04004447 RID: 17479
		Component,
		// Token: 0x04004448 RID: 17480
		EAnimSyncGroupScope_MAX
	}
}
