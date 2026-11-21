using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200084C RID: 2124
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TASdkPlugin.ESaveMode")]
	public enum ESaveMode : byte
	{
		// Token: 0x04005424 RID: 21540
		None_Save,
		// Token: 0x04005425 RID: 21541
		SaveGame,
		// Token: 0x04005426 RID: 21542
		Sqlite,
		// Token: 0x04005427 RID: 21543
		ESaveMode_MAX
	}
}
