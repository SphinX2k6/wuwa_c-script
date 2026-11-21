using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001FC RID: 508
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESpawnActorCollisionHandlingMethod")]
	public enum ESpawnActorCollisionHandlingMethod : byte
	{
		// Token: 0x04000CA8 RID: 3240
		Undefined,
		// Token: 0x04000CA9 RID: 3241
		AlwaysSpawn,
		// Token: 0x04000CAA RID: 3242
		AdjustIfPossibleButAlwaysSpawn,
		// Token: 0x04000CAB RID: 3243
		AdjustIfPossibleButDontSpawnIfColliding,
		// Token: 0x04000CAC RID: 3244
		DontSpawnIfColliding,
		// Token: 0x04000CAD RID: 3245
		ESpawnActorCollisionHandlingMethod_MAX
	}
}
