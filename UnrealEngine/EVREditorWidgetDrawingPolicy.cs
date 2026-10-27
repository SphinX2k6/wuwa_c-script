using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A5E RID: 10846
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/VREditor.EVREditorWidgetDrawingPolicy")]
	public enum EVREditorWidgetDrawingPolicy : byte
	{
		// Token: 0x04015F6A RID: 89962
		Always,
		// Token: 0x04015F6B RID: 89963
		Hovering,
		// Token: 0x04015F6C RID: 89964
		EVREditorWidgetDrawingPolicy_MAX
	}
}
