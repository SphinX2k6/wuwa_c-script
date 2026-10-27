using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003ED RID: 1005
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARObjectClassification")]
	public enum EARObjectClassification : byte
	{
		// Token: 0x04001897 RID: 6295
		NotApplicable,
		// Token: 0x04001898 RID: 6296
		Unknown,
		// Token: 0x04001899 RID: 6297
		Wall,
		// Token: 0x0400189A RID: 6298
		Ceiling,
		// Token: 0x0400189B RID: 6299
		Floor,
		// Token: 0x0400189C RID: 6300
		Table,
		// Token: 0x0400189D RID: 6301
		Seat,
		// Token: 0x0400189E RID: 6302
		Face,
		// Token: 0x0400189F RID: 6303
		Image,
		// Token: 0x040018A0 RID: 6304
		World,
		// Token: 0x040018A1 RID: 6305
		SceneObject,
		// Token: 0x040018A2 RID: 6306
		HandMesh,
		// Token: 0x040018A3 RID: 6307
		Door,
		// Token: 0x040018A4 RID: 6308
		Window,
		// Token: 0x040018A5 RID: 6309
		EARObjectClassification_MAX
	}
}
