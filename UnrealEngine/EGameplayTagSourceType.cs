using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020013DA RID: 5082
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayTags.EGameplayTagSourceType")]
	public enum EGameplayTagSourceType : byte
	{
		// Token: 0x04009EF3 RID: 40691
		Native,
		// Token: 0x04009EF4 RID: 40692
		DefaultTagList,
		// Token: 0x04009EF5 RID: 40693
		TagList,
		// Token: 0x04009EF6 RID: 40694
		RestrictedTagList,
		// Token: 0x04009EF7 RID: 40695
		DataTable,
		// Token: 0x04009EF8 RID: 40696
		UglyTagList,
		// Token: 0x04009EF9 RID: 40697
		Invalid,
		// Token: 0x04009EFA RID: 40698
		EGameplayTagSourceType_MAX
	}
}
