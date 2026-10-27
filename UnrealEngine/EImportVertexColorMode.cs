using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022D0 RID: 8912
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintEditorMode.EImportVertexColorMode")]
	public enum EImportVertexColorMode : byte
	{
		// Token: 0x040120AF RID: 73903
		FromTexture,
		// Token: 0x040120B0 RID: 73904
		FromPosition,
		// Token: 0x040120B1 RID: 73905
		EImportVertexColorMode_MAX
	}
}
