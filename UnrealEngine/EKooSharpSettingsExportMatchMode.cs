using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200272B RID: 10027
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SharpherealEditor.EKooSharpSettingsExportMatchMode")]
	public enum EKooSharpSettingsExportMatchMode : byte
	{
		// Token: 0x04014054 RID: 82004
		Equals,
		// Token: 0x04014055 RID: 82005
		Regex,
		// Token: 0x04014056 RID: 82006
		StartsWith,
		// Token: 0x04014057 RID: 82007
		EndsWith,
		// Token: 0x04014058 RID: 82008
		Contains,
		// Token: 0x04014059 RID: 82009
		Any,
		// Token: 0x0401405A RID: 82010
		EKooSharpSettingsExportMatchMode_MAX
	}
}
