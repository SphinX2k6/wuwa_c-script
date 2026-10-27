using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B55 RID: 2901
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERuntimeVirtualTextureMipValueMode")]
	public enum ERuntimeVirtualTextureMipValueMode
	{
		// Token: 0x04004FD8 RID: 20440
		RVTMVM_None,
		// Token: 0x04004FD9 RID: 20441
		RVTMVM_MipLevel,
		// Token: 0x04004FDA RID: 20442
		RVTMVM_MipBias,
		// Token: 0x04004FDB RID: 20443
		RVTMVM_MAX
	}
}
