using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BA6 RID: 2982
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EUpdateRateShiftBucket")]
	public enum EUpdateRateShiftBucket : byte
	{
		// Token: 0x0400521B RID: 21019
		ShiftBucket0,
		// Token: 0x0400521C RID: 21020
		ShiftBucket1,
		// Token: 0x0400521D RID: 21021
		ShiftBucket2,
		// Token: 0x0400521E RID: 21022
		ShiftBucket3,
		// Token: 0x0400521F RID: 21023
		ShiftBucket4,
		// Token: 0x04005220 RID: 21024
		ShiftBucket5,
		// Token: 0x04005221 RID: 21025
		ShiftBucketMax,
		// Token: 0x04005222 RID: 21026
		EUpdateRateShiftBucket_MAX
	}
}
