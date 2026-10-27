using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200286B RID: 10347
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SMSystem.ESMExposedFunctionExecutionType")]
	public enum ESMExposedFunctionExecutionType : byte
	{
		// Token: 0x04015066 RID: 86118
		SM_Graph,
		// Token: 0x04015067 RID: 86119
		SM_NodeInstance,
		// Token: 0x04015068 RID: 86120
		SM_None,
		// Token: 0x04015069 RID: 86121
		SM_MAX
	}
}
