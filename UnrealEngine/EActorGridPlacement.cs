using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009E1 RID: 2529
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EActorGridPlacement")]
	public enum EActorGridPlacement : byte
	{
		// Token: 0x040043E6 RID: 17382
		Bounds,
		// Token: 0x040043E7 RID: 17383
		Location,
		// Token: 0x040043E8 RID: 17384
		AlwaysLoaded,
		// Token: 0x040043E9 RID: 17385
		None,
		// Token: 0x040043EA RID: 17386
		EActorGridPlacement_MAX
	}
}
