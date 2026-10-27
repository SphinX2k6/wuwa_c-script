using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A1F RID: 10783
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFBXSceneNormalGenerationMethod")]
	public enum EFBXSceneNormalGenerationMethod : byte
	{
		// Token: 0x04015DF8 RID: 89592
		BuiltIn,
		// Token: 0x04015DF9 RID: 89593
		MikkTSpace,
		// Token: 0x04015DFA RID: 89594
		EFBXSceneNormalGenerationMethod_MAX
	}
}
