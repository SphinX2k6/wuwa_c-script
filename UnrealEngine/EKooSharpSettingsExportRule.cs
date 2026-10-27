using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200272C RID: 10028
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SharpherealEditor.EKooSharpSettingsExportRule")]
	public enum EKooSharpSettingsExportRule : byte
	{
		// Token: 0x0401405C RID: 82012
		Blacklist,
		// Token: 0x0401405D RID: 82013
		Whitelist,
		// Token: 0x0401405E RID: 82014
		EKooSharpSettingsExportRule_MAX
	}
}
