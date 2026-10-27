using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A8D RID: 6797
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ESplinePlaneType")]
	public enum ESplinePlaneType : byte
	{
		// Token: 0x0400DA59 RID: 55897
		XY,
		// Token: 0x0400DA5A RID: 55898
		XZ,
		// Token: 0x0400DA5B RID: 55899
		YZ,
		// Token: 0x0400DA5C RID: 55900
		ESplinePlaneType_MAX
	}
}
