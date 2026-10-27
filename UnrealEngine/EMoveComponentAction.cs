using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ADE RID: 2782
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMoveComponentAction")]
	public enum EMoveComponentAction
	{
		// Token: 0x04004B0E RID: 19214
		Move,
		// Token: 0x04004B0F RID: 19215
		Stop,
		// Token: 0x04004B10 RID: 19216
		Return,
		// Token: 0x04004B11 RID: 19217
		EMoveComponentAction_MAX
	}
}
