using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000209 RID: 521
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EWindSourceType")]
	public enum EWindSourceType : byte
	{
		// Token: 0x04000D16 RID: 3350
		Directional,
		// Token: 0x04000D17 RID: 3351
		Point,
		// Token: 0x04000D18 RID: 3352
		EWindSourceType_MAX
	}
}
