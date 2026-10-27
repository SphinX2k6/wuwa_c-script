using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B91 RID: 2961
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETimecodeProviderSynchronizationState")]
	public enum ETimecodeProviderSynchronizationState
	{
		// Token: 0x04005184 RID: 20868
		Closed,
		// Token: 0x04005185 RID: 20869
		Error,
		// Token: 0x04005186 RID: 20870
		Synchronized,
		// Token: 0x04005187 RID: 20871
		Synchronizing,
		// Token: 0x04005188 RID: 20872
		ETimecodeProviderSynchronizationState_MAX
	}
}
