using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026B5 RID: 9909
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RigVM.ERigVMParameterType")]
	public enum ERigVMParameterType : byte
	{
		// Token: 0x04013D5A RID: 81242
		Input,
		// Token: 0x04013D5B RID: 81243
		Output,
		// Token: 0x04013D5C RID: 81244
		Invalid,
		// Token: 0x04013D5D RID: 81245
		ERigVMParameterType_MAX
	}
}
