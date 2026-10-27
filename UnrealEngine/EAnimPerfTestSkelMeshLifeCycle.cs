using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001750 RID: 5968
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComponent.EAnimPerfTestSkelMeshLifeCycle")]
	public enum EAnimPerfTestSkelMeshLifeCycle : sbyte
	{
		// Token: 0x0400BB3A RID: 47930
		Transient,
		// Token: 0x0400BB3B RID: 47931
		KeepInLevel,
		// Token: 0x0400BB3C RID: 47932
		EAnimPerfTestSkelMeshLifeCycle_MAX
	}
}
