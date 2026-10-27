using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000466 RID: 1126
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EObjectStateTypeEnum")]
	public enum EObjectStateTypeEnum : byte
	{
		// Token: 0x04001C20 RID: 7200
		Chaos_NONE,
		// Token: 0x04001C21 RID: 7201
		Chaos_Object_Sleeping,
		// Token: 0x04001C22 RID: 7202
		Chaos_Object_Kinematic,
		// Token: 0x04001C23 RID: 7203
		Chaos_Object_Static,
		// Token: 0x04001C24 RID: 7204
		Chaos_Object_Dynamic,
		// Token: 0x04001C25 RID: 7205
		Chaos_Object_UserDefined = 100,
		// Token: 0x04001C26 RID: 7206
		Chaos_Max,
		// Token: 0x04001C27 RID: 7207
		Chaos_MAX
	}
}
