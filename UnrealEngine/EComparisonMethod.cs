using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020012DA RID: 4826
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/FunctionalTesting.EComparisonMethod")]
	public enum EComparisonMethod : byte
	{
		// Token: 0x040097E7 RID: 38887
		Equal_To,
		// Token: 0x040097E8 RID: 38888
		Not_Equal_To,
		// Token: 0x040097E9 RID: 38889
		Greater_Than_Or_Equal_To,
		// Token: 0x040097EA RID: 38890
		Less_Than_Or_Equal_To,
		// Token: 0x040097EB RID: 38891
		Greater_Than,
		// Token: 0x040097EC RID: 38892
		Less_Than,
		// Token: 0x040097ED RID: 38893
		EComparisonMethod_MAX
	}
}
