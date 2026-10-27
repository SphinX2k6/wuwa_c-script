using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000718 RID: 1816
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.ELogTimes")]
	public enum ELogTimes
	{
		// Token: 0x04002DF3 RID: 11763
		None,
		// Token: 0x04002DF4 RID: 11764
		UTC,
		// Token: 0x04002DF5 RID: 11765
		SinceGStartTime,
		// Token: 0x04002DF6 RID: 11766
		Local,
		// Token: 0x04002DF7 RID: 11767
		ELogTimes_MAX
	}
}
