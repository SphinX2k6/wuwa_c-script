using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015E9 RID: 5609
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroActorFolderCheck.EAddTagType")]
	public enum EAddTagType : byte
	{
		// Token: 0x0400AFF3 RID: 45043
		Actor,
		// Token: 0x0400AFF4 RID: 45044
		Component,
		// Token: 0x0400AFF5 RID: 45045
		EAddTagType_MAX
	}
}
