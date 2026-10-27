using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A74 RID: 2676
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EFullyLoadPackageType")]
	public enum EFullyLoadPackageType
	{
		// Token: 0x040047C7 RID: 18375
		FULLYLOAD_Map,
		// Token: 0x040047C8 RID: 18376
		FULLYLOAD_Game_PreLoadClass,
		// Token: 0x040047C9 RID: 18377
		FULLYLOAD_Game_PostLoadClass,
		// Token: 0x040047CA RID: 18378
		FULLYLOAD_Always,
		// Token: 0x040047CB RID: 18379
		FULLYLOAD_Mutator,
		// Token: 0x040047CC RID: 18380
		FULLYLOAD_MAX
	}
}
