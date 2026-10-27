using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022D1 RID: 8913
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintEditorMode.EVertexColorExportSectionMethod")]
	public enum EVertexColorExportSectionMethod : sbyte
	{
		// Token: 0x040120B3 RID: 73907
		ExportAllSections,
		// Token: 0x040120B4 RID: 73908
		ExportSingleSection,
		// Token: 0x040120B5 RID: 73909
		ExportAsWhole,
		// Token: 0x040120B6 RID: 73910
		EVertexColorExportSectionMethod_MAX
	}
}
