using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AC1 RID: 2753
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialStencilCompare")]
	public enum EMaterialStencilCompare
	{
		// Token: 0x04004A1E RID: 18974
		MSC_Less,
		// Token: 0x04004A1F RID: 18975
		MSC_LessEqual,
		// Token: 0x04004A20 RID: 18976
		MSC_Greater,
		// Token: 0x04004A21 RID: 18977
		MSC_GreaterEqual,
		// Token: 0x04004A22 RID: 18978
		MSC_Equal,
		// Token: 0x04004A23 RID: 18979
		MSC_NotEqual,
		// Token: 0x04004A24 RID: 18980
		MSC_Never,
		// Token: 0x04004A25 RID: 18981
		MSC_Always,
		// Token: 0x04004A26 RID: 18982
		MSC_Toon,
		// Token: 0x04004A27 RID: 18983
		MSC_NotToon,
		// Token: 0x04004A28 RID: 18984
		MSC_Count,
		// Token: 0x04004A29 RID: 18985
		MSC_MAX
	}
}
