using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000179 RID: 377
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvOverlapShape")]
	public enum EEnvOverlapShape
	{
		// Token: 0x04000680 RID: 1664
		Box,
		// Token: 0x04000681 RID: 1665
		Sphere,
		// Token: 0x04000682 RID: 1666
		Capsule,
		// Token: 0x04000683 RID: 1667
		EEnvOverlapShape_MAX
	}
}
