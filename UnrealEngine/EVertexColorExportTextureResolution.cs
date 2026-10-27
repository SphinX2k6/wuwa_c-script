using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022D2 RID: 8914
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintEditorMode.EVertexColorExportTextureResolution")]
	public enum EVertexColorExportTextureResolution : sbyte
	{
		// Token: 0x040120B8 RID: 73912
		Res_4096,
		// Token: 0x040120B9 RID: 73913
		Res_2048,
		// Token: 0x040120BA RID: 73914
		Res_1024,
		// Token: 0x040120BB RID: 73915
		Res_MAX
	}
}
