using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A51 RID: 10833
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/VariantManagerContentEditor.EVariantManagerTestEnum")]
	public enum EVariantManagerTestEnum : byte
	{
		// Token: 0x04015F1A RID: 89882
		None,
		// Token: 0x04015F1B RID: 89883
		FirstOption,
		// Token: 0x04015F1C RID: 89884
		SecondOption = 3,
		// Token: 0x04015F1D RID: 89885
		ThirdOption = 45,
		// Token: 0x04015F1E RID: 89886
		EVariantManagerTestEnum_MAX
	}
}
