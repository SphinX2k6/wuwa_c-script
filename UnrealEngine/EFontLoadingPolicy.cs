using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002800 RID: 10240
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EFontLoadingPolicy")]
	public enum EFontLoadingPolicy : byte
	{
		// Token: 0x04014D9C RID: 85404
		LazyLoad,
		// Token: 0x04014D9D RID: 85405
		Stream,
		// Token: 0x04014D9E RID: 85406
		Inline,
		// Token: 0x04014D9F RID: 85407
		EFontLoadingPolicy_MAX
	}
}
