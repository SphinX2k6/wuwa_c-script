using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BA5 RID: 2981
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EUIScalingRule")]
	public enum EUIScalingRule : byte
	{
		// Token: 0x04005213 RID: 21011
		ShortestSide,
		// Token: 0x04005214 RID: 21012
		LongestSide,
		// Token: 0x04005215 RID: 21013
		Horizontal,
		// Token: 0x04005216 RID: 21014
		Vertical,
		// Token: 0x04005217 RID: 21015
		ScaleToFit,
		// Token: 0x04005218 RID: 21016
		Custom,
		// Token: 0x04005219 RID: 21017
		EUIScalingRule_MAX
	}
}
