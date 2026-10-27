using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A39 RID: 10809
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EProjectPackagingBuildConfigurations")]
	public enum EProjectPackagingBuildConfigurations
	{
		// Token: 0x04015E94 RID: 89748
		PPBC_Debug,
		// Token: 0x04015E95 RID: 89749
		PPBC_DebugGame,
		// Token: 0x04015E96 RID: 89750
		PPBC_Development,
		// Token: 0x04015E97 RID: 89751
		PPBC_Test,
		// Token: 0x04015E98 RID: 89752
		PPBC_Shipping,
		// Token: 0x04015E99 RID: 89753
		PPBC_MAX
	}
}
