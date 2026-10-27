using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002855 RID: 10325
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.ETextWrappingPolicy")]
	public enum ETextWrappingPolicy : byte
	{
		// Token: 0x04014FFD RID: 86013
		DefaultWrapping,
		// Token: 0x04014FFE RID: 86014
		AllowPerCharacterWrapping,
		// Token: 0x04014FFF RID: 86015
		ETextWrappingPolicy_MAX
	}
}
