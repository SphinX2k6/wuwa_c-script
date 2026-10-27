using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A2D RID: 2605
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECollisionEnabled")]
	public enum ECollisionEnabled
	{
		// Token: 0x040045BB RID: 17851
		NoCollision,
		// Token: 0x040045BC RID: 17852
		QueryOnly,
		// Token: 0x040045BD RID: 17853
		PhysicsOnly,
		// Token: 0x040045BE RID: 17854
		QueryAndPhysics,
		// Token: 0x040045BF RID: 17855
		ECollisionEnabled_MAX
	}
}
