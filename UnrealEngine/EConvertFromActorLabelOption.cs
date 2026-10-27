using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200152B RID: 5419
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/InstanceTool.EConvertFromActorLabelOption")]
	public enum EConvertFromActorLabelOption : byte
	{
		// Token: 0x0400AA66 RID: 43622
		FromStaticMesh,
		// Token: 0x0400AA67 RID: 43623
		FromSelectedActor,
		// Token: 0x0400AA68 RID: 43624
		Custom,
		// Token: 0x0400AA69 RID: 43625
		EConvertFromActorLabelOption_MAX
	}
}
