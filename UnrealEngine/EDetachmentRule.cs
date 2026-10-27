using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A45 RID: 2629
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDetachmentRule")]
	public enum EDetachmentRule : byte
	{
		// Token: 0x04004662 RID: 18018
		KeepRelative,
		// Token: 0x04004663 RID: 18019
		KeepWorld,
		// Token: 0x04004664 RID: 18020
		EDetachmentRule_MAX
	}
}
