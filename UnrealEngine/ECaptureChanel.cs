using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200151D RID: 5405
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ImposterBaker.ECaptureChanel")]
	public enum ECaptureChanel : byte
	{
		// Token: 0x0400A9FE RID: 43518
		None,
		// Token: 0x0400A9FF RID: 43519
		BaseColorAlpha,
		// Token: 0x0400AA00 RID: 43520
		NormalDepth,
		// Token: 0x0400AA01 RID: 43521
		PBRAO,
		// Token: 0x0400AA02 RID: 43522
		LeafMask,
		// Token: 0x0400AA03 RID: 43523
		Num,
		// Token: 0x0400AA04 RID: 43524
		ECaptureChanel_MAX
	}
}
