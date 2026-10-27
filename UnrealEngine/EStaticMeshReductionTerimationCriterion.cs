using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B77 RID: 2935
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EStaticMeshReductionTerimationCriterion")]
	public enum EStaticMeshReductionTerimationCriterion : byte
	{
		// Token: 0x040050DA RID: 20698
		Triangles,
		// Token: 0x040050DB RID: 20699
		Vertices,
		// Token: 0x040050DC RID: 20700
		Any,
		// Token: 0x040050DD RID: 20701
		EStaticMeshReductionTerimationCriterion_MAX
	}
}
