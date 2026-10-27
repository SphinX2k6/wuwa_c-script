using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000775 RID: 1909
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CurveEditorTools.ECurveEditorFFTFilterClass")]
	public enum ECurveEditorFFTFilterClass : byte
	{
		// Token: 0x04003005 RID: 12293
		Butterworth,
		// Token: 0x04003006 RID: 12294
		Chebyshev,
		// Token: 0x04003007 RID: 12295
		ECurveEditorFFTFilterClass_MAX
	}
}
