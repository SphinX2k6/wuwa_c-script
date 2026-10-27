using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002008 RID: 8200
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUIRaycastSortType")]
	public enum EUIRaycastSortType : byte
	{
		// Token: 0x04010C92 RID: 68754
		DependOnUIDepth,
		// Token: 0x04010C93 RID: 68755
		DependOnDistance,
		// Token: 0x04010C94 RID: 68756
		EUIRaycastSortType_MAX
	}
}
