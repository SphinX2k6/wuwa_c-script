using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001E9D RID: 7837
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroUtility.EXboxMultiplayerActivityEncounterType")]
	public enum EXboxMultiplayerActivityEncounterType : byte
	{
		// Token: 0x04010205 RID: 66053
		Default,
		// Token: 0x04010206 RID: 66054
		Teammate,
		// Token: 0x04010207 RID: 66055
		Opponent,
		// Token: 0x04010208 RID: 66056
		EXboxMultiplayerActivityEncounterType_MAX
	}
}
