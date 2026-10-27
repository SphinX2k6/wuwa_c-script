using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B83 RID: 2947
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESyncOption")]
	public enum ESyncOption : byte
	{
		// Token: 0x04005116 RID: 20758
		Drive,
		// Token: 0x04005117 RID: 20759
		Passive,
		// Token: 0x04005118 RID: 20760
		Disabled,
		// Token: 0x04005119 RID: 20761
		ESyncOption_MAX
	}
}
