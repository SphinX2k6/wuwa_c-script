using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026AA RID: 9898
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RenderExporter.EMarkState")]
	public enum EMarkState : byte
	{
		// Token: 0x04013C9C RID: 81052
		Mark_None,
		// Token: 0x04013C9D RID: 81053
		Mark_Used,
		// Token: 0x04013C9E RID: 81054
		Mark_NotUsed,
		// Token: 0x04013C9F RID: 81055
		Count,
		// Token: 0x04013CA0 RID: 81056
		EMarkState_MAX
	}
}
