using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B82 RID: 2946
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESuggestProjVelocityTraceOption")]
	public enum ESuggestProjVelocityTraceOption
	{
		// Token: 0x04005111 RID: 20753
		DoNotTrace,
		// Token: 0x04005112 RID: 20754
		TraceFullPath,
		// Token: 0x04005113 RID: 20755
		OnlyTraceWhileAscending,
		// Token: 0x04005114 RID: 20756
		ESuggestProjVelocityTraceOption_MAX
	}
}
