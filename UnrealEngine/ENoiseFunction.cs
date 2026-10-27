using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AFA RID: 2810
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENoiseFunction")]
	public enum ENoiseFunction
	{
		// Token: 0x04004CF7 RID: 19703
		NOISEFUNCTION_SimplexTex,
		// Token: 0x04004CF8 RID: 19704
		NOISEFUNCTION_GradientTex,
		// Token: 0x04004CF9 RID: 19705
		NOISEFUNCTION_GradientTex3D,
		// Token: 0x04004CFA RID: 19706
		NOISEFUNCTION_GradientALU,
		// Token: 0x04004CFB RID: 19707
		NOISEFUNCTION_ValueALU,
		// Token: 0x04004CFC RID: 19708
		NOISEFUNCTION_VoronoiALU,
		// Token: 0x04004CFD RID: 19709
		NOISEFUNCTION_MAX
	}
}
