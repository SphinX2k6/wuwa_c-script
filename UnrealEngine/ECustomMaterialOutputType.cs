using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A3A RID: 2618
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECustomMaterialOutputType")]
	public enum ECustomMaterialOutputType
	{
		// Token: 0x0400460B RID: 17931
		CMOT_Float1,
		// Token: 0x0400460C RID: 17932
		CMOT_Float2,
		// Token: 0x0400460D RID: 17933
		CMOT_Float3,
		// Token: 0x0400460E RID: 17934
		CMOT_Float4,
		// Token: 0x0400460F RID: 17935
		CMOT_MaterialAttributes,
		// Token: 0x04004610 RID: 17936
		CMOT_MAX
	}
}
