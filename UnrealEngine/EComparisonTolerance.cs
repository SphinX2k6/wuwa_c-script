using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020012DB RID: 4827
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/FunctionalTesting.EComparisonTolerance")]
	public enum EComparisonTolerance : byte
	{
		// Token: 0x040097EF RID: 38895
		Zero,
		// Token: 0x040097F0 RID: 38896
		Low,
		// Token: 0x040097F1 RID: 38897
		Medium,
		// Token: 0x040097F2 RID: 38898
		High,
		// Token: 0x040097F3 RID: 38899
		Custom,
		// Token: 0x040097F4 RID: 38900
		EComparisonTolerance_MAX
	}
}
