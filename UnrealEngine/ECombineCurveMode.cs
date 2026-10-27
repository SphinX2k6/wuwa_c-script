using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200163A RID: 5690
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ECombineCurveMode")]
	public enum ECombineCurveMode : byte
	{
		// Token: 0x0400B321 RID: 45857
		Replenish,
		// Token: 0x0400B322 RID: 45858
		Accumulate,
		// Token: 0x0400B323 RID: 45859
		Override,
		// Token: 0x0400B324 RID: 45860
		CleanAndOverride,
		// Token: 0x0400B325 RID: 45861
		ECombineCurveMode_MAX
	}
}
