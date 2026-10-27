using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002952 RID: 10578
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.EBindingKind")]
	public enum EBindingKind : byte
	{
		// Token: 0x0401581A RID: 88090
		Function,
		// Token: 0x0401581B RID: 88091
		Property,
		// Token: 0x0401581C RID: 88092
		EBindingKind_MAX
	}
}
