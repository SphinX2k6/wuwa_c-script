using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200077D RID: 1917
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/DawnSDKCommon.EDawnSDKServerConfigChoice")]
	public enum EDawnSDKServerConfigChoice
	{
		// Token: 0x0400302F RID: 12335
		UseConfig1 = 1,
		// Token: 0x04003030 RID: 12336
		UseConfig2,
		// Token: 0x04003031 RID: 12337
		UseConfig3,
		// Token: 0x04003032 RID: 12338
		EDawnSDKServerConfigChoice_MAX
	}
}
