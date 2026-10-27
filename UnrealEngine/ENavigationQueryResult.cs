using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AE4 RID: 2788
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENavigationQueryResult")]
	public enum ENavigationQueryResult
	{
		// Token: 0x04004B31 RID: 19249
		Invalid,
		// Token: 0x04004B32 RID: 19250
		Error,
		// Token: 0x04004B33 RID: 19251
		Fail,
		// Token: 0x04004B34 RID: 19252
		Success,
		// Token: 0x04004B35 RID: 19253
		ENavigationQueryResult_MAX
	}
}
