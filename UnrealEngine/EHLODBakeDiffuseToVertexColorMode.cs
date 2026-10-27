using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A7D RID: 2685
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EHLODBakeDiffuseToVertexColorMode")]
	public enum EHLODBakeDiffuseToVertexColorMode : byte
	{
		// Token: 0x04004803 RID: 18435
		Disable,
		// Token: 0x04004804 RID: 18436
		NoCompression,
		// Token: 0x04004805 RID: 18437
		RGB565,
		// Token: 0x04004806 RID: 18438
		EHLODBakeDiffuseToVertexColorMode_MAX
	}
}
