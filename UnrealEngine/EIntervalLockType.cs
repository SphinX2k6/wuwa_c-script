using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001961 RID: 6497
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGAS.EIntervalLockType")]
	public enum EIntervalLockType : byte
	{
		// Token: 0x0400D190 RID: 53648
		NotLocked,
		// Token: 0x0400D191 RID: 53649
		LockUpperBound,
		// Token: 0x0400D192 RID: 53650
		LockLowerBound,
		// Token: 0x0400D193 RID: 53651
		LockBoth,
		// Token: 0x0400D194 RID: 53652
		EIntervalLockType_MAX
	}
}
