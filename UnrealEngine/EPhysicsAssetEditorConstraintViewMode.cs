using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A30 RID: 10800
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EPhysicsAssetEditorConstraintViewMode")]
	public enum EPhysicsAssetEditorConstraintViewMode : byte
	{
		// Token: 0x04015E5E RID: 89694
		None,
		// Token: 0x04015E5F RID: 89695
		AllPositions,
		// Token: 0x04015E60 RID: 89696
		AllLimits,
		// Token: 0x04015E61 RID: 89697
		EPhysicsAssetEditorConstraintViewMode_MAX
	}
}
