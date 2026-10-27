using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001E85 RID: 7813
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroTeaHelper.ESourceChannel")]
	public enum ESourceChannel : byte
	{
		// Token: 0x0401019A RID: 65946
		R,
		// Token: 0x0401019B RID: 65947
		G,
		// Token: 0x0401019C RID: 65948
		B,
		// Token: 0x0401019D RID: 65949
		A,
		// Token: 0x0401019E RID: 65950
		ESourceChannel_MAX
	}
}
