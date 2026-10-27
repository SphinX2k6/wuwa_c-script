using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000464 RID: 1124
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EImplicitTypeEnum")]
	public enum EImplicitTypeEnum : byte
	{
		// Token: 0x04001C13 RID: 7187
		Chaos_Implicit_Box,
		// Token: 0x04001C14 RID: 7188
		Chaos_Implicit_Sphere,
		// Token: 0x04001C15 RID: 7189
		Chaos_Implicit_Capsule,
		// Token: 0x04001C16 RID: 7190
		Chaos_Implicit_LevelSet,
		// Token: 0x04001C17 RID: 7191
		Chaos_Implicit_None,
		// Token: 0x04001C18 RID: 7192
		Chaos_Max,
		// Token: 0x04001C19 RID: 7193
		Chaos_MAX
	}
}
