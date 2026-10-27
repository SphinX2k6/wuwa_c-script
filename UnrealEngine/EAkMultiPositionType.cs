using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200027B RID: 635
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkMultiPositionType")]
	public enum EAkMultiPositionType : byte
	{
		// Token: 0x04000D7F RID: 3455
		SingleSource,
		// Token: 0x04000D80 RID: 3456
		MultiSources,
		// Token: 0x04000D81 RID: 3457
		MultiDirections,
		// Token: 0x04000D82 RID: 3458
		EAkMultiPositionType_MAX
	}
}
