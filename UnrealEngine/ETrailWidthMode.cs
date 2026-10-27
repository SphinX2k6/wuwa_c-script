using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B9B RID: 2971
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETrailWidthMode")]
	public enum ETrailWidthMode
	{
		// Token: 0x040051D3 RID: 20947
		ETrailWidthMode_FromCentre,
		// Token: 0x040051D4 RID: 20948
		ETrailWidthMode_FromFirst,
		// Token: 0x040051D5 RID: 20949
		ETrailWidthMode_FromSecond,
		// Token: 0x040051D6 RID: 20950
		ETrailWidthMode_MAX
	}
}
