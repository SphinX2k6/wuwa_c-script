using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015D0 RID: 5584
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KawaiiPhysics.EPlanarConstraint")]
	public enum EPlanarConstraint : byte
	{
		// Token: 0x0400AF39 RID: 44857
		None,
		// Token: 0x0400AF3A RID: 44858
		X,
		// Token: 0x0400AF3B RID: 44859
		Y,
		// Token: 0x0400AF3C RID: 44860
		Z,
		// Token: 0x0400AF3D RID: 44861
		EPlanarConstraint_MAX
	}
}
