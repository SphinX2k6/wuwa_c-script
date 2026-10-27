using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016E7 RID: 5863
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletWhirlpoolVelocityCurveType")]
	public enum EKuroBulletWhirlpoolVelocityCurveType : byte
	{
		// Token: 0x0400B8AE RID: 47278
		None,
		// Token: 0x0400B8AF RID: 47279
		Convex,
		// Token: 0x0400B8B0 RID: 47280
		LinearityDown,
		// Token: 0x0400B8B1 RID: 47281
		Concave,
		// Token: 0x0400B8B2 RID: 47282
		EKuroBulletWhirlpoolVelocityCurveType_MAX
	}
}
