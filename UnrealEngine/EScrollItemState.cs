using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000652 RID: 1618
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EScrollItemState")]
	public enum EScrollItemState : byte
	{
		// Token: 0x04003DEA RID: 15850
		DeActive,
		// Token: 0x04003DEB RID: 15851
		Updating,
		// Token: 0x04003DEC RID: 15852
		Completed,
		// Token: 0x04003DED RID: 15853
		EScrollItemState_MAX
	}
}
