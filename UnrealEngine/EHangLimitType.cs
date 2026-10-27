using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F21 RID: 7969
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVehicle.EHangLimitType")]
	public enum EHangLimitType : byte
	{
		// Token: 0x04010501 RID: 66817
		SingleDirect,
		// Token: 0x04010502 RID: 66818
		CutSphere,
		// Token: 0x04010503 RID: 66819
		EHangLimitType_MAX
	}
}
