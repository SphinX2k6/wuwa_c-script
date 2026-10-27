using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200265A RID: 9818
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ProceduralMeshComponent.EProcMeshSliceCapOption")]
	public enum EProcMeshSliceCapOption : byte
	{
		// Token: 0x040139A4 RID: 80292
		NoCap,
		// Token: 0x040139A5 RID: 80293
		CreateNewSectionForCap,
		// Token: 0x040139A6 RID: 80294
		UseLastSectionForCap,
		// Token: 0x040139A7 RID: 80295
		EProcMeshSliceCapOption_MAX
	}
}
