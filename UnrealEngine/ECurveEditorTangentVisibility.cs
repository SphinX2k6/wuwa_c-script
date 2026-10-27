using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000779 RID: 1913
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CurveEditor.ECurveEditorTangentVisibility")]
	public enum ECurveEditorTangentVisibility : byte
	{
		// Token: 0x0400301C RID: 12316
		AllTangents,
		// Token: 0x0400301D RID: 12317
		SelectedKeys,
		// Token: 0x0400301E RID: 12318
		NoTangents,
		// Token: 0x0400301F RID: 12319
		ECurveEditorTangentVisibility_MAX
	}
}
