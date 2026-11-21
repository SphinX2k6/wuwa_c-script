using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004A2 RID: 1186
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.BP_EWorldType")]
	public enum BP_EWorldType : byte
	{
		// Token: 0x04002F60 RID: 12128
		None,
		// Token: 0x04002F61 RID: 12129
		Game,
		// Token: 0x04002F62 RID: 12130
		Editor,
		// Token: 0x04002F63 RID: 12131
		PIE,
		// Token: 0x04002F64 RID: 12132
		EditorPreview,
		// Token: 0x04002F65 RID: 12133
		GamePreview,
		// Token: 0x04002F66 RID: 12134
		GameRPC,
		// Token: 0x04002F67 RID: 12135
		Inactive,
		// Token: 0x04002F68 RID: 12136
		BP_MAX
	}
}
