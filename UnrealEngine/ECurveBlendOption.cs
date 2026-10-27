using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A36 RID: 2614
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECurveBlendOption")]
	public enum ECurveBlendOption
	{
		// Token: 0x040045F3 RID: 17907
		Override,
		// Token: 0x040045F4 RID: 17908
		DoNotOverride,
		// Token: 0x040045F5 RID: 17909
		NormalizeByWeight,
		// Token: 0x040045F6 RID: 17910
		BlendByWeight,
		// Token: 0x040045F7 RID: 17911
		UseBasePose,
		// Token: 0x040045F8 RID: 17912
		UseMaxValue,
		// Token: 0x040045F9 RID: 17913
		UseMinValue,
		// Token: 0x040045FA RID: 17914
		ECurveBlendOption_MAX
	}
}
