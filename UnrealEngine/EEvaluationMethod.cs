using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023C4 RID: 9156
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EEvaluationMethod")]
	public enum EEvaluationMethod : byte
	{
		// Token: 0x0401262D RID: 75309
		Static,
		// Token: 0x0401262E RID: 75310
		Swept,
		// Token: 0x0401262F RID: 75311
		EEvaluationMethod_MAX
	}
}
