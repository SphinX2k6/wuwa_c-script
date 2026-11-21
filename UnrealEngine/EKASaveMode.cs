using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002D1 RID: 721
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.EKASaveMode")]
	public enum EKASaveMode : byte
	{
		// Token: 0x04001F42 RID: 8002
		None_Save,
		// Token: 0x04001F43 RID: 8003
		SaveGame,
		// Token: 0x04001F44 RID: 8004
		Sqlite,
		// Token: 0x04001F45 RID: 8005
		EKASaveMode_MAX
	}
}
