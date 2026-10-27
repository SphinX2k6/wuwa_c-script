using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023CF RID: 9167
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.ESpawnOwnership")]
	public enum ESpawnOwnership : byte
	{
		// Token: 0x0401267D RID: 75389
		InnerSequence,
		// Token: 0x0401267E RID: 75390
		MasterSequence,
		// Token: 0x0401267F RID: 75391
		External,
		// Token: 0x04012680 RID: 75392
		ESpawnOwnership_MAX
	}
}
