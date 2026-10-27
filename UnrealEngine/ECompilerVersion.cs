using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A6A RID: 10858
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/WindowsTargetPlatform.ECompilerVersion")]
	public enum ECompilerVersion : byte
	{
		// Token: 0x04015FB4 RID: 90036
		Default,
		// Token: 0x04015FB5 RID: 90037
		VisualStudio2015,
		// Token: 0x04015FB6 RID: 90038
		VisualStudio2017,
		// Token: 0x04015FB7 RID: 90039
		VisualStudio2019,
		// Token: 0x04015FB8 RID: 90040
		VisualStudio2022,
		// Token: 0x04015FB9 RID: 90041
		ECompilerVersion_MAX
	}
}
