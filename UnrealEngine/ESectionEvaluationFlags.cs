using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023CE RID: 9166
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.ESectionEvaluationFlags")]
	public enum ESectionEvaluationFlags : byte
	{
		// Token: 0x04012678 RID: 75384
		None,
		// Token: 0x04012679 RID: 75385
		PreRoll,
		// Token: 0x0401267A RID: 75386
		PostRoll,
		// Token: 0x0401267B RID: 75387
		ESectionEvaluationFlags_MAX
	}
}
