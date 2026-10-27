using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026B6 RID: 9910
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RigVM.ERigVMPinDirection")]
	public enum ERigVMPinDirection : byte
	{
		// Token: 0x04013D5F RID: 81247
		Input,
		// Token: 0x04013D60 RID: 81248
		Output,
		// Token: 0x04013D61 RID: 81249
		IO,
		// Token: 0x04013D62 RID: 81250
		Visible,
		// Token: 0x04013D63 RID: 81251
		Hidden,
		// Token: 0x04013D64 RID: 81252
		Invalid,
		// Token: 0x04013D65 RID: 81253
		ERigVMPinDirection_MAX
	}
}
