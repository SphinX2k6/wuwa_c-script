using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020018B7 RID: 6327
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameplay.ELockAxis")]
	public enum ELockAxis : byte
	{
		// Token: 0x0400CB9C RID: 52124
		Forward,
		// Token: 0x0400CB9D RID: 52125
		Back,
		// Token: 0x0400CB9E RID: 52126
		Right,
		// Token: 0x0400CB9F RID: 52127
		Left,
		// Token: 0x0400CBA0 RID: 52128
		Up,
		// Token: 0x0400CBA1 RID: 52129
		Down,
		// Token: 0x0400CBA2 RID: 52130
		ELockAxis_MAX
	}
}
