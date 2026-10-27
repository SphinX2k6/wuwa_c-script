using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200290E RID: 10510
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TextureEditor.ETextureEditorVolumeViewMode")]
	public enum ETextureEditorVolumeViewMode
	{
		// Token: 0x0401563A RID: 87610
		TextureEditorVolumeViewMode_DepthSlices,
		// Token: 0x0401563B RID: 87611
		TextureEditorVolumeViewMode_VolumeTrace,
		// Token: 0x0401563C RID: 87612
		TextureEditorVolumeViewMode_MAX
	}
}
