using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B9E RID: 2974
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETransitionType")]
	public enum ETransitionType : byte
	{
		// Token: 0x040051E1 RID: 20961
		None,
		// Token: 0x040051E2 RID: 20962
		Paused,
		// Token: 0x040051E3 RID: 20963
		Loading,
		// Token: 0x040051E4 RID: 20964
		Saving,
		// Token: 0x040051E5 RID: 20965
		Connecting,
		// Token: 0x040051E6 RID: 20966
		Precaching,
		// Token: 0x040051E7 RID: 20967
		WaitingToConnect,
		// Token: 0x040051E8 RID: 20968
		MAX
	}
}
