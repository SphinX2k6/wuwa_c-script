using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002953 RID: 10579
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.EDesignPreviewSizeMode")]
	public enum EDesignPreviewSizeMode : byte
	{
		// Token: 0x0401581E RID: 88094
		FillScreen,
		// Token: 0x0401581F RID: 88095
		Custom,
		// Token: 0x04015820 RID: 88096
		CustomOnScreen,
		// Token: 0x04015821 RID: 88097
		Desired,
		// Token: 0x04015822 RID: 88098
		DesiredOnScreen,
		// Token: 0x04015823 RID: 88099
		EDesignPreviewSizeMode_MAX
	}
}
