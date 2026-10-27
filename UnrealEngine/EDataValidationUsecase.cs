using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000714 RID: 1812
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EDataValidationUsecase")]
	public enum EDataValidationUsecase : byte
	{
		// Token: 0x04002DCC RID: 11724
		None,
		// Token: 0x04002DCD RID: 11725
		Manual,
		// Token: 0x04002DCE RID: 11726
		Commandlet,
		// Token: 0x04002DCF RID: 11727
		Save,
		// Token: 0x04002DD0 RID: 11728
		PreSubmit,
		// Token: 0x04002DD1 RID: 11729
		Script,
		// Token: 0x04002DD2 RID: 11730
		EDataValidationUsecase_MAX
	}
}
