using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200077A RID: 1914
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CurveEditor.ECurveEditorZoomPosition")]
	public enum ECurveEditorZoomPosition : byte
	{
		// Token: 0x04003021 RID: 12321
		CurrentTime,
		// Token: 0x04003022 RID: 12322
		MousePosition,
		// Token: 0x04003023 RID: 12323
		ECurveEditorZoomPosition_MAX
	}
}
