using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000777 RID: 1911
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CurveEditorTools.EMultiScalePivotType")]
	public enum EMultiScalePivotType : byte
	{
		// Token: 0x0400300D RID: 12301
		Average,
		// Token: 0x0400300E RID: 12302
		BoundCenter,
		// Token: 0x0400300F RID: 12303
		FirstKey,
		// Token: 0x04003010 RID: 12304
		LastKey,
		// Token: 0x04003011 RID: 12305
		EMultiScalePivotType_MAX
	}
}
