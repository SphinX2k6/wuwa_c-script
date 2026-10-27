using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020028D1 RID: 10449
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/StreamlineRHI.EStreamlineSettingOverride")]
	public enum EStreamlineSettingOverride : byte
	{
		// Token: 0x04015483 RID: 87171
		Enabled,
		// Token: 0x04015484 RID: 87172
		Disabled,
		// Token: 0x04015485 RID: 87173
		UseProjectSettings,
		// Token: 0x04015486 RID: 87174
		EStreamlineSettingOverride_MAX
	}
}
