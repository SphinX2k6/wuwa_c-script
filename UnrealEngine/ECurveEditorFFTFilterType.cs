using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000776 RID: 1910
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CurveEditorTools.ECurveEditorFFTFilterType")]
	public enum ECurveEditorFFTFilterType : byte
	{
		// Token: 0x04003009 RID: 12297
		Lowpass,
		// Token: 0x0400300A RID: 12298
		Highpass,
		// Token: 0x0400300B RID: 12299
		ECurveEditorFFTFilterType_MAX
	}
}
