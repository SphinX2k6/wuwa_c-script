using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BBB RID: 3003
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EWindowMode")]
	public enum EWindowMode
	{
		// Token: 0x040052B4 RID: 21172
		Fullscreen,
		// Token: 0x040052B5 RID: 21173
		WindowedFullscreen,
		// Token: 0x040052B6 RID: 21174
		Windowed,
		// Token: 0x040052B7 RID: 21175
		EWindowMode_MAX
	}
}
