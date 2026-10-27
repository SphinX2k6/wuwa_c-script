using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A6C RID: 2668
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFFTWindowType")]
	public enum EFFTWindowType : byte
	{
		// Token: 0x04004798 RID: 18328
		None,
		// Token: 0x04004799 RID: 18329
		Hamming,
		// Token: 0x0400479A RID: 18330
		Hann,
		// Token: 0x0400479B RID: 18331
		Blackman,
		// Token: 0x0400479C RID: 18332
		EFFTWindowType_MAX
	}
}
