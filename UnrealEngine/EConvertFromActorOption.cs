using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200152C RID: 5420
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/InstanceTool.EConvertFromActorOption")]
	public enum EConvertFromActorOption : byte
	{
		// Token: 0x0400AA6B RID: 43627
		InstancedStaticMeshActor,
		// Token: 0x0400AA6C RID: 43628
		HierarchicalInstancedStaticMeshActor,
		// Token: 0x0400AA6D RID: 43629
		EConvertFromActorOption_MAX
	}
}
