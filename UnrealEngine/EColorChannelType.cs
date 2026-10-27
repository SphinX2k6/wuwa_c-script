using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200035B RID: 859
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AssetExporter.EColorChannelType")]
	public enum EColorChannelType : byte
	{
		// Token: 0x040014B4 RID: 5300
		RGB,
		// Token: 0x040014B5 RID: 5301
		R,
		// Token: 0x040014B6 RID: 5302
		G,
		// Token: 0x040014B7 RID: 5303
		B,
		// Token: 0x040014B8 RID: 5304
		A,
		// Token: 0x040014B9 RID: 5305
		RGBA,
		// Token: 0x040014BA RID: 5306
		EColorChannelType_MAX
	}
}
