using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001E84 RID: 7812
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroTeaHelper.EKuroTextureChannelView")]
	public enum EKuroTextureChannelView : byte
	{
		// Token: 0x04010192 RID: 65938
		RGBA,
		// Token: 0x04010193 RID: 65939
		RGB,
		// Token: 0x04010194 RID: 65940
		R,
		// Token: 0x04010195 RID: 65941
		G,
		// Token: 0x04010196 RID: 65942
		B,
		// Token: 0x04010197 RID: 65943
		A,
		// Token: 0x04010198 RID: 65944
		EKuroTextureChannelView_MAX
	}
}
