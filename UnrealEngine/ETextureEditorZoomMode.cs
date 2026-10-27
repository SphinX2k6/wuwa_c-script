using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200290F RID: 10511
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TextureEditor.ETextureEditorZoomMode")]
	public enum ETextureEditorZoomMode : byte
	{
		// Token: 0x0401563E RID: 87614
		Custom,
		// Token: 0x0401563F RID: 87615
		Fit,
		// Token: 0x04015640 RID: 87616
		Fill,
		// Token: 0x04015641 RID: 87617
		ETextureEditorZoomMode_MAX
	}
}
