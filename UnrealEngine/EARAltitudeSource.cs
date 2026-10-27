using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003DB RID: 987
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARAltitudeSource")]
	public enum EARAltitudeSource : byte
	{
		// Token: 0x040017FC RID: 6140
		Precise,
		// Token: 0x040017FD RID: 6141
		Coarse,
		// Token: 0x040017FE RID: 6142
		UserDefined,
		// Token: 0x040017FF RID: 6143
		Unknown,
		// Token: 0x04001800 RID: 6144
		EARAltitudeSource_MAX
	}
}
