using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002689 RID: 9865
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Renderer.ETransvoxelRuntimeRenderMode")]
	public enum ETransvoxelRuntimeRenderMode : byte
	{
		// Token: 0x04013B08 RID: 80648
		CustomRenderer,
		// Token: 0x04013B09 RID: 80649
		RemovedRuntimeStaticMesh,
		// Token: 0x04013B0A RID: 80650
		RemovedRuntimeProceduralMesh,
		// Token: 0x04013B0B RID: 80651
		MeshPass,
		// Token: 0x04013B0C RID: 80652
		ETransvoxelRuntimeRenderMode_MAX
	}
}
