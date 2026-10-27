using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A4E RID: 6734
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.ETextureCombineFlag")]
	public enum ETextureCombineFlag : byte
	{
		// Token: 0x0400D76D RID: 55149
		CF_TO_ALPHA,
		// Token: 0x0400D76E RID: 55150
		CF_TO_MAX
	}
}
