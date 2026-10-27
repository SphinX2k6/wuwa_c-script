using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B03 RID: 2819
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EOrbitChainMode")]
	public enum EOrbitChainMode
	{
		// Token: 0x04004D43 RID: 19779
		EOChainMode_Add,
		// Token: 0x04004D44 RID: 19780
		EOChainMode_Scale,
		// Token: 0x04004D45 RID: 19781
		EOChainMode_Link,
		// Token: 0x04004D46 RID: 19782
		EOChainMode_MAX
	}
}
