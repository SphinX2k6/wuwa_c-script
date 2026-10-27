using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003F0 RID: 1008
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARSceneReconstruction")]
	public enum EARSceneReconstruction : byte
	{
		// Token: 0x040018B1 RID: 6321
		None,
		// Token: 0x040018B2 RID: 6322
		MeshOnly,
		// Token: 0x040018B3 RID: 6323
		MeshWithClassification,
		// Token: 0x040018B4 RID: 6324
		EARSceneReconstruction_MAX
	}
}
