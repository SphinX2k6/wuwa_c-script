using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A14 RID: 2580
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBlueprintType")]
	public enum EBlueprintType
	{
		// Token: 0x04004513 RID: 17683
		BPTYPE_Normal,
		// Token: 0x04004514 RID: 17684
		BPTYPE_Const,
		// Token: 0x04004515 RID: 17685
		BPTYPE_MacroLibrary,
		// Token: 0x04004516 RID: 17686
		BPTYPE_Interface,
		// Token: 0x04004517 RID: 17687
		BPTYPE_LevelScript,
		// Token: 0x04004518 RID: 17688
		BPTYPE_FunctionLibrary,
		// Token: 0x04004519 RID: 17689
		BPTYPE_MAX
	}
}
