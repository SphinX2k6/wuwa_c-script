using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200032F RID: 815
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EWarpingVectorMode")]
	public enum EWarpingVectorMode : byte
	{
		// Token: 0x04001371 RID: 4977
		ComponentSpaceVector,
		// Token: 0x04001372 RID: 4978
		ActorSpaceVector,
		// Token: 0x04001373 RID: 4979
		WorldSpaceVector,
		// Token: 0x04001374 RID: 4980
		IKFootRootLocalSpaceVector,
		// Token: 0x04001375 RID: 4981
		EWarpingVectorMode_MAX
	}
}
