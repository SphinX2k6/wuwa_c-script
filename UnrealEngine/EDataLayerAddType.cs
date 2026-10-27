using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015EB RID: 5611
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroActorFolderCheck.EDataLayerAddType")]
	public enum EDataLayerAddType : byte
	{
		// Token: 0x0400AFFC RID: 45052
		ActorPath,
		// Token: 0x0400AFFD RID: 45053
		ActorLabel,
		// Token: 0x0400AFFE RID: 45054
		Tag,
		// Token: 0x0400AFFF RID: 45055
		EDataLayerAddType_MAX
	}
}
