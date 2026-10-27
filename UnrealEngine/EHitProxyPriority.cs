using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A7C RID: 2684
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EHitProxyPriority")]
	public enum EHitProxyPriority
	{
		// Token: 0x040047FD RID: 18429
		HPP_World,
		// Token: 0x040047FE RID: 18430
		HPP_Wireframe,
		// Token: 0x040047FF RID: 18431
		HPP_Foreground,
		// Token: 0x04004800 RID: 18432
		HPP_UI,
		// Token: 0x04004801 RID: 18433
		HPP_MAX
	}
}
