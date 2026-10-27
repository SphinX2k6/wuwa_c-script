using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A77 RID: 2679
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EGBufferFormat")]
	public enum EGBufferFormat
	{
		// Token: 0x040047E0 RID: 18400
		Force8BitsPerChannel,
		// Token: 0x040047E1 RID: 18401
		Default,
		// Token: 0x040047E2 RID: 18402
		HighPrecisionNormals = 3,
		// Token: 0x040047E3 RID: 18403
		Force16BitsPerChannel = 5,
		// Token: 0x040047E4 RID: 18404
		EGBufferFormat_MAX
	}
}
