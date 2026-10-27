using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001632 RID: 5682
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EBoneBindType")]
	public enum EBoneBindType : byte
	{
		// Token: 0x0400B2D5 RID: 45781
		TPoseFix,
		// Token: 0x0400B2D6 RID: 45782
		KuroCacheAdditive,
		// Token: 0x0400B2D7 RID: 45783
		EBoneBindType_MAX
	}
}
