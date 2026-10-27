using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200049B RID: 1179
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ClothPainter.ESourceColorChannel")]
	public enum ESourceColorChannel : byte
	{
		// Token: 0x04001DFB RID: 7675
		Red,
		// Token: 0x04001DFC RID: 7676
		Green,
		// Token: 0x04001DFD RID: 7677
		Blue,
		// Token: 0x04001DFE RID: 7678
		Alpha,
		// Token: 0x04001DFF RID: 7679
		ESourceColorChannel_MAX
	}
}
