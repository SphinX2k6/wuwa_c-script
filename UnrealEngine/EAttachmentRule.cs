using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009F7 RID: 2551
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAttachmentRule")]
	public enum EAttachmentRule : byte
	{
		// Token: 0x04004469 RID: 17513
		KeepRelative,
		// Token: 0x0400446A RID: 17514
		KeepWorld,
		// Token: 0x0400446B RID: 17515
		SnapToTarget,
		// Token: 0x0400446C RID: 17516
		EAttachmentRule_MAX
	}
}
