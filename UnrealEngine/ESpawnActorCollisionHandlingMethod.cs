using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B70 RID: 2928
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESpawnActorCollisionHandlingMethod")]
	public enum ESpawnActorCollisionHandlingMethod : byte
	{
		// Token: 0x040050AF RID: 20655
		Undefined,
		// Token: 0x040050B0 RID: 20656
		AlwaysSpawn,
		// Token: 0x040050B1 RID: 20657
		AdjustIfPossibleButAlwaysSpawn,
		// Token: 0x040050B2 RID: 20658
		AdjustIfPossibleButDontSpawnIfColliding,
		// Token: 0x040050B3 RID: 20659
		DontSpawnIfColliding,
		// Token: 0x040050B4 RID: 20660
		ESpawnActorCollisionHandlingMethod_MAX
	}
}
