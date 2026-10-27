using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A07 RID: 2567
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAxisOption")]
	public enum EAxisOption
	{
		// Token: 0x040044C6 RID: 17606
		X,
		// Token: 0x040044C7 RID: 17607
		Y,
		// Token: 0x040044C8 RID: 17608
		Z,
		// Token: 0x040044C9 RID: 17609
		X_Neg,
		// Token: 0x040044CA RID: 17610
		Y_Neg,
		// Token: 0x040044CB RID: 17611
		Z_Neg,
		// Token: 0x040044CC RID: 17612
		Custom,
		// Token: 0x040044CD RID: 17613
		EAxisOption_MAX
	}
}
