using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001829 RID: 6185
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEffectMakerEditor.ENormalMapSourceChannel")]
	public enum ENormalMapSourceChannel : byte
	{
		// Token: 0x0400C67C RID: 50812
		Luminance,
		// Token: 0x0400C67D RID: 50813
		R,
		// Token: 0x0400C67E RID: 50814
		G,
		// Token: 0x0400C67F RID: 50815
		B,
		// Token: 0x0400C680 RID: 50816
		A,
		// Token: 0x0400C681 RID: 50817
		ENormalMapSourceChannel_MAX
	}
}
