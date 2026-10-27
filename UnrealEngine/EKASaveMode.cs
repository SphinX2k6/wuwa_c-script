using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015DD RID: 5597
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.EKASaveMode")]
	public enum EKASaveMode : byte
	{
		// Token: 0x0400AF98 RID: 44952
		None_Save,
		// Token: 0x0400AF99 RID: 44953
		SaveGame,
		// Token: 0x0400AF9A RID: 44954
		Sqlite,
		// Token: 0x0400AF9B RID: 44955
		EKASaveMode_MAX
	}
}
