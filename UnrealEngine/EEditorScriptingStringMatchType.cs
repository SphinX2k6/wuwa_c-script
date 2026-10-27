using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000788 RID: 1928
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/EditorScriptingUtilities.EEditorScriptingStringMatchType")]
	public enum EEditorScriptingStringMatchType : byte
	{
		// Token: 0x040030A0 RID: 12448
		Contains,
		// Token: 0x040030A1 RID: 12449
		MatchesWildcard,
		// Token: 0x040030A2 RID: 12450
		ExactMatch,
		// Token: 0x040030A3 RID: 12451
		EEditorScriptingStringMatchType_MAX
	}
}
