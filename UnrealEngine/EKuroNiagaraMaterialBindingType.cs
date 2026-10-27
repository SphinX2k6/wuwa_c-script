using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A47 RID: 6727
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.EKuroNiagaraMaterialBindingType")]
	public enum EKuroNiagaraMaterialBindingType : byte
	{
		// Token: 0x0400D742 RID: 55106
		Float,
		// Token: 0x0400D743 RID: 55107
		LinearColor,
		// Token: 0x0400D744 RID: 55108
		Texture,
		// Token: 0x0400D745 RID: 55109
		EKuroNiagaraMaterialBindingType_MAX
	}
}
