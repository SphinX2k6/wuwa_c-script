using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000459 RID: 1113
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EChaosSolverTickMode")]
	public enum EChaosSolverTickMode : byte
	{
		// Token: 0x04001BBE RID: 7102
		Fixed,
		// Token: 0x04001BBF RID: 7103
		Variable,
		// Token: 0x04001BC0 RID: 7104
		VariableCapped,
		// Token: 0x04001BC1 RID: 7105
		VariableCappedWithTarget,
		// Token: 0x04001BC2 RID: 7106
		EChaosSolverTickMode_MAX
	}
}
