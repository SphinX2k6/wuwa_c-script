using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020028C5 RID: 10437
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/StreamlineBlueprint.EStreamlineFeature")]
	public enum EStreamlineFeature : byte
	{
		// Token: 0x0401543A RID: 87098
		DLSSG,
		// Token: 0x0401543B RID: 87099
		Latewarp,
		// Token: 0x0401543C RID: 87100
		Reflex,
		// Token: 0x0401543D RID: 87101
		DeepDVC,
		// Token: 0x0401543E RID: 87102
		Count,
		// Token: 0x0401543F RID: 87103
		EStreamlineFeature_MAX
	}
}
