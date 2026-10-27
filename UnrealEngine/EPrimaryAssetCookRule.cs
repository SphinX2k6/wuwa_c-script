using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B21 RID: 2849
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPrimaryAssetCookRule")]
	public enum EPrimaryAssetCookRule : byte
	{
		// Token: 0x04004DFA RID: 19962
		Unknown,
		// Token: 0x04004DFB RID: 19963
		NeverCook,
		// Token: 0x04004DFC RID: 19964
		DevelopmentCook,
		// Token: 0x04004DFD RID: 19965
		DevelopmentAlwaysCook,
		// Token: 0x04004DFE RID: 19966
		AlwaysCook,
		// Token: 0x04004DFF RID: 19967
		EPrimaryAssetCookRule_MAX
	}
}
