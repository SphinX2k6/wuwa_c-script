using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000459 RID: 1113
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMath.EJoinType")]
	public enum EJoinType : byte
	{
		// Token: 0x04002D98 RID: 11672
		Square,
		// Token: 0x04002D99 RID: 11673
		Round,
		// Token: 0x04002D9A RID: 11674
		Miter,
		// Token: 0x04002D9B RID: 11675
		EJoinType_MAX
	}
}
