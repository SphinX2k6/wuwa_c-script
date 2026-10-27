using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B63 RID: 2915
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESkeletalMeshForcePreviousBoneUpateMode")]
	public enum ESkeletalMeshForcePreviousBoneUpateMode : byte
	{
		// Token: 0x04005054 RID: 20564
		None,
		// Token: 0x04005055 RID: 20565
		NotUpdate,
		// Token: 0x04005056 RID: 20566
		UpdatePrevious,
		// Token: 0x04005057 RID: 20567
		DuplicateCurrentToPrevious,
		// Token: 0x04005058 RID: 20568
		ESkeletalMeshForcePreviousBoneUpateMode_MAX
	}
}
