using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027FF RID: 10239
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EFontLayoutMethod")]
	public enum EFontLayoutMethod : byte
	{
		// Token: 0x04014D98 RID: 85400
		Metrics,
		// Token: 0x04014D99 RID: 85401
		BoundingBox,
		// Token: 0x04014D9A RID: 85402
		EFontLayoutMethod_MAX
	}
}
