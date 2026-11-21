using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001DA RID: 474
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDataLayerState")]
	public enum EDataLayerState : byte
	{
		// Token: 0x04000BA3 RID: 2979
		Unloaded,
		// Token: 0x04000BA4 RID: 2980
		Loaded,
		// Token: 0x04000BA5 RID: 2981
		Activated,
		// Token: 0x04000BA6 RID: 2982
		EDataLayerState_MAX
	}
}
