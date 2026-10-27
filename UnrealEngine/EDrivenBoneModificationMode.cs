using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000318 RID: 792
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EDrivenBoneModificationMode")]
	public enum EDrivenBoneModificationMode : byte
	{
		// Token: 0x040012E9 RID: 4841
		AddToInput,
		// Token: 0x040012EA RID: 4842
		ReplaceComponent,
		// Token: 0x040012EB RID: 4843
		AddToRefPose,
		// Token: 0x040012EC RID: 4844
		EDrivenBoneModificationMode_MAX
	}
}
