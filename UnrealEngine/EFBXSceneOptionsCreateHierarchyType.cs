using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A21 RID: 10785
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFBXSceneOptionsCreateHierarchyType")]
	public enum EFBXSceneOptionsCreateHierarchyType : byte
	{
		// Token: 0x04015E01 RID: 89601
		FBXSOCHT_CreateLevelActors,
		// Token: 0x04015E02 RID: 89602
		FBXSOCHT_CreateActorComponents,
		// Token: 0x04015E03 RID: 89603
		FBXSOCHT_CreateBlueprint,
		// Token: 0x04015E04 RID: 89604
		FBXSOCHT_MAX
	}
}
