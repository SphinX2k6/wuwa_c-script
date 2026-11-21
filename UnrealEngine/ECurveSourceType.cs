using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A6 RID: 1190
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ECurveSourceType")]
	public enum ECurveSourceType : byte
	{
		// Token: 0x04002F8D RID: 12173
		Function,
		// Token: 0x04002F8E RID: 12174
		CurveFloat,
		// Token: 0x04002F8F RID: 12175
		ECurveSourceType_MAX
	}
}
