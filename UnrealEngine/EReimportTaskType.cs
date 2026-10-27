using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020026AD RID: 9901
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/RenderExporter.EReimportTaskType")]
	public enum EReimportTaskType : byte
	{
		// Token: 0x04013CB1 RID: 81073
		Task_None,
		// Token: 0x04013CB2 RID: 81074
		Task_Mesh_LOD,
		// Token: 0x04013CB3 RID: 81075
		Task_Mesh_UCX,
		// Token: 0x04013CB4 RID: 81076
		Task_Texture,
		// Token: 0x04013CB5 RID: 81077
		Task_Mesh_New,
		// Token: 0x04013CB6 RID: 81078
		Task_MAX
	}
}
