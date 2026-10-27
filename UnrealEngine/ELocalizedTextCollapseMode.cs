using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002238 RID: 8760
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Localization.ELocalizedTextCollapseMode")]
	public enum ELocalizedTextCollapseMode : byte
	{
		// Token: 0x04011C65 RID: 72805
		IdenticalTextIdAndSource,
		// Token: 0x04011C66 RID: 72806
		IdenticalPackageIdTextIdAndSource,
		// Token: 0x04011C67 RID: 72807
		IdenticalNamespaceAndSource,
		// Token: 0x04011C68 RID: 72808
		ELocalizedTextCollapseMode_MAX
	}
}
