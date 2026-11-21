using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001D8 RID: 472
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EComponentCreationMethod")]
	public enum EComponentCreationMethod : byte
	{
		// Token: 0x04000B98 RID: 2968
		Native,
		// Token: 0x04000B99 RID: 2969
		SimpleConstructionScript,
		// Token: 0x04000B9A RID: 2970
		UserConstructionScript,
		// Token: 0x04000B9B RID: 2971
		Instance,
		// Token: 0x04000B9C RID: 2972
		EComponentCreationMethod_MAX
	}
}
