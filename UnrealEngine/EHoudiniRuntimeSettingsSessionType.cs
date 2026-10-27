using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001497 RID: 5271
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniRuntimeSettingsSessionType")]
	public enum EHoudiniRuntimeSettingsSessionType
	{
		// Token: 0x0400A4EB RID: 42219
		HRSST_InProcess,
		// Token: 0x0400A4EC RID: 42220
		HRSST_Socket,
		// Token: 0x0400A4ED RID: 42221
		HRSST_NamedPipe,
		// Token: 0x0400A4EE RID: 42222
		HRSST_None,
		// Token: 0x0400A4EF RID: 42223
		HRSST_MAX
	}
}
