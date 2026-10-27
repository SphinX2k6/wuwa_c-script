using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001752 RID: 5970
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComponent.ESimpleRunState")]
	public enum ESimpleRunState : byte
	{
		// Token: 0x0400BB43 RID: 47939
		Stop,
		// Token: 0x0400BB44 RID: 47940
		Run,
		// Token: 0x0400BB45 RID: 47941
		Wait,
		// Token: 0x0400BB46 RID: 47942
		ESimpleRunState_MAX
	}
}
