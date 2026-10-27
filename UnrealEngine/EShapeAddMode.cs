using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A6 RID: 1190
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ComponentVisualizers.EShapeAddMode")]
	public enum EShapeAddMode : byte
	{
		// Token: 0x04001E41 RID: 7745
		AppendAfter = 1,
		// Token: 0x04001E42 RID: 7746
		AppendBefore,
		// Token: 0x04001E43 RID: 7747
		InsertAfter = 4,
		// Token: 0x04001E44 RID: 7748
		InsertBefore = 8,
		// Token: 0x04001E45 RID: 7749
		EShapeAddMode_MAX
	}
}
