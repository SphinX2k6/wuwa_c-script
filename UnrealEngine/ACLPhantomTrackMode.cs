using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000C7 RID: 199
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ACLPlugin.ACLPhantomTrackMode")]
	public enum ACLPhantomTrackMode : byte
	{
		// Token: 0x04000274 RID: 628
		Ignore,
		// Token: 0x04000275 RID: 629
		Strip,
		// Token: 0x04000276 RID: 630
		Warn,
		// Token: 0x04000277 RID: 631
		ACLPhantomTrackMode_MAX
	}
}
