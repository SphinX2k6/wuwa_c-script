using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B2F RID: 2863
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPSOGeneratorRenderTargetStoreAction")]
	public enum EPSOGeneratorRenderTargetStoreAction
	{
		// Token: 0x04004EC8 RID: 20168
		PSO_STORE_NoAction,
		// Token: 0x04004EC9 RID: 20169
		PSO_STORE_Store,
		// Token: 0x04004ECA RID: 20170
		PSO_STORE_MultisampleResolve,
		// Token: 0x04004ECB RID: 20171
		PSO_STORE_MAX
	}
}
