using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ADD RID: 2781
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMouseLockMode")]
	public enum EMouseLockMode : byte
	{
		// Token: 0x04004B08 RID: 19208
		DoNotLock,
		// Token: 0x04004B09 RID: 19209
		LockOnCapture,
		// Token: 0x04004B0A RID: 19210
		LockAlways,
		// Token: 0x04004B0B RID: 19211
		LockInFullscreen,
		// Token: 0x04004B0C RID: 19212
		EMouseLockMode_MAX
	}
}
