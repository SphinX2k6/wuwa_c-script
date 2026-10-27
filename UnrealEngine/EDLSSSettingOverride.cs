using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000786 RID: 1926
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/DLSS.EDLSSSettingOverride")]
	public enum EDLSSSettingOverride : byte
	{
		// Token: 0x04003097 RID: 12439
		Enabled,
		// Token: 0x04003098 RID: 12440
		Disabled,
		// Token: 0x04003099 RID: 12441
		UseProjectSettings,
		// Token: 0x0400309A RID: 12442
		EDLSSSettingOverride_MAX
	}
}
