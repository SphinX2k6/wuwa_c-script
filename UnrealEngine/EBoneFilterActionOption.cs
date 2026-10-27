using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A17 RID: 2583
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBoneFilterActionOption")]
	public enum EBoneFilterActionOption : byte
	{
		// Token: 0x04004526 RID: 17702
		Remove,
		// Token: 0x04004527 RID: 17703
		Keep,
		// Token: 0x04004528 RID: 17704
		Invalid,
		// Token: 0x04004529 RID: 17705
		EBoneFilterActionOption_MAX
	}
}
