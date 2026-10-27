using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001753 RID: 5971
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComponent.ESplineRunState")]
	public enum ESplineRunState : byte
	{
		// Token: 0x0400BB48 RID: 47944
		None,
		// Token: 0x0400BB49 RID: 47945
		Trip,
		// Token: 0x0400BB4A RID: 47946
		ReturnTrip,
		// Token: 0x0400BB4B RID: 47947
		ESplineRunState_MAX
	}
}
