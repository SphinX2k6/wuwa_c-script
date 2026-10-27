using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A3A RID: 10810
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EProjectPackagingInternationalizationPresets")]
	public enum EProjectPackagingInternationalizationPresets : byte
	{
		// Token: 0x04015E9B RID: 89755
		English,
		// Token: 0x04015E9C RID: 89756
		EFIGS,
		// Token: 0x04015E9D RID: 89757
		EFIGSCJK,
		// Token: 0x04015E9E RID: 89758
		CJK,
		// Token: 0x04015E9F RID: 89759
		All,
		// Token: 0x04015EA0 RID: 89760
		EProjectPackagingInternationalizationPresets_MAX
	}
}
