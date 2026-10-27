using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A48 RID: 10824
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/USDClasses.EReferencerTypeHandling")]
	public enum EReferencerTypeHandling : byte
	{
		// Token: 0x04015EED RID: 89837
		Ignore,
		// Token: 0x04015EEE RID: 89838
		MatchReferencedType,
		// Token: 0x04015EEF RID: 89839
		ClearReferencerType,
		// Token: 0x04015EF0 RID: 89840
		ShowPrompt,
		// Token: 0x04015EF1 RID: 89841
		EReferencerTypeHandling_MAX
	}
}
