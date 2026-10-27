using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FFF RID: 8191
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUIAudioDataType")]
	public enum EUIAudioDataType : byte
	{
		// Token: 0x04010C53 RID: 68691
		Default,
		// Token: 0x04010C54 RID: 68692
		UUISpineRenderable,
		// Token: 0x04010C55 RID: 68693
		UUIButtonComponent,
		// Token: 0x04010C56 RID: 68694
		UUIExtendToggle,
		// Token: 0x04010C57 RID: 68695
		UUIAudioManager,
		// Token: 0x04010C58 RID: 68696
		UUINiagara,
		// Token: 0x04010C59 RID: 68697
		UUISliderComponent,
		// Token: 0x04010C5A RID: 68698
		EUIAudioDataType_MAX
	}
}
