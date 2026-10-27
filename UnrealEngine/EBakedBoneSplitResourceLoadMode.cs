using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A09 RID: 2569
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBakedBoneSplitResourceLoadMode")]
	public enum EBakedBoneSplitResourceLoadMode : byte
	{
		// Token: 0x040044D3 RID: 17619
		Synchronous,
		// Token: 0x040044D4 RID: 17620
		Asynchronous,
		// Token: 0x040044D5 RID: 17621
		EBakedBoneSplitResourceLoadMode_MAX
	}
}
