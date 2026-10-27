using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A54 RID: 10836
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ViewportInteraction.EViewportInteractionDraggingMode")]
	public enum EViewportInteractionDraggingMode : byte
	{
		// Token: 0x04015F2B RID: 89899
		Nothing,
		// Token: 0x04015F2C RID: 89900
		TransformablesWithGizmo,
		// Token: 0x04015F2D RID: 89901
		TransformablesAtLaserImpact,
		// Token: 0x04015F2E RID: 89902
		AssistingDrag,
		// Token: 0x04015F2F RID: 89903
		TransformablesFreely,
		// Token: 0x04015F30 RID: 89904
		World,
		// Token: 0x04015F31 RID: 89905
		Interactable,
		// Token: 0x04015F32 RID: 89906
		Material,
		// Token: 0x04015F33 RID: 89907
		EViewportInteractionDraggingMode_MAX
	}
}
