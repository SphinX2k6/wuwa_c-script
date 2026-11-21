using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001DB RID: 475
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDetachmentRule")]
	public enum EDetachmentRule : byte
	{
		// Token: 0x04000BA8 RID: 2984
		KeepRelative,
		// Token: 0x04000BA9 RID: 2985
		KeepWorld,
		// Token: 0x04000BAA RID: 2986
		EDetachmentRule_MAX
	}
}
