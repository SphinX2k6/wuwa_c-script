using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026B3 RID: 9907
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RigVM.ERigVMMemoryType")]
	public enum ERigVMMemoryType : byte
	{
		// Token: 0x04013CFE RID: 81150
		Work,
		// Token: 0x04013CFF RID: 81151
		Literal,
		// Token: 0x04013D00 RID: 81152
		External,
		// Token: 0x04013D01 RID: 81153
		Invalid,
		// Token: 0x04013D02 RID: 81154
		ERigVMMemoryType_MAX
	}
}
