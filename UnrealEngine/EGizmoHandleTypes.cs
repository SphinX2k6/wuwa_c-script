using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A52 RID: 10834
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ViewportInteraction.EGizmoHandleTypes")]
	public enum EGizmoHandleTypes : byte
	{
		// Token: 0x04015F20 RID: 89888
		All,
		// Token: 0x04015F21 RID: 89889
		Translate,
		// Token: 0x04015F22 RID: 89890
		Rotate,
		// Token: 0x04015F23 RID: 89891
		Scale,
		// Token: 0x04015F24 RID: 89892
		EGizmoHandleTypes_MAX
	}
}
