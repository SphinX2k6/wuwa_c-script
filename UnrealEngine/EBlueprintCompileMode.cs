using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A10 RID: 2576
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBlueprintCompileMode")]
	public enum EBlueprintCompileMode : byte
	{
		// Token: 0x040044FD RID: 17661
		Default,
		// Token: 0x040044FE RID: 17662
		Development,
		// Token: 0x040044FF RID: 17663
		FinalRelease,
		// Token: 0x04004500 RID: 17664
		EBlueprintCompileMode_MAX
	}
}
