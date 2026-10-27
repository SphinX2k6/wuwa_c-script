using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026B7 RID: 9911
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RigVM.ERigVMRegisterType")]
	public enum ERigVMRegisterType : byte
	{
		// Token: 0x04013D67 RID: 81255
		Plain,
		// Token: 0x04013D68 RID: 81256
		String,
		// Token: 0x04013D69 RID: 81257
		Name,
		// Token: 0x04013D6A RID: 81258
		Struct,
		// Token: 0x04013D6B RID: 81259
		Invalid,
		// Token: 0x04013D6C RID: 81260
		ERigVMRegisterType_MAX
	}
}
