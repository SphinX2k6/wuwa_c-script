using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023C5 RID: 9157
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EMovieSceneBlendType")]
	public enum EMovieSceneBlendType : byte
	{
		// Token: 0x04012631 RID: 75313
		Invalid,
		// Token: 0x04012632 RID: 75314
		Absolute,
		// Token: 0x04012633 RID: 75315
		Additive,
		// Token: 0x04012634 RID: 75316
		Relative = 4,
		// Token: 0x04012635 RID: 75317
		AdditiveFromBase = 8,
		// Token: 0x04012636 RID: 75318
		EMovieSceneBlendType_MAX
	}
}
