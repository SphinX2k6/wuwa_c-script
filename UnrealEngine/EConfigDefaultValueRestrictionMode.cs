using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026A7 RID: 9895
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RenderExporter.EConfigDefaultValueRestrictionMode")]
	public enum EConfigDefaultValueRestrictionMode : byte
	{
		// Token: 0x04013C8B RID: 81035
		None,
		// Token: 0x04013C8C RID: 81036
		Warning,
		// Token: 0x04013C8D RID: 81037
		Clamp,
		// Token: 0x04013C8E RID: 81038
		COUNT,
		// Token: 0x04013C8F RID: 81039
		EConfigDefaultValueRestrictionMode_MAX
	}
}
