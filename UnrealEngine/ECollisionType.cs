using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001639 RID: 5689
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ECollisionType")]
	public enum ECollisionType : byte
	{
		// Token: 0x0400B31A RID: 45850
		None,
		// Token: 0x0400B31B RID: 45851
		Spherical,
		// Token: 0x0400B31C RID: 45852
		Cylinder,
		// Token: 0x0400B31D RID: 45853
		Capsule,
		// Token: 0x0400B31E RID: 45854
		Planar,
		// Token: 0x0400B31F RID: 45855
		ECollisionType_MAX
	}
}
