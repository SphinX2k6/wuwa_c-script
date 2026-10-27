using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200147D RID: 5245
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EAttribStorageType")]
	public enum EAttribStorageType : sbyte
	{
		// Token: 0x0400A413 RID: 42003
		Invalid = -1,
		// Token: 0x0400A414 RID: 42004
		INT,
		// Token: 0x0400A415 RID: 42005
		INT64,
		// Token: 0x0400A416 RID: 42006
		FLOAT,
		// Token: 0x0400A417 RID: 42007
		FLOAT64,
		// Token: 0x0400A418 RID: 42008
		STRING,
		// Token: 0x0400A419 RID: 42009
		EAttribStorageType_MAX
	}
}
