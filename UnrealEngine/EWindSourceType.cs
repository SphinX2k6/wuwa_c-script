using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BBD RID: 3005
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EWindSourceType")]
	public enum EWindSourceType : byte
	{
		// Token: 0x040052BD RID: 21181
		Directional,
		// Token: 0x040052BE RID: 21182
		Point,
		// Token: 0x040052BF RID: 21183
		EWindSourceType_MAX
	}
}
