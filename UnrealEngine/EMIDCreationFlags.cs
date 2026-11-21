using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001EB RID: 491
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMIDCreationFlags")]
	public enum EMIDCreationFlags : byte
	{
		// Token: 0x04000C26 RID: 3110
		None,
		// Token: 0x04000C27 RID: 3111
		Transient,
		// Token: 0x04000C28 RID: 3112
		EMIDCreationFlags_MAX
	}
}
