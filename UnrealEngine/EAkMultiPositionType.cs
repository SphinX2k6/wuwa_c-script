using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000D3 RID: 211
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EAkMultiPositionType")]
	public enum EAkMultiPositionType : byte
	{
		// Token: 0x04000345 RID: 837
		SingleSource,
		// Token: 0x04000346 RID: 838
		MultiSources,
		// Token: 0x04000347 RID: 839
		MultiDirections,
		// Token: 0x04000348 RID: 840
		EAkMultiPositionType_MAX
	}
}
