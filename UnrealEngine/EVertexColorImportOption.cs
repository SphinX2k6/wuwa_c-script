using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A43 RID: 10819
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EVertexColorImportOption")]
	public enum EVertexColorImportOption
	{
		// Token: 0x04015ED2 RID: 89810
		Replace,
		// Token: 0x04015ED3 RID: 89811
		Ignore,
		// Token: 0x04015ED4 RID: 89812
		Override,
		// Token: 0x04015ED5 RID: 89813
		EVertexColorImportOption_MAX
	}
}
