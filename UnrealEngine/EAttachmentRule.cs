using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001CD RID: 461
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAttachmentRule")]
	public enum EAttachmentRule : byte
	{
		// Token: 0x04000B41 RID: 2881
		KeepRelative,
		// Token: 0x04000B42 RID: 2882
		KeepWorld,
		// Token: 0x04000B43 RID: 2883
		SnapToTarget,
		// Token: 0x04000B44 RID: 2884
		EAttachmentRule_MAX
	}
}
