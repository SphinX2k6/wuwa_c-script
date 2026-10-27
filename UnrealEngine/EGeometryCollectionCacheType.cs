using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000462 RID: 1122
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EGeometryCollectionCacheType")]
	public enum EGeometryCollectionCacheType : byte
	{
		// Token: 0x04001C02 RID: 7170
		None,
		// Token: 0x04001C03 RID: 7171
		Record,
		// Token: 0x04001C04 RID: 7172
		Play,
		// Token: 0x04001C05 RID: 7173
		RecordAndPlay,
		// Token: 0x04001C06 RID: 7174
		EGeometryCollectionCacheType_MAX
	}
}
