using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001488 RID: 5256
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniInputObjectType")]
	public enum EHoudiniInputObjectType : byte
	{
		// Token: 0x0400A463 RID: 42083
		Invalid,
		// Token: 0x0400A464 RID: 42084
		Object,
		// Token: 0x0400A465 RID: 42085
		StaticMesh,
		// Token: 0x0400A466 RID: 42086
		SkeletalMesh,
		// Token: 0x0400A467 RID: 42087
		SceneComponent,
		// Token: 0x0400A468 RID: 42088
		StaticMeshComponent,
		// Token: 0x0400A469 RID: 42089
		InstancedStaticMeshComponent,
		// Token: 0x0400A46A RID: 42090
		SplineComponent,
		// Token: 0x0400A46B RID: 42091
		HoudiniSplineComponent,
		// Token: 0x0400A46C RID: 42092
		HoudiniAssetComponent,
		// Token: 0x0400A46D RID: 42093
		Actor,
		// Token: 0x0400A46E RID: 42094
		Landscape,
		// Token: 0x0400A46F RID: 42095
		Brush,
		// Token: 0x0400A470 RID: 42096
		CameraComponent,
		// Token: 0x0400A471 RID: 42097
		DataTable,
		// Token: 0x0400A472 RID: 42098
		HoudiniAssetActor,
		// Token: 0x0400A473 RID: 42099
		FoliageType_InstancedStaticMesh,
		// Token: 0x0400A474 RID: 42100
		GeometryCollection,
		// Token: 0x0400A475 RID: 42101
		GeometryCollectionComponent,
		// Token: 0x0400A476 RID: 42102
		GeometryCollectionActor_Deprecated,
		// Token: 0x0400A477 RID: 42103
		SkeletalMeshComponent,
		// Token: 0x0400A478 RID: 42104
		Blueprint,
		// Token: 0x0400A479 RID: 42105
		EHoudiniInputObjectType_MAX
	}
}
