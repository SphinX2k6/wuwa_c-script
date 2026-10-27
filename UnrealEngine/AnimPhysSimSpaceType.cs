using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200030D RID: 781
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimPhysSimSpaceType")]
	public enum AnimPhysSimSpaceType : byte
	{
		// Token: 0x040012AC RID: 4780
		Component,
		// Token: 0x040012AD RID: 4781
		Actor,
		// Token: 0x040012AE RID: 4782
		World,
		// Token: 0x040012AF RID: 4783
		RootRelative,
		// Token: 0x040012B0 RID: 4784
		BoneRelative,
		// Token: 0x040012B1 RID: 4785
		AnimPhysSimSpaceType_MAX
	}
}
