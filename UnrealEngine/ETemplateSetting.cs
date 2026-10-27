using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020013FD RID: 5117
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameProjectGeneration.ETemplateSetting")]
	public enum ETemplateSetting
	{
		// Token: 0x04009FB4 RID: 40884
		Languages,
		// Token: 0x04009FB5 RID: 40885
		HardwareTarget,
		// Token: 0x04009FB6 RID: 40886
		GraphicsPreset,
		// Token: 0x04009FB7 RID: 40887
		StarterContent,
		// Token: 0x04009FB8 RID: 40888
		XR,
		// Token: 0x04009FB9 RID: 40889
		Raytracing,
		// Token: 0x04009FBA RID: 40890
		All,
		// Token: 0x04009FBB RID: 40891
		ETemplateSetting_MAX
	}
}
