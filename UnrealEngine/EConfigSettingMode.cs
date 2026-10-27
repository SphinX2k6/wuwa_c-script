using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026A8 RID: 9896
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RenderExporter.EConfigSettingMode")]
	public enum EConfigSettingMode : byte
	{
		// Token: 0x04013C91 RID: 81041
		User,
		// Token: 0x04013C92 RID: 81042
		Developer,
		// Token: 0x04013C93 RID: 81043
		COUNT,
		// Token: 0x04013C94 RID: 81044
		EConfigSettingMode_MAX
	}
}
