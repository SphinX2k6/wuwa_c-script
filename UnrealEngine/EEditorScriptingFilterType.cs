using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000787 RID: 1927
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/EditorScriptingUtilities.EEditorScriptingFilterType")]
	public enum EEditorScriptingFilterType : byte
	{
		// Token: 0x0400309C RID: 12444
		Include,
		// Token: 0x0400309D RID: 12445
		Exclude,
		// Token: 0x0400309E RID: 12446
		EEditorScriptingFilterType_MAX
	}
}
