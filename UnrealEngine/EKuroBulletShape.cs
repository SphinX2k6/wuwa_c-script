using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016E5 RID: 5861
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletShape")]
	public enum EKuroBulletShape : byte
	{
		// Token: 0x0400B8A2 RID: 47266
		None,
		// Token: 0x0400B8A3 RID: 47267
		Box,
		// Token: 0x0400B8A4 RID: 47268
		Sphere,
		// Token: 0x0400B8A5 RID: 47269
		Sector,
		// Token: 0x0400B8A6 RID: 47270
		Cylinder,
		// Token: 0x0400B8A7 RID: 47271
		EKuroBulletShape_MAX
	}
}
