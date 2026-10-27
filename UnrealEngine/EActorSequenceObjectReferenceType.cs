using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000D9 RID: 217
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ActorSequence.EActorSequenceObjectReferenceType")]
	public enum EActorSequenceObjectReferenceType : byte
	{
		// Token: 0x040002C9 RID: 713
		ContextActor,
		// Token: 0x040002CA RID: 714
		ExternalActor,
		// Token: 0x040002CB RID: 715
		Component,
		// Token: 0x040002CC RID: 716
		EActorSequenceObjectReferenceType_MAX
	}
}
