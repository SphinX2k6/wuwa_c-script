using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200231C RID: 8988
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieSceneTools.FTransformChannelEnum")]
	public enum FTransformChannelEnum : byte
	{
		// Token: 0x04012266 RID: 74342
		TranslateX,
		// Token: 0x04012267 RID: 74343
		TranslateY,
		// Token: 0x04012268 RID: 74344
		TranslateZ,
		// Token: 0x04012269 RID: 74345
		RotateX,
		// Token: 0x0401226A RID: 74346
		RotateY,
		// Token: 0x0401226B RID: 74347
		RotateZ,
		// Token: 0x0401226C RID: 74348
		ScaleX,
		// Token: 0x0401226D RID: 74349
		ScaleY,
		// Token: 0x0401226E RID: 74350
		ScaleZ,
		// Token: 0x0401226F RID: 74351
		FTransformChannelEnum_MAX
	}
}
