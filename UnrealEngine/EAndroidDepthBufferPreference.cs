using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002AC RID: 684
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AndroidRuntimeSettings.EAndroidDepthBufferPreference")]
	public enum EAndroidDepthBufferPreference
	{
		// Token: 0x04000EFA RID: 3834
		Default,
		// Token: 0x04000EFB RID: 3835
		Bits16 = 16,
		// Token: 0x04000EFC RID: 3836
		Bits24 = 24,
		// Token: 0x04000EFD RID: 3837
		Bits32 = 32,
		// Token: 0x04000EFE RID: 3838
		EAndroidDepthBufferPreference_MAX
	}
}
