using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020028F8 RID: 10488
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TASdkPlugin.ESaveMode")]
	public enum ESaveMode : byte
	{
		// Token: 0x040155BF RID: 87487
		None_Save,
		// Token: 0x040155C0 RID: 87488
		SaveGame,
		// Token: 0x040155C1 RID: 87489
		Sqlite,
		// Token: 0x040155C2 RID: 87490
		ESaveMode_MAX
	}
}
